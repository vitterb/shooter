using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioClip audioClip;
    public GameObject explosionsParticle;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bullit")
        {
            print("hit");
            print(transform.position);
                Instantiate(explosionsParticle, transform.position, transform.rotation);
            if (audioClip)
            {
                if (gameObject.GetComponent<AudioSource>())
                {
                    gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
                }
                else
                {
                    AudioSource.PlayClipAtPoint(audioClip, transform.position);
                }
            }
            Destroy(gameObject);
            player.GetComponent<MyGameManager>().Addscore();
        }
    }
}
