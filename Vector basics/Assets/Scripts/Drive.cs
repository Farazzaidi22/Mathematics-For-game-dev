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
        direction = fuel.transform.position - this.transform.position;
        Coord dir = MyMath.GetNormal(new Coord(direction));
        direction = dir.ToVector();
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