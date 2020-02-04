using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovo : MonoBehaviour
{
    public GameObject galinha;
    public GameObject raposa;
    Rigidbody2D rb2D;
    bool parado = false;

    public GameController controller;

    int aleatorio;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!parado)
        {
            transform.Translate(Vector3.down * 0.12f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Chao")
        {
            Debug.Log("Colidiu");
            parado = true;
        }

        if (collision.gameObject == raposa)
        {
            ResetaOvo();
            parado = false;
        }

        if (collision.gameObject == galinha)
        {
            ResetaOvo();
            parado = false;
            controller.Pontuou();
        }
    }

    public void ResetaOvo()
    {
        aleatorio = Random.Range(1,5);

        switch (aleatorio)
        {
            case 1:
                {
                    this.transform.position = new Vector2(-8f, 5.51f);
                    break;
                }
            case 2:
                {
                    this.transform.position = new Vector2(-4f, 5.51f);
                    break;
                }
            case 3:
                {
                    this.transform.position = new Vector2(0f, 5.51f);
                    break;
                }
            case 4:
                {
                    this.transform.position = new Vector2(4f, 5.51f);
                    break;
                }
            case 5:
                {
                    this.transform.position = new Vector2(8f, 5.51f);
                    break;
                }
        }
    }
}
