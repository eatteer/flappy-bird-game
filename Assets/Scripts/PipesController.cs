using UnityEngine;

public class PipesController : MonoBehaviour
{
    [SerializeField]
    public float velocity = 1;

    void Update()
    {
        this.transform.Translate(Vector2.left * velocity * Time.deltaTime);
    }
}
