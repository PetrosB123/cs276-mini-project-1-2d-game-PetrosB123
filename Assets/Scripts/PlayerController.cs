using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    private Label highScoreText;
    private Button restartButton;
    public GameObject explosionEffect;
    public GameObject Pop;
    private Label scoreText;
    public UIDocument uiDocument;
    private float score = 0f;
    public float scoreMultiplier = 10f;
    public float thrustForce = 1.5f;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
        highScoreText = uiDocument.rootVisualElement.Q<Label>("HighScoreLabel");
        rb = GetComponent<Rigidbody2D>();

        restartButton = uiDocument.rootVisualElement.Q<Button>("RestartButton");
        restartButton.style.display = DisplayStyle.None;

        restartButton.clicked += ReloadScene;

        scoreText.text = "Score: " + score;

            if (PlayerPrefs.GetFloat("highscore") < score)
                {
                PlayerPrefs.SetFloat("highscore", score);
                }
            highScoreText.text = "High Score: " + PlayerPrefs.GetFloat("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            // Calculate mouse direction
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (mousePos - transform.position).normalized;

            // Move player in direction of mouse
            transform.up = direction;
            rb.AddForce(direction * thrustForce);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        restartButton.style.display = DisplayStyle.Flex;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bubble(Clone)")
        {
            score += 1;

            var popPoint = other.ClosestPoint(transform.position);

            Destroy(other.gameObject);
            var pop = Object.Instantiate(Pop, popPoint, Quaternion.identity);
            Destroy(pop, 0.1f);

            scoreText.text = "Score: " + score;

            if (PlayerPrefs.GetFloat("highscore") < score)
                {
                PlayerPrefs.SetFloat("highscore", score);
                }
            highScoreText.text = "High Score: " + PlayerPrefs.GetFloat("highscore");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }   
}
