using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    
    private float speed = 5.0f;
    private float turnSpeed;
    private float horizontalInput;
    //private float forwardInput;

    private float leftBoundary = -5;
    private float rightBoundary = 5f;

    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");

       //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
       transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
       //transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

       if(transform.position.x < leftBoundary)
       {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z); 
       }

       if(transform.position.x > rightBoundary)
       {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z); 
       }

       if (Input.GetButtonDown("Fire1"))
        //Input.GetMouseButtonDown(ButtonDown.Mouse 0
       {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            
       }
       
    }
     
}
