using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : StatItem {

	public enum PotionTypes {
		HEALTH,
		STRENGTH,
		MIXED
	}

	public BasePotion() {
		Stamina = 0;
		Strength = 0;
		Initiative = 0;
		ItemName = "Empty";
	}

	private PotionTypes potion;

	public PotionTypes Potion {
		get{ return potion; }
		set{potion = value;}
	}
}
