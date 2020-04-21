using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRotate : MonoBehaviour
{
    public GameObject[] point;
    public Vector3 angle;

    // Start is called before the first frame update
    void Start()
    {
        angle = angle * Mathf.Deg2Rad;
        foreach (GameObject p in point)
        {
            Coords position = new Coords(p.transform.position, 1);
            p.transform.position = HolisticMath.Rotation(position, angle.x, true,
                                                        angle.y, true,
                                                        angle.z, true).ToVector();

        }

        Matrix rot = HolisticMath.GetRotationMatrix(angle.x, true, angle.y, true, angle.z, true);
        float rotAngle = HolisticMath.GetRotationAxisAngle(rot);
        Coords rotaxis = HolisticMath.GetRotationAxis(rot, rotAngle);

        Debug.Log(rotAngle * Mathf.Rad2Deg + " about " + rotaxis.ToString());
        Coords.DrawLine(new Coords(0, 0, 0), rotaxis * 5, 0.2f, Color.yellow);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
