using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectt : MonoBehaviour
{
    public GameHandler gameHandler;
    public AudioClip coinSound;
    void Start()
    {
        gameHandler = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameHandler.coins++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(this.gameObject);

        }
    }
}

