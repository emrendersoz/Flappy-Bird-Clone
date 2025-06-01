using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kus : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    Rigidbody2D rb;
    public GameManager managerGame;
    public GameObject DeathScreen;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            if(Time.timeScale==1)
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);
        }
        else
        {
            if (Time.timeScale==1)
            {
                transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 1.0f);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Skor")
        {
            managerGame.updateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Olum")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }
}
