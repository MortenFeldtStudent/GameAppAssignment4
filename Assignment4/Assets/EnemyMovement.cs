using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public GameObject endPoint;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        endPoint = GameObject.Find("END");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(endPoint.transform.position);

    }

}
