using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_type_1 : MonoBehaviour
{
    private float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.2f;
        }
        else
        {
            speed = 0.1f;
        }
    }

    void Move()
    {
        float horizontal_mvt = Input.GetAxis("Horizontal");
        float vertical_mvt = Input.GetAxis("Vertical");
        
        GetComponent<Rigidbody2D>().MovePosition(transform.position + (Vector3.right * horizontal_mvt + Vector3.up * vertical_mvt) * speed);
            
    }
}
