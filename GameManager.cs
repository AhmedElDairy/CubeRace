using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gamEnded = false;

    public float RestarDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

   public void GameOver()
    {        
        if(gamEnded == false)
        {
            gamEnded = true;
           // Debug.Log("");
           Invoke("Restart",RestarDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
     
    
}
