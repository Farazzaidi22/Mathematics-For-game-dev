using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath
{
    static public Coord GetNormal(Coord vector)
    {
        float length = GetDistance(new Coord(0, 0, 0), vector);
        vector.x /= length;
        vector.y /= length;
        vector.z /= length;

        return vector;
    }

    static public float GetDistance(Coord point1, Coord point2)
    {
        float diffSquared = Mathf.Sqrt(Square(point1.x - point2.x) +
                                       Square(point1.y - point2.y) +
                                       Square(point1.z - point2.z));
        return diffSquared;
    }

    static public float Square(float value)
    {
        return value * value;
    }

    static public float DotProd(Coord vec1, Coord vec2)
    {
        float dot = (vec1.x * vec2.x) + (vec1.y * vec2.y) + (vec1.z * vec2.z);
        return dot;
    }

    static public float Angle(Coord vec1, Coord vec2)
    {
        float theta = (DotProd(vec1, vec2)) / (GetDistance(new Coord(0,0,0), vec1) * GetDistance(new Coord(0, 0, 0), vec2));
        return Mathf.Acos(theta);
    }

    static public Coord LookAt2D(Coord forwardVec, Coord position, Coord focus)
    {
        Coord direction = new Coord(focus.x - position.x, focus.y - position.y, position.z);
        float angle = MyMath.Angle(forwardVec, direction);
        bool clockwise = false;
        if(MyMath.CrossProd(forwardVec, direction).z < 0)
        {
            clockwise = true;
        }
        Coord newdir = MyMath.Rotate(forwardVec, angle, clockwise);
        return newdir;
    }

    static public Coord Rotate(Coord vec, float angle,bool clockwise)
    {
        if(clockwise)
        {
            angle = 2 * Mathf.PI - angle;
        }

        float xVal = Mathf.Cos(angle) * vec.x - Mathf.Sin(angle) * vec.y;
        float yVal = Mathf.Sin(angle) * vec.x + Mathf.Cos(angle) * vec.y;
        return new Coord(xVal, yVal, 0);
    }

                               //(Curr direc, wanna be direc)
    static public Coord CrossProd(Coord vec1, Coord vec2)
    {
        float zVal = (vec1.x * vec2.y) - (vec1.y * vec2.x);
        float yVal = (vec1.z * vec2.x) - (vec1.x * vec2.z);
        float xVal = (vec1.y * vec2.z) - (vec1.z * vec2.y);

        return new Coord(xVal,yVal,zVal);
    }
}
