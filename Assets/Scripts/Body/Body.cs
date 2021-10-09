using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public static int fingerCount { get => instance.fingers.Count; private set { } }
    public static int armCount { get => instance.arms.Count; private set { } }
    public static int eyeCount { get => instance.eyes.Count; private set { } }
    public static int noseCount { get => instance.nose.Count; private set { } }
    public static int legCount { get => instance.legs.Count; private set { } }
    public static int footCount { get => instance.feet.Count; private set { } }
    public static int earCount { get => instance.ears.Count; private set { } }
    public static Body instance;
    public List<Arm> arms = new List<Arm>();
    public List<Finger> fingers = new List<Finger>();
    public List<Leg> legs = new List<Leg>();
    public List<Foot> feet = new List<Foot>();
    public List<Eye> eyes = new List<Eye>();
    public List<Ear> ears = new List<Ear>();
    public List<Nose> nose = new List<Nose>();

    public Dictionary<Transform, Member> dicoGameObjectToMember;

    private void Start()
    {
        instance = this;
        InitBody();
    }

    private void InitBody()
    {
        //Create each arm
        for (int i = 0; i < 6; i++)
        {
            Transform fullArm = transform.GetChild(2).GetChild(i);
            //Create the arm
            Arm newArm = new Arm();
            arms.Add(newArm);
            Link(fullArm.GetChild(0), newArm);
            //Create the fingers
            for (int j = 0; j < 7; j++)
            {
                Finger newFinger = new Finger();
                fingers.Add(newFinger);
                newArm.fingers.Add(newFinger);
                newFinger.arm = newArm;
                Link(fullArm.GetChild(j + 1), newFinger);
            }
        }
        //Create each leg
        for (int i = 0; i < 4; i++)
        {
            Transform fullLeg = transform.GetChild(3).GetChild(i);
            //Create the leg
            Leg newLeg = new Leg();
            legs.Add(newLeg);
            Link(fullLeg.GetChild(0), newLeg);
            //Create the foot
            Foot newFoot = new Foot();
            feet.Add(newFoot);
            newLeg.foot = newFoot;
            newFoot.leg = newLeg;
            Link(fullLeg.GetChild(1), newFoot);
        }
        //Create each ear
        for (int i = 0; i < 2; i++)
        {
            Transform ear = transform.GetChild(4).GetChild(0).GetChild(i);
            //Create the ear
            Ear newEar = new Ear();
            ears.Add(newEar);
            Link(ear, newEar);
        }
        //Create each ear
        for (int i = 0; i < 3; i++)
        {
            Transform eye = transform.GetChild(4).GetChild(1).GetChild(i);
            //Create the ear
            Eye newEye = new Eye();
            eyes.Add(newEye);
            Link(eye, newEye);
        }
        //Create the nose
        Transform noseTransform = transform.GetChild(4).GetChild(2);
        Nose newNose = new Nose();
        nose.Add(newNose);
        Link(noseTransform, newNose);

    }

    private void Link(Transform t, Member m)
    {
        MemberCollider mc = t.GetComponent<MemberCollider>();
        mc.member = m;
        m.memberCollider = mc;
        if (!mc.isActiveByDefault)
        {
            m.active = false;
            mc.gameObject.SetActive(false);
        }
    }

}

public class Member
{
    public MemberCollider memberCollider;
    public bool active = true;
    public virtual void Cut()
    {
        active = false;
        memberCollider.gameObject.SetActive(false);
    }

    public virtual void Grow()
    {
        active = true;
        memberCollider.gameObject.SetActive(true);
    }
}

public class Arm : Member
{
    public List<Finger> fingers = new List<Finger>();

    public override void Cut()
    {
        active = false;
        memberCollider.gameObject.SetActive(false);
        foreach (Finger f in fingers)
        {
            f.Cut();
        }
    }

    public override void Grow()
    {
        base.Grow();
        foreach (Finger finger in fingers)
        {
            if (Random.Range(0, 2) == 0)
            {
                finger.Grow();
            }
        }
    }
}

public class Finger : Member
{
    public Arm arm;
    public override void Grow()
    {
        if (!arm.active)
        {
            Debug.LogWarning("Trying to grow a finger with no arm to attach");
        }
        base.Grow();
    }
}

public class Leg : Member
{
    public Foot foot;
    public override void Cut()
    {
        active = false;
        memberCollider.gameObject.SetActive(false);
        foot.Cut();
    }

    public override void Grow()
    {
        base.Grow();
        if (Random.Range(0, 2) == 0)
        {
            foot.Grow();
        }
    }
}

public class Foot : Member
{
    public Leg leg;

    public override void Grow()
    {
        if (!leg.active)
        {
            Debug.LogWarning("Trying to grow a foot with no leg to attach");
        }
        base.Grow();
    }
}

public class Eye : Member
{

}


public class Ear : Member
{

}

public class Nose : Member
{

}