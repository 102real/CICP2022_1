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

    private int s2count = 0;

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

        if (SceneManager.GetActiveScene().name== "02.TR" && s2count==0)
        {
            s2count = s2count+1;
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
        yield return new WaitForSeconds(5f);
        Debug.Log("트리거 작동!");
        GameObject.Find("TR_AnimManager").GetComponent<LoadScenes02>().Anim02();
        Sound1.SetActive(false);
        Sound2.SetActive(false);
        Sound3.SetActive(false);
        Sound4.SetActive(false);
        Sound5.SetActive(false);
        Sound6.SetActive(false);
        Sound7.SetActive(false);
    }
}
