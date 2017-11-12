using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionGenerator : MonoBehaviour {

	private static BasePotion potion;

	public static BasePotion generate(int round) {
		int ctr = 0;
		potion = new BasePotion ();
		ctr++;
		pickPotionType ();
		switch (potion.Potion) {
		case(BasePotion.PotionTypes.HEALTH):
			potion.Stamina = Random.Range (8, 12) + (int)(round * 0.55);
			potion.Strength = 0;
			potion.Initiative = 0;
			potion.ItemName = "Health Potion";
			break;
		case(BasePotion.PotionTypes.STRENGTH):
			potion.Strength = Random.Range (2, 4) + (int)(round * 0.4);
			potion.Stamina = 0;
			potion.Initiative = 0;
			potion.ItemName = "Strength Potion";
			break;
		case(BasePotion.PotionTypes.MIXED):
			potion.Stamina = Random.Range (5, 7) + (int)(round * 0.35);
			potion.Strength = Random.Range (5, 7 + (int)(round * 0.20));
			potion.Initiative = 0;
			potion.ItemName = "Mixed Potion";
			break;

		}
		return potion;
	}


	private static void pickPotionType() {
		int temp = Random.Range (1, 4);
		if (temp == 1) {
			potion.Potion = BasePotion.PotionTypes.HEALTH;
		}
		else if (temp == 2) {
			potion.Potion = BasePotion.PotionTypes.STRENGTH;
		}
		else if (temp == 3) {
			potion.Potion = BasePotion.PotionTypes.MIXED;
		}
	}
}
