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
                    oneHasGrown = oneHasGrown || CutArmAtRandom();
                    break;
                case Members.Ear:
                    oneHasGrown = oneHasGrown || CutEarAtRandom();
                    break;
                case Members.Eye:
                    oneHasGrown = oneHasGrown || CutEyeAtRandom();
                    break;
                case Members.Finger:
                    oneHasGrown = oneHasGrown || CutFingerAtRandom();
                    break;
                case Members.Foot:
                    oneHasGrown = oneHasGrown || CutFootAtRandom();
                    break;
                case Members.Leg:
                    oneHasGrown = oneHasGrown || CutLegAtRandom();
                    break;
                case Members.Nose:
                    oneHasGrown = oneHasGrown || CutNoseAtRandom();
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

    [MenuItem("Cutter/Cut Finger at random")]
    static void CutFinger()
    {
        CutFingerAtRandom();
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

    [MenuItem("Cutter/Cut Arm at random")]
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

    [MenuItem("Cutter/Cut Foot at random")]
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

    [MenuItem("Cutter/Cut Leg at random")]
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

    [MenuItem("Cutter/Cut Eye at random")]
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

    [MenuItem("Cutter/Cut Ear at random")]
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

    [MenuItem("Cutter/Cut Nose at random")]
    static void CutNose()
    {
        CutNoseAtRandom();
    }
}
