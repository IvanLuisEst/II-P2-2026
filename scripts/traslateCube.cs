using UnityEngine;

public class traslateCube : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(moveDirection.x * speed, moveDirection.y * speed, moveDirection.z * speed);
    }
}