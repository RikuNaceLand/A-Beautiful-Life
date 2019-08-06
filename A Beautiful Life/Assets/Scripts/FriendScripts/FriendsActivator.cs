using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendsActivator : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
     if (Gamecontroller.Upgrade3Bought == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }

     if (Gamecontroller.Upgrade4Bought == true)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }

     if (Gamecontroller.Upgrade8Bought == true)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
