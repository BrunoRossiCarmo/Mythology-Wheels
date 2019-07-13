using UnityEngine;
using System.Collections;

public class Movimento_Player : MonoBehaviour
{

    float _velocidade;
    float _girar;

    void Start()
    {
        _velocidade = 10.0F;
        _girar = 140.0F;
    }

    // 1 update/frame
    void Update()
    {
        float translate = (Input.GetAxis("Vertical") * _velocidade) * Time.deltaTime;
        float rotate = (Input.GetAxis("Horizontal") * _girar) * Time.deltaTime;

        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotate, 0);
    }


}