susing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{

    public float scrollSpeed;
    public bool scroll = true;

    Material backgroundMaterial;
    // Gets renderer Component on Awake
    private void Awake()
    {
        backgroundMaterial = GetComponent<Renderer>().material;

    }
    //FixedUpdate defines Texture Scroll Speed
    private void FixedUpdate()
    {
        if (scroll)
        {
            Vector2 offset = new Vector2(scrollSpeed * Time.time, 0f);

            backgroundMaterial.mainTextureOffset = offset;

        }
    }
}
