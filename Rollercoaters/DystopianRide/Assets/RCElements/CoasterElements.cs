using UnityEngine;
using System.Collections;

public class CoasterElements : MonoBehaviour {

    public GameObject Loop;
    public GameObject Twist;
    public GameObject Cobra;
    public GameObject Drop;
    public GameObject Pretzel;
    private int coasterpointer = 10;

    public GameObject FinalCoaster;
	// Use this for initialization
	void Start () {
        coasterpointer = 10;
        Loop.SetActive(false);
        Twist.SetActive(false);
        Cobra.SetActive(false);
        Drop.SetActive(false);
        Pretzel.SetActive(false);

        coasterIndivElements(Loop);
        coasterIndivElements(Drop);
	
	}

    private void coasterIndivElements( GameObject elem )
    {
        Transform parentT = elem.transform;
        FinalCoaster = GameObject.FindWithTag("FinalCoaster");
        foreach( Transform obj in parentT )
        {
            Debug.Log(obj.name);
            obj.name = "" + coasterpointer;
            coasterpointer++;
/*            obj.parent = FinalCoaster.transform;
*/        } 
        Transform t = elem.transform;
        foreach( Transform ob in t )
        {
            Transform clone;
            clone = Instantiate (ob, ob.transform.position, ob.transform.rotation) as Transform;
            clone.parent = FinalCoaster.transform;
        }



    }
    	
}
