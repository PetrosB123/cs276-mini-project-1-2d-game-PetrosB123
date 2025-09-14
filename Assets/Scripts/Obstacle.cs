using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject Borders;
    public GameObject bounceEffectPrefab;
    public GameObject Pop;
    float minSpeed = 75f;
    float maxSpeed = 300f;
    float minSize = 0.5f;
    float maxSize = 1.5f;
    public float maxSpinSpeed = 10f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
        rb = GetComponent<Rigidbody2D>();

        float randomSpeed = Random.Range(minSpeed, maxSpeed) / randomSize;
        Vector2 randomDirection = Random.insideUnitCircle;
        rb.AddForce(randomDirection * randomSpeed);

        float randomTorque = Random.Range(-maxSpinSpeed, maxSpinSpeed);
        rb.AddTorque(randomTorque);
    }




    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 contactPoint = collision.GetContact(0).point;
        GameObject bounceEffect = Instantiate(bounceEffectPrefab, contactPoint, Quaternion.identity);

        // Destroy the effect after 1 second
        Destroy(bounceEffect, 1f);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bubble(Clone)")
        {
            var popPoint = other.ClosestPoint(transform.position);

            Destroy(other.gameObject);
            Borders.SetActive(false);
            var pop = Object.Instantiate(Pop, popPoint, Quaternion.identity);
            Destroy(pop, 0.1f);
        }
    }
}
