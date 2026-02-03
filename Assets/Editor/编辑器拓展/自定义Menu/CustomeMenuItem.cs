using UnityEditor;
using UnityEngine;

// 静态类：菜单方法必须是静态的，类建议设为静态（规范）
public static class CustomeMenuItem
{
    // [MenuItem(菜单路径, 是否验证, 优先级)]
    [MenuItem("CustomeMenuItem/创建测试玩家", false, 1)]
    public static void CreateTestPlayer() // 必须是静态无参方法
    {
        // 菜单点击后执行的核心逻辑
        Debug.Log("点击了自定义菜单，开始创建测试玩家！");
    }

    #region 第二个参数测试
    [MenuItem("CustomeMenuItem/参数测试", true, 2)]
    public static bool BoolTest()
    {
        if(Selection.activeObject != null) return true;

        return false; 
    }

    [MenuItem("CustomeMenuItem/参数测试", false, 2)]
    public static void BoolTestBase()
    {
        Debug.Log("选中并且点击物体 ");  
    }
    #endregion


}