using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRayIntersect : MonoBehaviour
{
    public GameObject sphere;
    public GameObject quad;
    public Transform cornor1;
    public Transform cornor2;
    public Transform cornor3;

    Plane plane;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vertices = quad.GetComponent<MeshFilter>().mesh.vertices;
        plane = new Plane(quad.transform.TransformPoint(vertices[0]),
                          quad.transform.TransformPoint(vertices[1]),
                          quad.transform.TransformPoint(vertices[2]));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float t = 0.0f;

            if(plane.Raycast(ray, out t))
            {
                Vector3 hitPoint = ray.GetPoint(t);
                sphere.transform.position = hitPoint;
            }
        }
        
    }
}
