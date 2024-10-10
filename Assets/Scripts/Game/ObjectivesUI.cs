using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectivesUI : MonoBehaviour
{
    public TextMeshProUGUI textRemainingGhosts;
    public TextMeshProUGUI textRemainingTrash;

    public void SetGhostQnty(int ghostsQnty)
    {
        textRemainingGhosts.text = ghostsQnty + " Ghost Remaining";
    }

    public void SetTrashQnty(int trashQnty)
    {
        textRemainingTrash.text = trashQnty + " Trash Remaining";
    }
}
