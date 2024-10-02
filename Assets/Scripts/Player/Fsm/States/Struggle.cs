using Fsm_Mk2;
using UnityEngine;

public class Struggle : State
{
    private GameObject _model;
    private Rigidbody _rigidbody;

    public Struggle(GameObject model)
    {
        _model = model;
    }

    public override void Enter()
    {
        _rigidbody = _model.GetComponent<Rigidbody>();
        
        _rigidbody.constraints = RigidbodyConstraints.FreezePositionX | 
                                 RigidbodyConstraints.FreezePositionY | 
                                 RigidbodyConstraints.FreezePositionZ |
                                 RigidbodyConstraints.FreezeRotation;
    }

    public override void Tick(float delta)
    {
    }

    public override void FixedTick(float delta)
    {
    }

    public override void Exit()
    {
        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }
}