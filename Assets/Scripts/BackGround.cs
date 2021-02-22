using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float vel = 1f;
    public float forca = 1000f;
    public Renderer backGround;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2 (vel / forca, 0);
        backGround.material.mainTextureOffset += offset;
    }
}
