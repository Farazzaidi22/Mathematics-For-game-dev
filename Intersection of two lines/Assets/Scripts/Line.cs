using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line
{
    Coords A;
    Coords B;
    Coords v;

    public enum LINETYPE { LINE, SEGMENT, RAY};
    LINETYPE type;

    public Line(Coords A_, Coords B_, LINETYPE _type)
    {
        A = A_;
        B = B_;
        type = _type;
        v = new Coords(B.x - A.x, B.y - A.y, B.z - A.z);
    }

    public Line(Coords A_, Coords V)
    {
        A = A_;
        v = V;
        B = A_ + v;
        type = LINETYPE.SEGMENT;
    }

    public void DrawLine(float width, Color col)
    {
        Coords.DrawLine(A, B, width, col);
    }

    public float IntersectAt(Line l)
    {
        if(HolisticMath.Dot(Coords.Perp(l.v), v) == 0)
        {
            return float.NaN;
        }

        Coords c = l.A - this.A;
        float t = HolisticMath.Dot(Coords.Perp(l.v), c) / HolisticMath.Dot(Coords.Perp(l.v), v);
        if((t < 0 || t > 1) && type == LINETYPE.SEGMENT)
        {
            return float.NaN;
        }
        return t;
    }

    public Coords Lerp(float t) //GetAtPoint(float t)
    {
        if(type == LINETYPE.SEGMENT)
        {
            t = Mathf.Clamp(t, 0, 1);
        }
        else if(type == LINETYPE.RAY && t < 0)
        {
            t = 0;
        }

        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.z * t;

        return new Coords(xt, yt, zt);
    }
}
