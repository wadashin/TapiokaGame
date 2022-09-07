using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] CreateTapi _createTapi;

    [SerializeField] Transform _tapiposi;

    [SerializeField] Text _scoreText;

    [SerializeField] Text _resultText;

    [SerializeField] Image _note;

    [SerializeField] Image _background;

    [SerializeField] string[] _resultSentence;

    private int score = 0;

    public static bool news = true;

    bool inGame = true;
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
            if (inGame)
            {
                score = value;
                ScoreReWrite();
            }
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

    public void Scoring()
    {
        inGame = false;
        _resultText.gameObject.SetActive(true);
        _note.gameObject.SetActive(true);
        _background.gameObject.SetActive(true);

        if (score < 800)
        {
            _resultText.text = _resultSentence[0];
        }
        else if(score < 850)
        {
            _resultText.text = _resultSentence[1];
        }
        else if(score < 900)
        {
            _resultText.text = _resultSentence[2];
        }
        else if(score < 1000)
        {
            _resultText.text = _resultSentence[3];
        }
        else
        {
            _resultText.text = _resultSentence[4];
        }
    }


}
