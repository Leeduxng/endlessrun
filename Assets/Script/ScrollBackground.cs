using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float speed;
    [SerializeField] Renderer _scollBackground;
    
    void Update()
    {
        _scollBackground.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
