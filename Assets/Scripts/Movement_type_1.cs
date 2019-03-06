using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_type_1 : MonoBehaviour
{
    public float speed;

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
        float horizontal_mvt = Input.GetAxis("Horizontal");
        float vertical_mvt = Input.GetAxis("Vertical");
        
        transform.Translate((Vector2.right * horizontal_mvt + Vector2.up * vertical_mvt) * speed * Time.deltaTime);
            
    }
}
