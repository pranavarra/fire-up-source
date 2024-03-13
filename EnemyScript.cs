using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EnemyScript : MonoBehaviour
{
    private Transform player;
    private Rigidbody2D eRb;
    public float moveSpeed = 0f;
    private Vector2 movement;
    private float timeThere = 1f;
    public GameObject bulletPre;
    private bool nearPl = false;
    public Transform bulletPos;
    // Start is called before the first frame update
    void Start()
    {
        GameObject pl = GameObject.FindWithTag("Player");
        player = pl.GetComponent<Transform>();
        eRb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        eRb.rotation = angle - 90f;
        direction.Normalize();
        movement = direction;
        timeThere += Time.deltaTime;
    }
    void FixedUpdate()
    {
            Move(movement);
        
    }
    void Move(Vector2 dir)
    {
        eRb.MovePosition((Vector2)transform.position + (dir * moveSpeed * Time.deltaTime));
    }

    

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && Math.Round(timeThere)%5 == 0)
        {
            nearPl = true;
            Debug.Log("Hello");
            Instantiate(bulletPre, bulletPos.position, transform.rotation);
        }
    }
}
