using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logging : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("I just awoke!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hey buddy first time here");
        
    }

    // Update is called once per frame
    void Update()
    {
       print("Hello on update!");
    }
}
