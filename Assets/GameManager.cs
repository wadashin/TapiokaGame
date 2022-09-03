using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform _tapiposi;

    [SerializeField] Text scoreText;

    private int score = 0;

    public delegate void StopDelegate();

    public StopDelegate stopDelegate;

    public Transform Tapiposi
    {
        get
        {
            return _tapiposi;
        }
    }

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            ScoreReWrite();
        }
    }

    void Start()
    {
        ScoreReWrite();
    }

    void Point(GameObject tapi)
    {

    }

    public void ScoreReWrite()
    {
        scoreText.text = Score.ToString();
    }

    public void GameEnd()
    {
        Debug.Log(1);
        stopDelegate();
    }
}
