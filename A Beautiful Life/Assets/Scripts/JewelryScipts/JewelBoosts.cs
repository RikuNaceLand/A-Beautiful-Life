using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JewelBoosts : MonoBehaviour
{

    private GameControl gameController = GameControl.Instance;

    public Text RubyBoost;
    public Text EmeraldBoost;
    public Text SapphireBoost;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        RubyBoost.text = "x" + gameController.RubyBoost.ToString("#,0.##");

        if (gameController.EmeraldBoost < 200)
        {
            EmeraldBoost.text = gameController.EmeraldBoost.ToString("#,0") + "%";
        }
        else
        {
            EmeraldBoost.text = "200% (MAX)";
        }

        SapphireBoost.text = gameController.FriendsLevelCap.ToString("#,0");

    }
}
