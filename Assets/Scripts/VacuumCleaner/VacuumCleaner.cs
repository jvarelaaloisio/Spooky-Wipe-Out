using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Patron State
public class VacuumCleaner
{
    [SerializeField] private List<ToolByID> toolsByIDs = new List<ToolByID>();
    private ITool _currentTool;
    
    public void SwitchToTool(int id)
    {
        var toolById = toolsByIDs.Where(toolById=> toolById.Id == id).FirstOrDefault();

        if(toolById == null)
        {
            Debug.LogError($"No tool for the id {id}");
            return;
        }

        var nextTool = toolById.tool.GetTool();

        if( nextTool == null || nextTool == _currentTool)
        {
            return;
        }

        _currentTool.PowerOff();

        _currentTool = nextTool;

        _currentTool.PowerOn();
    }

    private class ToolByID
    {
        public int Id;
        public ToolProvider tool;
    }
}
