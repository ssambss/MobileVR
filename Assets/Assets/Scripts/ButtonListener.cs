using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.Events;

public class ButtonListener : MonoBehaviour
{
	public UnityEvent ActionEvent;


	void Start()
	{
		GetComponent<ButtonController>().InteractableStateChanged.AddListener(InitiateEvent);
	}


	void InitiateEvent(InteractableStateArgs state)
	{
		if (state.NewInteractableState == InteractableState.ActionState)
		{
			ActionEvent.Invoke();
		}
	}
}