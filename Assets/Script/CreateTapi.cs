using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTapi : MonoBehaviour
{
    [SerializeField] int _randomNum = 80;
    [SerializeField] GameObject[] tapis;
    GameManager gameManager;

    void Start()
    {
        StartCoroutine("ItemCreate");
    }



    IEnumerator ItemCreate()
    {
        if (Random.Range(0, 100) <= _randomNum)
        {
            Instantiate(tapis[0], new Vector2(this.transform.position.x + Random.Range(-2.0f, 2.0f), this.transform.position.y), Quaternion.identity);
        }
        else
        {
            Instantiate(tapis[1], new Vector2(this.transform.position.x + Random.Range(-2, 2), this.transform.position.y), Quaternion.identity);
        }
        yield return new WaitForSecondsRealtime(0.05f);
        StartCoroutine("ItemCreate");
    }
}
