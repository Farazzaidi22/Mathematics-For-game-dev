using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    Coord origin = new Coord(0, 0);

    public int distance = 20;

    public int xmax = 200;
    public int ymax = 200;

    Coord XstartPoint; 
    Coord XendPoint; 
    Coord YstartPoint;
    Coord YendPoint;


    // Start is called before the first frame update
    void Start()
    {
        //origin
        Coord.DrawPoint(origin, 1, Color.yellow);

        //Coord.DrawPoint(point, 1, Color.cyan);

        // x and y axes
        XstartPoint = new Coord(xmax, 0);
        XendPoint = new Coord(-xmax, 0);
        YstartPoint = new Coord(0, ymax);
        YendPoint = new Coord(0, -ymax);


        int xgap = (int)(xmax / (float)distance);
        for (int x = -xgap * distance; x <= xgap * distance; x+= distance)
        {
            Coord.DrawLine(new Coord(x, -ymax), new Coord(x, ymax), 0.5f, Color.magenta);
        }

        int ygap = (int)(ymax / (float)distance);
        for (int y = -ygap * distance; y <= ygap * distance; y+= distance)
        {
            Coord.DrawLine(new Coord(-xmax, y), new Coord(xmax, y), 0.5f, Color.yellow);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
