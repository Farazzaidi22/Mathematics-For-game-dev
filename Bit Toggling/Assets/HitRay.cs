using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRay : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        int layerMask = (1 << 9) | (1 << 10) ; //can't directly go to layer 10 cuz they work in bit pattern
        //layerMask = ~layerMask; //for passing through every layer but that one
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),
            out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance
                , Color.yellow);
            Debug.Log("hit");
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.red);
            Debug.Log("missed");
        }
    }
}
