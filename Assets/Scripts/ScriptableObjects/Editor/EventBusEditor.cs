using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(MyCustomScript))]
public class MyCustomEditor : Editor
{
    private MyCustomScript script;

    private void OnEnable()
    {
        // Method 1
        script = (MyCustomScript) target;
    }

    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("MyButton"))
        {
			
        }

        // Draw default inspector after button...
        base.OnInspectorGUI();
    }
}