using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;


    public float CzasPomiedzyFalami = 30f;
    private float countdown = 30f;
    public Text waveCountDownText;
    private int waveIndex = 0;
    public Text WyswietlNumerFali;
    public int NumerFali;


    void Update()
    {                           // Przyspieszanie fali
        if (countdown <= 0f || GoButton.instance.GuzikWcisniety == true)
        {     
            StartCoroutine(SpawnWave());
            countdown = CzasPomiedzyFalami;

            // przyspieszanie fali
            GoButton.instance.GuzikWcisniety = false;
        }

        // Zbija count down  
        countdown -= Time.deltaTime;
        waveCountDownText.text = Mathf.Round(countdown).ToString();
    }

    // Spawnior fal
    IEnumerator SpawnWave()
    {
        // numer fali
        waveIndex++;
        // Wyswietlacz numeru fali
        NumerFali = waveIndex;
        WyswietlNumerFali.text = Mathf.Round(waveIndex).ToString();
        // koniec wyswietlacza
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();           
            yield return new WaitForSeconds(0.3f);
            SpawnEnemy();
            yield return new WaitForSeconds(0.3f);
            SpawnEnemy();
            yield return new WaitForSeconds(0.3f);
        }        
    }


    //Spawnior mobkow
    public void SpawnEnemy()
    {     
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }


}
