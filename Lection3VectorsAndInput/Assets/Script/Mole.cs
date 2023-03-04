using TMPro;
using UnityEngine;

public class Mole : MonoBehaviour
{
    private static int score;
    private static int missedScore;

    [SerializeField] private TextMeshProUGUI scoreTxt;

    private bool missed;

    // Start is called before the first frame update
    private void Start()
    {
        missed = true;
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnDestroy()
    {
        if (missed)
        {
            missedScore++;
            Debug.Log("Missed Score: " + missedScore);
            Debug.Log(" Score: " + score);
        }
    }

    private void OnMouseDown()
    {
        missed = false;
        score++;
        Destroy(gameObject);

        updateScore();
        Debug.Log(" Score: " + score);
    }

    private void updateScore()
    {
        scoreTxt.text = "Scossre: " + score;
    }
}