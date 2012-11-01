using UnityEngine;
using System.Collections;
using System;

public class Deck {

	Card[] cards;
	int discarted;
	
	public Deck(){
		this.cards = new Card[52];
		InitializeDeck();
	}
	
	public void InitializeDeck(){
		int number;
		for(int i=0; i<(cards.Length/4); i++){
			number = i+1;
			cards[i] = new Card();
			cards[(number*2)-1]=new Card();
			cards[(number*3)-1]=new Card();
			cards[(number*4)-1]=new Card();
			cards[i].SetCard(number, Type.Clover);
			cards[(number*2)-1].SetCard(number, Type.Diamond);
			cards[(number*3)-1].SetCard(number, Type.Heart);
			cards[(number*4)-1].SetCard(number, Type.Pike);
		}
		discarted = 0;
	}
	
	public void SortDeck(){
		System.Random rand = new System.Random();
		Array.Sort<Card>(cards, delegate(Card x, Card y) {
			return (x.Equals(y))?0:rand.Next(-1, 2);
		});
		/*Card switcher;
		int random;
		for(int i = 0; i<cards.Length; i++){
			random = Random.Range (0,51);
			switcher = cards[i];
			cards[i] = cards[random];
			cards[random] = switcher;
		}*/
	}
	
	public Card DrawCard(){
		cards[discarted].InDeck = true;
		discarted++;
		return cards[discarted-1];
	}
	
	public int CurrrentsCard(){
		return 52-discarted;
	}
	
}
