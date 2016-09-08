using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class NodeSpawner : MonoBehaviour {

    // visual update over nodes
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    // end of visual update

    BuildManager buildManager;

    private GameObject turret;
    public Vector3 positionOffset;

    public static NodeSpawner Nodeinstance;

    void Start ()
    {
        Nodeinstance = this;
        // visual update over nodes
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        // end of visual update

        buildManager = BuildManager.instance;
    }

    public void TurretBuilder ()
    {     
            GameObject turretToBuild = buildManager.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            buildManager.noturret();
    }

    // *** Klikanie na noda ***

    // klikniecie na pole
    void OnMouseDown ()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if (turret != null)
        {
            // zrobic by wyswietlalo na ekranie!
            Debug.Log("place already taken");
            return;
        }
        TurretBuilder();

    }

    // najazd na pole
	void OnMouseEnter ()
    {
     
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        // visual update over nodes       
        rend.material.color = hoverColor;
        // end of visual update

    }

    // wyjscie z pola
    void OnMouseExit()
    {
        // visual update over nodes
        rend.material.color = startColor;
        // end of visual update
    }
}
