using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolProvider : MonoBehaviour
{
    public ITool GetTool()
    {
        var tool = GetComponent<ITool>();
        if (tool != null)
        {
            return tool;
        }

        Debug.LogError("No tool found");
        return null;
    }
}
