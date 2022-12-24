using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delayToDestroy = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(255, 0, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("아야!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package")
        {
            pickUpPackage(other);
        }

        if (other.tag == "Customer")
        {
            deliverToCustomer();
        }
    }

    private void deliverToCustomer() {
        if (hasPackage) 
        {
            Debug.Log("delievered to customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }

    private void pickUpPackage(Collider2D other) {
        if (hasPackage) return;

        Debug.Log("Package picked up");
        hasPackage = true;
        spriteRenderer.color = hasPackageColor;
        Destroy(other.gameObject, delayToDestroy);
    }
}
