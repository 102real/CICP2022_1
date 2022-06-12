﻿using UnityEngine;
using System.Collections;

namespace ARPGFX
{


public class ARPGFXPortalScript : MonoBehaviour
{

    public GameObject portalOpenPrefab;
    public GameObject portalIdlePrefab;
    public GameObject portalClosePrefab;
    private GameObject portalOpen;
    private GameObject portalIdle;
    private GameObject portalClose;
        private bool setbool = false;
    public float portalLifetime = 4.0f;


    void Start()
    {
        portalOpen = Instantiate(portalOpenPrefab, transform.position, transform.rotation);
        portalIdle = Instantiate(portalIdlePrefab, transform.position, transform.rotation);
        portalIdle.SetActive(false);
        portalClose = Instantiate(portalClosePrefab, transform.position, transform.rotation);
        portalClose.SetActive(false);

        StartCoroutine("PortalLoop");
    }

        private void Update()
        {
            if (setbool)
            {
                StopCoroutine("PortalLoop");
            }
        }

        IEnumerator PortalLoop()
    {
        while (true)
        {
            portalOpen.SetActive(true);

            yield return new WaitForSeconds(0.8f);

            portalIdle.SetActive(true);
			portalOpen.SetActive(false);

            yield return new WaitForSeconds(portalLifetime);

                setbool = true;


        }
    }
}

}