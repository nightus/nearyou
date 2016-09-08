using UnityEngine;
using System.Collections;

public class UpSpeedButton : MonoBehaviour
{
    Turret TurretInstance;
    ShopScript instance;

    public void OnMouseDown()
    {
        ShopScript.instance.MoneySpeed();
        Turret.TurretInstance.MoreSpeed();
    }

}
