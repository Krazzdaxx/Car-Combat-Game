using UnityEngine;
using System.Collections;

public class SelfRotation : MonoBehaviour {
    public int speed;
	void Update () {

        transform.Rotate(Vector3.up *speed* Time.deltaTime);
	}
}
