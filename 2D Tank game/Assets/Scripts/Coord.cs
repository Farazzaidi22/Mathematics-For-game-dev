using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coord
{
    public float x;
    public float y;
    public float z;

    public Coord(float _x, float _y)
    {
        x = _x;
        y = _y;
        z = -1;
    }

    public Coord(float _X, float _Y, float _Z)
    {
        x = _X;
        y = _Y;
        z = _Z;
    }

    public Coord(Vector3 vecscop)
    {
        x = vecscop.x;
        y = vecscop.y;
        z = vecscop.z;
    }

    public override string ToString()
    {
        return "(" + x + " ," + y + " ," + z + ")";
    }

    public Vector3 ToVector()
    {
        return new Vector3(x, y, z);
    }

    static public void DrawPoint(Coord position, float width, Color colour)
    {
        GameObject line = new GameObject("Point: " + position.ToString());
        LineRenderer lineRend = line.AddComponent<LineRenderer>();
        lineRend.material = new Material(Shader.Find("Unlit/Color"));
        lineRend.material.color = colour;
        lineRend.positionCount = 2;
        lineRend.SetPosition(0, new Vector3(position.x - width / 3.0f, position.y - width / 3.0f, position.z));
        lineRend.SetPosition(1, new Vector3(position.x + width / 3.0f, position.y + width / 3.0f, position.z));
        lineRend.startWidth = width;
        lineRend.endWidth = width;
    }

    static public void DrawLine(Coord startPos, Coord endPos , float width, Color colour)
    {
        GameObject line = new GameObject("line: " + startPos.ToString() + "-" + startPos.ToString());
        LineRenderer lineRend = line.AddComponent<LineRenderer>();
        lineRend.material = new Material(Shader.Find("Unlit/Color"));
        lineRend.material.color = colour;
        lineRend.positionCount = 2;
        lineRend.SetPosition(0, new Vector3(startPos.x, startPos.y, startPos.z));
        lineRend.SetPosition(1, new Vector3(endPos.x, endPos.y, endPos.z));
        lineRend.startWidth = width;
        lineRend.endWidth = width;
    }
}
