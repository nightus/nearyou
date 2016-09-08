using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour
{
    private GameObject turretToBuild;
    public static BuildManager instance;
    public GameObject standardTurretPrefab;
    public GameObject MissleTurretPrefab;
    public GameObject LaserTurretPrefab;
    // Level 2 Wiezyczek
    public GameObject standardTurretPrefabLVL2;



    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("More than Build Manager in scene");
            return;
        }
        instance = this;
    }
    

    
    public void setturretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
    public void noturret()
    {
        turretToBuild = null;
    }


    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }










}
