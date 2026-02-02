using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuCreate
{
    [MenuItem("Assets/SSSSSSScrObj")]
    public static void CreateMulty()
    {
        MyScriptableObject obj = ScriptableObject.CreateInstance<MyScriptableObject>();

        AssetDatabase.CreateAsset(obj, "Assets/NewMyScriptableObject.asset");

        AssetDatabase.SaveAssets();

        AssetDatabase.Refresh();
    }
}
