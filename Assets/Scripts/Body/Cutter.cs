using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Cutter
{
    public static void CutMemberAtRandom(Members member, int amount)
    {
        SoundEffectHelper.instance.MakeCutingSound();
        for (int i = 0; i < amount; i++)
        {
            switch (member)
            {
                case Members.Arm:
                    CutArmAtRandom();
                    break;
                case Members.Ear:
                    CutEarAtRandom();
                    break;
                case Members.Eye:
                    CutEyeAtRandom();
                    break;
                case Members.Finger:
                    CutFingerAtRandom();
                    break;
                case Members.Foot:
                    CutFootAtRandom();
                    break;
                case Members.Leg:
                    CutLegAtRandom();
                    break;
                case Members.Nose:
                    CutNoseAtRandom();
                    break;
            }
        }
    }
    static void CutFingerAtRandom()
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
        }
    }

    [MenuItem("Cutter/Cut Finger at random")]
    static void CutFinger()
    {
        CutFingerAtRandom();
    }

    static void CutArmAtRandom()
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
        }
    }

    [MenuItem("Cutter/Cut Arm at random")]
    static void CutArm()
    {
        CutArmAtRandom();
    }

    static void CutFootAtRandom()
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
        }
    }

    [MenuItem("Cutter/Cut Foot at random")]
    static void CutFoot()
    {
        CutFootAtRandom();
    }

    static void CutLegAtRandom()
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
        }
    }

    [MenuItem("Cutter/Cut Leg at random")]
    static void CutLeg()
    {
        CutLegAtRandom();
    }

    static void CutEyeAtRandom()
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
        }
    }

    [MenuItem("Cutter/Cut Eye at random")]
    static void CutEye()
    {
        CutEyeAtRandom();
    }

    static void CutEarAtRandom()
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
        }
    }

    [MenuItem("Cutter/Cut Ear at random")]
    static void CutEar()
    {
        CutEarAtRandom();
    }

    static void CutNoseAtRandom()
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
        }
    }

    [MenuItem("Cutter/Cut Nose at random")]
    static void CutNose()
    {
        CutNoseAtRandom();
    }
}
