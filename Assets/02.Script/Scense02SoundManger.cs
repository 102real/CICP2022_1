using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scense02SoundManger : MonoBehaviour
{
    [SerializeField] GameObject gmanger;
    public bool Soundb01 = false;
    public bool Soundb02 = false;
    public bool Soundb03 = false;
    public bool Soundb04 = false;
    public bool Soundb05 = false;
    public bool Soundb06 = false;
    public bool Soundb07 = false;
    public bool Soundb08 = false;
    public bool Soundb09 = false;
    public bool Soundb10 = false;
    public bool Soundb11 = false;
    public bool Soundb12 = false;
    void Start()
    {
       gmanger = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Soundb01)
        {
            gmanger.GetComponent<GameManager>().SoundMt1();
        }
        if (Soundb02)
        {
            gmanger.GetComponent<GameManager>().SoundMt2();
        }
        if (Soundb03)
        {
            gmanger.GetComponent<GameManager>().SoundMt3();
        }
        if (Soundb04)
        {
            gmanger.GetComponent<GameManager>().SoundMt4();
        }
        if (Soundb05)
        {
            gmanger.GetComponent<GameManager>().SoundMt5();
        }
        if (Soundb06)
        {
            gmanger.GetComponent<GameManager>().SoundMt6();
        }
        if (Soundb07)
        {
            gmanger.GetComponent<GameManager>().SoundMt8();
        }
        if (Soundb09)
        {
            gmanger.GetComponent<GameManager>().SoundMt9();
        }
        if (Soundb10)
        {
            gmanger.GetComponent<GameManager>().SoundMt10();
        }
        if (Soundb11)

        {
            gmanger.GetComponent<GameManager>().SoundMt11();
        }
        if (Soundb12)
        {
            gmanger.GetComponent<GameManager>().SoundMt12();
        }
    }
}
