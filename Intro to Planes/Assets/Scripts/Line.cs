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
