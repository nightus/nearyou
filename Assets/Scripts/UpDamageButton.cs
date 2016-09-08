using UnityEngine;
using System.Collections;

public class UpDamageButton : MonoBehaviour
{
    Turret TurretInstance;
    ShopScript instance;

    public void OnMouseDown()
    {
        ShopScript.instance.MoneyDamage();      
    }

}
