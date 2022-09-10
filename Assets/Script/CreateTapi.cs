using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTapi : MonoBehaviour
{
    [SerializeField] int _randomNum;
    [SerializeField] GameObject[] tapis;
    GameManager gameManager;

    void Start()
    {
        StartCoroutine("ItemCreate");
    }



    IEnumerator ItemCreate()
    {
        int random = Random.Range(0, 100);
        if (random <= _randomNum)
        {
            Instantiate(tapis[0], new Vector2(this.transform.position.x + Random.Range(-2.0f, 2.0f), this.transform.position.y), Quaternion.identity);
        }
        else if(random == 96 || random == 97)
        {
            Instantiate(tapis[1], new Vector2(this.transform.position.x + Random.Range(-2, 2), this.transform.position.y), Quaternion.identity);
        }
        else
        {
            Instantiate(tapis[2], new Vector2(this.transform.position.x + Random.Range(-2, 2), this.transform.position.y), Quaternion.identity);
        }
        yield return new WaitForSecondsRealtime(0.027f);
        StartCoroutine("ItemCreate");
    }
}
