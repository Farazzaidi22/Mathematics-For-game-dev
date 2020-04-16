using UnityEngine;
using System.Collections;
using System;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{
    //Vector2 up = new Vector2(0, 0.1f);
    //Vector2 right = new Vector2(0.1f, 0);

    public GameObject fuel;
    float speed = 5f;
    Vector3 direction;
    float stopPoint = 0.1f;

    private void Start()
    {
        //direction = fuel.transform.position - this.transform.position;
        //Coord dirNormal = MyMath.GetNormal(new Coord(direction));
        //direction = dirNormal.ToVector();


        //this.transform.up = MyMath.LookAt2D(new Coord(this.transform.forward), 
        //                                    new Coord(this.transform.position),
        //                                    new Coord(fuel.transform.position)).ToVector();

        direction = fuel.transform.position - this.transform.position;
        Coord dirNormal = MyMath.GetNormal(new Coord(direction));
        direction = dirNormal.ToVector();
        float a = MyMath.Angle(new Coord(0, 1, 0), new Coord(direction)); // * (180.0f / Mathf.PI);
        Debug.Log("Angle: " + a);

        bool clockwise = false;
        if (MyMath.CrossProd(new Coord(this.transform.up), dirNormal).z < 0)
        {
            clockwise = true;
        }

        Coord newDir = MyMath.Rotate(new Coord(0, 1, 0), a, clockwise);
        this.transform.up = new Vector3(newDir.x, newDir.y, newDir.z);
    }

    void Update()
    {
        //if(Vector3.Distance(this.transform.position, fuel.transform.position) > stopPoint)
        if(MyMath.GetDistance(new Coord(this.transform.position), new Coord(fuel.transform.position)) > stopPoint)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
        
        
        //Vector3 position = this.transform.position;

        //if(Input.GetKey(KeyCode.UpArrow))
        //{
        //    position.x += up.x;
        //    position.y += up.y;
        //}

        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    position.x += up.x;
        //    position.y += - up.y;
        //}

        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    position.x += right.x;
        //    position.y += right.y;
        //}

        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    position.x += - right.x;
        //    position.y += right.y;
        //}

        //this.transform.position = position;
    }
}