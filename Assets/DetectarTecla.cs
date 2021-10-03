using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarTecla : MonoBehaviour
{
    float velocidad = 1.0f;
    float velAngular = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, velAngular * Time.deltaTime, 0);
        // Verifi camos si se ha oprimido la tecla fl echa izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -velAngular * Time.deltaTime, 0);
        // Verifi camos si se ha oprimido la tecla fl echa arriba
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, 0, velocidad * Time.deltaTime);
    }
}
