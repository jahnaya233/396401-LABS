using UnityEngine;
using UnityEngine.AI;

namespace Core.FSM
{
    public class ReplantState : BaseState
    {
        public ReplantState(MeshRenderer renderer, NavMeshAgent agent) : base(renderer, agent)
        {
        }

        public override void Enter()
        {
            //When the g key is pressed, the user transitions from the harvest state and enters
            //the plant state and the player turns orange until the planting is done. Then once the p
            //key is pressed the player returns to the patrol state and turns yellow again.

            meshRenderer.material.color = Color.orange;
        }
        public override void Update()
        {
            base.Update();
        }
        public override void Exit()
        {
            base.Exit();
        }
    }
}