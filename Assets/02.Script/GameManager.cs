using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int tagCt = 0;
    [SerializeField]
    public GameObject Sound1;
    public GameObject Sound2;
    public GameObject Sound3;
    public GameObject Sound4;
    public GameObject Sound5;
    public GameObject Sound6;
    public GameObject Sound7;

    public GameObject potal;

    // Update is called once per frame
    void Update()
    {
        if(tagCt == 1)
        {
            Sound1.SetActive(true);
        }
        if (tagCt == 2)
        {
            Sound2.SetActive(true);
        }
        if (tagCt == 3)
        {
            Sound3.SetActive(true);
        }
        if (tagCt == 4)
        {
            Sound4.SetActive(true);
        }
        if (tagCt == 5)
        {
            Sound5.SetActive(true);
        }
        if (tagCt == 6)
        {
            Sound6.SetActive(true);
        }
        if (tagCt == 7)
        {
            Sound7.SetActive(true);
            potal.SetActive(true);
        }
    }

    public void TagAble()
    {
        tagCt = tagCt+1;
        Debug.Log("SetAble : "+tagCt);
    }
}
