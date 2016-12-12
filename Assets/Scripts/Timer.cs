using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTimer;

    void Start()
    {
        startTimer = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTimer;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        
        if(seconds =="59.00")
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
	
}
