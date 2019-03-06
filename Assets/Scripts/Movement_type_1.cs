using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_type_1 : MonoBehaviour
{
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
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 180);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 90);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
    }
}
