using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BNG
{
    public class LoadScenes01 : MonoBehaviour
    {

        [Tooltip("Wait this long in seconds before attempting to load the scene. Useful if you need to fade the screen out before attempting to load the level.")]
        public float ScreenFadeTime = 1f;

        ScreenFader sf;

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

            
                if (sf == null)
                {
                    sf = FindObjectOfType<ScreenFader>();
                    // May not have found anything
                    if (sf != null)
                    {
                        sf.DoFadeIn();
                    }
                }
            

            if (ScreenFadeTime > 0)
            {
                yield return new WaitForSeconds(ScreenFadeTime);
            }

            SceneManager.LoadScene("02.TR");
        }
    }
}

