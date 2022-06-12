using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserTag : MonoBehaviour
{
    public GameObject tag1;
    public GameObject tag2;
    public GameObject tag3;
    bool TagEnd = true;
    void Start()
    {
        tag1.SetActive(true);
        tag2.SetActive(false);
        tag3.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Eraser" && TagEnd)
        {
            TagEnd = false;
            tag1.SetActive(false);
            tag2.SetActive(true);
            tag3.SetActive(true);
            if(tag1.activeSelf == false)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().TagAble();
            }
        }
    }
}
