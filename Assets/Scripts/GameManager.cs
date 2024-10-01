using System.Collections.Generic;
using System.Linq;
using Gameplay.Timer;
using UnityEngine;
using Ghosts;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private ObjectivesUI objectivesUI;
    public List<Ghost> ghosts;
    public List<Trash> garbage;
    [SerializeField] private string nextScene;

    private int ghostCounter = 0;

    private static GameManager _instance;

    IEnumerator Start()
    {
        yield return null;

        ghostCounter = ghosts.Count;


        foreach (Trash trash in garbage )
        {
            trash.OnDestroy += RemoveTrash;
        }
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            // Si ya existe una instancia y no es esta, se destruye el objeto duplicado
            Destroy(gameObject);
        }

        objectivesUI.SetTrashQnty(garbage.Count);
    }

    private void OnDestroy()
    {
        _instance = null;
    }

    private void RemoveTrash(Trash trash)
    {
        trash.OnDestroy -= RemoveTrash;
        garbage.Remove(trash);
        objectivesUI.SetTrashQnty(garbage.Count);
        Debug.Log("The trash has been destroyed");
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
        objectivesUI.SetGhostQnty(ghostCounter);

        if (timer.finished || (!IsAnyGhost() && !IsAnyGarbage()))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}