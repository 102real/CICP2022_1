using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class LoadScenes00 : MonoBehaviour
    {

    public bool scenechage = false;
        public float ScreenFadeTime = 1f;


    public void Update()
    {
        if (scenechage)
        {
            LoadScene();
        }
    }

    public void LoadScene()
        {
            StartCoroutine("FadeThenLoadScene");            
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Change")
            {
                Debug.Log("생성완료");
                LoadScene();                
            }
        }

        public IEnumerator FadeThenLoadScene()
        {

            
                        

            if (ScreenFadeTime > 0)
            {
                yield return new WaitForSeconds(ScreenFadeTime);
            }

            SceneManager.LoadScene("01.Main_JH");
        }
    }


