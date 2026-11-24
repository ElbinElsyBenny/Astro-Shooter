using UnityEngine;

public class AstroSpawnner : MonoBehaviour
{
    public GameObject astroSpawnner;
    public float spawnRate;
    public float timer;
    public float spawnneroffset;
    public GameObject Debri;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnRock();
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
            spawnRock();
            timer = 0;
        }
        
    }

    void spawnRock()
    {
        float rightPoint = transform.position.x + spawnneroffset;
        float leftPoint = transform.position.x - spawnneroffset;

        float randomX = Random.Range(leftPoint,rightPoint);

        Instantiate(astroSpawnner,new Vector3(randomX,transform.position.y,0),transform.rotation);
    }

    public void DebriSpawnner(Vector3 spawnPosition)
    {
        Instantiate(Debri, spawnPosition,Quaternion.identity);
    }
}
