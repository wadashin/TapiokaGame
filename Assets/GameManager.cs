using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] CreateTapi _createTapi;

    [SerializeField] Transform _tapiposi;

    [SerializeField] Text _scoreText;

    private int score = 0;

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
        _scoreText.text = Score.ToString() + "Kcal";
    }

    
}
