using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOut : MonoBehaviour
{
    public GameObject Block;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            Block.SetActive(true);
            Debug.Log("생성완료");
        }
    }
}
