using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantGemBoostUpdater : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gamecontroller.RubyBoost = 1f + Gamecontroller.Ruby1Amount * 0.05f + Gamecontroller.Ruby2Amount * 0.25f + Gamecontroller.Ruby3Amount * 1f;


        if (Gamecontroller.Emerald1Amount * 1f + Gamecontroller.Emerald2Amount * 5f + Gamecontroller.Emerald3Amount * 20f > 200)
        {
            Gamecontroller.EmeraldBoost = 200f;
        }
        else
        {
            Gamecontroller.EmeraldBoost = Gamecontroller.Emerald1Amount * 1f + Gamecontroller.Emerald2Amount * 5f + Gamecontroller.Emerald3Amount * 20f;
        }
        




        Gamecontroller.FriendsLevelCap = 100000f + Gamecontroller.Sapphire1Amount * 1000f + Gamecontroller.Sapphire2Amount * 5000f + Gamecontroller.Sapphire3Amount * 20000f;



    }
}
