using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DataOne", menuName = "Custom/MyScriptableObject")]
public class MyScriptableObject : ScriptableObject
{
    public int id;
    public float hp;
}
