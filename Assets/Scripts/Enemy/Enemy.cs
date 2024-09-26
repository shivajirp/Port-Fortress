using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private StateMachine stateMachine;
    private NavMeshAgent agent;
    public NavMeshAgent Agent { get => agent; }
    private Animator animator;


    //just for debugging
    [SerializeField]
    private string currentState;

    public Path path;
    public GameObject player;
    public float sightDistance = 20f;
    public float fieldOfView = 85f;
    public float eyeHeight;

    // Start is called before the first frame update
    void Start()
    {
        stateMachine = GetComponent<StateMachine>();
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        stateMachine.Initialise();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        bool playerInSight = CanSeePlayer();

        animator.SetBool("shoot", playerInSight);
        animator.SetFloat("Speed", agent.desiredVelocity.sqrMagnitude);
    }

    public bool CanSeePlayer()
    {
        // is player close enough to be seen
        if(Vector3.Distance(transform.position, player.transform.position) < sightDistance)
        {
            Vector3 targetDirection = player.transform.position - transform.position - Vector3.up * eyeHeight;
            float angleToPlayer = Vector3.Angle(targetDirection, transform.forward);
            if(angleToPlayer >= -fieldOfView && angleToPlayer <= fieldOfView)
            {
                Ray ray = new Ray(transform.position + (Vector3.up * eyeHeight), targetDirection);
                RaycastHit hitInfo = new RaycastHit();
                if(Physics.Raycast(ray, out hitInfo, sightDistance))
                {
                    if(hitInfo.transform.gameObject == player)
                    {
                        Debug.DrawRay(ray.origin, ray.direction * sightDistance);
                        return true;
                    }
                }
            }
        }
        return false;
    }

    
}
