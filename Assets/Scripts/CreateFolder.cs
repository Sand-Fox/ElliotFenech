using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFolder : MonoBehaviour
{
    private GameObject[] blueTiles;

    public void ActivateDesactivate()
    {
        blueTiles = GameObject.FindGameObjectsWithTag("BlueTile");
        foreach (GameObject blueTile in blueTiles)
        {
            blueTile.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            
            blueTile.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }

        gameObject.SetActive(!gameObject.activeSelf);
    }
}
