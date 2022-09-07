using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject scoreUIText;

    [SerializeField]
    private float velocity = 1;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pipe" || collision.tag == "Ground")
        {
            gameManager.GetComponent<GameManager>().GameOver();
        }

        if (collision.tag == "ScoreCollider")
        {
            scoreUIText.GetComponent<ScoreController>().IncreaseScore();
        }
    }
}
