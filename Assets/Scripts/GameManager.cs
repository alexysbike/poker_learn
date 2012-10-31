using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	Deck deck = new Deck();
	float pot;
	float currentBet;
	float minimum;
	Spot[] spots = new Spot[6];

	public float CurrentBet {
		get {
			return this.currentBet;
		}
		set {
			currentBet = value;
		}
	}
	
	public float Pot {
		get {
			return this.pot;
		}
	}	
	
	// Use this for initialization
	void Start () {
		//deck = new Deck();
		pot = 0;
		currentBet = 0;
		spots[0] = ScriptableObject.CreateInstance<Spot>();
		spots[0].PositionOne = new Vector3(-0.15f, 0.25f, 0f);
		spots[0].PositionTwo =new Vector3(0.15f, 0.25f, 0f);
		//spots[1].PositionOne = new Vector3(1.13f, 1.75f, 0f);
		//spots[1].PositionTwo =new Vector3(1.38f, 1.75f, 0f);
		StartMatch ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
                Debug.Log(hit);
            }
		}
	}
	
	public void ClearPot(){
		pot = 0;
	}
	
	public void AddToPot(float amount){
		pot+=amount;
	}
	
	public void StartMatch(){
		deck.InitializeDeck ();
		spots[0].SetCards(deck.DrawCard().GetStringName(), deck.DrawCard().GetStringName());
	}
}
