using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Turret : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;





    // do upgradu na wiezyczki
    BuildManager buildManager;
    private GameObject turret;

    // dla PowerUpów! 
    public static Turret TurretInstance;

    [Header("Attributes")]
    public float range = 8f;
    public float fireRate = 0.5f;
    public float fireCountDown = 0f;

    [Header("Unity Setup Fields")]
    public Transform partToRotate;
    private Transform target;
    public string enemyTag = "Enemy";
    public float turnSpeed = 10f;

    
    void Start ()
    {
        TurretInstance = this;
        InvokeRepeating  ("UpdateTarget", 0f, 0.5f);

        /*
        buildManager = BuildManager.instance;
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        */
    }

    void UpdateTarget ()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (target == null)           
            return;

        // Target locker
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountDown <= 0f )
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }
        fireCountDown -= Time.deltaTime;
	}


    // Strzelanie 
    void Shoot ()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Seek(target);
        }
    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);

    }


    // ***UPGRADE TURRET SECTION***   
    void OnMouseDown()
    {       
        Debug.Log("Kliknalem sobie na wieze i chuj");
    }
    
    
    public void MoreSpeed ()
    {
        TurretPanelON.Turret.GetComponent<Turret>().fireRate += 1f;
    }

    public void MoreRange ()
    {
        TurretPanelON.Turret.GetComponent<Turret>().range += 1f;
    }
    
    public void MoreDamage ()
    {
        Debug.Log("Nothing to do here... O_O");
    }

    // ***UPGRADE TURRET SECTION END***

    // ***TURRET STATS SECTION***
    public void StatDisplayer ()
    {
        //  TO DO!
    }



    // ***TURRET STATS SECTION END***
}
