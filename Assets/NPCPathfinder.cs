using UnityEngine;
using Pathfinding;
public class NPCPathfinder : MonoBehaviour
{
    AIPath aIPath;
    public Transform target;

    void Start()
    {
        aIPath = GetComponent<AIPath>();
    }
    void Update()
        {
            aIPath.destination = target.position;
        }
}