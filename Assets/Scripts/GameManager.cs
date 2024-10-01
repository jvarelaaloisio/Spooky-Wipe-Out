using System.Collections.Generic;
using System.Linq;
using Gameplay.Timer;
using UnityEngine;
using Ghosts;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Timer timer;
    [SerializeField] private List<Ghost> ghosts;
    [SerializeField] private List<Trash> garbage;
    [SerializeField] private string nextScene;

    private static GameManager _instance;


    void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            // Si ya existe una instancia y no es esta, se destruye el objeto duplicado
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        _instance = null;
    }

    public static GameManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = FindObjectOfType<GameManager>();
        }

        return _instance;
    }

    public bool IsAnyGhost()
    {
        return ghosts.Any(ghost => ghost.isActiveAndEnabled);
    }
    
    public bool IsAnyGarbage()
    {
        return garbage.Any(trash => trash.isActiveAndEnabled);
    }

    public float GetTimeLeft()
    {
        return timer.GetTime();
    }

    private void Update()
    {
        if (timer.finished || (!IsAnyGhost() && !IsAnyGarbage()))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}