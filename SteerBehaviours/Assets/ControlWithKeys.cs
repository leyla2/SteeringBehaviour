using UnityEngine;
using System.Collections;

public class ControlWithKeys : MonoBehaviour {
    Vector3 speed = new Vector3(5, 1, 0);// was testing movement with this
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((Input.GetAxis("Horizontal") * Time.deltaTime)*5, 0f, (Input.GetAxis("Vertical") * Time.deltaTime)*5);// get the wasd or UP/DOWN/LEFT/RIGHT input and move 1 pixel accordingly, also in relation to your system's time.
	}
}
