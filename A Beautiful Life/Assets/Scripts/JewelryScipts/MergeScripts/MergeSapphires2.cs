using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSapphires2 : MonoBehaviour
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

        if (Gamecontroller.Sapphire2Amount > 1)
        {
            Gamecontroller.Sapphire2Amount = Gamecontroller.Sapphire2Amount - 2;
            Gamecontroller.Sapphire3Amount = Gamecontroller.Sapphire3Amount + 1;
        }


    }
}
