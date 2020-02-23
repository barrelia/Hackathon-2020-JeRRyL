using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticky : MonoBehaviour
{
    // Start is called before the first frame update
	private GameObject gameObj;
	public GameObject Broom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnCollisionEnter(Collision collision)
    {
		if (collision.gameObject.tag == "Broom")
		{
			gameObj.transform.parent = Broom.transform;
		}
	}
}
