using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArmour : StatItem {

	public BaseArmour() {
		Stamina = 0;
		Strength = 0;
		Initiative = 0;
		ItemName = "Empty";
	}

	public enum ArmourTypes {
		CHEST,
		HELMET,
		BOOTS
	}

	private ArmourTypes armour;

	public ArmourTypes Armour {
		get{ return armour;  }
		set{armour = value;}
	}
}
