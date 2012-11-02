using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Deck {

	List<Card> cards = new List<Card>();
	int discarted;
	
	public Deck(){
		InitializeDeck();
	}
	
	public void InitializeDeck(){
		cards.Clear();
		int number;
		for(int i = 0; i<52; i++){
			cards.Add (new Card());
		}
		for(int i=0; i<(cards.Count/4); i++){
			number = i+1;
			cards[i].SetCard(number, Type.Clover);
			cards[i+13].SetCard(number, Type.Diamond);
			cards[i+26].SetCard(number, Type.Heart);
			cards[i+39].SetCard(number, Type.Pike);
		}
		discarted = 0;
	}
	
	public void SortDeck(){
		cards.Shuffle();
		cards.Shuffle();
		cards.Shuffle();
		cards.Shuffle();
		cards.Shuffle();
		cards.Shuffle();
		
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
