using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AttributeManager_for_Maze : MonoBehaviour
{
    static public int green = 4;
    static public int blue = 2;
    static public int red = 1;

    public Text attributeDisplay;
    public int attributes = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BLUE_KEY")
        {
            attributes |= blue;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "GREEN_KEY")
        {
            attributes |= green;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "RED_KEY")
        {
            attributes |= red;
            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "GOLDEN_KEY")
        {
            attributes |= (blue| green | red);
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0, -50, 0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
    }
}
