using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_type_2 : MonoBehaviour
{
    private float norm = 0.32f; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();    
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().MovePosition(transform.position + Vector3.right * norm);
            //transform.Translate(Vector2.right * norm);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().MovePosition(transform.position + Vector3.left * norm);
            //transform.Translate(Vector2.left * norm);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().MovePosition(transform.position + Vector3.up * norm);
            //transform.Translate(Vector2.up * norm);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().MovePosition(transform.position + Vector3.down * norm);
            //transform.Translate(Vector2.down * norm);
        }
    }
}
