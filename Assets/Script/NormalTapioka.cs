using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTapioka : TapiokaBase
{
    Rigidbody2D _rb;

    [SerializeField] float _speed = 2;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (strawpoint)
        {
            //transform.position = Vector2.MoveTowards(transform.position, strawpoint.transform.position, _speed);
            _rb.velocity = Vector2.up;
            transform.position = new Vector2(strawpoint.transform.position.x, transform.position.y);
        }
    }

    public override void Absorption(Transform straw)
    {
        strawpoint = straw;
        _rb.gravityScale = 0;
    }
}
