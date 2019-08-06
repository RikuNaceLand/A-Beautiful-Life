using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Upgrade2 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Material Bought;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.T2UPUpgrade2Bought == true)
        {
            GetComponent<Renderer>().material = Bought;
            transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Gamecontroller.T2UPUpgrade2Bought == false)
        {

            if (Gamecontroller.T1UPUpgrade2Bought == true)
            {
                if (Gamecontroller.UltimatePoints > 9)
                {

                    Gamecontroller.T2UPUpgrade2Bought = true;

                    Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints - 10;
                    GetComponent<Renderer>().material = Bought;
                    transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                }
            }
        }

    }
}
