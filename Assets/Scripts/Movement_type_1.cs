using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_type_1 : MonoBehaviour
{
    [Range(0, 0.5f)]
    public float speed;

    private Animator animator;
    private float mvtSpeed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        if (Input.GetAxis("Sprint") > 0)
        {
            mvtSpeed = 2 * speed;
            animator.speed = 2 * speed * 20;
        }
        else
        {
            mvtSpeed = speed;
            animator.speed = speed * 20;
        }
    }

    void Move()
    {
        float horizontal_mvt = Input.GetAxis("Horizontal");
        float vertical_mvt = Input.GetAxis("Vertical");

        animator.SetFloat("HorizontalSpeed", horizontal_mvt);
        animator.SetFloat("VerticalSpeed", vertical_mvt);

        GetComponent<Rigidbody2D>().MovePosition(transform.position + (Vector3.right * horizontal_mvt + Vector3.up * vertical_mvt) * mvtSpeed);
    }
}
