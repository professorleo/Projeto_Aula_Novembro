using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour
{
    [SerializeField] GameObject carro;

    void Update()
    {
        transform.position = carro.transform.position;
        transform.Translate(0, 0, -10);
    }
}
