using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inimigo : MonoBehaviour
{
    float vel = 5f;
    SpriteRenderer render;
    Rigidbody2D rb2D;
    bool condicao = false;
    float timer = 0;


    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        rb2D.velocity = new Vector2(vel, rb2D.velocity.y);
        render.flipX = condicao;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Direita" || collision.gameObject.tag == "Esquerda")
        {
            if(vel < 0)
            {
                if (timer <= 15)
                {
                    vel = -5f;
                }
                else if (timer <= 30)
                {
                    vel = -8f;
                }
                else if (timer <= 50)
                {
                    vel = -11f;
                }
            }else if (vel > 0)
            {
                if (timer <= 15)
                {
                    vel = 5f;
                }
                else if (timer <= 30)
                {
                    vel = 8f;
                }
                else if (timer <= 50)
                {
                    vel = 11f;
                }
            }
            vel = vel * -1;
            condicao = !condicao;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Direita" || collision.gameObject.tag == "Esquerda")
        {
            if (vel < 0)
            {
                if (timer <= 15)
                {
                    vel = -5f;
                }
                else if (timer <= 30)
                {
                    vel = -8f;
                }
                else if (timer <= 50)
                {
                    vel = -11f;
                }
            }
            else if (vel > 0)
            {
                if (timer <= 15)
                {
                    vel = 5f;
                }
                else if (timer <= 30)
                {
                    vel = 8f;
                }
                else if (timer <= 50)
                {
                    vel = 11f;
                }
            }
            vel = vel * -1;
            condicao = !condicao;
        }
    }
}
