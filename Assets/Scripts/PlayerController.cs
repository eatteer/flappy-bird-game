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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pipe" || collision.tag == "Ground")
        {
            Debug.Log("GameOver");
            gameManager.GetComponent<GameManager>().GameOver();
        }

        if (collision.tag == "ScoreCollider")
        {
            Debug.Log("ScoreCollider");
            scoreUIText.GetComponent<ScoreController>().IncreaseScore();
        }
    }
}
