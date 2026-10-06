using UnityEngine;

public class velocidadCube : MonoBehaviour
{
    public float velocidad;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha arriba: " + vertical * velocidad);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha abajo: " + vertical * velocidad);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha izquierda: " + horizontal * velocidad);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha derecha: " + horizontal * velocidad);
        }
    }
}