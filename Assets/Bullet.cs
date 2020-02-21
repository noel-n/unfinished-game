using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public Rigidbody2D rigid;
	public float speed;
    // Start is called before the first frame update
    void Start()
    {
		rigid = GetComponent<Rigidbody2D>();
		rigid.velocity = GameObject.Find("Player").transform.up*speed;

		Destroy(this.gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
