using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterController : MonoBehaviour
{
    public GameObject targetPlayer;
    private NavMeshAgent MonAgent;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        MonAgent = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MonAgent.SetDestination(targetPlayer.transform.position);
        float dist = Vector3.Distance(transform.position, targetPlayer.transform.position);
        if (dist <= 5)
        {
            ani.SetBool("Run", false);
            ani.SetTrigger("Attack");
        }
        else
        {
            ani.SetBool("Run", true);
        }
    }
}
