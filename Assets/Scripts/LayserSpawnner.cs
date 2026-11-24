using UnityEngine;

public class LayserSpawnner : MonoBehaviour
{
    public GameObject spawnner;
    public float spawnRate = 1f;
    private float timer = 0f;
    private Move Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        Player = GetComponentInParent<Move>();
    }
    void Start()
    {
        spawnLayser();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if(Player.fly)
            {
                spawnLayser();
            }
            
            timer = 0;
        }
        
    }

    void spawnLayser()
    {
        Instantiate(spawnner, transform.position, transform.rotation);
    }
}
