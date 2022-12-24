using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("아야!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("트리거!");
    }
}
