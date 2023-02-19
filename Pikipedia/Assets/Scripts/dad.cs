using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dad : MonoBehaviour
{
    public GameObject cubePrefab;
    //private IEnumerator coroutine;
    private float _delay = 5;
    
    

    public void FixedUpdate()
    {
        //Random r = new Random();
        if (_delay > 0)
        {
            _delay -= Time.fixedDeltaTime;

            if (_delay <= 0)
            {   
                Instantiate(cubePrefab,transform.position,Quaternion.identity);
                /*coroutine = spawn(2.0f);
                StartCoroutine(coroutine);*/
                _delay = 5;
                //int x= r.Next(39);

            }
        }
    }


}

/*    void Start()
    {
        coroutine = spawn(5.0f);
        StartCoroutine(coroutine);
    }
    
    IEnumerator spawn(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(cubePrefab,transform.position,Quaternion.identity);
        
    }
    
    
    */