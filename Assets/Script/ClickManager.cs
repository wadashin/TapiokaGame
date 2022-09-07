using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    [SerializeField] GameObject[] _zuroros;
    //2.5 ~ -4

    private float time;

    void Update()
    {
        //if(Input.GetButtonDown("Fire1"))
        //{
        //    Instantiate(_zuroros[Random.Range(0, 6)], new Vector2(0, Random.Range(-4, 3)), Quaternion.identity);
        //}
        if(Input.GetButton("Fire1"))
        {
            time += Time.deltaTime;
            if(time >= 1.5f)
            {
                Instantiate(_zuroros[Random.Range(0, 6)], new Vector2(0, Random.Range(-4f, 3f)), Quaternion.identity);
                time = 0;
            }
        }
    }
}
