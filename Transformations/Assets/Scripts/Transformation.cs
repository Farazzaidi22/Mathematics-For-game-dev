using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    public GameObject[] point;
    public Vector3 angle;
    public Vector3 traslate;
    public Vector3 Scale;
    public GameObject centre;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 c = new Vector3(centre.transform.position.x,
                                centre.transform.position.y,
                                centre.transform.position.z);

        angle = angle * Mathf.Deg2Rad;

        foreach(GameObject p in point)
        {
            Coords position = new Coords(p.transform.position, 1);

            //p.transform.position = HolisticMath.Translation(position,
            //                       new Coords(new Vector3(traslate.x, traslate.y, traslate.z), 0)).ToVector();

            //p.transform.position = HolisticMath.Scaling(position, Scale.x, Scale.y, Scale.z).ToVector();

            //position = HolisticMath.Translation(position, new Coords(new Vector3(-c.x, -c.y, -c.z), 0));
            //position = HolisticMath.Scaling(position, Scale.x, Scale.y, Scale.z);
            //p.transform.position = HolisticMath.Translation(position,
            //                       new Coords(new Vector3(c.x, c.y, c.z), 0)).ToVector();

            //p.transform.position = HolisticMath.Rotation(position, angle.x, true, angle.y, true, angle.z, true).ToVector();
            position = HolisticMath.Translation(position, new Coords(new Vector3(-c.x, -c.y, -c.z), 0));
            position = HolisticMath.Rotation(position, angle.x, true, angle.y, true, angle.z, true);
            p.transform.position = HolisticMath.Translation(position,
                                   new Coords(new Vector3(c.x, c.y, c.z), 0)).ToVector();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
