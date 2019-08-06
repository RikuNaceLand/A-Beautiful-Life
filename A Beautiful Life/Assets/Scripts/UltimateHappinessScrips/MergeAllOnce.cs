using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeAllOnce : MonoBehaviour
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

        if (Gamecontroller.Emerald2Amount > 1)
        {
            Gamecontroller.Emerald2Amount = Gamecontroller.Emerald2Amount - 2;
            Gamecontroller.Emerald3Amount = Gamecontroller.Emerald3Amount + 1;
        }

        if (Gamecontroller.Sapphire1Amount > 1)
        {
            Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount - 2;
            Gamecontroller.Sapphire2Amount = Gamecontroller.Sapphire2Amount + 1;
        }

        if (Gamecontroller.Sapphire2Amount > 1)
        {
            Gamecontroller.Sapphire2Amount = Gamecontroller.Sapphire2Amount - 2;
            Gamecontroller.Sapphire3Amount = Gamecontroller.Sapphire3Amount + 1;
        }

        if (Gamecontroller.Ruby1Amount > 1)
        {
            Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount - 2;
            Gamecontroller.Ruby2Amount = Gamecontroller.Ruby2Amount + 1;
        }

        if (Gamecontroller.Ruby2Amount > 1)
        {
            Gamecontroller.Ruby2Amount = Gamecontroller.Ruby2Amount - 2;
            Gamecontroller.Ruby3Amount = Gamecontroller.Ruby3Amount + 1;
        }


    }
}
