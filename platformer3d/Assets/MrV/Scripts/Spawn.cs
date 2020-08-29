using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject thingToSpawn;

	public KeyCode key = KeyCode.Mouse0;
    public float fireRate = 0.1f;
    public float time = 0;

    void Update()
    {
        time += Time.deltaTime;
		if (Input.GetKey(key))
           
		{ if (time >= fireRate)
            {
                Instantiate(thingToSpawn, transform.position, transform.rotation);
                time = 0;
            }
		}
    }
}
