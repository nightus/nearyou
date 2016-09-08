using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class StartGameButton : MonoBehaviour
{
    public void LoadLevel()
    {
        Time.timeScale = 1.0f;
        Debug.Log("Loading First lvl");
        SceneManager.LoadScene("Level1");
    }
}
