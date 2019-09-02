using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moving : MonoBehaviour
{
    public Rigidbody rb;
    public float sideways = 500f;
    public float forward = 500f;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        rb.AddForce(0, 0, forward * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}