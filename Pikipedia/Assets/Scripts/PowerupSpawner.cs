using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    private float _delay = 5;
	public List<GameObject> prefabsToSpawn;
	
    public void FixedUpdate()
    {
        this._delay += Time.deltaTime;
        if (this._delay >=2.5f)
        {
            int randomPrefab = Random.Range(0, prefabsToSpawn.Count);
            GameObject pts = Instantiate(prefabsToSpawn[randomPrefab],new Vector3(Random.Range(-18f,18f),7.5f,0f),Quaternion.identity);
            this._delay=0;
        }

    }

}