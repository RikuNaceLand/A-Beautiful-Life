using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeRubies1 : MonoBehaviour
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
        
        if (Gamecontroller.Ruby1Amount > 1)
        {
            Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount - 2;
            Gamecontroller.Ruby2Amount = Gamecontroller.Ruby2Amount + 1;
        }


    }
}
