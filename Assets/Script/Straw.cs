using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straw : MonoBehaviour
{
    private Vector2 mouse;
    private Vector2 target;

    private static float capacity = 0.05f;

    public static bool agameEnd = true;

    public float timer;

    [SerializeField] Transform _absorptionPoint;

    Vector2 pos;

    public static float Capacity
    {
        get
        {
            return capacity;
        }
        set
        {
            if (value > 0)
            {
                capacity += 0.05f;
            }
            else if(value < 0)
            {
                capacity -= 0.05f;
            }
        }
    }


    void Start()
    {
        agameEnd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mouse = Input.mousePosition;
            pos = Camera.main.ScreenToWorldPoint(new Vector2(mouse.x, mouse.y));
        }

        if(Input.GetButton("Fire1") || Input.GetMouseButton(0))
        {
            mouse = Input.mousePosition;
            target = Camera.main.ScreenToWorldPoint(new Vector2(mouse.x, mouse.y));
            this.transform.position = new Vector2(transform.position.x, transform.position.y) + (target - pos);
            pos = target;
        }

        //else if(Input.GetButtonUp("Fire1"))
        //{
        //    agameEnd = false;
        //    //StopAllCoroutines();
        //}
    }

    private void FixedUpdate()
    {
        if (agameEnd)
        {
            if (Input.GetButton("Fire1") || Input.GetMouseButtonDown(0))
            {
                timer += Time.deltaTime;
                if (timer >= capacity)
                {
                    GetComponent<CircleCollider2D>().enabled = true;
                    timer -= capacity;
                }
                else
                {
                    GetComponent<CircleCollider2D>().enabled = false;
                }
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (agameEnd && collision.TryGetComponent(out TapiokaBase tapioka))
        {
            tapioka.Absorption(_absorptionPoint);
            //StartCoroutine("AbsorptionCoolTime");
        }
    }

    //IEnumerator AbsorptionCoolTime()
    //{
    //    GetComponent<CircleCollider2D>().enabled = false;
    //    yield return new WaitForSecondsRealtime(capacity);
    //    GetComponent<CircleCollider2D>().enabled = true;
    //}


}
