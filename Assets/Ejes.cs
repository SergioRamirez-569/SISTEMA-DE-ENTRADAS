using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejes : MonoBehaviour
{
    float velocidad = 0.05f;
    float velAngular = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotamos de acuerdo al movimiento del eje horizontal
        transform.Rotate(0, velAngular * Input.GetAxis("Horizontal"), 0);
        // Rotamos de acuerdo al movimiento vertical del eje
        transform.Translate(0, 0, velocidad * Input.GetAxis("Vertical"));
        // Si se oprime el boton de disparo subimos el objeto
        if (Input.GetButtonDown("Fire1"))
            transform.Translate(0, 0.5f, 0);
    }
}
