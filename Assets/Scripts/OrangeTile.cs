using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeTile : MonoBehaviour
{
    private GameObject SpawnObject;
    private Button SpawnButton;
    private GameObject[] orangeTiles;
    private GameObject[] blueTiles;
    private GameObject player;

    private void Awake()
    {
        SpawnObject = GameObject.Find("SpawnModeButton");
        SpawnButton = SpawnObject.GetComponent<Button>();
    }

    private void OnMouseDown()
    {
        orangeTiles = GameObject.FindGameObjectsWithTag("OrangeTile");
        foreach (GameObject orangeTile in orangeTiles)
        {
            orangeTile.SendMessage("Move");
        }


        player = GameObject.FindGameObjectWithTag("Player");
        if (transform.name == "Orange Tile Right")
        {
            player.SendMessage("MoveRight");
        }

        if (transform.name == "Orange Tile Left")
        {
            player.SendMessage("MoveLeft");
        }

        if (transform.name == "Orange Tile Up")
        {
            player.SendMessage("MoveUp");
        }

        if (transform.name == "Orange Tile Down")
        {
            player.SendMessage("MoveDown");
        }

    }


    private IEnumerator Move()
    {
        transform.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        transform.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        SpawnButton.interactable = false;
        yield return new WaitForSeconds(0.95f);

        transform.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        transform.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        SpawnButton.interactable = true;


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
