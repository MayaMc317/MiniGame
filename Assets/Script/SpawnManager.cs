using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(7.21f, 1.23f, -0.1f), enemyPrefabs[enemyIndex].transform.rotation);
        }
    }
}
