using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimer : MonoBehaviour
{
    float timer = 0;
    float lifeTime = 3f;

    // Update is called once per frame
    void Update()
    {
        if (lifeTime > timer)
            timer += Time.deltaTime;
        else
            Destroy(gameObject);
    }
}
