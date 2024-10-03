using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
<<<<<<< Updated upstream
    private float speed = 1f;

    
=======
    private float speed = 10;

    private float leftBoundary = -48;
    private float rightBoundary = 48f;
    private float upBoundary = 10;
    private float downBoundary = -10;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

<<<<<<< Updated upstream
       
=======
        if(transform.position.x < leftBoundary)
       {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z); 
       }

       if(transform.position.x > rightBoundary)
       {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z); 
       }

       if(transform.position.x < downBoundary)
       {
            transform.position = new Vector3(downBoundary, transform.position.y, transform.position.z); 
       }

       if(transform.position.x > upBoundary)
       {
            transform.position = new Vector3(upBoundary, transform.position.y, transform.position.z); 
       }
>>>>>>> Stashed changes

    }

    
}
