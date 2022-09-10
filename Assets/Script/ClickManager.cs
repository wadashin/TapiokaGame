using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    [SerializeField] GameObject[] _zuroros;
    //2.5 ~ -4

    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;

    private float time;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //if(Input.GetButtonDown("Fire1"))
        //{
        //    Instantiate(_zuroros[Random.Range(0, 6)], new Vector2(0, Random.Range(-4, 3)), Quaternion.identity);
        //}
        if(Input.GetButton("Fire1") || Input.GetMouseButtonDown(0))
        {
            time += Time.deltaTime;
            if(time >= 1.5f)
            {
                Instantiate(_zuroros[Random.Range(0, 6)], new Vector2(0, Random.Range(-4f, 3f)), Quaternion.identity);
                if(Random.Range(0,2) == 0)
                {
                    audioSource.PlayOneShot(sound1);
                }
                else
                {
                    audioSource.PlayOneShot(sound2);
                }
                time = 0;
            }
        }
    }
}
