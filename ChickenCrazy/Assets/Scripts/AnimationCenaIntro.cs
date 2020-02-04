using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCenaIntro : MonoBehaviour
{
    public Animation galinha, raposa;
    float timer = 0, velocidade = 0.1f;

    void Update()
    {
        Time.timeScale = 1;

        timer += Time.deltaTime;

        if (timer >= 6)
        {
            galinha.vira = !galinha.vira;
            raposa.vira = !raposa.vira;
            velocidade = velocidade * -1;
            timer = 0;
        }

        transform.Translate(Vector3.right * velocidade);
    }
}
