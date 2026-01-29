using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSerializeTest : MonoBehaviour
{
    public int a = 10;
    public int b { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
