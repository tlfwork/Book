
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TargetScript))]
public class CustomerInspector : Editor
{
    private TargetScript _targetScript;

    private void OnEnable()
    {
        // 将target转换为PlayerTest类型（target是Editor类的内置属性，代表当前选中的组件）
        _targetScript = target as TargetScript;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        serializedObject.Update();

        EditorGUILayout.LabelField("自定义玩家组件面板");

        _targetScript.moveSpeed = EditorGUILayout.FloatField("移动速度", _targetScript.moveSpeed);

        _targetScript.currentHp = EditorGUILayout.IntSlider("当前血量",  _targetScript.currentHp, 0, 100);

        _targetScript.dead = EditorGUILayout.Toggle("死亡状态", _targetScript.dead);

        SerializedProperty property = serializedObject.FindProperty("_name");

        property.stringValue = EditorGUILayout.TextField("姓名", property.stringValue);

        serializedObject.ApplyModifiedProperties();
    }
}
