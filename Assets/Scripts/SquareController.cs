using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{

    float direction = 1f;

    public float speed = 0.1f;

    public List<Color> colors;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 centerPosition = new Vector3(0,0,0);

        //Transform squareTransform = GetComponent<Transform>();

        //squareTransform.position = centerPosition;
        gameObject.transform.position = centerPosition;
        //changeColor();
    }


    private void Update()
    {
        Move();
        if (gameObject.transform.position.x > 5 || gameObject.transform.position.x < -5) {

            ChangeDirection();
            ChangeColor();
        }
    }

    private void ChangeDirection() {

        Debug.Log("Byt riktning");
        direction *= -1;
    }


    private void Move()
    {
        Vector3 position = gameObject.transform.position;

        position.x += direction * speed;

        gameObject.transform.position = position;
   }

    private void ChangeColor()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        int random = Random.Range(0, colors.Count);
        spriteRenderer.color = colors[random];

    }
}
