using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour
{
    public SimBehaviourBase interactingBehaviour;

  public enum InteractTypes
    {
        lamp,
        
    }
    public InteractTypes interactable;

    public void Awake()
    {

        switch (interactable)
        {
            case InteractTypes.lamp:
                interactingBehaviour = new SimBehaviourLamp(this.gameObject);
                break;
           
            
          
        }
    }
    private void Update()
    {
       
    }

}
