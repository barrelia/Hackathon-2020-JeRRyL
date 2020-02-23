using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlassBin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter(Collider Bin)
	{
		if(Bin.gameObject.CompareTag("DONT PICK UP"))
		{
			SceneManager.LoadScene("I_Level2");
		}
	}
}
