using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Grower
{

    public static void GrowMemberAtRandom(Members member, int amount)
    {
        bool oneHasGrown = false;
        for (int i = 0; i < amount; i++)
        {
            switch (member)
            {
                case Members.Arm:
                    oneHasGrown = GrowArmAtRandom() || oneHasGrown;
                    break;
                case Members.Ear:
                    oneHasGrown = GrowEarAtRandom() || oneHasGrown;
                    break;
                case Members.Eye:
                    oneHasGrown = GrowEyeAtRandom() || oneHasGrown;
                    break;
                case Members.Finger:
                    oneHasGrown = GrowFingerAtRandom() || oneHasGrown;
                    break;
                case Members.Foot:
                    oneHasGrown = GrowFootAtRandom() || oneHasGrown;
                    break;
                case Members.Leg:
                    oneHasGrown = GrowLegAtRandom() || oneHasGrown;
                    break;
                case Members.Nose:
                    oneHasGrown = GrowNoseAtRandom() || oneHasGrown;
                    break;
            }
        }
        if (oneHasGrown)
            SoundEffectHelper.instance.MakeGrowSound();
    }
    static bool GrowFingerAtRandom()
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
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Grower/Grow Finger at random")]
#endif
    static void GrowFinger()
    {
        GrowMemberAtRandom(Members.Finger, 3);
    }

    static bool GrowArmAtRandom()
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
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Grower/Grow Arm at random")]
#endif
    static void GrowArm()
    {
        GrowArmAtRandom();
    }

    static bool GrowFootAtRandom()
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
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Grower/Grow Foot at random")]
#endif
    static void GrowFoot()
    {
        GrowFootAtRandom();
    }

    static bool GrowLegAtRandom()
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
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Grower/Grow Leg at random")]
#endif
    static void GrowLeg()
    {
        GrowLegAtRandom();
    }

    static bool GrowEyeAtRandom()
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
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Grower/Grow Eye at random")]
#endif
    static void GrowEye()
    {
        GrowEyeAtRandom();
    }

    static bool GrowEarAtRandom()
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
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Grower/Grow Ear at random")]
#endif
    static void GrowEar()
    {
        GrowEarAtRandom();
    }

    static bool GrowNoseAtRandom()
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
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Grower/Grow Nose at random")]
#endif
    static void GrowNose()
    {
        GrowNoseAtRandom();
    }
}
