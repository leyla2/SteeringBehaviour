using UnityEngine;
using System.Collections;

public class Avoider : MonoBehaviour
{
    public Transform avoidee; //make these public so I can drag the objects to it in Unity.
    public Transform currentveh;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(avoidee); //face the car
        transform.Translate(Vector3.back * 50 * Time.deltaTime); // move away from car's coordinates. 
    }
}
