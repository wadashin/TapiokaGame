using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour
{
    [SerializeField] Image _explosion;
    [SerializeField] Text _challengeText;

    [SerializeField] Text _mainTitleText;
    [SerializeField] Text _subTitleText;
    [SerializeField] GameObject _i;
    [SerializeField] GameObject _juice;
    [SerializeField] GameObject _sigeru;
    [SerializeField] Button _startButton;
    [SerializeField] Button _setumeiButton;
    [SerializeField] GameObject _audioObj;



    public void Dokaaaan()
    {
        _explosion.gameObject.SetActive(true); 
        _challengeText.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    public void Title()
    {
        _mainTitleText.gameObject.SetActive(true);
        _subTitleText.gameObject.SetActive(true);
        _i.SetActive(true);
        _juice.SetActive(true);
        _sigeru.SetActive(true);
        _startButton.gameObject.SetActive(true);
        _setumeiButton.gameObject.SetActive(true);
        Destroy(this.gameObject);
    }

    public void Bakuhatuon()
    {
        _audioObj.gameObject.SetActive(true);
    }
}
