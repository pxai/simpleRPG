using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.right, Time.deltaTime);
        //transform.Rotate(Vector3.up, Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward * -0.9f);
    }
}
