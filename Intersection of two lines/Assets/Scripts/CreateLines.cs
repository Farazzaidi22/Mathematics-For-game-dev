using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLines : MonoBehaviour
{
    Line line1;
    Line line2;

    // Start is called before the first frame update
    void Start()
    {
        //line1 = new Line(new Coords(-100,0,0), new Coords(200,150,0), Line.LINETYPE.LINE);
        //line1.DrawLine(1, Color.green);
        //line2 = new Line(new Coords(-100,10 ,0), new Coords(200, 150, 0), Line.LINETYPE.LINE);
        //line2.DrawLine(1, Color.red);

        line1 = new Line(new Coords(-100, 0, 0), new Coords(20, 50, 0));
        line1.DrawLine(1, Color.green);
        line2 = new Line(new Coords(-100, 10, 0), new Coords(0, 50, 0));
        line2.DrawLine(1, Color.red);

        float intersectT = line1.IntersectAt(line2);
        float intersectS = line2.IntersectAt(line1);

        Debug.Log(intersectS);
        Debug.Log(intersectT);

        if (intersectT == intersectT && intersectS == intersectS)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = line1.Lerp(intersectT).ToVector();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
