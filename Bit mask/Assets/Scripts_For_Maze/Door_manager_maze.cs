using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_manager_maze : MonoBehaviour
{
    int doortype = 0;

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.GetComponent<AttributeManager_for_Maze>().attributes & doortype) != 0)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        this.GetComponent<BoxCollider>().isTrigger = false;
        other.gameObject.GetComponent<AttributeManager_for_Maze>().attributes &= ~doortype;
    }

    void Start()
    {
        if (this.gameObject.tag == "BLUE_DOOR") doortype = AttributeManager_for_Maze.blue;
        if (this.gameObject.tag == "GREEN_DOOR") doortype = AttributeManager_for_Maze.green;
        if (this.gameObject.tag == "RED_DOOR") doortype = AttributeManager_for_Maze.red;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
