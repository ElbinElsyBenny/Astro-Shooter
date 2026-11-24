using UnityEngine;

public class BgScroller : MonoBehaviour
{
    public float ScrollSpeed;
    public Renderer Bg;


    // Update is called once per frame
    void Update()
    {
        Bg.material.mainTextureOffset += new Vector2(0, ScrollSpeed * Time.deltaTime);
    }
}
