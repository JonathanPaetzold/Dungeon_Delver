using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : StatItem {

	public enum WeaponTypes {
		SWORD,
		DAGGER,
		STAFF
	}

	public BaseWeapon() {
		Stamina = 0;
		Strength = 0;
		Initiative = 0;
		ItemName = "Empty";
	}

	private WeaponTypes weaponType;

	public WeaponTypes WeaponType {
		get{ return weaponType; }
		set{weaponType = value;}
	}
}
