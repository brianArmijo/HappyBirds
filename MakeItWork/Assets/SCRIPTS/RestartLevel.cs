﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    void Update()
    {
        if (Input.GetKey(keyRestart))
            SceneManager.LoadScene("Scenes/MainMenu");
    }
}
