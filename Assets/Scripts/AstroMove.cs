using UnityEngine;

public class AstroMove : MonoBehaviour
{
    public float speed;
    public float limiter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < limiter)
        {
            Destroy(gameObject);
        }
    }
}
