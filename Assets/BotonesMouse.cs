using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesMouse : MonoBehaviour
{
    float velocidad = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifi camos si se oprime el boton izquierdo
        if (Input.GetMouseButton(0))
            transform.Rotate(0, velocidad * Time.deltaTime, 0);

        // Verifi camos si se oprime el boton central
        if (Input.GetMouseButton(1))
            transform.Rotate(velocidad * Time.deltaTime, 0, 0);

        // Verifi camos si se oprime el boton derecho
        if (Input.GetMouseButton(2))
            transform.Rotate(0, -velocidad * Time.deltaTime, 0);
    }
}
