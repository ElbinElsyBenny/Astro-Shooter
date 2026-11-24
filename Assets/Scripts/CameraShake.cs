using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public float ShakeDuration = 0.15f;
    public float ShakeMagnitude = 0.08f;

    private Vector3 OriginalPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        OriginalPosition = transform.position;
        
    }

    IEnumerator Shake()
    {
        float elapsedTime = 0f;

        while (elapsedTime < ShakeDuration)
        {
            Vector2 randomOffset = Random.insideUnitCircle * ShakeMagnitude;

            transform.position = OriginalPosition + new Vector3(randomOffset.x, randomOffset.y, 0);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        transform.position = OriginalPosition;

    }

    public void StartShake()
    {
        StartCoroutine(Shake());
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
