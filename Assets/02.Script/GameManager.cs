using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject Sound8;
    public GameObject Sound9;
    public GameObject Sound10;
    public GameObject Sound11;
    public GameObject Sound12;
    public GameObject you;
    public GameObject Eraser_touch_efx;
    AudioSource audioSource;

    private int s2count = 0;

    public GameObject potal;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

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
        }
        if (tagCt == 8)
        {
            Sound8.SetActive(true);
        }
        if (tagCt == 9)
        {
            Sound9.SetActive(true);
        }
        if (tagCt == 10)
        {
            Sound10.SetActive(true);
        }
        if (tagCt == 11)
        {
            Sound11.SetActive(true);
        }
        if (tagCt == 12)
        {
            Sound12.SetActive(true);
            potal.SetActive(true);
        }

        if (SceneManager.GetActiveScene().name== "02.TR" && s2count==0)
        {
            audioSource.Play();
            s2count = s2count+1;
            potal.SetActive(false);
            Debug.Log("02.TR");
            StartCoroutine("SoundMute");
        }
    }

    public void TagAble()
    {
        tagCt = tagCt+1;
        Debug.Log("SetAble : "+tagCt);
    }

    public IEnumerator SoundMute()
    {
        Debug.Log("트리거 작동!");
        

        yield return new WaitForSeconds(3f);
        you.SetActive(true);
        yield return new WaitForSeconds(10f);
        GameObject.Find("TR_AnimManager").GetComponent<LoadScenes02>().Anim02();
        Sound1.SetActive(false);
        yield return new WaitForSeconds(4f);
        Sound2.SetActive(false);
        yield return new WaitForSeconds(3f);
        Sound3.SetActive(false);
        yield return new WaitForSeconds(2f);
        Sound4.SetActive(false);
        yield return new WaitForSeconds(2f);
        Sound5.SetActive(false);
        yield return new WaitForSeconds(2f);
        Sound6.SetActive(false);
        Sound7.SetActive(false);
        yield return new WaitForSeconds(2f);
        Sound8.SetActive(false);
        yield return new WaitForSeconds(3f);
        Sound9.SetActive(false);
        Sound10.SetActive(false);
        yield return new WaitForSeconds(2f);
        Sound11.SetActive(false);
        Sound12.SetActive(false);
    }

    public void SoundMt1()
    {
        Sound1.SetActive(false);
    }
    public void SoundMt2()
    {
        Sound2.SetActive(false);
    }
    public void SoundMt3()
    {
        Sound3.SetActive(false);
    }
    public void SoundMt4()
    {
        Sound4.SetActive(false);
    }
    public void SoundMt5()
    {
        Sound5.SetActive(false);
    }
    public void SoundMt6()
    {
        Sound6.SetActive(false);
    }
    public void SoundMt7()
    {
        Sound7.SetActive(false);
    }
    public void SoundMt8()
    {
        Sound8.SetActive(false);
    }
    public void SoundMt9()
    {
        Sound9.SetActive(false);
    }
    public void SoundMt10()
    {
        Sound10.SetActive(false);
    }
    public void SoundMt11()
    {
        Sound11.SetActive(false);
    }
    public void SoundMt12()
    {
        Sound12.SetActive(false);
    }

}
