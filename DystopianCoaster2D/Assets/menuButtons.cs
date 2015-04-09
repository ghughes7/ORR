using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuButtons : MonoBehaviour {

	public Canvas FirstScreen;
	public Canvas FirstFirstScreen;
	public Canvas SecondFirstScreen;
	public Canvas ThirdFirstScreen;
	public Canvas FourthFirstScreen;

	public Button FirstAButton;
	public Button FirstBButton;
	public Button FirstCButton;
	public Button FirstDButton;

	public Button SecondAButton;
	public Button SecondBButton;
	public Button SecondCButton;
	public Button SecondDButton;
	
	public Button ThirdAButton;
	public Button ThirdBButton;
	public Button ThirdCButton;
	public Button ThirdDButton;
	
	public Button FourthAButton;
	public Button FourthBButton;
	public Button FourthCButton;
	public Button FourthDButton;

	// Use this for initialization
	void Start () {
		FirstScreen = FirstScreen.GetComponent<Canvas> ();
		FirstFirstScreen = FirstFirstScreen.GetComponent<Canvas> ();
		SecondFirstScreen = SecondFirstScreen.GetComponent<Canvas> ();
		ThirdFirstScreen = ThirdFirstScreen.GetComponent<Canvas> ();
		FourthFirstScreen = FourthFirstScreen.GetComponent<Canvas> ();

		FirstAButton = FirstAButton.GetComponent<Button> ();
		FirstBButton = FirstBButton.GetComponent<Button> ();
		FirstCButton = FirstCButton.GetComponent<Button> ();
		FirstDButton = FirstDButton.GetComponent<Button> ();

		SecondAButton = SecondAButton.GetComponent<Button> ();
		SecondBButton = SecondBButton.GetComponent<Button> ();
		SecondCButton = SecondCButton.GetComponent<Button> ();
		SecondDButton = SecondDButton.GetComponent<Button> ();
		
		ThirdAButton = ThirdAButton.GetComponent<Button> ();
		ThirdBButton = ThirdBButton.GetComponent<Button> ();
		ThirdCButton = ThirdCButton.GetComponent<Button> ();
		ThirdDButton = ThirdDButton.GetComponent<Button> ();
		
		FourthAButton = FourthAButton.GetComponent<Button> ();
		FourthBButton = FourthBButton.GetComponent<Button> ();
		FourthCButton = FourthCButton.GetComponent<Button> ();
		FourthDButton = FourthDButton.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
