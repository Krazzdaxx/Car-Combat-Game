﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Level");
    }
}
