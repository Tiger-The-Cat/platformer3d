using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float moveTime = 2.5f;
    public float moveAmount = 0;
    public float moveSpeed = 5;
    public Vector3 direction = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        moveAmount += Time.deltaTime;
        if (moveAmount >= moveTime)
        {
            moveAmount = 0;
            if (direction == Vector3.forward)
            {
                direction = Vector3.back;
            }
            else
            {
                if (direction == Vector3.back)
                {
                    direction = Vector3.forward;
                }
            }
            if (direction == Vector3.left)
            {
                direction = Vector3.right;
            }
            else
            {
                if (direction == Vector3.right)
                {
                    direction = Vector3.left;
                }
            }
                if (direction == Vector3.up)
                {
                    direction = Vector3.down;
                }
            else
            {
                if (direction == Vector3.down)
                {
                    direction = Vector3.up;
                }
            }
        }
    }
}
