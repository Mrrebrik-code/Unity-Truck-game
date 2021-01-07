using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartLevl : MonoBehaviour
{
    [SerializeField] GameObject car;
    [SerializeField] GameObject carmini;
    [SerializeField] GameObject Helper;
    [SerializeField] GameObject Panel;

    public int count;
    [SerializeField] private int coutMax;

    [SerializeField] AudioSource audioPlayer;

    [SerializeField] private AudioClip startGruzovik;

    [SerializeField] private GameObject WinPanel;

    private void Start()
    {
        car.GetComponent<Animator>().SetTrigger("Start");
        carmini.GetComponent<Animator>().SetTrigger("Start");
        Helper.GetComponent<Animator>().SetTrigger("Start");
        Panel.GetComponent<Animator>().SetTrigger("Start");
        audioPlayer.PlayOneShot(startGruzovik);
    }

    private void Update()
    {
        if(count == coutMax)
        {
            WinPanel.SetActive(true);
            count = 0;
        }
    }

}
