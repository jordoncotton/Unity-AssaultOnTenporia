using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Agent1Behaviour : MonoBehaviour {
    private Vector3 playerinput;
    [SerializeField]
    private GameObject ammo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerinput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = transform.position+=playerinput;
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate<GameObject>(ammo);
        }
    }
}
