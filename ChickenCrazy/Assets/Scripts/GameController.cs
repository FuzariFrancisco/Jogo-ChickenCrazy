using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject painelGanhou, painelPerdeu;
    public Text tempo, pontos, ScorePerdeu, ScoreGanhou;
    int pontosCont;
    float tempoCont = 60;

    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        tempo.text = "Tempo: 00:" + Mathf.Floor(tempoCont).ToString();
        pontos.text = "Pontos: " + pontosCont.ToString();

        ScoreGanhou.text = pontosCont.ToString();
        ScorePerdeu.text = pontosCont.ToString();

        tempoCont -= Time.deltaTime;

        if (tempoCont <= 0)
        {
            Ganhou();
        }
    }

    public void Perdeu()
    {
        Destroy(tempo);
        Destroy(pontos);
        Time.timeScale = 0;
        painelPerdeu.SetActive(true);
    }

    public void Ganhou()
    {
        Destroy(tempo);
        Destroy(pontos);
        Time.timeScale = 0;
        painelGanhou.SetActive(true);
    }

    public void RetornaMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pontuou()
    {
        pontosCont++;
    }



}
