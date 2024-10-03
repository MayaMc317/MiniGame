using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public GameObject player;
<<<<<<< Updated upstream
    private Vector3 offset = new Vector3(-0.472f, 0.384f, -0.327f);
=======
    private Vector3 offset = new Vector3(0,1.5f,-1.936f);
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = player.transform.position + offset; 
    }
}
