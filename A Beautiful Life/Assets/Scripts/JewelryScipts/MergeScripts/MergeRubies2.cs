using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeRubies2 : MonoBehaviour
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

        if (Gamecontroller.Ruby2Amount > 1)
        {
            Gamecontroller.Ruby2Amount = Gamecontroller.Ruby2Amount - 2;
            Gamecontroller.Ruby3Amount = Gamecontroller.Ruby3Amount + 1;
        }


    }
}
