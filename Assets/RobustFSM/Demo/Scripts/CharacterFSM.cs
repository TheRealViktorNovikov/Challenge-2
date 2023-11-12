using RobustFSM.Base;
using Assets.SimpleFSM.Demo.Scripts.States.Idle;
using Assets.SimpleFSM.Demo.Scripts.States.Patrol;
using Assets.SimpleFSM.Demo.Scripts.States.Chase;

namespace Assets.SimpleFSM.Demo.Scripts
{
    public class CharacterFSM : MonoFSM<Character>
    {
        public override void AddStates()
        {
            //add the states
            AddState<IdleMainState>();
            AddState<PatrolMainState>();
            AddState<ChaseChoosePoint>();

            //set the initial state
            SetInitialState<IdleMainState>();
        }
    }
}
