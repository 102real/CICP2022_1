using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes02 : MonoBehaviour
{
    public bool loadScenes02=false;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (loadScenes02)
        {
            SceneManager.LoadScene("03.End");
        }
    }

    public void Anim02()
    {
        anim.SetTrigger("TR");
    }
}
