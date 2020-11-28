using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartLevl : MonoBehaviour
{
    [SerializeField] GameObject car;
    [SerializeField] GameObject carmini;
    [SerializeField] GameObject Helper;
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject button;
    [SerializeField] AudioClip click;
    [SerializeField] AudioClip carsta;
    [SerializeField] AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }


    public void StartGame()
    {
        car.GetComponent<Animator>().SetTrigger("Start");
        carmini.GetComponent<Animator>().SetTrigger("Start");
        Helper.GetComponent<Animator>().SetTrigger("Start");
        Panel.GetComponent<Animator>().SetTrigger("Start");
        button.SetActive(false);
        audiosource.PlayOneShot(click);
        audiosource.PlayOneShot(carsta);
    }
}
