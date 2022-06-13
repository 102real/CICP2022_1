using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaMove : MonoBehaviour
{

    public float x = 0.5f;
    float xOffset;

    public float y = 0.5f;
    float yOffset;

    void Update()
    {

        xOffset -= (Time.deltaTime * x) / 10f;
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(xOffset, 0);
        gameObject.GetComponent<MeshRenderer>().material.mainTextureOffset = new Vector2(xOffset, 0);
        gameObject.GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", new Vector2(xOffset, 0));

        yOffset -= (Time.deltaTime * y) / 10f;
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, yOffset);
        gameObject.GetComponent<MeshRenderer>().material.mainTextureOffset = new Vector2(0, yOffset);
        gameObject.GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", new Vector2(0, yOffset));

        Color color = gameObject.GetComponent<MeshRenderer>().material.color;
        for(float i = 0.0f; i<=1.0f; i += 0.01f)
        {
            color.a = i;
            gameObject.GetComponent<MeshRenderer>().material.color = color;
        }

    }
}
