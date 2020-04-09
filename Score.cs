using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = player.position.z.ToString("0");   
    }
}
