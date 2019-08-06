using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achieve2 : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public Material Earned;

    private Material Unearned;

    // Start is called before the first frame update
    void Start()
    {
        Unearned = GetComponent<Renderer>().material;

        if (Unearned == Earned)
        {
            //nothing
        }
        else if (Gamecontroller.Achieve2Unlocked == true)
        {
            GetComponent<Renderer> ().material = Earned;
        }


    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
