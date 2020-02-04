﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecaChao : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Chao")
        {
            Player.GetComponent<Player>().noChao = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chao")
        {
            Player.GetComponent<Player>().noChao = false;
        }
    }
}
