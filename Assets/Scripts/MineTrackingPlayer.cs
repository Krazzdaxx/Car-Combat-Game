using UnityEngine;
using System.Collections;

public class MineTrackingPlayer : MonoBehaviour {

    public int speed;
    
    public GameObject target;
	
	// Update is called once per frame
	void Update () {
    transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
	}
}
