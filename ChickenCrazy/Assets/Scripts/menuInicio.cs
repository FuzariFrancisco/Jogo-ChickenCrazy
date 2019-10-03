using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicio : MonoBehaviour
{
    public void CarregaJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void FechaJogo()
    {
        Application.Quit();
    }
}
