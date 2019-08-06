using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGemCount : MonoBehaviour
{
    private GameControl gameController = GameControl.Instance;

    public Text Ruby1Count;
    public Text Ruby2Count;
    public Text Ruby3Count;
    public Text Emerald1Count;
    public Text Emerald2Count;
    public Text Emerald3Count;
    public Text Sapphire1Count;
    public Text Sapphire2Count;
    public Text Sapphire3Count;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Ruby1Count.text = "Owned: " + gameController.Ruby1Amount.ToString("#,0");
        Ruby2Count.text = "Owned: " + gameController.Ruby2Amount.ToString("#,0");
        Ruby3Count.text = "Owned: " + gameController.Ruby3Amount.ToString("#,0");

        Emerald1Count.text = "Owned: " + gameController.Emerald1Amount.ToString("#,0");
        Emerald2Count.text = "Owned: " + gameController.Emerald2Amount.ToString("#,0");
        Emerald3Count.text = "Owned: " + gameController.Emerald3Amount.ToString("#,0");

        Sapphire1Count.text = "Owned: " + gameController.Sapphire1Amount.ToString("#,0");
        Sapphire2Count.text = "Owned: " + gameController.Sapphire2Amount.ToString("#,0");
        Sapphire3Count.text = "Owned: " + gameController.Sapphire3Amount.ToString("#,0");

        if (gameController.Achieve6Unlocked == false)
        {
            if (gameController.Sapphire3Amount > 4 && gameController.Emerald3Amount > 4 && gameController.Ruby3Amount > 4)
            {
                gameController.Achieve6Unlocked = true;
                StartCoroutine(AchievementUnlocked());
            }

        }



    }

    IEnumerator AchievementUnlocked()
    {

        transform.GetChild(1).gameObject.SetActive(true);

        yield return new WaitForSeconds(5);

        transform.GetChild(1).gameObject.SetActive(false);

    }

}
