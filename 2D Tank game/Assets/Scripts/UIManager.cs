using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject Tank;
    public GameObject fuel;
    public Text tankPosition;
    public Text fuelPosition;
    public Text energyAmt;


    public void AddEnergy(string amt)
    {
        int n;
        if(int.TryParse(amt, out n))
        {
            energyAmt.text = amt;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        tankPosition.text = Tank.transform.position + "";
        fuelPosition.text = fuel.GetComponent<ObjManager>().objPos + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
