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
        robo
        
    }
    public InteractTypes interactable;
    public TextMeshPro hoverTextPrefab;
    private TextMeshPro hoverText;
    public void Awake()
    {
        hoverText = Instantiate(hoverTextPrefab);
        hoverText.gameObject.SetActive(false);
        hoverText.text = interactable.ToString();

        switch (interactable)
        {
            case InteractTypes.lamp:
                interactingBehaviour = new SimBehaviourLamp(this.gameObject);
                break;
           
            case InteractTypes.robo:
                interactingBehaviour = new SimBehaviourRoboTalk("BIP BOP  <| º_º|>");
                break;
          
        }
    }
    private void Update()
    {
        hoverText.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseEnter()
    {
        if (this.isActiveAndEnabled)
        {
            hoverText.gameObject.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        if (this.isActiveAndEnabled)
        {
            hoverText.gameObject.SetActive(false);
        }
    }
}
