using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    Coord origin = new Coord(0, 0);

    //Coord point = new Coord(10, 20);


    Coord star1 = new Coord(2, 2);
    Coord star2 = new Coord(3, 3);
    Coord star3 = new Coord(12.5f, 10);
    Coord star4 = new Coord(10, 20);
    Coord star5 = new Coord(7.5f, 25);
    Coord star6 = new Coord(5, 30);
    Coord star7 = new Coord(10,35);
    Coord star8 = new Coord(15, 33);
    Coord star9 = new Coord(17, 31);
    Coord star10 = new Coord(22, 28);
    Coord star11 = new Coord(25, 25);
    Coord star12 = new Coord(30, 10);
    Coord star13 = new Coord(35, 8);


    Coord Xcods = new Coord(160, 0);
    Coord nXcods = new Coord(-160, 0);
    Coord Ycods = new Coord(0,100);
    Coord nYcods = new Coord(0,-100);


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(star1.ToString());

        Coord.DrawPoint(star1, 1, Color.cyan);
        Coord.DrawPoint(star2, 1, Color.cyan);
        Coord.DrawPoint(star3, 1, Color.cyan);
        Coord.DrawPoint(star4, 1, Color.cyan);
        Coord.DrawPoint(star5, 1, Color.cyan);
        Coord.DrawPoint(star6, 1, Color.cyan);
        Coord.DrawPoint(star7, 1, Color.cyan);
        Coord.DrawPoint(star8, 1, Color.cyan);
        Coord.DrawPoint(star9, 1, Color.cyan);
        Coord.DrawPoint(star10, 1, Color.cyan);
        Coord.DrawPoint(star11, 1, Color.cyan);
        Coord.DrawPoint(star12, 1, Color.cyan);
        Coord.DrawPoint(star13, 1, Color.cyan);


        Coord.DrawLine(star1, star2, 0.5f, Color.red);
        Coord.DrawLine(star2, star3, 0.5f, Color.red);
        Coord.DrawLine(star3, star4, 0.5f, Color.red);
        Coord.DrawLine(star4, star5, 0.5f, Color.red);
        Coord.DrawLine(star5, star6, 0.5f, Color.red);
        Coord.DrawLine(star6, star7, 0.5f, Color.red);
        Coord.DrawLine(star7, star8, 0.5f, Color.red);
        Coord.DrawLine(star8, star9, 0.5f, Color.red);
        Coord.DrawLine(star9, star10, 0.5f, Color.red);
        Coord.DrawLine(star10, star11, 0.5f, Color.red);
        Coord.DrawLine(star11, star12, 0.5f, Color.red);
        Coord.DrawLine(star12, star13, 0.5f, Color.red);

        //origin
        Coord.DrawPoint(origin, 1, Color.yellow);
        
        //Coord.DrawPoint(point, 1, Color.cyan);

        // x and y axes
        Coord.DrawLine(Xcods, nXcods, 0.5f, Color.red);
        Coord.DrawLine(Ycods, nYcods, 0.5f, Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
