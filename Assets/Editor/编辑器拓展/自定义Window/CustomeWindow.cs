using UnityEditor;
using UnityEngine;

public class CustomeWindow : EditorWindow
{
    ipconfig ipconfig;

    string BeginIp = string.Empty;

    string BeginPort = string.Empty;

    [MenuItem("CustomeWindow/IP配置", false, 0)]
    public static void OpenWindow()
    {
        // 获取/创建窗口：GetWindow<窗口类>(是否浮动, 窗口标题, 是否置顶)
        CustomeWindow window = GetWindow<CustomeWindow>(false, "IP配置", true);
        // 设置窗口大小（可选）
        window.minSize = new Vector2(400, 500); // 最小尺寸
        window.maxSize = new Vector2(400, 500); // 最大尺寸（固定窗口大小）
        window.Show(); // 显示窗口（可选，GetWindow会自动显示）
    }

    private void OnEnable()
    {
        ipconfig = AssetDatabase.LoadAssetAtPath<ipconfig>("Assets/Res/IpConfig/IpConfig.asset");

        if (ipconfig == null) 
        {
            ipconfig = ScriptableObject.CreateInstance<ipconfig>();

            AssetDatabase.CreateAsset(ipconfig, "Assets/Res/IpConfig/IpConfig.asset");
        }

        BeginIp = ipconfig.address;

        BeginPort = ipconfig.port;
    }

    private void OnGUI()
    {
        BeginIp = EditorGUILayout.TextField("IP地址", BeginIp);

        BeginPort = EditorGUILayout.TextField("端口", BeginPort);

        if (GUILayout.Button("保存"))
        {
            ipconfig.address = BeginIp;

            ipconfig.port = BeginPort;

            AssetDatabase.SaveAssets();

            AssetDatabase.Refresh();
        }
    }
}
