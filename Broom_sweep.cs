using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broom_sweep : MonoBehaviour
{
    // Start is called before the first frame update
	public Camera mainCamera;
    public string raycastReturn;
    private GameObject gameObj;
	private float xAngle = -10;
	private float yAngle = -10;
	private float zAngle = 20;
	private float height = 2.66f;
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
                        if(objectTag == "Broom")
                        {
                            Transform target = Camera.main.transform;
                            gameObj.transform.parent = target;// the object is child of camera
                            Vector3 currentPos = mainCamera.WorldToViewportPoint(gameObj.transform.localPosition);
                            var rightCorner = new Vector3(.9f,-0.1f,2.4f);
                            currentPos = rightCorner;
                            gameObj.transform.localPosition = currentPos;
							xAngle = -10;
							yAngle = -10;
							zAngle = 0;
							height = 2.54f;

                        }
                    }
                }
            }
        }
    }
	void LateUpdate()
	{
		transform.rotation = transform.rotation = Quaternion.Euler(xAngle, yAngle, zAngle);
		transform.position = new Vector3(transform.position.x, height, transform.position.z);
	}

}
