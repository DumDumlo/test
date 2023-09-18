using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Configurable Variables
    [SerializeField] int menuIndex = 0;
    [SerializeField] int startingLevel = 1;

    //Private Variables
    int currentLevel = -1337;
    bool playerDead = false;

    //Cached Refrences

    public static GameManager globalGameManager = null;

    //Called on load
    private void Awake()
    {
        if (GameManager.globalGameManager == null)
        {
            globalGameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && currentLevel != menuIndex)
        {
            OnToMenu();
        }
    }

    public void OnStartAtFirstLevel()
    {
        currentLevel = startingLevel;
        SceneManager.LoadScene(currentLevel);
    }

    public void OnLoadNewLevel(int levelToLoad)
    {
        currentLevel = levelToLoad;
        SceneManager.LoadScene(currentLevel);
    }

    public void OnToMenu()
    {
        currentLevel = menuIndex;
        SceneManager.LoadScene(currentLevel);
    }
}
