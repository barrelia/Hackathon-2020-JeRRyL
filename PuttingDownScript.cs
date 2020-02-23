using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingDownScript : MonoBehaviour
{
    public Camera mainCamera;
    public string raycastReturn;
    private GameObject gameObj;
    public string release;
    public string parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))// if left button pressed...
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider != null )
            {
                raycastReturn = hit.collider.gameObject.name;
                if (gameObj != GameObject.Find(raycastReturn))
                {
                    gameObj = GameObject.Find(raycastReturn);
                    string objectTag = gameObj.tag;
                    parent = gameObj.transform.parent.name;
                    if (objectTag == "MovableObj" && gameObj.transform.parent == mainCamera)
                    {
                        gameObj.transform.parent = null;
                        if (Input.GetMouseButtonDown(0))
                        {
                            release = "yes";
                            if (Input.GetMouseButtonDown(0))
                                gameObj.transform.position = Input.mousePosition;
                        }
                        
                    }
                }
            }
        }
    }    
}

