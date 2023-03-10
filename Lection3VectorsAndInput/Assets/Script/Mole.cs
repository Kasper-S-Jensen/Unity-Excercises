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
        //   scoreTxt = GetComponent<TextMeshProUGUI>();
        missed = true;
        Destroy(gameObject, 2f);
        UpdateScore();
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


        UpdateScore();
        Destroy(gameObject);
        Debug.Log(" Score: " + score);
    }

    private void UpdateScore()
    {
        scoreTxt.enabled = false;
        print("inside update score");
        scoreTxt.text = "Scoriie: " + score;
        Canvas.ForceUpdateCanvases();
    }
}