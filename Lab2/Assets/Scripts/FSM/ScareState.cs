using UnityEngine;
using UnityEngine.AI;

namespace Core.FSM
{
    public class ScareState : BaseState
    {
        public ScareState(MeshRenderer renderer, NavMeshAgent agent) : base(renderer, agent)
        {
        }

        public override void Enter()
        {
            //When the s key is pressed, the user transitions from the patrol state and enters
            //the scare state when an animal is found eating crops. The player turns red until 
            //the animal has been scared away. Then once the p key is pressed the player returns
            //to the patrol state and turns yellow again.

            meshRenderer.material.color = Color.red;
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