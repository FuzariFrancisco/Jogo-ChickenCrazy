using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inimigo : MonoBehaviour
{
    float vel = 0.5f;
    SpriteRenderer render;
    bool condicao = false;
    float timer = 0;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(Vector3.right * vel);
        render.flipX = condicao;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paredes")
        {
            if(vel < 0)
            {
                if (timer <= 15)
                {
                    vel = -0.10f;
                }
                else if (timer <= 30)
                {
                    vel = -0.15f;
                }
                else if (timer <= 50)
                {
                    vel = -0.20f;
                }
            }else if (vel > 0)
            {
                if (timer <= 15)
                {
                    vel = 0.10f;
                }
                else if (timer <= 30)
                {
                    vel = 0.15f;
                }
                else if (timer <= 50)
                {
                    vel = 0.20f;
                }
            }
            vel = vel * -1;
            condicao = !condicao;
        }
    }
}
