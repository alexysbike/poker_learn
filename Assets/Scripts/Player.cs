using UnityEngine;
using System.Collections;

public class Player {
	
	string id;
	string name;
	Card[] cards;
	float money;
	float currentBet;
	Spot spot;

	public Spot Spot {
		get {
			return this.spot;
		}
		set {
			spot = value;
		}
	}
	
	public float CurrentBet {
		get {
			return this.currentBet;
		}
	}

	public float Money {
		get {
			return this.money;
		}
	}	
	public Player(){
		cards =new Card[2];
		money = 0;
		currentBet = 0;
	}
	
	public void Bet(float bet){
		currentBet = bet;
		money -= bet;
	}
	
	public void collectPot(float pot){
		money += pot;
	}
}
