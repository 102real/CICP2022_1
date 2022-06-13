using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
float startTime;
    float animDur = 60.0f;

    Vector3 startPos, endPos;
    float posRange = .1f;
    public bool noZMove = true;

    
    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        animDur = Random.Range(3, 100);
        posRange = Random.Range(0.1f, 2.0f);
        makeNewEnds();
    }

    float randomRange(float a, float b)
    {
        if (a > b)
        {
            return Random.Range(b, a);
        }
        else
        {
            return Random.Range(a, b);
        }
    }

    void makeNewEnds()
    {
        startTime = Time.time;

        endPos = new Vector3(
            randomRange(startPos.x - posRange, startPos.x + posRange),
            randomRange(startPos.y - posRange, startPos.y + posRange),
            noZMove ? 0 : randomRange(startPos.z - posRange, startPos.z + posRange)
        );

        
    }

    // Update is called once per frame
    void Update()
    {
        float timePassed = Time.time - startTime;
        float pctComplete = timePassed / animDur;

        if (pctComplete >= 1.0f)
        {
            makeNewEnds();
            return;
        }

        if (pctComplete < 0.5f)
        {
            transform.position = Vector3.Lerp(startPos, endPos, pctComplete * 2f);
        }
        else
        {
            // tween back
            float pct2 = (1.0f - pctComplete) * 2f;
            transform.position = Vector3.Lerp(startPos, endPos, pct2);
        }
    }
}
