using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField] Canvas _setumeiCanvas;
    void Start()
    {
        
    }

    

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SetumeiButton()
    {
        _setumeiCanvas.gameObject.SetActive(true);
    }

    public void SetumeiOff()
    {
        _setumeiCanvas.gameObject.SetActive(false);
    }
}
