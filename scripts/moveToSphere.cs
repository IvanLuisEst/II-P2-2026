using UnityEngine;

public class moveToSphere : MonoBehaviour
{
    private Transform transformSphere;
    public float speed;

    void Start()
    {
        GameObject sphere = GameObject.FindWithTag("sphere");
        transformSphere = sphere.transform;
    }

    void Update()
    {
        Vector3 direction = transformSphere.position - transform.position;
        direction.y = 0;
        direction = direction.normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
