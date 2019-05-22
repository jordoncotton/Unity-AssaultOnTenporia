using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BulletBehaviour : MonoBehaviour
{
    //   public float bulletSpeed = 10f;
    //   public Rigidbody bullet;

    //// Use this for initialization
    //void Fire()
    //   {
    //       Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
    //       bulletClone.velocity = transform.forward * bulletSpeed;
    //}

    //// Update is called once per frame
    //void Update ()
    //   {
    //	if(Input.GetButtonDown("Fire1"))
    //       {
    //           Fire();
    //       }
    //}
    //   //////////////////////////////////
    [SerializeField]
    private int maxSpeed;
    private float timer;
    private Vector3 velocity;
    private void Start()
    {
        velocity = transform.position.normalized*maxSpeed;
    }
    private void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }
}
