using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LazerKill : MonoBehaviour {
        void OnTriggerEnter(Collider other)
        {
        //Destroy(GameObject.FindWithTag("Car"));
        SceneManager.LoadScene("Main Menu");
        }
}
