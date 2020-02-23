using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Glass_Shatter : MonoBehaviour
{
	public GameObject remains;
	public GameObject pusher;
	public float speed;
	public float Resilience;
	private Rigidbody rb;
	public float time;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		
    }

    // Update is called once per frame
    void Update()
    {
		speed = GetComponent<Rigidbody>().velocity.magnitude;
		
    }
	//void OnTriggerEnter(Collider cube)
	//{
		//if(GetComponent<Rigidbody>().velocity.magnitude > 5)
		//{
			//Destroy(gameObject);
		//}
	//}
	void OnCollisionEnter(Collision collision)
    {
		if(speed > Resilience)
		{
			ContactPoint contact = collision.contacts[0];
			Destroy(gameObject);
			Instantiate(remains, transform.position, transform.rotation);
			Instantiate(pusher, transform.position, transform.rotation);
			time = 0;
		}
	}
}