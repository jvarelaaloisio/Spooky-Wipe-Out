using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectivesUI : MonoBehaviour
{
    private int ghostsQnty;
    private int trashQnty;

    public TextMeshProUGUI textRemainingGhosts;
    public TextMeshProUGUI textRemainingTrash;

    void Update()
    {
        textRemainingGhosts.text = ghostsQnty + " Ghost Remaining";
        textRemainingTrash.text = trashQnty + " Trash Remaining";
    }

    public void SetGhostQnty(int ghostsQnty)
    {
        this.ghostsQnty = ghostsQnty;
    }

    public void SetTrashQnty(int trashQnty)
    {
        this.trashQnty = trashQnty;
    }
}
