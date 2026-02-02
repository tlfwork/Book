using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyScriptableObject data = Resources.Load<MyScriptableObject>("DataLoad");

        Debug.Log(data.playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
