using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public GameObject gameover;
    //private float topBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.z > topBound) 
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if(other.gameObject.tag == "Enemy")
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
