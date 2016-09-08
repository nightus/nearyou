using UnityEngine;
using System.Collections;

public class TurretStatsOFF : MonoBehaviour
{

    public GameObject StatWindow;
    void OnMouseDown()
    {
        StatWindow.gameObject.SetActive(false);
    }

}
