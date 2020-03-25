using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject player;
        // Start is called before the first frame update
    public void respawn()
    {
        player.SetActive(false);
        player.transform.position = respawnPoint.position;
        player.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
