using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1.0f;
    public float Rotationspeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //float xTranslate = Input.GetAxis("Horizontal") * speed;
        //float yTranslate = Input.GetAxis("VerticalY") * speed;
        //float zTranslate = Input.GetAxis("Vertical") * speed;

        float xRotate= Input.GetAxis("Horizontal") * Rotationspeed;
        float yRotate = Input.GetAxis("Vertical") * Rotationspeed;
        float zRotate = Input.GetAxis("HorizontalZ") * Rotationspeed;
        float zTranslate = Input.GetAxis("VerticalY") * speed;

        // moves in world space
        //transform.position = new Vector3(transform.position.x + xTranslate,
        //                                 transform.position.y + yTranslate,
        //                                 transform.position.z + zTranslate);


        //or
        // moves in object space
        //transform.Translate(xTranslate, 0, 0);
        //transform.Translate(0, yTranslate, 0);
        //transform.Translate(0, 0, zTranslate);

        //or

        //transform.Translate(xTranslate, yTranslate, zTranslate);

        transform.Rotate(xRotate, yRotate, zRotate);
        transform.Translate(0, 0, zTranslate);
    }
}
