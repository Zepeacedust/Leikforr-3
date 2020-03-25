using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{

    public int coins = 0;
    public GameObject endscreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Debug.Log("TAX COLLECTAH!");
            coins++;
            Destroy(other.gameObject);
            if (coins > 0)
            {
                endscreen.SetActive(true);
            }
        }
    }
}
