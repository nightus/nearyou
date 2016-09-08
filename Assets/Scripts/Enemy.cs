using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public static Enemy instance;
    EndScript Endinstance;
    public float speed = 10f;

    // zarabianie hajsu
    public ShopScript otherScripts;

    public Transform target;
    public int WPindex = 0;

    // Do ENEMY
    public int maxHitPoints = 100;
    public int HitPoints = 0;

    



    public GameObject healthBar;

    void Start ()
    {
        instance = this;
        Endinstance = EndScript.instance;
    }

    public void Awake()
    {
        target = Waypoints.points[0];
        HitPoints = maxHitPoints;


        // By sprawdzic czy HP BAR dziala
        //InvokeRepeating("decreaseHitPoints",3,2);
    }

    

    

    // Odejmowanie HP przez wieze
    public void decreaseHitPoints(int dmg)
            {
                HitPoints -= dmg;
                //Damage();

                // obliczanie HP bara
                float calcHealth =(HitPoints / (maxHitPoints * 1.0f)); // 90 / 100 = 0.9
                SetHealthBar(calcHealth);
                  //  Debug.Log(calcHealth); consola wyswietlanie ilosci hp enemy

               if (HitPoints <= 0)
               {
            // gdy zdechnie otrzymaj hajsik
            ShopScript.instance.gettingMoney();
            DestroyImmediate(this.gameObject,true);
               } 
            }


    // ustawianie HP bara enemy
    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }


    // Podazanie za WP
    void Update ()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWP();

        }



        // Kill on G
        /*
        if (Input.GetKeyDown(KeyCode.G))
        {
            decreaseHitPoints();

        }
        */
    }

    // Podazanie za WP cz2 + destroy przeciwnika gdy dotrze do konca + odebranie HP naszej Bazie
    void GetNextWP()
    {
        if (WPindex >= Waypoints.points.Length - 1)
        {
            Endinstance.decreaseEndHitPoints();
            Destroy(gameObject);
            return;
        }
        WPindex++;
        target = Waypoints.points[WPindex];
    }




}
