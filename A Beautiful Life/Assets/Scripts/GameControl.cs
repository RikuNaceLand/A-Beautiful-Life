using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO; //Wird benoetigt zum Abspeichern

public class GameControl : MonoBehaviour
{

    public float SaveTimer = 0f;


    public int Day = 0;

    public float HappinessAmount = 1f;

    public float TotalHappiness = 1f;

    public float PercentageToUltimate = 0f;

    public float BaseHappinessPerSecond = 0.1f;
    public float TotalHappinessPerSecond;
    public float TotalTotalHappinessPerSecond;

    public bool DisplayMainInstructions = true;

    public bool Upgrade1Bought = false;
    public bool Upgrade2Bought = false;
    public bool Upgrade3Bought = false;
    public bool Upgrade4Bought = false;
    public bool Upgrade5Bought = false;
    public bool Upgrade6Bought = false;
    public bool Upgrade7Bought = false;
    public float Upgrade7Boost;
    public bool Upgrade8Bought = false;
    public bool Upgrade9Bought = false;
    public int Upgrade9Boost = 1;

    public float FriendsPrice = 1000f;
    public float FriendsAmount = 0f;
    public float FriendsWorth = 5f;
    public float FriendsLevelCap = 100000f;

    public float HobbiesPrice = 100000f;
    public float HobbiesAmount = 0f;
    public float HobbiesWorth = 0.1f;

    public bool Achieve1Unlocked = false;
    public bool Achieve2Unlocked = false;
    public bool Achieve3Unlocked = false;
    public bool Achieve4Unlocked = false;
    public bool Achieve5Unlocked = false;
    public bool Achieve6Unlocked = false;
    public bool Achieve7Unlocked = false;

    public int NaceBucks;
    public bool Achieve4NaceBucksGotten = false;

    public float TPTimer = 600f;
    public int TPAmount = 10;

    public int BreathingLevel = 1;
    public int AgingLevel = 1;
    public int PeeingLevel = 1;

    public int MedalCountBreathing = 0;
    public int MedalCountAging = 0;
    public int MedalCountPeeing = 0;

    public bool BreathingUpgr1Bought = false;
    public bool AgingUpgr1Bought = false;
    public bool PeeingUpgr1Bought = false;
    public bool BreathingUpgr2Bought = false;
    public bool AgingUpgr2Bought = false;
    public bool PeeingUpgr2Bought = false;
    public int AgingUpgr2Mult = 1;
    public bool FinalMedalUpgrBought = false;

    public int MedalMultToHPs = 1;
    public int MedalCountTotal = 0;

    public int Ruby1Amount = 0;
    public int Ruby2Amount = 0;
    public int Ruby3Amount = 0;
    public int Emerald1Amount = 0;
    public int Emerald2Amount = 0;
    public int Emerald3Amount = 0;
    public int Sapphire1Amount = 0;
    public int Sapphire2Amount = 0;
    public int Sapphire3Amount = 0;

    public float RubyBoost = 1f;
    public float EmeraldBoost = 0;
    public float SapphireBoost = 0;

    public int AmountBoostersBought = 1;

    public int UltimatePoints = 0;
    public bool EverWentUltimate = false;
    public int AmountUltimated = 0;

    public bool T1UPUpgrade1Bought = false;
    public int T1Upgrade1MultiToUP = 1;
    public bool T1UPUpgrade2Bought = false;
    public int T1Upgrade2MultiToFriendsWorth = 1;
    public bool T1UPUpgrade3Bought = false;

    public bool T2UPUpgrade1Bought = false;
    public int T2Upgrade1MultiToUP = 1;
    public bool T2UPUpgrade2Bought = false;
    public bool T2UPUpgrade3Bought = false;

    public bool T3UPUpgrade1Bought = false;
    public int T3Upgrade1MultiToUP = 1;
    public bool T3UPUpgrade2Bought = false;
    public bool T3UPUpgrade3Bought = false;
    public int T3Upgrade3BoostToHobbies = 1;

    public bool T4UPUpgrade1Bought = false;
    public bool T4UPUpgrade2Bought = false;
    public int T4Upgrade2BoostToHobbies = 1;
    public bool T4UPUpgrade3Bought = false;

    public bool BeyondUltimateUpgrBought = false;







    public static GameControl Instance
    {
        get;
        set;
    }


    private void OnApplicationQuit()
    {
        
    }


    private void Awake()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");



        DontDestroyOnLoad(transform.gameObject);
        Instance = this;


        //ANFANGVONSVENSCODE


        Debug.Log(Application.persistentDataPath); //Gibt den Pfad aus, wo von Unity Programmen Dateien abgespeichert werden
        saveOrLoad(false); //Laedt zu Beginn des Programms den letzten Speicherstand des Spiels
        
    }


    public void saveOrLoad(bool shouldBeSaved) //public void kann von außerhalb aufgerufen werden um zu laden(Reset) oder zu speichern
    {
        if (shouldBeSaved)
        {
            Save(); //fuehrt Save-Funktion aus, falls shouldBeSaved true ist
        }
        else
        {
            Load(); //fuehrt Load-Funktion aus, falls shouldBeSaved false ist
        }
    }


    void Load()
    {
        string path = Path.Combine(Application.persistentDataPath, "NaceCoins.save");
        if (File.Exists(path)) //stellt sicher, dass auch eine Speicherdatei vorhanden ist mit dem Namen NaceCoins.save
        {
            using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
            {
                //liest die Datei aus und weist den entsprechenden Variablen playerName, naceCoins etc. Werte zu

                Day = reader.ReadInt32();

                HappinessAmount = reader.ReadSingle();

                TotalHappiness = reader.ReadSingle();

                PercentageToUltimate = reader.ReadSingle();

                BaseHappinessPerSecond = reader.ReadSingle();
                TotalHappinessPerSecond = reader.ReadSingle();
                TotalTotalHappinessPerSecond = reader.ReadSingle();

                DisplayMainInstructions = reader.ReadBoolean();

                Upgrade1Bought = reader.ReadBoolean();
                Upgrade2Bought = reader.ReadBoolean();
                Upgrade3Bought = reader.ReadBoolean();
                Upgrade4Bought = reader.ReadBoolean();
                Upgrade5Bought = reader.ReadBoolean();
                Upgrade6Bought = reader.ReadBoolean();
                Upgrade7Bought = reader.ReadBoolean();
                Upgrade7Boost = reader.ReadSingle();
                Upgrade8Bought = reader.ReadBoolean();
                Upgrade9Bought = reader.ReadBoolean();
                Upgrade9Boost = reader.ReadInt32();

                FriendsPrice = reader.ReadSingle();
                FriendsAmount = reader.ReadSingle();
                FriendsWorth = reader.ReadSingle();
                FriendsLevelCap = reader.ReadSingle();

                HobbiesPrice = reader.ReadSingle();
                HobbiesAmount = reader.ReadSingle();
                HobbiesWorth = reader.ReadSingle();

                Achieve1Unlocked = reader.ReadBoolean();
                Achieve2Unlocked = reader.ReadBoolean();
                Achieve3Unlocked = reader.ReadBoolean();
                Achieve4Unlocked = reader.ReadBoolean();
                Achieve5Unlocked = reader.ReadBoolean();
                Achieve6Unlocked = reader.ReadBoolean();
                Achieve7Unlocked = reader.ReadBoolean();

                NaceBucks = reader.ReadInt32();
                Achieve4NaceBucksGotten = reader.ReadBoolean();

                TPTimer = reader.ReadSingle();
                TPAmount = reader.ReadInt32();

                BreathingLevel = reader.ReadInt32();
                AgingLevel = reader.ReadInt32();
                PeeingLevel = reader.ReadInt32();

                MedalCountBreathing = reader.ReadInt32();
                MedalCountAging = reader.ReadInt32();
                MedalCountPeeing = reader.ReadInt32();

                BreathingUpgr1Bought = reader.ReadBoolean();
                AgingUpgr1Bought = reader.ReadBoolean();
                PeeingUpgr1Bought = reader.ReadBoolean();
                BreathingUpgr2Bought = reader.ReadBoolean();
                AgingUpgr2Bought = reader.ReadBoolean();
                PeeingUpgr2Bought = reader.ReadBoolean();
                AgingUpgr2Mult = reader.ReadInt32();
                FinalMedalUpgrBought = reader.ReadBoolean();

                MedalMultToHPs = reader.ReadInt32();
                MedalCountTotal = reader.ReadInt32();

                Ruby1Amount = reader.ReadInt32();
                Ruby2Amount = reader.ReadInt32();
                Ruby3Amount = reader.ReadInt32();
                Emerald1Amount = reader.ReadInt32();
                Emerald2Amount = reader.ReadInt32();
                Emerald3Amount = reader.ReadInt32();
                Sapphire1Amount = reader.ReadInt32();
                Sapphire2Amount = reader.ReadInt32();
                Sapphire3Amount = reader.ReadInt32();

                RubyBoost = reader.ReadSingle();
                EmeraldBoost = reader.ReadSingle();
                SapphireBoost = reader.ReadSingle();

                AmountBoostersBought = reader.ReadInt32();

                UltimatePoints = reader.ReadInt32();
                EverWentUltimate = reader.ReadBoolean();
                AmountUltimated = reader.ReadInt32();

                T1UPUpgrade1Bought = reader.ReadBoolean();
                T1Upgrade1MultiToUP = reader.ReadInt32();
                T1UPUpgrade2Bought = reader.ReadBoolean();
                T1Upgrade2MultiToFriendsWorth = reader.ReadInt32();
                T1UPUpgrade3Bought = reader.ReadBoolean();

                T2UPUpgrade1Bought = reader.ReadBoolean();
                T2Upgrade1MultiToUP = reader.ReadInt32();
                T2UPUpgrade2Bought = reader.ReadBoolean();
                T2UPUpgrade3Bought = reader.ReadBoolean();

                T3UPUpgrade1Bought = reader.ReadBoolean();
                T3Upgrade1MultiToUP = reader.ReadInt32();
                T3UPUpgrade2Bought = reader.ReadBoolean();
                T3UPUpgrade3Bought = reader.ReadBoolean();
                T3Upgrade3BoostToHobbies = reader.ReadInt32();

                T4UPUpgrade1Bought = reader.ReadBoolean();
                T4UPUpgrade2Bought = reader.ReadBoolean();
                T4Upgrade2BoostToHobbies = reader.ReadInt32();
                T4UPUpgrade3Bought = reader.ReadBoolean();

                BeyondUltimateUpgrBought = reader.ReadBoolean();


            }
        }
    }

    void Save()
    {
        string path = Path.Combine(Application.persistentDataPath, "NaceCoins.save"); //beliebiger Name verwendbar, Pfad im Unity Editor anpassbar
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
        {
            //Speicherreihenfolge und Ladereihenfolge sollten übereinstimmen

            
            

            writer.Write(Day);
            

            writer.Write(HappinessAmount);

            writer.Write(TotalHappiness);

            writer.Write(PercentageToUltimate);

            writer.Write(BaseHappinessPerSecond);
            writer.Write(TotalHappinessPerSecond);
            writer.Write(TotalTotalHappinessPerSecond);

            writer.Write(DisplayMainInstructions);

            writer.Write(Upgrade1Bought);
            writer.Write(Upgrade2Bought);
            writer.Write(Upgrade3Bought);
            writer.Write(Upgrade4Bought);
            writer.Write(Upgrade5Bought);
            writer.Write(Upgrade6Bought);
            writer.Write(Upgrade7Bought);
            writer.Write(Upgrade7Boost);
            writer.Write(Upgrade8Bought);
            writer.Write(Upgrade9Bought);
            writer.Write(Upgrade9Boost);

            writer.Write(FriendsPrice);
            writer.Write(FriendsAmount);
            writer.Write(FriendsWorth);
            writer.Write(FriendsLevelCap);

            writer.Write(HobbiesPrice);
            writer.Write(HobbiesAmount);
            writer.Write(HobbiesWorth);

            writer.Write(Achieve1Unlocked);
            writer.Write(Achieve2Unlocked);
            writer.Write(Achieve3Unlocked);
            writer.Write(Achieve4Unlocked);
            writer.Write(Achieve5Unlocked);
            writer.Write(Achieve6Unlocked);
            writer.Write(Achieve7Unlocked);

            writer.Write(NaceBucks);
            writer.Write(Achieve4NaceBucksGotten);

            writer.Write(TPTimer);
            writer.Write(TPAmount);

            writer.Write(BreathingLevel);
            writer.Write(AgingLevel);
            writer.Write(PeeingLevel);

            writer.Write(MedalCountBreathing);
            writer.Write(MedalCountAging);
            writer.Write(MedalCountPeeing);

            writer.Write(BreathingUpgr1Bought);
            writer.Write(AgingUpgr1Bought);
            writer.Write(PeeingUpgr1Bought);
            writer.Write(BreathingUpgr2Bought);
            writer.Write(AgingUpgr2Bought);
            writer.Write(PeeingUpgr2Bought);
            writer.Write(AgingUpgr2Mult);
            writer.Write(FinalMedalUpgrBought);

            writer.Write(MedalMultToHPs);
            writer.Write(MedalCountTotal);

            writer.Write(Ruby1Amount);
            writer.Write(Ruby2Amount);
            writer.Write(Ruby3Amount);
            writer.Write(Emerald1Amount);
            writer.Write(Emerald2Amount);
            writer.Write(Emerald3Amount);
            writer.Write(Sapphire1Amount);
            writer.Write(Sapphire2Amount);
            writer.Write(Sapphire3Amount);

            writer.Write(RubyBoost);
            writer.Write(EmeraldBoost);
            writer.Write(SapphireBoost);

            writer.Write(AmountBoostersBought);

            writer.Write(UltimatePoints);
            writer.Write(EverWentUltimate);
            writer.Write(AmountUltimated);

            writer.Write(T1UPUpgrade1Bought);
            writer.Write(T1Upgrade1MultiToUP);
            writer.Write(T1UPUpgrade2Bought);
            writer.Write(T1Upgrade2MultiToFriendsWorth);
            writer.Write(T1UPUpgrade3Bought);

            writer.Write(T2UPUpgrade1Bought);
            writer.Write(T2Upgrade1MultiToUP);
            writer.Write(T2UPUpgrade2Bought);
            writer.Write(T2UPUpgrade3Bought);

            writer.Write(T3UPUpgrade1Bought);
            writer.Write(T3Upgrade1MultiToUP);
            writer.Write(T3UPUpgrade2Bought);
            writer.Write(T3UPUpgrade3Bought);
            writer.Write(T3Upgrade3BoostToHobbies);

            writer.Write(T4UPUpgrade1Bought);
            writer.Write(T4UPUpgrade2Bought);
            writer.Write(T4Upgrade2BoostToHobbies);
            writer.Write(T4UPUpgrade3Bought);

            writer.Write(BeyondUltimateUpgrBought);
        }
    }

    //ENDE VON SVENS CODE



    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(WaitForLoad());
    }

    // Update is called once per frame
    void Update()
    {
        if (SaveTimer > 10)
        {
            Save();
            SaveTimer = 0;
        }

        SaveTimer = SaveTimer + 1 * Time.deltaTime;

    }

    IEnumerator WaitForLoad()
    {
        
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(1);
        
    }

}
