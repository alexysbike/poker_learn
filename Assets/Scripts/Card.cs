using UnityEngine;
using System.Collections;

public enum Type{
	Diamond,
	Pike,
	Heart,
	Clover
}

public class Card {

	int number;
	Type type;
	bool inDeck;

	public bool InDeck {
		get {
			return this.inDeck;
		}
		set {
			inDeck = value;
		}
	}
	
	public int Number {
		get {
			return this.number;
		}
		set {
			number = value;
		}
	}

	public Type Type {
		get {
			return this.type;
		}
		set {
			type = value;
		}
	}	
	
	public Card(){
		this.inDeck = false;
	}
	
	public void SetCard(int number, Type type){
		this.number = number;
		this.type = type;
	}
	
	public string GetStringName(){
		string name = "undefined";
		switch(type){
		case Type.Clover:name = "clover";
			break;
		case Type.Diamond:name = "diamond";
			break;
		case Type.Heart:name = "heart";
			break;
		case Type.Pike:name = "pike";
			break;
		}
		return name+"_"+number;
	}
}
