using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int tagCt = 0;
    [SerializeField]

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TagAble()
    {
        tagCt = tagCt+1;
        Debug.Log("SetAble : "+tagCt);
    }
}
