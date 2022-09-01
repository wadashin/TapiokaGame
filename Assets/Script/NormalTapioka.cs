using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTapioka : TapiokaBase
{
    [SerializeField] float _speed = 2;

    void Start()
    {
        
    }

    void Update()
    {
        if (strawpoint)
        {
            transform.position = Vector2.MoveTowards(transform.position, strawpoint.transform.position, _speed);
        }
    }

    public override void Absorption(Transform straw)
    {
        strawpoint = straw;
        Destroy(GetComponent<Rigidbody2D>());
    }
}
