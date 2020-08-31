using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]

    Transform destination;
    public Vector3 position;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        position = this.transform.position;
        SetDestination();
    }

    private void SetDestination()
    {
        Vector3 target = destination.transform.position;
        agent.SetDestination(target);
    }
}
