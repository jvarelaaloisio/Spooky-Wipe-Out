using System.Collections;
using System.Collections.Generic;
using EventSystems.EventSceneManager;
using Player.FSM;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;
    
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private string menuSceneName;
    
    [SerializeField] private EventChannelSceneManager eventChannelSceneManager;

    private void Start()
    {
        inputReader.OnPauseStart += InitPauseMenu;
    }

    private void InitPauseMenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void Restart()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        eventChannelSceneManager.OnRemoveScene(gameObject.scene.name);
        eventChannelSceneManager.OnAddScene(gameObject.scene.name);
    }
    
    public void GoMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        eventChannelSceneManager.OnAddScene(menuSceneName);
        eventChannelSceneManager.OnRemoveScene(gameObject.scene.name);
    }
}
