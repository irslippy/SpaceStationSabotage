using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
public class ShootGun : MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;
    public GameObject LiveProjectile;
    public InputActionReference shootAction;
    private XRBaseInteractor interactor;
    private ActionBasedController actionController;
    public Transform launchPostition;
    public float velocity;
    public void GetInteractor()
    {
        interactor = grabInteractable.selectingInteractor;
    }

    public void ReleaseInteractor()
    {
        interactor = null;
    }

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(Shoot);
        shootAction.action.started += Shoot;
    }

    private void Shoot(ActivateEventArgs arg0)
    {
           Destroy(grabInteractable);
           LaunchPowercell();
    }

    private void Shoot(InputAction.CallbackContext obj)
    {
        if (obj.control.ToString().Contains("Right") && interactor.name.Contains("Right"))
        {
            Destroy(grabInteractable);
            LaunchPowercell();
        }
    }

    void LaunchPowercell()
    {
        GameObject cell =Instantiate(LiveProjectile, launchPostition.transform.position, launchPostition.transform.rotation);
        Rigidbody rb = cell.GetComponent<Rigidbody>();
        rb.AddRelativeForce(launchPostition.transform.forward * velocity, ForceMode.VelocityChange);
    }
    
}
