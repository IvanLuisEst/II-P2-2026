using UnityEngine;

public class marcadorSphere : MonoBehaviour
{
    public Vector3 desplazamiento;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            transform.position += desplazamiento;
        }
    }
}
