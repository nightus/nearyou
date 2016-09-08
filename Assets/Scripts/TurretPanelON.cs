using UnityEngine;
using System.Collections;

public class TurretPanelON : MonoBehaviour
{
    //public string PanelTag = "UpgradePanel";
    public static GameObject Turret;
    public GameObject UpgradeWindow;
    void OnMouseDown()
    {
       Turret = gameObject;
       UpgradeWindow =  GameObject.FindGameObjectWithTag("UpgradePanel");
       UpgradeWindow.transform.GetChild(0).gameObject.SetActive(true);
        
    }

}
