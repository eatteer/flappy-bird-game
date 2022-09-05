using UnityEngine;

public class PipesSpawnerController : MonoBehaviour
{
    public float interval = 1.5f;
    private float timeElapsed = 0;
    public float height = 0.5f;
    public GameObject pipes;

    void Update()
    {
        if(timeElapsed > interval)
        {
            GameObject newPipes = Instantiate(pipes);
            float randomY = Random.Range(-height, height);
            newPipes.transform.position = this.transform.position + new Vector3(0, randomY, 0);
            timeElapsed = 0;
            Destroy(newPipes, 10);
        }

        timeElapsed += Time.deltaTime;
    }
}
