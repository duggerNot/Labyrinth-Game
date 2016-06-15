using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {


	void Start () {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.sleepThreshold = -1f;
    }
	

}
