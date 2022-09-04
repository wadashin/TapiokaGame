using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigeruTapioka : TapiokaBase
{
    Rigidbody2D _rb;

    GameManager gameManager;

    bool absorption = false;


    [SerializeField] float _speed = 2;

    [SerializeField] GameObject _iTapi;


    void Start()
    {
        gameManager = GameObject.Find("===GameManagerObj===").GetComponent<GameManager>();
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(Vector2.up * 2, ForceMode2D.Impulse);
        StartCoroutine("Destroyer");
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
        absorption = true;
        strawpoint = straw;

        GetComponent<CircleCollider2D>().isTrigger = true;
    }

    public override void Swallow()
    {
        Instantiate(_iTapi, gameManager.Tapiposi);
        Straw.Capacity++;
        Destroy(this.gameObject);
    }

    public override void Deth()
    {
        Destroy(this.gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("StrawObj"))
        {

        }
        else if (collision.CompareTag("SwallowPoint"))
        {
            Swallow();
        }
        else if (collision.CompareTag("DethZone"))
        {
            Deth();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("StrawObj"))
        {
            GetComponent<CircleCollider2D>().isTrigger = false;
            absorption = false;
            strawpoint = null;
        }
    }

    IEnumerator Destroyer()
    {
        yield return new WaitForSecondsRealtime(5);
        Destroy(this.gameObject);
    }
}
