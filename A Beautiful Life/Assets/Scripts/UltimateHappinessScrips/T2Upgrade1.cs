using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Upgrade1 : MonoBehaviour
{
    private GameControl Gamecontroller = GameControl.Instance;

    public Material Bought;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamecontroller.T2UPUpgrade1Bought == true)
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

        if (Gamecontroller.T2UPUpgrade1Bought == false)
        {

            if (Gamecontroller.T1UPUpgrade1Bought == true)
            {
                if (Gamecontroller.UltimatePoints > 2)
                {

                    Gamecontroller.T2UPUpgrade1Bought = true;
                    Gamecontroller.T2Upgrade1MultiToUP = 2;
                    Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints - 3;
                    GetComponent<Renderer>().material = Bought;
                    transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
                }
            }
        }

    }
}
