using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumCleaner
{
    private IVacuumMode _currentMode;

    public void ActivateVacuumMode()
    {
        _currentMode.Use();
    }
}
