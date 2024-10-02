using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ghosts
{
    public class Ghost : MonoBehaviour
    {
        public Action<Ghost> OnBeingDestroy;
    }
}