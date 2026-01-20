using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{


    public Sim sim;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleMouseInput();
        }
    }


    private void HandleMouseInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            TryInteract(hit);
        }
    }

    private void TryInteract(RaycastHit hit)
    {
        Debug.Log("Tocando " + hit.transform.name);
        
            sim.Interact(hit);
    }
}
