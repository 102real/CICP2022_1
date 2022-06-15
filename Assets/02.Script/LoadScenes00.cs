using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class LoadScenes00 : MonoBehaviour
    {

        [Tooltip("Wait this long in seconds before attempting to load the scene. Useful if you need to fade the screen out before attempting to load the level.")]
        public float ScreenFadeTime = 1f;

        

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

            SceneManager.LoadScene("02.TR");
        }
    }


