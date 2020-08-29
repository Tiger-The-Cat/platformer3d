using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject thingToSpawn;

	public KeyCode key = KeyCode.Mouse0;

    void Update()
    {
		if (Input.GetKeyDown(key))
		{
			Instantiate(thingToSpawn, transform.position, transform.rotation);
		}
    }
}
