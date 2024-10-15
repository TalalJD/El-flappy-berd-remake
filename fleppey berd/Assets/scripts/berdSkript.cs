using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class berdSkript : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float flapStrenght;
    public LogicScript logic;
    public bool gameNotLost = true;
    private float deadZone = -42;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameNotLost) {
            Rigidbody2D.velocity = Vector2.up * flapStrenght;
        }

        if (transform.position.y <= deadZone)
        {
            Debug.Log("Bird died XD");
            Destroy(gameObject);
            logic.gameOver();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        gameNotLost = false;
    }
}
