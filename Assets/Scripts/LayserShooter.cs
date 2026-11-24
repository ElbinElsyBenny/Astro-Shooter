using UnityEngine;

public class LayserShooter : MonoBehaviour
{
    public float speed;
    public float Limiter;
    public LogicScript Logic;
    public GameObject explosion;
    public CameraShake cameraShake;
    public AstroSpawnner AstroSpawnner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Logic = FindFirstObjectByType<LogicScript>();
        cameraShake = FindFirstObjectByType<CameraShake>();
        AstroSpawnner = FindFirstObjectByType<AstroSpawnner>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if(transform.position.y > Limiter)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        //Debug.Log("Laser detected: " + other.name);
        if(other.CompareTag("Astro"))
        {
            cameraShake.StartShake();

            if (Random.Range(1, 6) == 1)
            {
                AstroSpawnner.DebriSpawnner(other.transform.position);
            }
        }
        else if (other.CompareTag("Debri"))
        {
            cameraShake.StartShake();
        }
        else
        {
            return;
        }

        Instantiate(explosion, other.transform.position, Quaternion.identity); //Explosion effect

        Destroy(other.gameObject); // Destroy Asteroid
        Destroy(gameObject); //Destroy layser

        Logic.AddScore(1); //Add +1 score
    }
}
