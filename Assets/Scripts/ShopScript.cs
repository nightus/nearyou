using UnityEngine;
using UnityEngine.UI;


public class ShopScript : MonoBehaviour
{
    BuildManager buildManager;
    public int Money = 0;
    public Text MoneyScore;
    public static ShopScript instance;

    void Start()
    {
        Money = 60;
        MoneyScore.text = Money.ToString();
        instance = this;
        buildManager = BuildManager.instance;
            
    }

    public void gettingMoney()
    {
        Money += 2;
        // wyswietlacz do money
        MoneyScore.text = Money.ToString();
    }

    // Standard turret
    public void PurchaseStandardTurret()
    {
        if (Money >= 20)
        {
            Money -= 20;
            MoneyScore.text = Money.ToString();
           // Debug.Log("Standard turret purchased");
            buildManager.setturretToBuild(buildManager.standardTurretPrefab);
        }
        else
        {
            Debug.Log("Not enough MONEY");
        }
    }

    // Missile turret
    public void PurchaseMissileTurret()
    {
        if (Money >= 50)
        {
            Money -= 50;
            MoneyScore.text = Money.ToString();
           // Debug.Log("Missile turret purchased");
            buildManager.setturretToBuild(buildManager.MissleTurretPrefab);
        }
        else
        {         
            Debug.Log("Not enough MONEY");

        }
    }

    // Laser turret
    public void PurchaseLaserTurret()
    {
        if (Money >= 30)
        {
            Money -= 30;
            MoneyScore.text = Money.ToString();
          //  Debug.Log("Laser turret purchased");
            buildManager.setturretToBuild(buildManager.LaserTurretPrefab);
        }
        else
        {
            Debug.Log("Not enough MONEY");
        } 
    }


    // ***Upgrade turrets section***
    public void MoneySpeed ()
    {
        if (Money >= 20)
        {
            Debug.Log("MOOOAR SPEED!");
            Money -= 20;
            MoneyScore.text = Money.ToString();
        }
        else
        {
            Debug.Log("MOAR MONEY NIGGA");
        }
    }

    public void MoneyRange ()
    {       
        if (Money >= 30)
        {
            Debug.Log("MOOOAR RANGE!");
            Money -= 30;
            MoneyScore.text = Money.ToString();
        }
        else
        {
            Debug.Log("Moar Money Nigga");
        }
        
    }

    public void MoneyDamage ()
    {
        if (Money >= 40)
        {
            Debug.Log("MOOOAR POWAH!");
            Money -= 40;
            MoneyScore.text = Money.ToString();
        }
        else
        {
            Debug.Log("Bitch you need some mony first");
        }
    }



}
