using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{

    public Button button1; // define button. 
    public Button start; // define button. 
    public Button quit; // define button. 
    public GameObject Panel; 

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(Level); // when we click on button ,execute 'Level function'.
        start.onClick.AddListener(KneeStart); // when we click on button ,execute 'KneeStart function'.
        quit.onClick.AddListener(QuitButton); // when we click on button ,execute 'QuitButton function'.
        
    }
    void Level()
    {
        Panel.SetActive(true);  //activate panel.
    }
    void KneeStart()
    {
        SceneManager.LoadScene("Room");  // Go to room scene

    }
    void QuitButton()
    {
        Panel.SetActive(false);  //deactivate panel.
        
    }
}
