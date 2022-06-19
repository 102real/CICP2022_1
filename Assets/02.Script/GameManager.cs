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
    public GameObject outro;
    public GameObject potal_efx;
    public GameObject erg;

    private int s2count = 0;

    public GameObject potal;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(tagCt == 1)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound1.SetActive(true);
        }
        if (tagCt == 2)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound2.SetActive(true);
        }
        if (tagCt == 3)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound3.SetActive(true);
        }
        if (tagCt == 4)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound5.SetActive(true);
        }
        if (tagCt == 6)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound6.SetActive(true);
        }
        if (tagCt == 7)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound7.SetActive(true);
        }
        if (tagCt == 8)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound8.SetActive(true);
        }
        if (tagCt == 9)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound9.SetActive(true);
        }
        if (tagCt == 10)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound10.SetActive(true);
        }
        if (tagCt == 11)
        {
            erg.SetActive(false);
            erg.SetActive(true);
            Sound11.SetActive(true);
        }
        if (tagCt == 12)
        {
            
            potal_efx.SetActive(true);
            potal.SetActive(true);
        }

        if (SceneManager.GetActiveScene().name== "02.TR" && s2count==0)
        {
            potal_efx.SetActive(false);
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
        yield return new WaitForSeconds(1f);
        Sound2.SetActive(false);
        yield return new WaitForSeconds(1f);
        Sound3.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Sound4.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Sound5.SetActive(false);
        yield return new WaitForSeconds(1f);
        Sound6.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Sound7.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Sound8.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Sound9.SetActive(false);
        
        yield return new WaitForSeconds(1f);
        Sound10.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Sound11.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Sound12.SetActive(false);
        potal_efx.SetActive(true);
        yield return new WaitForSeconds(1f);
        outro.SetActive(true);


    }

   
}
