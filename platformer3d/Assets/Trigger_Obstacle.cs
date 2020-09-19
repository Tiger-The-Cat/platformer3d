using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Obstacle : MonoBehaviour
{
 //   public GameObject player;
    public float moveHeight = 10;
    public float speed = 5;
    public bool ismoving;
    public Vector3 direction = Vector3.up;
    private float bottomY;
    private float topY;
    private bool onPlatform;

    // Start is called before the first frame update
    void Start()
    {
        bottomY = transform.position.y;
        topY = bottomY + moveHeight;
    }

    // Update is called once per frame
    void Update()
    {
        if (ismoving)
        {
            transform.Translate(direction * speed * Time.deltaTime);
            if (direction == Vector3.up && transform.position.y >= topY)
            {
                direction = onPlatform ? Vector3.zero : Vector3.down;
            }
            if (direction == Vector3.down && transform.position.y <= bottomY)
            {
                ismoving = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Player") {
            onPlatform = true;
            ismoving = true;
            direction = Vector3.up;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag =="Player") {
            onPlatform = false;
            direction = Vector3.down;
        }
    }
}
