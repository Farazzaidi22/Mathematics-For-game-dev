using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane
{
    Coords A;
    Coords B;
    Coords C;
    Coords u;
    Coords v;

    public Plane(Coords A_, Coords B_, Coords C_)
    {
        A = A_;
        B = B_;
        C = C_;
        u = B - A;
        v = C - A;
    }

    public Coords Lerp(float s, float t) //GetAtPoint(float t)
    {
        float xst = A.x + v.x * s + u.x * t;
        float yst = A.y + v.y * s + u.y * t;
        float zst = A.z + v.z * s + u.z * t;

        return new Coords(xst, yst, zst);
    }
}
