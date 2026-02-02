using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class MenuCreateMyScriptableObject
{
    [MenuItem("Assets/ScrObj")]
    public static void CreateMulty()
    {
        MyScriptableObject obj = ScriptableObject.CreateInstance<MyScriptableObject>();

        AssetDatabase.CreateAsset(obj, "Assets/Book/Ω≈±æ–Ú¡–ªØ/ScriptableObject/DataTwo.asset");

        AssetDatabase.SaveAssets();

        AssetDatabase.Refresh();
    }
}
