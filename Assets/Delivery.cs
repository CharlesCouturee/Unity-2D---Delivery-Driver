using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;

    [SerializeField] float destroyDelay = 0f;
    [SerializeField] Color32 hasPackgaeColor = new Color32(0, 239, 56, 255);
    [SerializeField] Color32 noPackgaeColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackgaeColor;
            Destroy(collision.gameObject, destroyDelay);
        }
        else if (collision.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = noPackgaeColor;
        }
    }
}
