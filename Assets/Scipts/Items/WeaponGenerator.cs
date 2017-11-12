using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGenerator : MonoBehaviour {

	private static BaseWeapon weapon;

	public static BaseWeapon generate(int round) {
		int ctr = 0;
		weapon = new BaseWeapon ();
		ctr++;
		pickWeaponType ();
		switch (weapon.WeaponType) {
		case(BaseWeapon.WeaponTypes.SWORD):
			weapon.Strength = Random.Range (3, 7) + (int)(round * 0.6);
			weapon.Initiative = Random.Range (1, 2) + (int)(round * 0.1);
			weapon.ItemName = "Sword: +" + weapon.Strength;
			break;
		case(BaseWeapon.WeaponTypes.DAGGER):
			weapon.Strength = Random.Range (1, 4) + (int)(round * 0.2);
			weapon.Initiative = Random.Range (3, 8) + (int)(round * 0.1);
			weapon.ItemName = "Dagger: +" + weapon.Strength;
			break;
		case(BaseWeapon.WeaponTypes.STAFF):
			weapon.Strength = Random.Range (3, 5) + (int)(round * 0.35);
			weapon.Initiative = Random.Range (2, 5) + (int)(round * 0.1);
			weapon.ItemName = "Staff: +" + weapon.Strength;
			break;
		
		}
		return weapon;
	}


	private static void pickWeaponType() {
		int temp = Random.Range (1, 4);
		if (temp == 1) {
			weapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		}
		else if (temp == 2) {
			weapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		}
		else if (temp == 3) {
			weapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}
	}
		
}
