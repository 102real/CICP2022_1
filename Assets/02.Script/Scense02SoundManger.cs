using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scense02SoundManger : MonoBehaviour
{
    [SerializeField] GameObject gmanger;
    
    void Start()
    {
       gmanger = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
