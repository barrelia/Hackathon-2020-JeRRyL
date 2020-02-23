using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public int FumeButton;
    public int Height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FumeButton == 1 && Height < 4.5)
        {
            SceneManager.LoadScene("Winning Screen");
        }
    }
}
