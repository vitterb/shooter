using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    public GameObject bullet;
    float timer = 10f;
    bool start = false;
    public float shootRate = 3f;
    // Update is called once per frame
    void Update()
    {
        float shoot = Input.GetAxis("Fire1");
        print(shoot);

        if (shoot == 1 && timer >= shootRate)
        {
            GameObject newBullet = Instantiate(bullet, transform.position+transform.forward, transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 500, ForceMode.VelocityChange);
            start = true;
            timer = 0f;
        }

        if (start)
        {
            if (timer < shootRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = shootRate;
                start = false;
            }
        }
    }
}
