using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    private float scollSpeed = 2.0f;
    private MeshRenderer meshRenderer;
    private float y_scroll;

    void Awake(){
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y_scroll = Time.time * scollSpeed;
        Vector2 offset = new Vector2(0f, y_scroll);
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
