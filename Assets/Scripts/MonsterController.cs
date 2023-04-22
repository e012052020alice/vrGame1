using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterController : MonoBehaviour
{
    public GameObject targetPlayer;
    private NavMeshAgent MonAgent;
    // Start is called before the first frame update
    void Start()
    {
        MonAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
