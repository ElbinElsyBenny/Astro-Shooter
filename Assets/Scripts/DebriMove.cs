using UnityEngine;

public class DebriMove : MonoBehaviour
{
    public float speed = 2f;

    private Vector2 Direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, -0.3f);

        Direction = new Vector2(randomX, randomY).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(Direction * speed * Time.deltaTime);
    }
}
