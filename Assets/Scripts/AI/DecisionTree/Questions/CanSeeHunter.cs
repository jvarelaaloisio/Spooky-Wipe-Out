using UnityEngine;

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
            Vector3 hunterPosition = data.hunter.position.IgnoreY();
            Vector3 selfPosition = data.self.transform.position.IgnoreY();

            var result = Vector3.Distance(hunterPosition, selfPosition) <= data.self.viewHunterDistance;

            //Debug.Log($"La distancia fue {Vector3.Distance(hunterPosition, selfPosition)}");
            
            return result ? 0 : 1;
        }

        return 1;
    }
}
