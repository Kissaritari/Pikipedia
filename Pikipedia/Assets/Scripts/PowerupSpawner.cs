using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    private float _delay = 0f;
	public List<GameObject> prefabsToSpawn; // Different looking powerupPrefabs go here
	
    public void FixedUpdate()
    {
        this._delay += Time.deltaTime; // Logic for spawning powerup once in 10 seconds
        if (this._delay >=10f)
        {
            int randomPrefab = Random.Range(0, prefabsToSpawn.Count); // Random looking powerupPrefab spawner
            GameObject pts = Instantiate(prefabsToSpawn[randomPrefab],new Vector3(Random.Range(-18f,18f),7.5f,0f),Quaternion.identity); // random spot to spawn the powerupPrefab
            this._delay=0;
        }

    }

}