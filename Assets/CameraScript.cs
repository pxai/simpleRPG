using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject player;

    void Start()
    {
    }

    void Update()
    {
        Vector3 playerpos = player.transform.position;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
    }
}
