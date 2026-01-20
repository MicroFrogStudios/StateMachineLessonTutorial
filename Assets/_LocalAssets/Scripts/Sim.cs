using UnityEngine;

public class Sim : MonoBehaviour
{
    public ISimBehaviour simBehaviour;

    public float speed = 0.5f;
    public float minDistance = 2f;

   

    private void Awake()
    {
        simBehaviour = new SimBehaviourIdle(this);
        simBehaviour.Awake();
    }

    public void changeState(ISimBehaviour behaviour)
    {
        Debug.Log("Changing state to: " + behaviour.ToString());
        simBehaviour.Asleep();
        simBehaviour = behaviour;
        simBehaviour.Awake();
    }

    public void BecomeInterrumpible()
    {
        simBehaviour.IsInterrumpible = true;
    }
    public void Interact(RaycastHit hit)
    {
        simBehaviour.Interact(hit);
    }

    void Update()
    {
        simBehaviour.Update();
    }

}
