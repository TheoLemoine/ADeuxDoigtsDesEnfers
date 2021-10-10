using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Cutter
{
    public static void CutMemberAtRandom(Members member, int amount)
    {
        bool oneHasGrown = false;
        for (int i = 0; i < amount; i++)
        {
            switch (member)
            {
                case Members.Arm:
                    oneHasGrown = CutArmAtRandom() || oneHasGrown;
                    break;
                case Members.Ear:
                    oneHasGrown = CutEarAtRandom() || oneHasGrown;
                    break;
                case Members.Eye:
                    oneHasGrown = CutEyeAtRandom() || oneHasGrown;
                    break;
                case Members.Finger:
                    oneHasGrown = CutFingerAtRandom() || oneHasGrown;
                    break;
                case Members.Foot:
                    oneHasGrown = CutFootAtRandom() || oneHasGrown;
                    break;
                case Members.Leg:
                    oneHasGrown = CutLegAtRandom() || oneHasGrown;
                    break;
                case Members.Nose:
                    oneHasGrown = CutNoseAtRandom() || oneHasGrown;
                    break;
            }
        }
        if (oneHasGrown)
            SoundEffectHelper.instance.MakeCutingSound();
    }
    static bool CutFingerAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.fingers)
        {
            if (member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Cut();
            return true;
        }
        return false;
    }
#if UNITY_EDITOR
    [MenuItem("Cutter/Cut Finger at random")]
#endif
    static void CutFinger()
    {
        CutMemberAtRandom(Members.Finger, 3);
    }

    static bool CutArmAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.arms)
        {
            if (member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Cut();
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Cutter/Cut Arm at random")]
#endif
    static void CutArm()
    {
        CutArmAtRandom();
    }

    static bool CutFootAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.feet)
        {
            if (member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Cut();
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Cutter/Cut Foot at random")]
#endif
    static void CutFoot()
    {
        CutFootAtRandom();
    }

    static bool CutLegAtRandom()
    {
        List<Member> list = new List<Member>();
        foreach (Member member in Body.instance.legs)
        {
            if (member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Cut();
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Cutter/Cut Leg at random")]
#endif
    static void CutLeg()
    {
        CutLegAtRandom();
    }

    static bool CutEyeAtRandom()
    {
        List<Member> list = new List<Member>();

        foreach (Member member in Body.instance.eyes)
        {
            if (member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Cut();
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Cutter/Cut Eye at random")]
#endif
    static void CutEye()
    {
        CutEyeAtRandom();
    }

    static bool CutEarAtRandom()
    {
        List<Member> list = new List<Member>();

        foreach (Member member in Body.instance.ears)
        {
            if (member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Cut();
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Cutter/Cut Ear at random")]
#endif
    static void CutEar()
    {
        CutEarAtRandom();
    }

    static bool CutNoseAtRandom()
    {
        List<Member> list = new List<Member>();

        foreach (Member member in Body.instance.nose)
        {
            if (member.active)
            {
                list.Add(member);
            }
        }
        if (list.Count > 0)
        {
            int randomInt = Random.Range(0, list.Count);
            list[randomInt].Cut();
            return true;
        }
        return false;
    }

#if UNITY_EDITOR
    [MenuItem("Cutter/Cut Nose at random")]
#endif
    static void CutNose()
    {
        CutNoseAtRandom();
    }
}
