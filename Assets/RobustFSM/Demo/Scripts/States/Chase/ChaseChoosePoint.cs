using Assets.SimpleFSM.Demo.Scripts.States.Patrol;
using RobustFSM.Base;
using UnityEngine;

namespace Assets.SimpleFSM.Demo.Scripts.States.Chase
{
    public class ChaseChoosePoint : MonoHState
    {
        public override void AddStates()
        {
            AddState<ChaseInitiate>();
            AddState<ChaseMainState>();
            AddState<Initiate>();

            SetInitialState<ChaseMainState>();
        }
    }
}
