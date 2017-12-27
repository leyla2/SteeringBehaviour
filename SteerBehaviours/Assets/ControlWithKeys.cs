using UnityEngine;
using System.Collections;

public class ControlWithKeys : MonoBehaviour {
    Vector3 velo = new Vector3(5, 1, 0);// was testing movement with this
    public float speed; 
	// Use this for initialization
	void Start () {
        speed = 100;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((Input.GetAxis("Horizontal") * Time.deltaTime)*speed, 0f, (Input.GetAxis("Vertical") * Time.deltaTime)*speed);// get the wasd or UP/DOWN/LEFT/RIGHT input and move 1 pixel accordingly, also in relation to your system's time.
        transform.Rotate(0f,0f, Input.GetAxis("Horizontal") * Time.deltaTime * 200);// on turn give the car a realistic 'falling over' effect. 
        transform.Rotate(0f, Input.GetAxis("Horizontal") * Time.deltaTime * 100, 0f);

    }
}
