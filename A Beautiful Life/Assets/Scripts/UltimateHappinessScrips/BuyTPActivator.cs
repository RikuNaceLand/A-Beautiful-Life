using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTPActivator : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        
        if (Gamecontroller.T3UPUpgrade2Bought == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        if (Gamecontroller.T3UPUpgrade2Bought == true && Gamecontroller.T4UPUpgrade3Bought == true)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
