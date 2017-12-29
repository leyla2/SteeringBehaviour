using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
    public Transform car;
    public Transform chicken;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(car);
        transform.Translate(Vector3.forward * 50 * Time.deltaTime);
    }
}
