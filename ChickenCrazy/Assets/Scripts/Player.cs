using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode esquerda;
    public KeyCode direita;
    public KeyCode pulo;
    public GameObject raposa, vida1, vida2, vida3;
    SpriteRenderer render;
    public GameController controller;
    int contaMortes = 0;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(esquerda))
        {
            transform.Translate(Vector3.left * 0.11f);
            render.flipX = true;
        }
        if (Input.GetKey(direita))
        {
            transform.Translate(Vector3.right * 0.11f);
            render.flipX = false;
        }
        if (Input.GetKey(pulo))
        {
            transform.Translate(Vector3.up * 0.15f);
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
                transform.position = new Vector2(0,0);
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
}
