using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    private Rigidbody2D _rbody;
    private float _horizontalMovement;

    // Start is called before the first frame update
    void Start()
    {

    }

    private float HorizontalMovement;

    private void setHorizontalMovement(float value)
    {
        if (value != _horizontalMovement)
        {
            _horizontalMovement = value;
        }

    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = (Input.GetAxis("Horizontal"));
    }

    private void Awake()
    {
        _rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        _rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, _rbody.velocity.y);
    }
}