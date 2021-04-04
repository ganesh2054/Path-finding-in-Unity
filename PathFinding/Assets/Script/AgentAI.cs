using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class AgentAI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform destination;
    NavMeshAgent agent;
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        if(agent==null)
        {
            Debug.Log("error");
        }
        else
        {
            SetDestination();
        }
    }

    // Update is called once per frame
  public void SetDestination()
    {
        if(destination!=null)
        {
            Vector3 target = destination.transform.position;
            agent.SetDestination(target);
        }
    }
}
