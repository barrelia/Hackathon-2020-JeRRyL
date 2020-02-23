using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fume_Hood_Movement : MonoBehaviour
{
    public Camera mainCamera;
    public string raycastReturn;
    private GameObject fumehood;
    public string names;
    //public bool held = false;
    Vector3 eyy;
    private Rigidbody lol;
    public bool t = true;
    

    // Start is called before the first frame update
    void Start()
    {
        eyy = new Vector3(0.0f, 0.0f, 0.0f);
        lol = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Euler(90, 0, -180);
        //held = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) //&& held == true)// if left button pressed...
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider != null)
            {
                raycastReturn = hit.collider.gameObject.name;
                fumehood = GameObject.Find(raycastReturn);
                string objectTag = fumehood.tag;
                names = objectTag;
                if (objectTag == "FumeHood")
                {
                    Transform target = Camera.main.transform;
                    fumehood.transform.parent = target;// the object is child of camera
                                                      //held = true;
                }

            }
        }

    }
    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(90, 0, -180);
        transform.position = new Vector3(-0.469f, transform.position.y, 3.034583f);

    }
}
