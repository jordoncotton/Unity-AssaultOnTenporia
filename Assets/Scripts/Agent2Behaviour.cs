using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Agent2Behaviour : MonoBehaviour {
    private Vector3 playerinput;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerinput = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2"));
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = transform.position += playerinput;
    }
}
