using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int score = 0;

    public void IncreaseScore()
    {
        this.GetComponent<Text>().text = (++score).ToString();
    }
}
