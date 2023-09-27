using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    public Vector3 spawnPoint;
    //public Vector3 a;
    //public Vector3 b;


    /*
    private void Start()
    {
        Application.targetFrameRate = 500;
    }
    */
    private void Start()
    {
        spawnPoint = transform.position;
    }

    void Update()
    {
        //print(Time.deltaTime);
        Vector3 moveDiraction = new Vector3();
        moveDiraction.x = Input.GetAxisRaw("Horizontal");
        moveDiraction.z = Input.GetAxisRaw("Vertical");
        print(moveDiraction);

        //transform.position += moveDiraction * speed * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = moveDiraction * speed;

        if(moveDiraction != Vector3.zero)transform.forward = moveDiraction;
        /*
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);

        }
        */
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Enemy")
        {

            //transform.position = spawnPoint;
            var currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        }
    }
}



