using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicio : MonoBehaviour
{
    public GameObject painelTutorial, painelCreditos;

    void Start()
    {
    }

    public void CarregaJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void FechaJogo()
    {
        Application.Quit();
    }

    public void AbrePainelCreditos()
    {
        painelCreditos.SetActive(true);
    }

    public void FechaPainelCreditos()
    {
        painelCreditos.SetActive(false);
    }

    public void AbrePainelTutorial()
    {
        painelTutorial.SetActive(true);
    }

    public void FechaPainelTutorial()
    {
        painelTutorial.SetActive(false);
    }
}
