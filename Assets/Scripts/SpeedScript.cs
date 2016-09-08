using UnityEngine;
using System.Collections;

public class SpeedScript : MonoBehaviour
{

    public void Update ()
    {

        // P = pauza
        if (Input.GetKeyDown(KeyCode.P))
            Time.timeScale = 0.0f;
        // N = normal speed
        else if (Input.GetKeyDown(KeyCode.N))
            Time.timeScale = 1.0f;
        // F = fast speed
        else if (Input.GetKeyDown(KeyCode.F))
            Time.timeScale = 2.0f;
        // M = slow speed
        else if (Input.GetKeyDown(KeyCode.M))
            Time.timeScale = 0.5f;
    }

    public void Pause ()
    {
        Time.timeScale = 0.0f;
    }

    public void NormalSpeed()
    {
        Time.timeScale = 1.0f;
    }

    public void FastSpeed()
    {
        Time.timeScale = 2.0f;
    }

    public void SlowSpeed()
    {
        Time.timeScale = 0.5f;
    }







}
