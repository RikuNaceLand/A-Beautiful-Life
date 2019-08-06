using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class x10BoosterMedals : MonoBehaviour
{

    private GameControl Gamecontroller = GameControl.Instance;

    public float Luck;
    public int GemGotten;


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

        //Payment
        if (Gamecontroller.MedalCountAging > 49 && Gamecontroller.MedalCountBreathing > 49 && Gamecontroller.MedalCountPeeing > 49)
        {
            Gamecontroller.MedalCountAging = Gamecontroller.MedalCountAging - 50;
            Gamecontroller.MedalCountPeeing = Gamecontroller.MedalCountPeeing - 50;
            Gamecontroller.MedalCountBreathing = Gamecontroller.MedalCountBreathing - 50;

            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            //EmeraldBoost applied and amount of Boosters Set
            if (Gamecontroller.EmeraldBoost > 100)
            {
                Luck = Random.Range(100f, 199f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 3;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }


            }

            else
            {
                Luck = Random.Range(0f, 99f);

                if (Gamecontroller.EmeraldBoost > Luck)
                {
                    Gamecontroller.AmountBoostersBought = 2;
                }
                else
                {
                    Gamecontroller.AmountBoostersBought = 1;
                }

            }

            //Actually getting Jewels/Gems
            //0,3 is correct for Random.Range, since this is an int and thus the max value is EXcluded, unlike Random.Range with floats
            if (Gamecontroller.AmountBoostersBought == 1)
            {
                //1 of 1 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 2)
            {
                //1 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
                //2 of 2 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }
            else if (Gamecontroller.AmountBoostersBought == 3)
            {
                //1 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //2 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }

                //3 of 3 opened
                GemGotten = Random.Range(0, 3);

                if (GemGotten == 0)
                {
                    Gamecontroller.Ruby1Amount = Gamecontroller.Ruby1Amount + 1;
                }
                else if (GemGotten == 1)
                {
                    Gamecontroller.Emerald1Amount = Gamecontroller.Emerald1Amount + 1;
                }
                else if (GemGotten == 2)
                {
                    Gamecontroller.Sapphire1Amount = Gamecontroller.Sapphire1Amount + 1;
                }
            }


        }






    }





}
