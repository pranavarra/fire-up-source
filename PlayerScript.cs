using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class PlayerScript : MonoBehaviour
{
    //public CharacterController plController;
    public static float score = 0;
    public AudioClip expClip;
    public float speed = 20f;
    public float RotationSpeed = 5f;
    public Rigidbody2D plRb;
    private AudioSource plAudio;
    public GameObject bulletPrefab;
    public AudioClip coinClip;
    public Text scoreTxt;
    public static int numP = 0;
    public int maxPeople = 30;
    public GameObject deathScreen;
    public GameObject gameScreen;
    public static bool dead = false;
    public Transform bulletPos;
    public Text scoreT;
    private SpriteRenderer plSp;
    public Sprite[] spArr;
    public AudioClip shootClip;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        GameObject pl = GameObject.Find("Sp");
        plSp = pl.GetComponent<SpriteRenderer>();
        Debug.Log(dead);
        plAudio = GetComponent<AudioSource>();
        plSp.sprite = spArr[ShopScript.rInt];

        deathScreen.SetActive(false);
    }
    float rotSpeed = 20;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
    }
    //OnMouseDrag();
    // Update is called once per frame
    void Update()
    {
        if(numP == maxPeople)
        {
            PlayerScript.dead = true;
        }
        scoreT.text = "Score: " + Math.Round(score).ToString();
        Debug.Log(score);
        score += (Time.deltaTime*5);
        if(dead == true)
        {
            
            //Destroy(gameObject);
            Time.timeScale = 0f;
            gameScreen.SetActive(false);
            deathScreen.SetActive(true);
        }
        scoreTxt.text = "Rescued: " + numP.ToString() + "/" + maxPeople.ToString();
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z - 90f);

        Vector3 mousePos = Input.mousePosition;
        float inputX = Input.GetAxisRaw("Horizontal") * speed;
        float inputY = Input.GetAxisRaw("Vertical") * speed;
        Vector3 moveVector = new Vector3(inputX, inputY, 0f);

        /*plController.Move(moveVector * Time.deltaTime);
        transform.Rotate(0f, 0f, (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), Space.World);
        Debug.Log(Input.GetAxis("Mouse X").ToString());*/
        plRb.velocity = transform.up * speed;

        if (Input.GetMouseButtonDown(0))
        {
            plAudio.clip = shootClip;
            plAudio.Play();
            Instantiate(bulletPrefab, bulletPos.position, transform.rotation);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "bullet")
        {
            dead = true;
        }
        if (other.gameObject.tag == "collect")
        {
            score += 200f;
            plAudio.clip = coinClip;
            plAudio.Play();
            Destroy(other.gameObject);
            numP++;
        }
        if (other.gameObject.tag == "blackhole")
        {
            PlayerScript.dead = true;
            plAudio.clip = expClip;
            plAudio.Play();
        }
    }

    

}
