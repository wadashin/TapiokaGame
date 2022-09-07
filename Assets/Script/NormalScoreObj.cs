using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScoreObj : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        StartCoroutine("Digestion");
        gameManager = GameObject.Find("===GameManagerObj===").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Delete()
    {
        Destroy(this.gameObject);
    }

    IEnumerator Digestion()
    {
        yield return new WaitForSecondsRealtime(4);
        gameManager.Score++;
        Destroy(this.gameObject);
    }
}
