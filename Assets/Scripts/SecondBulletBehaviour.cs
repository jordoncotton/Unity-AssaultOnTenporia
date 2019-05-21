using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBulletBehaviour : MonoBehaviour
{
    public GameObject bullet_emiiter;
    public GameObject bullet;

    public float bullet_Forward_Force;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("space")) ;

        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(bullet, bullet_emiiter.transform.position, bullet_emiiter.transform.rotation) as GameObject;

        Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
        Rigidbody Temporary_rigidbody;
        Temporary_rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        Temporary_rigidbody.AddForce(transform.forward * bullet_Forward_Force);

        Destroy(Temporary_Bullet_Handler, 10.0f);
	}
}
