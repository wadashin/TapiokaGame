using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceScript : MonoBehaviour
{
    [SerializeField] CreateTapi _createTapi;

    [SerializeField] GameManager _gameManager;

    public void GameEnd()
    {
        Straw.agameEnd = false;
        _gameManager.Scoring();
        _createTapi.StopCoroutine("ItemCreate");
    }
}
