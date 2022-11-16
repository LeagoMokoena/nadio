using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class racer_mesh : MonoBehaviour
{
    [SerializeField] private Transform movepos;

    public NavMeshAgent agent;

    private void Awake()
    {
        //agent = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //agent.destination = movepos.position;
    }
}
