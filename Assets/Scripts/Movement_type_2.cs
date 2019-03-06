using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_type_2 : MonoBehaviour
{
    private float norm = 0.5f; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        Move();
        
        
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * norm);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * norm);
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.right * norm);
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.right * norm);
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
    }
}
