using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourGenerator : MonoBehaviour {

	private static BaseArmour armour;

	public static BaseArmour generate(int round) {
		int ctr = 0;
		armour = new BaseArmour ();
		ctr++;
		pickArmourType ();
		switch (armour.Armour) {
		case(BaseArmour.ArmourTypes.HELMET):
			armour.Stamina = Random.Range (3, 6) + (int)(round * 0.5);
			armour.Initiative = Random.Range (1, 2) + (int)(round * 0.1);
			armour.ItemName = "+" + armour.Stamina.ToString();
			break;
		case(BaseArmour.ArmourTypes.CHEST):
			armour.Strength = Random.Range (2, 4) + (int)(round * 0.25);
			armour.Stamina = Random.Range (6, 10) + (int)(round * 0.6);
			armour.ItemName = "+" + armour.Stamina + "/+" + armour.Strength ;
			break;
		case(BaseArmour.ArmourTypes.BOOTS):
			armour.Stamina = Random.Range (1, 3) + (int)(round * 0.15);
			armour.Strength = Random.Range (2, 4) + (int)(round * 0.2);
			armour.ItemName = "+" + armour.Stamina + "/+" + armour.Strength ;
			break;

		}
		return armour;
	}


	private static void pickArmourType() {
		int temp = Random.Range (1, 4);
		if (temp == 1) {
			armour.Armour = BaseArmour.ArmourTypes.BOOTS;
		}
		else if (temp == 2) {
			armour.Armour = BaseArmour.ArmourTypes.CHEST;
		}
		else if (temp == 3) {
			armour.Armour = BaseArmour.ArmourTypes.HELMET;
		}
	}
}
