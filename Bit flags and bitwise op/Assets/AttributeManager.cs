using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AttributeManager : MonoBehaviour
{
    int magic = 16;
    int intelligence = 8;
    int charisma = 4;
    int fly = 2;
    int invisible = 1;

    public Text attributeDisplay;
    int attribute = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MAGIC")
        {
            attribute |= magic;
        }

        if (other.gameObject.tag == "INTELLIGENCE")
        {
            attribute |= intelligence;
        }

        if (other.gameObject.tag == "CHARISMA")
        {
            attribute |= charisma;
        }

        if (other.gameObject.tag == "FLY")
        {
            attribute |= fly;
        }

        if (other.gameObject.tag == "INVISIBLE")
        {
            attribute |= invisible;
        }

        if (other.gameObject.tag == "ANTIMAGIC")
        {
            attribute &= ~magic;
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
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attribute, 2).PadLeft(8, '0');
    }
       
}
