using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTile : MonoBehaviour
{
    public GameObject BlueCubePrefab;

    private void OnMouseDown()
    {
        GameObject a = Instantiate(BlueCubePrefab) as GameObject;
        a.transform.position = transform.position;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cube"))
        {
            transform.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            transform.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }
    }

    
}
