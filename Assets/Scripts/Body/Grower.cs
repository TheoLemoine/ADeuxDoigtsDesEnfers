using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Grower
{

    public static void GrowMemberAtRandom(Members member, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            switch (member)
            {
                case Members.Arm:
                    GrowArmAtRandom();
                    break;
                case Members.Ear:
                    GrowEarAtRandom();
                    break;
                case Members.Eye:
                    GrowEyeAtRandom();
                    break;
                case Members.Finger:
                    GrowFingerAtRandom();
                    break;
                case Members.Foot:
                    GrowFootAtRandom();
                    break;
                case Members.Leg:
                    GrowLegAtRandom();
                    break;
                case Members.Nose:
                    GrowNoseAtRandom();
                    break;
            }
        }
    }
    static void GrowFingerAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.fingers)
        {
            if (!member.active && ((Finger)member).arm.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Grow();
        }
    }

    [MenuItem("Grower/Grow Finger at random")]
    static void GrowFinger()
    {
        GrowFingerAtRandom();
    }

    static void GrowArmAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.arms)
        {
            if (!member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Grow();
        }
    }

    [MenuItem("Grower/Grow Arm at random")]
    static void GrowArm()
    {
        GrowArmAtRandom();
    }

    static void GrowFootAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.feet)
        {
            if (!member.active && ((Foot)member).leg.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Grow();
        }
    }

    [MenuItem("Grower/Grow Foot at random")]
    static void GrowFoot()
    {
        GrowFootAtRandom();
    }

    static void GrowLegAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.legs)
        {
            if (!member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Grow();
        }
    }

    [MenuItem("Grower/Grow Leg at random")]
    static void GrowLeg()
    {
        GrowLegAtRandom();
    }

    static void GrowEyeAtRandom()
    {
        List<Member> list = new List<Member>();

        foreach (Member member in Body.instance.eyes)
        {
            if (!member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Grow();
        }
    }

    [MenuItem("Grower/Grow Eye at random")]
    static void GrowEye()
    {
        GrowEyeAtRandom();
    }

    static void GrowEarAtRandom()
    {
        List<Member> list = new List<Member>();

        foreach (Member member in Body.instance.ears)
        {
            if (!member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Grow();
        }
    }

    [MenuItem("Grower/Grow Ear at random")]
    static void GrowEar()
    {
        GrowEarAtRandom();
    }

    static void GrowNoseAtRandom()
    {
        List<Member> list = new List<Member>();

        foreach (Member member in Body.instance.nose)
        {
            if (!member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Grow();
        }
    }

    [MenuItem("Grower/Grow Nose at random")]
    static void GrowNose()
    {
        GrowNoseAtRandom();
    }
}
