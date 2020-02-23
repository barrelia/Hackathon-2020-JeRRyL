 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingStuffUpScript : MonoBehaviour
{
    public Camera mainCamera;
    public string raycastReturn;
    private GameObject gameObj;
    public string Parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            if (Input.GetMouseButtonDown(2))// if left button pressed...
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
                        if(objectTag == "MovableObj")
                        {
                            Transform target = Camera.main.transform;
                            gameObj.transform.parent = target;// the object is child of camera
                            Vector3 currentPos = mainCamera.WorldToViewportPoint(gameObj.transform.localPosition);
                            var rightCorner = new Vector3(.9f,-0.1f,1);
                            currentPos = rightCorner;
                            gameObj.transform.localPosition = currentPos;

                        }
                        else if(objectTag == "Broom")
                        {
                            Transform target = Camera.main.transform;
                            gameObj.transform.parent = target;// the object is child of camera
                            Vector3 currentPos = mainCamera.WorldToViewportPoint(gameObj.transform.localPosition);
                            var rightCorner = new Vector3(.5f, -1.2f, 2.0f);
                            currentPos = rightCorner;
                            gameObj.transform.localPosition = currentPos;
                        }
                        Parent = gameObj.transform.parent.name;
                    }
                }
            }
        }
    }
}
