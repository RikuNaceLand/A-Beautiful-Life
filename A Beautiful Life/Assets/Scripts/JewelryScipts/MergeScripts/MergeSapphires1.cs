using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSapphires1 : MonoBehaviour
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

        if (Gamecontroller.Sapphire1Amount > 1)
        {
            Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount - 2;
            Gamecontroller.Sapphire2Amount = Gamecontroller.Sapphire2Amount + 1;
        }


    }
}
