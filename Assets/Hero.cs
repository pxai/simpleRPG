using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
    private Animator heroAnimator;

    // Use this for initialization
    void Start () {
        heroAnimator = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        //if (heroAnimator.GetCurrentAnimatorStateInfo(0).IsName("Flying"))
        //{
        //    status = FLYING_STATUS;
        //}

        Vector3 direction = new Vector3();

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //Invokes the method methodName in time seconds, 
        //    //then repeatedly every repeatRate seconds.
        //    InvokeRepeating("Fire", 0.0001f, firingRate);
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    CancelInvoke("Fire");
        //}


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            heroAnimator.SetInteger("state",1);
            direction += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            heroAnimator.SetInteger("state", 2);
            direction += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            heroAnimator.SetInteger("state", 3);
            direction += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            heroAnimator.SetInteger("state", 0);
            direction += Vector3.down;

        }

        // restrict the player to the gamespace
        //float newX = Mathf.Clamp(transform.position.x, 0.5f, 16f);
        //float newY = Mathf.Clamp(transform.position.y, 0f, 10f);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        transform.Translate(direction.normalized * 1 * Time.deltaTime);
    }
}
