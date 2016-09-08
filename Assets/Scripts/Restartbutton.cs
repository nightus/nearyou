using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class Restartbutton : MonoBehaviour {


    public void LoadLevel()
    {
        Time.timeScale = 1.0f;
        Debug.Log("Restarting....");
        SceneManager.LoadScene("Level1");
    }
}
