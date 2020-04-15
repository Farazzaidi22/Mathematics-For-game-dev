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
}
