using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntToString : MonoBehaviour
{

    public GameObject Player;
   
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        text.text = Player.GetComponent<MyGameManager>().score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player != null){
            text.text = Player.GetComponent<MyGameManager>().score.ToString();
        }
        
    }
}
