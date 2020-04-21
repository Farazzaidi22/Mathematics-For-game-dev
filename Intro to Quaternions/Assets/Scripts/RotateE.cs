using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateE : MonoBehaviour
{
    void Update()
    {
        this.transform.forward = HolisticMath.Rotation(new Coords(this.transform.forward, 0),
                                                       1 * Mathf.Deg2Rad, false, 1 * Mathf.Deg2Rad, false, 1 * Mathf.Deg2Rad, false).ToVector();
    }
}
