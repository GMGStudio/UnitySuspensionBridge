using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(HingeJointHelper))]
public class HingeJoinUI : Editor
{


    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        HingeJointHelper myScript = (HingeJointHelper)target;

        if (GUILayout.Button("Add HingeJoints"))
        {
            myScript.AddHingeJoints();
        }
        if (GUILayout.Button("Delete HingeJoints"))
        {
            myScript.DeleteHingeJoints();
        }
    }
}