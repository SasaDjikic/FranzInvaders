using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime);
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    private void OnDestroy()
    {
        gameManager.instance.score += 1;
    }
}
