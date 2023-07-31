using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, vertical, 0f) * _moveSpeed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4, 0), 0);

        if (transform.position.x > 3.5f)
        {
            transform.position = new Vector3(-3.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -3.5f)
        {
            transform.position = new Vector3(3.5f, transform.position.y, 0);
        }
    }
}
