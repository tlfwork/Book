using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ScriptInstectorChange : MonoBehaviour
{
    [SerializeField]
    private int a;

    [SerializeField]
    private GameObject obj;

    // Start is called before the first frame update
#if UNITY_EDITOR
    [CustomEditor(typeof(ScriptInstectorChange))]
    public class TestInspector:Editor
    {
        public override void OnInspectorGUI()
        {
            Debug.Log("aaaa");
            serializedObject.Update();

            SerializedProperty property = serializedObject.FindProperty(nameof(a));

            property.intValue = EditorGUILayout.IntField("主键", property.intValue);

            EditorGUILayout.PropertyField(property,true);//默认绘制

            property = serializedObject.FindProperty(nameof(obj));

            property.objectReferenceValue = EditorGUILayout.ObjectField
                ("游戏对象",
                property.objectReferenceValue,
                typeof(GameObject),
                true);

            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}
