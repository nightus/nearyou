using UnityEngine;
using System.Collections;

public class UpRangeButton : MonoBehaviour
{
    Turret TurretInstance;
    ShopScript instance;

    public void OnMouseDown()
    {
        ShopScript.instance.MoneyRange();
        Turret.TurretInstance.MoreRange();       
    }

}
