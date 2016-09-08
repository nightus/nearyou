using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurretStatsON : MonoBehaviour
{
    Turret TurretInstance;

    public static GameObject Turret;
    public GameObject StatWindow;
    void OnMouseDown()
    {
        // tak??
        TurretInstance.StatDisplayer();   
        // kykyk  
        Turret = gameObject;
        StatWindow = GameObject.FindGameObjectWithTag("UpgradePanel");
        StatWindow.transform.GetChild(1).gameObject.SetActive(true);
    }

}
