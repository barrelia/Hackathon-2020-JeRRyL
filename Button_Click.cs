using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Click : MonoBehaviour
{
    // Start is called before the first frame update
	public Camera mainCamera;
    public string raycastReturn;
    private GameObject gameObj;
	public int FumeButton = 0;
	public GameObject button2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            if (Input.GetMouseButtonDown(0))// if left button pressed...
            { 
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                
                if (Physics.Raycast(ray, out hit) && hit.collider!= null)
                {
                    raycastReturn = hit.collider.gameObject.name;
                    if(gameObj != GameObject.Find(raycastReturn))
                    { 
                        gameObj = GameObject.Find(raycastReturn);
                        string objectTag = gameObj.tag;
                        if(objectTag == "FumeButton")
                        {
                            FumeButton = 1;
							Destroy(gameObject);
							Instantiate(button2, transform.position, transform.rotation);

                        }
                    }
                }
            }
        }
    }
}
