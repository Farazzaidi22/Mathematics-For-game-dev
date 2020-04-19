using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlaneHit : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform C;
    public Transform D;
    public Transform E;

    Line line;
    Plane plane;

    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(new Coords(A.position), new Coords(B.position), new Coords(C.position));
        line  = new Line(new Coords(D.position), new Coords(E.position), Line.LINETYPE.RAY);
        line.Draw(1, Color.green);

        for(float s = 0; s<1; s+=0.1f)
        {
            for (float t = 0; t < 1; t += 0.1f)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = plane.Lerp(s, t).ToVector();
            }
        }

        float interceptT = line.IntersectsAt(plane);
        if(interceptT == interceptT)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = line.Lerp(interceptT).ToVector();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
