using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal, 0);
        transform.Translate(transform.forward * speed * Time.deltaTime,Space.World);
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
    }
}
