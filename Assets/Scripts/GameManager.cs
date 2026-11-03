using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private int score = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // Opcional: DontDestroyOnLoad(gameObject); si es vol mantenir entre escenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log($"Coin collected! Score: {score}");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}