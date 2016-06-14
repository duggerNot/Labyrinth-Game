using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour {

    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    public float horizontalSpeed = 3.0F;
    public float verticalSpeed = 3.0F;


    void FixedUpdate()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, 0, h);
    }
}
