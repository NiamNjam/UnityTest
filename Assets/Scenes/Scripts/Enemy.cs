using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 speed;


    // Update is called once per frame
    void Update()
    {
        /*
            //collision
            var player = GameObject.Find("Player").transform;
            //var plane = GameObject.Find("Plane").transform;

            var distance = Vector3.Distance(transform.position, player.position);

            if (distance < 1f)
            {
                //player.position = new Vector3(0, 0, 0);
                player.position = Vector3.zero;
            }

            //movement

            if (transform.position.x > 5 && speed > 0)
            {
                speed = -speed;
            }
            if (transform.position.x < -5 && speed < 0)
            {
                speed = -speed;
            }

            transform.position += Vector3.right * speed * Time.deltaTime;
        */
        transform.position += speed * Time.deltaTime;
        

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "fence") return;
        speed = -speed;
    }


}
