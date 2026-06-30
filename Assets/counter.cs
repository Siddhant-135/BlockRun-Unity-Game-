using UnityEngine;
using TMPro;

public class counter : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Transform player;
    private float startingPosition;

    void Start()
    {
        scoreText.text = "Travel further for higher score!";
        startingPosition = player.position.x;
    }

    void Update()
    {
        scoreText.text = "Distance: " + (player.position.x - startingPosition).ToString("F0") + "m";
    }
}
