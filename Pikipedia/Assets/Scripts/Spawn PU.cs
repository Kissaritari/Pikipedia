using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPU : MonoBehaviour
{
    public GameObject cubePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubePrefab,transform.position,Quaternion.identity);
        }
    }
}
