using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 200);
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // jump
        if (Input.GetKeyDown("space") || Input.GetKeyDown("up"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }   

        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }

    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        System.Threading.Thread.Sleep(500);
        SceneManager.LoadScene("mainScene");
    }
}
