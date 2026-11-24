using UnityEngine;

public class Move : MonoBehaviour
{
    public float movespeed = 1f;
    public LogicScript Logic;
    public bool fly = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Logic = FindFirstObjectByType<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)&& fly)
        {
            transform.position += Vector3.right * movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) && fly)
        {
            transform.position += Vector3.left * movespeed * Time.deltaTime;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        //Debug.Log("Player detected: " + collision.gameObject.name);

        //Debug.Log("player collided wit: " + collision.gameObject.name + " |Tag: " + collision.gameObject.tag);


        if (collision.gameObject.CompareTag("Astro") || collision.gameObject.CompareTag("Debri"))
        {
            Logic.GameOver();
            fly = false;
        }
    }
}
