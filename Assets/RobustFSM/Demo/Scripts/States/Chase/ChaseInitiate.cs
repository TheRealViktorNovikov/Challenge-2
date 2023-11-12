using Assets.RobustFSM.Demo.Scripts.States;
using RobustFSM.Base;
using UnityEngine;

namespace Assets.SimpleFSM.Demo.Scripts.States.Chase
{
    public class ChaseInitiate : BCharacterMonoState
    {
        public override void Initialize()
        {
            base.Initialize();

            //set a specific name for this state
            StateName = "Chase";
        }

        public override void OnEnter()
        {
            base.OnEnter();
        }

        public void Update()
        {
            Machine.ChangeState<ChaseChoosePoint>();
        }
    }
}
