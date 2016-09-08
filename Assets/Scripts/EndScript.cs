using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class EndScript : MonoBehaviour
{


    public int MaxEndHitPoints = 100;
    public int EndHitPoints = 0;
    public GameObject EndhealthBar;
    public static EndScript instance;


    // Use this for initialization
    void Start ()
    {
        instance = this;
        EndHitPoints = MaxEndHitPoints;
    }
	
	// Update is called once per frame
	void Update ()
    {
    }


    public void decreaseEndHitPoints()
    {
        EndHitPoints -= 5;
        float EndcalcHealth = (EndHitPoints / (MaxEndHitPoints * 1.0f)); // 90 / 100 = 0.9
        EndSetHealthBar(EndcalcHealth);
        // Debug.Log(EndcalcHealth);

        if (EndHitPoints <= 0)
        {
            Debug.Log("Loading Restart Menu...");
            SceneManager.LoadScene("RestartMenu");
            Debug.Log("END GAME!");
        }
    }
    public void EndSetHealthBar(float myHealth)
    {
        EndhealthBar.transform.localScale = new Vector3(myHealth, EndhealthBar.transform.localScale.y, EndhealthBar.transform.localScale.z);
    }

}







