using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControleCarro : MonoBehaviour
{
    float velocidade = 0.01f;
    float anguloGiro = 0.5f;
    [SerializeField] Text textoVida;
    int valorVida = 100;

    void Update()
    {
        float acelerar = Input.GetAxis("Vertical") * velocidade;
        float virar = Input.GetAxis("Horizontal") * anguloGiro;
        
        transform.Rotate(0, 0, -virar);
        transform.Translate(0, acelerar, 0);

    }

    void OnCollisionEnter2D(Collision2D other) {
        valorVida = valorVida - 10;
        textoVida.text = $"Vida: {valorVida}";
    }
}
