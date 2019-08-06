using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeEmeralds1 : MonoBehaviour
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

        if (Gamecontroller.Emerald1Amount > 1)
        {
            Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount - 2;
            Gamecontroller.Emerald2Amount = Gamecontroller.Emerald2Amount + 1;
        }


    }
}
