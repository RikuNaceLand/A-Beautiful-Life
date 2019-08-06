using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeEmeralds2 : MonoBehaviour
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

        if (Gamecontroller.Emerald2Amount > 1)
        {
            Gamecontroller.Emerald2Amount = Gamecontroller.Emerald2Amount - 2;
            Gamecontroller.Emerald3Amount = Gamecontroller.Emerald3Amount + 1;
        }


    }
}
