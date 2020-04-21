using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    public GameObject[] point;
    public Vector3 angle;
    public Vector3 traslate;
    public Vector3 Scale;
    public Vector3 shear;
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
            //position = HolisticMath.Translation(position, new Coords(new Vector3(-c.x, -c.y, -c.z), 0));
            //position = HolisticMath.Rotation(position, angle.x, true, angle.y, true, angle.z, true);
            //p.transform.position = HolisticMath.Translation(position,
            //                       new Coords(new Vector3(c.x, c.y, c.z), 0)).ToVector();


            p.transform.position = HolisticMath.Shear(position, shear.x, shear.y, shear.z).ToVector();
            //p.transform.position = HolisticMath.ReflectX(position).ToVector();


        }

        Coords.DrawLine(new Coords(point[0].transform.position), new Coords(point[1].transform.position), 0.09f ,Color.yellow);
        Coords.DrawLine(new Coords(point[0].transform.position), new Coords(point[3].transform.position), 0.09f, Color.yellow);
        Coords.DrawLine(new Coords(point[0].transform.position), new Coords(point[4].transform.position), 0.09f, Color.yellow);
       

        Coords.DrawLine(new Coords(point[1].transform.position), new Coords(point[2].transform.position), 0.09f, Color.yellow);
        Coords.DrawLine(new Coords(point[1].transform.position), new Coords(point[5].transform.position), 0.09f, Color.yellow);

        Coords.DrawLine(new Coords(point[2].transform.position), new Coords(point[9].transform.position), 0.09f, Color.yellow);
        Coords.DrawLine(new Coords(point[2].transform.position), new Coords(point[3].transform.position), 0.09f, Color.yellow);
        Coords.DrawLine(new Coords(point[2].transform.position), new Coords(point[6].transform.position), 0.09f, Color.yellow);

        Coords.DrawLine(new Coords(point[3].transform.position), new Coords(point[7].transform.position), 0.09f, Color.yellow);
        Coords.DrawLine(new Coords(point[3].transform.position), new Coords(point[8].transform.position), 0.09f, Color.yellow);


        Coords.DrawLine(new Coords(point[4].transform.position), new Coords(point[5].transform.position), 0.09f, Color.yellow);
        Coords.DrawLine(new Coords(point[4].transform.position), new Coords(point[7].transform.position), 0.09f, Color.yellow);

        Coords.DrawLine(new Coords(point[5].transform.position), new Coords(point[6].transform.position), 0.09f, Color.yellow);

        Coords.DrawLine(new Coords(point[6].transform.position), new Coords(point[7].transform.position), 0.09f, Color.yellow);
        Coords.DrawLine(new Coords(point[6].transform.position), new Coords(point[9].transform.position), 0.09f, Color.yellow);

        Coords.DrawLine(new Coords(point[7].transform.position), new Coords(point[8].transform.position), 0.09f, Color.yellow);

        Coords.DrawLine(new Coords(point[8].transform.position), new Coords(point[9].transform.position), 0.09f, Color.yellow);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
