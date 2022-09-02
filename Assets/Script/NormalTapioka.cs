using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTapioka : TapiokaBase
{
    Rigidbody2D _rb;

    bool absorption = false;

    [SerializeField] float _speed = 2;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (strawpoint && absorption)
        {
            _rb.velocity = Vector2.up * _speed;
            transform.position = new Vector2(strawpoint.transform.position.x, transform.position.y);
        }

        
    }

    public override void Absorption(Transform straw)
    {
        strawpoint = straw;
        _rb.gravityScale = 0;
    }

    public override void Swallow()
    {
        throw new System.NotImplementedException();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("StrawObj"))
        {
            absorption = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("StrawObj"))
        {
            if(strawpoint)
            {
                _rb.velocity = Vector2.zero;
                _rb.gravityScale = 1;
            }
            absorption = false;
            strawpoint = null;

        }
    }
}
