using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
    public Transform car; //make these public so I can drag the objects to it in Unity.
    public Transform chicken;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(car); //face the car
        transform.Translate(Vector3.forward * 50 * Time.deltaTime); // move towards car's coordinates. 
    }
}
