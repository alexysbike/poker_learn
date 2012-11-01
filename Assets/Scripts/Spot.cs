using UnityEngine;
using System.Collections;

public class Spot: ScriptableObject {
	
	int id;
	GameObject cardOne;
	GameObject cardTwo;
	tk2dAnimatedSprite as1;
	tk2dAnimatedSprite as2;
	Vector3 positionOne;
	Vector3 positionTwo;
	bool active = false;
	Player player = new Player();

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
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SetCardOne(Card card){
		player.SetCard1(card);
		as1.Play(card.GetStringName());
	}
	
	public void SetCardTwo(Card card){
		player.SetCard2(card);
		as2.Play(card.GetStringName());
	}
	
	public void SetCards(Card card1, Card card2){
		SetCardOne(card1);
		SetCardTwo(card2);
	}
	
	public void InstantiateCards(GameObject prefab){
		cardOne = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
		cardTwo = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
		as1 = cardOne.GetComponent<tk2dAnimatedSprite>();
		as2 = cardTwo.GetComponent<tk2dAnimatedSprite>();
	}
	
	public void Card1Ubication(){
		cardOne.transform.position = this.positionOne;
	}
	
	public void Card2Ubication(){
		cardTwo.transform.position = this.positionTwo;
	}
	
	public void CardsUbication(){
		Card1Ubication();
		Card2Ubication();
	}
}
