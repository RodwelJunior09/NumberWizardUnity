using UnityEngine;
using TMPro;

public class GameWizard : MonoBehaviour
{
    int guess;
    [SerializeField] int maxNumber;
    [SerializeField] int minNumber;
    [SerializeField] TextMeshProUGUI guessText;
    // Start is called before the first frame update
    void Start()
    {
        InitGame();
    }

    public void OnPressLower()
    {
        maxNumber = guess - 1;
        NextGuess();
    }

    public void OnPressHigher()
    {
        minNumber = guess + 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(minNumber, maxNumber + 1);
        guessText.text = guess.ToString();
    }

    void InitGame()
    { 
        NextGuess();
        guessText.text = guess.ToString();
    }
}
