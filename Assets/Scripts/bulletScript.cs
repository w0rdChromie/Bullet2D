using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//credit to Brackeys for the inspiration for this code
public class bulletScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
    }
}
