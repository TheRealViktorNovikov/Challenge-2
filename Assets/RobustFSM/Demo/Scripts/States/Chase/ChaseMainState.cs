using Assets.RobustFSM.Demo.Scripts.States;
using Assets.SimpleFSM.Demo.Scripts.States.Patrol;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.SimpleFSM.Demo.Scripts.States.Chase
{
    public class ChaseMainState : BCharacterMonoState
    {
        private float _thinkTime;
        private Material _initMaterial;

        public override void OnEnter()
        {
            base.OnEnter();
            // set some stuff
            _thinkTime = 0;
            _initMaterial = Owner.MeshRenderer.material;

            // invoke change material
            InvokeRepeating("ChangeToRandomMaterial", 0.5f, 0.1f);
        }

        public void Update()
        {
            _thinkTime -= Time.deltaTime;
            if (_thinkTime < 0f)
            {
                //find the chase point
                Transform temp = Owner.ChasePoint[0];

                //update target and go to patrol
                Owner.Target = temp;
                SuperMachine.ChangeState<PatrolMainState>();
            }
        }

        public override void OnExit()
        {
            base.OnExit();

            // reset material
            Owner.MeshRenderer.material = _initMaterial;
            CancelInvoke("ChangeToRandomMaterial");
        }

        public void ChangeToRandomMaterial()
        {
            Material choosenMaterial = Owner.Materials[Random.Range(0, Owner.Materials.Count)];
            Owner.MeshRenderer.material = choosenMaterial;
        }
    }
}
