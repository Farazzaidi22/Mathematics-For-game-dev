using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class setbits : MonoBehaviour
{
    int bSeq = 8 + 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Convert.ToString(bSeq, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
