using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode pulo;
    public GameObject raposa, vida1, vida2, vida3;
    SpriteRenderer render;
    public GameController controller;
    int contaMortes = 0;
    private Rigidbody2D rb2D;
    private Animator animacao;
    float horizontal, velocidade = 10f, MinusVelocidade = -10f;
    public bool noChao = false;
    bool direita = false, esquerda = false;
    Vector2 fundoEsquerda, topoDireita;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
        animacao = GetComponent<Animator>();
        fundoEsquerda = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topoDireita = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movimentar();
        Animacao();
        Pulo();
    }

    void Movimentar()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !esquerda)
        {
            rb2D.velocity = new Vector2(MinusVelocidade, rb2D.velocity.y);
            render.flipX = true;
        }

        if (Input.GetKey(KeyCode.RightArrow) && !direita)
        {
            rb2D.velocity = new Vector2(velocidade, rb2D.velocity.y);
            render.flipX = false;
        }
    }

    void Animacao()
    {
        if (/*Input.GetKey(KeyCode.A) ||*/ Input.GetKey(KeyCode.LeftArrow) ||
            /*Input.GetKey(KeyCode.D) || */Input.GetKey(KeyCode.RightArrow))
        {
            animacao.SetBool("Andando", true);
        }
        else
        {
            animacao.SetBool("Andando", false);
        }
    }

    void Pulo()
    {
        if (/*Input.GetButtonDown("Jump")*/Input.GetKey(KeyCode.UpArrow) && noChao)
        {
            rb2D.AddForce(new Vector2(0f, 12f), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == raposa)
        {
            contaMortes++;
            if (contaMortes == 1)
            {
                Destroy(vida1);
                transform.position = new Vector2(0,2);
            }else if (contaMortes == 2)
            {
                Destroy(vida2);
                transform.position = new Vector2(0, 0);
            }
            else if (contaMortes >= 3)
            {
                Destroy(vida3);
                Destroy(this.gameObject);
                controller.Perdeu();
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Esquerda")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            esquerda = true;
        }

        if (collision.gameObject.tag == "Direita")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            direita = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {        
            esquerda = false;               
            direita = false;        
    }


}
