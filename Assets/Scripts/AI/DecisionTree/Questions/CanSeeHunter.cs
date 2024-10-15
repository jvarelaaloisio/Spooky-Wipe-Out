using UnityEngine;
using Ghosts;

public class CanSeeHunter : AI.DecisionTree.TreeQuestion
{
    public override int CheckCondition()
    {
        var hunter = GameObject.FindGameObjectWithTag("Player");

        if (hunter == null)
        {
            return 1;
        }

        if(getData() is GhostBehaviourData data)
        {
            // set using data.self.<<something>>

            float viewDistance = 5;
            var result = Vector3.Distance(data.hunter.position.IgnoreY(), data.self.transform.position.IgnoreY()) < viewDistance;
            return result ? 0 : 1;
        }

        return 1;
    }
}
public struct GhostBehaviourData
{
    public WalkingGhostAgent self { get; set; }
    public Transform hunter{ get; set; }
}
