using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITool
{
    event Action OnPowerOn;
    event Action OnPowerOff;

    void PowerOn();
    void PowerOff();
}
