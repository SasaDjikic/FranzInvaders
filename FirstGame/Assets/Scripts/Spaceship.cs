using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public AudioSource laserSound;
    public float moveSpeed;
    public GameObject laserObject;
    public GameObject cannonLeft;
    public GameObject cannonRight;

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        Vector3 movement = Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -20, 20);
        transform.position = position;
    }

    void Shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Jo");
            Instantiate(laserObject, cannonRight.transform.position, laserObject.transform.rotation);
            Instantiate(laserObject, cannonLeft.transform.position, laserObject.transform.rotation);
            laserSound.Play();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    private void OnDestroy()
    {
        gameManager.instance.gameOver = true;
        Application.Quit();
    }
}
