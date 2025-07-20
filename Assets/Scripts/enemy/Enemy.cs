using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private StateMachine stateMachine;
    private GameObject player;
    private NavMeshAgent agent;
    
    public NavMeshAgent Agent { get => agent; }
    [SerializeField]
    public GameObject Player { get => player; }
    
    public Paths paths;
    [Header("Sight Values")]
    public float sightDistance = 20f;
    public float fieldofView = 85;
    public float eyeHeight;
    [Header("Weapon Values")]
    public Transform gunBarrel;
    [Range(0.1f,10f)]
    public float fireRate;
    private string currentState;
    // Start is called before the first frame update
    void Start()
    {
        stateMachine = GetComponent<StateMachine>();
        agent = GetComponent<NavMeshAgent>();
        stateMachine.Initialise();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CanSeePlayer();
        currentState = stateMachine.activeState.ToString();
    }
    public bool CanSeePlayer()
    {
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < sightDistance)
            {
                Vector3 targetDirection = player.transform.position - transform.position - (Vector3.up * eyeHeight);
                float angleToPlayer = Vector3.Angle(targetDirection, transform.forward);
                if (angleToPlayer >= -fieldofView && angleToPlayer <= fieldofView)
                {
                    Ray ray = new Ray(transform.position + (Vector3.up * eyeHeight), targetDirection);
                    RaycastHit hitInfo = new RaycastHit();
                    if (Physics.Raycast(ray, out hitInfo, sightDistance))
                    { 
                        if (hitInfo.transform.gameObject == player)
                        { 
                            Debug.DrawRay(ray.origin, ray.direction * sightDistance);
                            return true;
                        }
                    }

                   
                }
            }
        }
        return false;

    }
}
