using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuButtons : MonoBehaviour {
	
	public Canvas FirstScreen;
	public Canvas ConstructionScreen;
	public Canvas UndergroundScreen;
	public Canvas EscapeScreen;
	
	public Canvas CFirstElementScreen;
	public Canvas CSecondElementScreen;
	public Canvas CThirdElementScreen;
	public Canvas CFourthElementScreen;
	
	public Button ConstructionButton;
	public Button UndergroundButton;
	public Button EscapeButton;
	
	public Button ConstructionAButton;
	public Button ConstructionBButton;
	public Button ConstructionCButton;
	public Button ConstructionDButton;
	
	public Button UndergroundAButton;
	public Button UndergroundBButton;
	public Button UndergroundCButton;
	public Button UndergroundDButton;
	
	public Button EscapeAButton;
	public Button EscapeBButton;
	public Button EscapeCButton;
	public Button EscapeDButton;
	
	public Button CFirstElementAButton;
	public Button CFirstElementBButton;
	public Button CFirstElementCButton;
	public Button CFirstElementDButton;
	
	public Button CSecondElementAButton;
	public Button CSecondElementBButton;
	public Button CSecondElementCButton;
	public Button CSecondElementDButton;
	
	public Button CThirdElementAButton;
	public Button CThirdElementBButton;
	public Button CThirdElementCButton;
	public Button CThirdElementDButton;
	
	public Button CFourthElementAButton;
	public Button CFourthElementBButton;
	public Button CFourthElementCButton;
	public Button CFourthElementDButton;
	
	// Use this for initialization
	void Start () {
		FirstScreen        = FirstScreen.GetComponent<Canvas> ();
		ConstructionScreen = ConstructionScreen.GetComponent<Canvas> ();
		UndergroundScreen  = UndergroundScreen.GetComponent<Canvas> ();
		EscapeScreen       = EscapeScreen.GetComponent<Canvas> ();
		
		ConstructionButton = ConstructionButton.GetComponent<Button> ();
		UndergroundButton  = UndergroundButton.GetComponent<Button> ();
		EscapeButton       = EscapeButton.GetComponent<Button> ();
		
		CFirstElementScreen       = CFirstElementScreen.GetComponent<Canvas> ();
		CSecondElementScreen      = CSecondElementScreen.GetComponent<Canvas> ();
		CThirdElementScreen       = CThirdElementScreen.GetComponent<Canvas> ();
		CFourthElementScreen      = CFourthElementScreen.GetComponent<Canvas> ();
		
		ConstructionAButton = ConstructionAButton.GetComponent<Button> ();
		ConstructionBButton = ConstructionBButton.GetComponent<Button> ();
		ConstructionCButton = ConstructionCButton.GetComponent<Button> ();
		ConstructionDButton = ConstructionDButton.GetComponent<Button> ();
		
		UndergroundAButton = UndergroundAButton.GetComponent<Button> ();
		UndergroundBButton = UndergroundBButton.GetComponent<Button> ();
		UndergroundCButton = UndergroundCButton.GetComponent<Button> ();
		UndergroundDButton = UndergroundDButton.GetComponent<Button> ();
		
		EscapeAButton = EscapeAButton.GetComponent<Button> ();
		EscapeBButton = EscapeBButton.GetComponent<Button> ();
		EscapeCButton = EscapeCButton.GetComponent<Button> ();
		EscapeDButton = EscapeDButton.GetComponent<Button> ();
		
		CFirstElementAButton = CFirstElementAButton.GetComponent<Button> ();
		CFirstElementBButton = CFirstElementBButton.GetComponent<Button> ();
		CFirstElementCButton = CFirstElementCButton.GetComponent<Button> ();
		CFirstElementDButton = CFirstElementDButton.GetComponent<Button> ();
		
		CSecondElementAButton = CSecondElementAButton.GetComponent<Button> ();
		CSecondElementBButton = CSecondElementBButton.GetComponent<Button> ();
		CSecondElementCButton = CSecondElementCButton.GetComponent<Button> ();
		CSecondElementDButton = CSecondElementDButton.GetComponent<Button> ();
		
		CThirdElementAButton = CThirdElementAButton.GetComponent<Button> ();
		CThirdElementBButton = CThirdElementBButton.GetComponent<Button> ();
		CThirdElementCButton = CThirdElementCButton.GetComponent<Button> ();
		CThirdElementDButton = CThirdElementDButton.GetComponent<Button> ();
		
		CFourthElementAButton = CFourthElementAButton.GetComponent<Button> ();
		CFourthElementBButton = CFourthElementBButton.GetComponent<Button> ();
		CFourthElementCButton = CFourthElementCButton.GetComponent<Button> ();
		CFourthElementDButton = CFourthElementDButton.GetComponent<Button> ();
		
		FirstScreen.enabled        = true;
		ConstructionScreen.enabled = false;
		UndergroundScreen.enabled  = false;
		EscapeScreen.enabled       = false;
		
		ConstructionButton.enabled = true;
		UndergroundButton.enabled  = true;
		EscapeButton.enabled       = true;   

		CFirstElementScreen.enabled  = false;
		CSecondElementScreen.enabled = false;
		CThirdElementScreen.enabled  = false;
		CFourthElementScreen.enabled = false;
		
		ConstructionAButton.enabled = false;;
		ConstructionBButton.enabled = false;;
		ConstructionCButton.enabled = false;;
		ConstructionDButton.enabled = false;;
		
		UndergroundAButton.enabled = false;
		UndergroundBButton.enabled = false;
		UndergroundCButton.enabled = false;
		UndergroundDButton.enabled = false;
		
		EscapeAButton.enabled = false;
		EscapeBButton.enabled = false;
		EscapeCButton.enabled = false;
		EscapeDButton.enabled = false;
		
		CFirstElementAButton.enabled = false;
		CFirstElementBButton.enabled = false;
		CFirstElementCButton.enabled = false;
		CFirstElementDButton.enabled = false;
		
		CSecondElementAButton.enabled = false;
		CSecondElementBButton.enabled = false;
		CSecondElementCButton.enabled = false;
		CSecondElementDButton.enabled = false;
		
		CThirdElementAButton.enabled = false;
		CThirdElementBButton.enabled = false;
		CThirdElementCButton.enabled = false;
		CThirdElementDButton.enabled = false;
		
		CFourthElementAButton.enabled = false;
		CFourthElementBButton.enabled = false;
		CFourthElementCButton.enabled = false;
		CFourthElementDButton.enabled = false;
	}
	
	public void ConstructionScreenPress()
	{
		FirstScreen.enabled        = false;
		ConstructionButton.enabled = false;
		EscapeButton.enabled       = false;
		UndergroundButton.enabled  = false;
		
		ConstructionScreen.enabled  = true;
		ConstructionAButton.enabled = true;
		ConstructionBButton.enabled = true;
		ConstructionCButton.enabled = true;
		ConstructionDButton.enabled = true;
		
	}
	
	public void TransportationPicked()
	{
		ConstructionScreen.enabled = false;
		ConstructionAButton.enabled = false;
		ConstructionBButton.enabled = false;
		ConstructionCButton.enabled = false;
		ConstructionDButton.enabled = false;
		
		CFirstElementScreen.enabled = true;
		CFirstElementAButton.enabled = true;
		CFirstElementBButton.enabled = true;
		CFirstElementCButton.enabled = true;
		CFirstElementDButton.enabled = true;
	}
	
	public void CFirstElementPicked()
	{
		CFirstElementScreen.enabled = false;
		CFirstElementAButton.enabled = false;
		CFirstElementBButton.enabled = false;
		CFirstElementCButton.enabled = false;
		CFirstElementDButton.enabled = false;
		
		CSecondElementScreen.enabled = true;
		CSecondElementAButton.enabled = true;
		CSecondElementBButton.enabled = true;
		CSecondElementCButton.enabled = true;
		CSecondElementDButton.enabled = true;
	}
	
	public void CSecondElementPicked()
	{
		CSecondElementScreen.enabled = false;
		CSecondElementAButton.enabled = false;
		CSecondElementBButton.enabled = false;
		CSecondElementCButton.enabled = false;
		CSecondElementDButton.enabled = false;
		
		CThirdElementScreen.enabled = true;
		CThirdElementAButton.enabled = true;
		CThirdElementBButton.enabled = true;
		CThirdElementCButton.enabled = true;
		CThirdElementDButton.enabled = true;
	}
	
	public void CThirdElementPicked()
	{
		CThirdElementScreen.enabled = false;
		CThirdElementAButton.enabled = false;
		CThirdElementBButton.enabled = false;
		CThirdElementCButton.enabled = false;
		CThirdElementDButton.enabled = false;
		
		CFourthElementScreen.enabled = true;
		CFourthElementAButton.enabled = true;
		CFourthElementBButton.enabled = true;
		CFourthElementCButton.enabled = true;
		CFourthElementDButton.enabled = true;
	}
	
	public void CFourthElementPicked()
	{
		CFourthElementScreen.enabled = false;
		CFourthElementAButton.enabled = false;
		CFourthElementBButton.enabled = false;
		CFourthElementCButton.enabled = false;
		CFourthElementDButton.enabled = false;
	}
	
}
