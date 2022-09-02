using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTapi : MonoBehaviour
{
    [SerializeField] int _randomNum = 80;
    [SerializeField] GameObject[] tapis;

    void Start()
    {
        StartCoroutine("ItemCreate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ItemCreate()
    {
        if (Random.Range(0, 100) <= _randomNum)
        {
            Instantiate(tapis[0], this.transform);
        }
        else
        {
            Instantiate(tapis[1], this.transform);
        }
        yield return new WaitForSecondsRealtime(0.2f);
        StartCoroutine("ItemCreate");
    }
}
