using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
	public float fireRate;
	public float nextFire;
	public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	 
			if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
			{

				//  if (Input.GetButton("Fire1") && Time.time > nextFire)
				//{
				nextFire = Time.time + fireRate;

				Instantiate(projectilePrefab,transform.position,new Quaternion(0,0,0,0));
				//Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
				//}



			
		}

	}
}
