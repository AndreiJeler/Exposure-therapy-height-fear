/*
InteractManager.cs - wirted by ThunderWire Games * Script for Interact Buttons, Items etc.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InteractManager : MonoBehaviour {
	
	public float PickupRange = 3; 
	public string UseButton = "Fire1";
	
	private GameObject playerCam;
	private Ray playerAim;
	
	private bool isPressed;
	private GameObject objectInteract;

	public GameObject EasterEggText1;
	public GameObject EasterEggText2;
	public GameObject EasterEggText3;



	void Start () {
		playerCam = Camera.main.gameObject;
		isPressed = false;
		objectInteract = null;
		EasterEggText1.SetActive(false);
		EasterEggText2.SetActive(false);
		EasterEggText3.SetActive(false);


	}

	void Update () {
		if(Input.GetButton(UseButton) && !isPressed){
			Interact();
			isPressed = true;
		}
		if(Input.GetButtonUp(UseButton) && isPressed){
			isPressed = false;
		}
	}
	
	private void Interact(){
		Ray playerAim = playerCam.GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		RaycastHit hit;
		
		if (Physics.Raycast (playerAim, out hit, PickupRange)){
			objectInteract = hit.collider.gameObject;
			if(hit.collider.tag == "ElevatorUp"){
				InteractUse("ElevatorUp");
			}
			if(hit.collider.tag == "ElevatorDown"){
				InteractUse("ElevatorDown");
			}
			if (hit.collider.tag == "computer")
			{
				OpenEasterEgg1();
			}
			if (hit.collider.tag == "keyboard")
			{
				OpenEasterEgg2();
			}
            if (hit.collider.tag == "easterEgg")
            {
				OpenEasterEggFinal();
            }
		}
	}
	
    private void InteractUse(string Call)
    {
		objectInteract.GetComponent<ElevatorButton>().SendCall(Call);
    }

	private void OpenEasterEgg1()
    {
		EasterEggText1.SetActive(true);
    }

	private void OpenEasterEgg2()
	{
		EasterEggText2.SetActive(true);
	}
	private void OpenEasterEggFinal()
	{
		Debug.Log("Congrats");
		EasterEggText3.SetActive(true);
	}
}
