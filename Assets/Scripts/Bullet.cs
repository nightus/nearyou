using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public int Damage;
    public static Bullet instance;
    private Transform target;
    public float speed = 70f;
    public GameObject impactEffect;
    public Enemy otherScripts;

    void Start ()
    {
        instance = this;
    }



    public void Seek(Transform _target)
    {
        target = _target;
    }



	// Update is called once per frame
	void Update ()
    {
	    if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
         
	}


    public void HitTarget ()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);

        // Odejmowanie HP      
        otherScripts = target.GetComponent<Enemy>();
        otherScripts.decreaseHitPoints(Damage);
        Destroy(gameObject);

    }
}
