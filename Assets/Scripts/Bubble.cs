using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float minSpeed = 10f;
    public float maxSpeed = 50f;
    float minSize = 0.75f;
    float maxSize = 1.25f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);

        float speed = Random.Range(minSpeed, maxSpeed) / randomSize;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, 1) * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
