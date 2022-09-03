using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straw : MonoBehaviour
{
    private Vector2 mouse;
    private Vector2 target;

    [SerializeField] Transform _absorptionPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            mouse = Input.mousePosition;
            target = Camera.main.ScreenToWorldPoint(new Vector2(mouse.x, mouse.y));
            this.transform.position = target;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<CircleCollider2D>().enabled = true;
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            GetComponent<CircleCollider2D>().enabled = false;
            StopAllCoroutines();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out TapiokaBase tapioka))
        {
            tapioka.Absorption(_absorptionPoint);
            StartCoroutine("AbsorptionCoolTime");
        }
    }

    IEnumerator AbsorptionCoolTime()
    {
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSecondsRealtime(0.2f);
        GetComponent<CircleCollider2D>().enabled = true;
    }


}
