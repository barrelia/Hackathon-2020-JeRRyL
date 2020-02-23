using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintAppear : MonoBehaviour
{
    public Camera mainCamera;
    public string raycastReturn;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
       text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))// if left button pressed...
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider != null)
            {
                raycastReturn = hit.collider.gameObject.name;
                if (raycastReturn == "Cuerpo")
                {
                    text.SetActive(true);
                }
            }
        }
    }
}
