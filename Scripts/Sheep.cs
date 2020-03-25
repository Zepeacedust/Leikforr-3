using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sheep : MonoBehaviour
{
    private NavMeshAgent navAgent;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<Leader>().gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        navAgent.destination = target.position;
    }
}
