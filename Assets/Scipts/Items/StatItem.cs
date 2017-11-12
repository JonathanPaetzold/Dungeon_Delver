using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatItem : BaseItem {

	private int stamina;
	private int strength;
	private int initiative;


	public int Stamina {
		get{ return stamina; }
		set{stamina = value;}
	}

	public int Strength {
		get{ return strength; }
		set{ strength = value; }
	}

	public int Initiative {
		get{ return initiative; }
		set{ initiative = value; }
	}
}
