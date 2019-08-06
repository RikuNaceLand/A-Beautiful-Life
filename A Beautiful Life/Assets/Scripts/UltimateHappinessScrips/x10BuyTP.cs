using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x10BuyTP : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Gamecontroller.HappinessAmount > 1e9)
        {
            Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount - 1e9f;
            Gamecontroller.TPAmount = Gamecontroller.TPAmount + 10;

        }


    }
}
