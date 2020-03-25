using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Death : MonoBehaviour
{
    private double _decelerationTolerance = 1.0;
    public int life = 100;
    public CharacterController position;
    public Text life_display;
    private Vector3 last_speed;
    public GameObject player;
    public Manager manager;
    public Component movementScript;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<Manager>();
        position = GetComponent<CharacterController>();
        last_speed = position.velocity;
        life_display.text = "Life: " + life.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Sheep")
        {
            life -= 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if ((last_speed - position.velocity).magnitude > 15)
            {
                life -= (int)(last_speed - position.velocity).magnitude;
                Debug.Log(last_speed);

            }
        if (position.gameObject.transform.position.y < 15)
        {
            Debug.Log("blub blub");
            life--;
        }
        if (life <= 0)
        {
            life = 100;
            manager.respawn();
        }
        last_speed = position.velocity;
        life_display.text = "Life: " + life.ToString();
     }
}