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
    public Text turnAngle;


    public void AddEnergy(string amt)
    {
        int n;
        if(int.TryParse(amt, out n))
        {
            print("amil4");
            energyAmt.text = amt;
        }
    }

    public void TurnAngle(string amt)
    {
        float n;
        print("amil");
        if(float.TryParse(amt, out n))
        {
            print("amil2");
            n = n * (Mathf.PI / 180);
            print("amil3");
            Tank.transform.up = MyMath.Rotate(new Coord(Tank.transform.up), n, false).ToVector();
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
