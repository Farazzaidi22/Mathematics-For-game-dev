using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSolidWall : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform C;
    public Transform D;
    public Transform E;

    public GameObject ball;

    Plane wall;
    Line ballpath;
    Line trajectory;

    // Start is called before the first frame update
    void Start()
    {
        wall = new Plane(new Coords(A.position),
                        new Coords(B.position),
                        new Coords(C.position));

        for (float s = 0; s <= 1; s += 0.1f)
        {
            for (float t = 0; t <= 1; t += 0.1f)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = wall.Lerp(s, t).ToVector();
            }
        }

        ballpath = new Line(new Coords(D.position), new Coords(E.position), Line.LINETYPE.RAY);
        ballpath.Draw(1, Color.green);

        ball.transform.position = ballpath.A.ToVector();

        float interceptT = ballpath.IntersectsAt(wall);
        if (interceptT == interceptT)
        {
            trajectory = new Line(ballpath.A, ballpath.Lerp(interceptT), Line.LINETYPE.SEGMENT);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.time <= 1)
        {
            ball.transform.position = trajectory.Lerp(Time.time).ToVector();
        }
        else
        {
            ball.transform.position += trajectory.Reflect(HolisticMath.Cross(wall.u,wall.v)).ToVector() * 
                                        Time.deltaTime * 5;
        }
    }
}
