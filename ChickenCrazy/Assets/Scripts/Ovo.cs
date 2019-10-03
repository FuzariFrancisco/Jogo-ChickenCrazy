using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovo : MonoBehaviour
{
    public GameObject galinha;
    public GameObject raposa;

    public GameController controller;

    int aleatorio;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == raposa)
        {
            ResetaOvo();
        }

        if (collision.gameObject == galinha)
        {
            ResetaOvo();
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
