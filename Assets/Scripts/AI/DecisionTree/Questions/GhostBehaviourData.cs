using UnityEngine;
using Ghosts;

public struct GhostBehaviourData
{
    public GhostBehaviourData(WalkingGhostAgent self, Transform hunter)
    {
        this.self = self;
        this.hunter = hunter;
    }

    public WalkingGhostAgent self { get; set; }

    public Transform hunter{ get; set; }
}
