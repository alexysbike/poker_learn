using UnityEngine;
using System.Collections;

public class Spot: ScriptableObject {
	
	int id;
	GameObject cardOne;
	GameObject cardTwo;
	Vector3 positionOne;
	Vector3 positionTwo;
	bool active = false;
	Player player;

	public bool Active {
		get {
			return this.active;
		}
		set {
			active = value;
		}
	}
	
	public Vector3 PositionOne {
		get {
			return this.positionOne;
		}
		set {
			positionOne = value;
		}
	}

	public Vector3 PositionTwo {
		get {
			return this.positionTwo;
		}
		set {
			positionTwo = value;
		}
	}	
	// Use this for initialization
	void OnEnable () {
		cardOne = (GameObject)Resources.Load("CardPrefab");
		cardTwo = (GameObject)Resources.Load("CardPrefab");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SetCardOne(string cardName){
		tk2dAnimatedSprite card = cardOne.GetComponent<tk2dAnimatedSprite>();
		card.Play (cardName);
	}
	
	public void SetCardTwo(string cardName){
		tk2dAnimatedSprite card = cardTwo.GetComponent<tk2dAnimatedSprite>();
		card.Play (cardName);
	}
	
	public void SetCards(string cardOneName, string cardTwoName){
		this.cardOne = Resources.Load("CardPrefab") as GameObject;
		this.cardTwo = Resources.Load("CardPrefab") as GameObject;
		tk2dAnimatedSprite cardOne = this.cardOne.GetComponent<tk2dAnimatedSprite>();
		cardOne.Play (cardOneName);
		tk2dAnimatedSprite cardTwo = this.cardTwo.GetComponent<tk2dAnimatedSprite>();
		cardTwo.Play (cardTwoName);
	}
	
	public void InstantiateCards(){
		Instantiate(cardOne, Vector3.zero, Quaternion.identity);
		Instantiate(cardTwo, Vector3.zero, Quaternion.identity);
	}
}
