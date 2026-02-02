using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewData", menuName = "Custom/MyScriptableObject")]
public class MyScriptableObject : ScriptableObject
{
    public int playerHealth;
    public float moveSpeed;
    public AudioClip jumpSound;
}
