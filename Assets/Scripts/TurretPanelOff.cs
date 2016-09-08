using UnityEngine;
using System.Collections;

public class TurretPanelOff : MonoBehaviour
{
    public GameObject UpgradeWindow;
    void OnMouseDown ()
    {
        UpgradeWindow.gameObject.SetActive(false);
    }
    

}
