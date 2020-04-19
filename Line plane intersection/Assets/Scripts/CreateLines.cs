﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLines : MonoBehaviour
{
    Line L1;
    Line L2;

    // Start is called before the first frame update
    void Start()
    {
        L1 = new Line(new Coords(0.0f, 0.0f, 0.0f), new Coords(-6.0f, 7.0f, 3.0f));
        L1.Draw(1, Color.green);
        L2 = new Line(new Coords(0.0f, 0.0f, 0.0f), new Coords(-7.0f, -6.0f, 6.0f));
        L2.Draw(1, Color.red);

        float intersectT = L1.IntersectsAt(L2);
        float intersectS = L2.IntersectsAt(L1);

        if (intersectT == intersectT && intersectS == intersectS)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = L1.Lerp(intersectT).ToVector();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
