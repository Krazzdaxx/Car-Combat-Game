using UnityEngine;
using System.Collections;

public class RaycastShooting : MonoBehaviour
{

    //public ScoreTracker send;
    public float damage = 100;
   
    void Start()
    {
        //ScoreTracker send = GetComponent<ScoreTracker>();
    }
    void Update()
    {
       
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) 
        {

            if (Physics.Raycast(ray, out hit, 200)) 
            {
                if (hit.collider.tag == "GreenTurret")
                {
                    //send.IncreaseScore(100);
                    hit.transform.SendMessage("KillTurret",25);
                }
                if (hit.collider.tag == "RedTurret")
                {
                    hit.transform.SendMessage("KillTurret", 50);
                    //send.IncreaseScore(50);
                }
                if (hit.collider.tag == "PurpleTurret")
                {
                    hit.transform.SendMessage("KillTurret", 100);
                    //send.IncreaseScore(25);
                }

            }
        }
    }
}

