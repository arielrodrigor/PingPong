using UnityEngine;
using TMPro;  // Importar TMPro en lugar de UnityEngine.UI

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText; // Cambiar de Text a TextMeshProUGUI
    public TextMeshProUGUI aiScoreText;  // Cambiar de Text a TextMeshProUGUI

    private int playerScore = 0;
    private int aiScore = 0;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }

    public void AIScores()
    {
        aiScore++;
        aiScoreText.text = aiScore.ToString();
    }
}
