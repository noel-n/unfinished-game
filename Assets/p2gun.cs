using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2gun : MonoBehaviour
{
	public float recoil;
	public float nextFire;
	public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
	   if(Time.time > nextFire)
		{
			nextFire = Time.time + recoil;
			Instantiate(bullet);
		}
		
    }
}
