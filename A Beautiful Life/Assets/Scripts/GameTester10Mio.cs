using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTester10Mio : MonoBehaviour
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

        Gamecontroller.HappinessAmount = Gamecontroller.HappinessAmount + 3000000000000000f;
        Gamecontroller.TotalHappiness = Gamecontroller.HappinessAmount;
        Gamecontroller.FriendsAmount = Gamecontroller.FriendsAmount + 10000f;
       
        Gamecontroller.MedalCountAging = Gamecontroller.MedalCountAging + 10;
        Gamecontroller.MedalCountBreathing = Gamecontroller.MedalCountBreathing + 10;
        Gamecontroller.MedalCountPeeing = Gamecontroller.MedalCountPeeing + 10;
        Gamecontroller.UltimatePoints = Gamecontroller.UltimatePoints + 100;

    }

}
