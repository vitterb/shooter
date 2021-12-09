using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public int score= 0;
    void Start()
    {
        score = 0;
    }

    public void Addscore()
    {
        score++;
    }
}
