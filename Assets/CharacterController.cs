using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Speed = 20f;
    public int randomIndex;
    public int Levels;
    // Start is called before the first frame update
    void Start()
    {
        randomIndex = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetKey("d"))
        {
            pos.x += Speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= Speed * Time.deltaTime;
        }
        transform.position = pos;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "door")
        {
            if (randomIndex == 0)
            {

            }
            if (randomIndex == 1)
            {

            }
            if (randomIndex == 2)
            {

            }
            if (randomIndex == 3)
            {

            }
        }

    }
}
