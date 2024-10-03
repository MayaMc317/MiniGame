using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{   
    public GameObject player;
    public float sensitivity;
    private Vector3 offset;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + offset;     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis ("Mouse X");
        float rotateVertical = Input.GetAxis ("Mouse Y");
        transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
        transform.RotateAround (Vector3.zero, transform.right, rotateVertical * sensitivity);

    }
}
