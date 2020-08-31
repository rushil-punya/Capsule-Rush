using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public GameObject projectile;
    public GameObject projPos;


    // Start is called before the first frame update
    void Start()
    {
        //projectile.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject projectileClone;
        if(Input.GetMouseButtonDown(0))
        {
            projectileClone = Instantiate(projectile, new Vector3(projPos.transform.position.x, projPos.transform.position.y, projPos.transform.position.z), projPos.transform.rotation);
            projectileClone.GetComponent<Rigidbody>().AddForce(projPos.transform.forward * bulletSpeed*100f);
            Destroy(projectileClone, 2);
              
        }
        /*if(projectileClone.transform.position + 100 > projPos.transform.position)
        {
            Destroy(projectileClone);
        }*/
        
    }
}
