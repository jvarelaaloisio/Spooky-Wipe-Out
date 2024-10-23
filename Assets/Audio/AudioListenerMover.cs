using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioListenerMover : MonoBehaviour
{

    private AkAudioListener listenerToMove;
    public string placeToMoveName;
    private GameObject placeToMove;
    private Transform placeToReturn;

    // Start is called before the first frame update
    void Start()
    {
        placeToMoveName = "Manolo";
        StartCoroutine(DelayInitialization());
    }

    IEnumerator DelayInitialization()
    {
        // Wait until the end of the frame
        yield return new WaitForEndOfFrame();

        placeToMove = GameObject.Find(placeToMoveName);

        listenerToMove = FindObjectOfType<AkAudioListener>();
        placeToReturn = listenerToMove.transform.parent;

        if (listenerToMove != null && placeToMove != null)
        {
            listenerToMove.transform.SetParent(placeToMove.transform, false);
            
        }


    }

    public void ReturnListener()
    {
        if (placeToReturn != null)
        {
            listenerToMove.transform.SetParent(placeToReturn, false);
        }
    }
}