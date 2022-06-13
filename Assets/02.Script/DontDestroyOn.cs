using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOn : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
