﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class I_Level1_script : MonoBehaviour
{
    public string Scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1()
    {
        SceneManager.LoadScene(Scene);
    }
}
