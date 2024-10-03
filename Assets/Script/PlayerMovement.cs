using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    private float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
     transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
     transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    }
}
