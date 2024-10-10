using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VacuumCleaner.Modes;

//Patron State
namespace VacuumCleaner
{
    public class CleanerController: MonoBehaviour
    {
        [SerializeField] private List<ToolByID> toolsByIDs = new List<ToolByID>();
        private ITool _currentTool;

        private void Start()
        {
            SwitchToTool(0);
        }
        
        public void SwitchToTool(int id)
        {
            var toolById = toolsByIDs.Where(toolById=> toolById.Id == id).FirstOrDefault();

            if(toolById == null)
            {
                Debug.LogError($"No tool for the id {id}");
                return;
            }

            var nextTool = toolById.tool.GetTool();

            if(nextTool == null || nextTool == _currentTool)
            {
                return;
            }

            _currentTool?.PowerOff();

            _currentTool = nextTool;

            _currentTool?.PowerOn();
        }

        private void Update()
        {
            Debug.Log($@"{nameof(CleanerController)}, current mode is: {_currentTool})");
        }
    }
}
