using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceScript : MonoBehaviour
{
    [SerializeField] CreateTapi _createTapi;

    public void GameEnd()
    {
        Straw.agameEnd = false;
        _createTapi.StopCoroutine("ItemCreate");
    }
}
