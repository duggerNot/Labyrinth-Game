using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour {


    public float horizontalSpeed = 0.5F;
    public float verticalSpeed = 0.5F;


    void FixedUpdate()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, 0, h);
    }
}
