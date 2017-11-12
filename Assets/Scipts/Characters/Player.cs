using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

	private BaseArmour equip;
	private BaseArmour equip2;
	private BaseArmour equip3;
	private BaseWeapon weap;
	private BasePotion pot1;
	private BasePotion pot2;
	private BasePotion pot3;
	public int maxStamina;
	public int currStamina;
	public int strength;
	public int initiative;
	List<GameObject> prefabList = new List<GameObject>();
	public GameObject Prefab1;
	public GameObject Prefab2;
	public Enemy enemy;
	private int ctr;
	public Text round;
	public Text str;
	public Text potion1;
	public Text potion2;
	public Text potion3;
	public Text weapon;
	public Text arm1;
	public Text arm2;
	public Text arm3;


	// Use this for initialization
	void Start () {
		round.text = " ";
		maxStamina = 40;
		currStamina = 40;
		strength = 3;
		initiative = 7;
		equip = new BaseArmour();
		equip2 = new BaseArmour();
		equip3 = new BaseArmour();
		weap = new BaseWeapon ();
		pot1 = new BasePotion();
		pot2 = new BasePotion();
		pot3 = new BasePotion();
		int ctr = 0;
		prefabList.Add(Prefab1);
		prefabList.Add(Prefab2);
		SpawnEnemy ();
		str.text = "Strength: " + strength.ToString ();
		potion1.text = "Potion1: " + pot1.ItemName;
		potion2.text = "Potion2: " + pot2.ItemName;
		potion3.text = "Potion3: " + pot3.ItemName;
	

	}

	void Update() {
		if (currStamina > 0) {
			WaitForKeyDown ();
			if (enemy.currStamina <= 0) {
				enemy = null;
				GameObject sprite = GameObject.FindWithTag("Enemy");
				Destroy(sprite);
				Debug.Log ("Killed");
				SpawnEnemy ();
				Debug.Log ("spawned");
				Loot ();
				str.text = "Strength:" + strength.ToString ();
			}

	
		}


	}


	void Loot() {
		int temp = Random.Range (0, 3);
		if (temp == 0) {
			BaseArmour tempArmour = ArmourGenerator.generate (ctr);
			switch (tempArmour.Armour) {
			case (BaseArmour.ArmourTypes.HELMET):
				equip = tempArmour;
				break;
			
			case (BaseArmour.ArmourTypes.CHEST):
				equip2 = tempArmour;
				break;
			case (BaseArmour.ArmourTypes.BOOTS):
				equip3 = tempArmour;
				break;
			}
			Debug.Log ("Armour drop");
		} 
		else if (temp == 1) {
			weap = WeaponGenerator.generate (ctr);
			Debug.Log ("Weapon drop");
		}
		else if (temp == 2) {
			BasePotion tempPot = PotionGenerator.generate (ctr);
			if (string.Compare(pot1.ItemName, "Empty") == 0) {
				pot1 = tempPot;
			}
			else if (string.Compare(pot2.ItemName, "Empty") == 0) {
				pot2 = tempPot;
			}
			else if (string.Compare(pot3.ItemName, "Empty") == 0) {
				pot3 = tempPot;
			}
			Debug.Log ("Potion drop");
		}
		int diffrence = maxStamina - currStamina;
		maxStamina = 40 + equip.Stamina + equip2.Stamina + equip3.Stamina + weap.Stamina;
		currStamina = 40 + equip.Stamina + equip2.Stamina + equip3.Stamina + weap.Stamina - diffrence;
		if (currStamina > maxStamina) {
			currStamina = maxStamina;
		}
		strength = 3 + equip.Strength + equip2.Strength + equip3.Strength + weap.Strength;
		initiative = 7 + equip.Initiative + equip2.Initiative + equip3.Initiative + weap.Initiative;
		weapon.text = "Weapon: " + weap.ItemName;
		arm1.text = "Helmet: " + equip.ItemName;
		arm2.text = "Chestplate: " + equip2.ItemName;
		arm3.text = "Boots: " + equip3.ItemName;
		potion1.text = "Potion1: " + pot1.ItemName;
		potion2.text = "Potion2: " + pot2.ItemName;
		potion3.text = "Potion3: " + pot3.ItemName;

	}



	void WaitForKeyDown() {
		if (Input.GetKeyDown (KeyCode.A)) {
			enemy.currStamina = enemy.currStamina - strength;
			if (enemy.currStamina > 0) {
				enemyAttack ();
			}

		}
		else if (Input.GetKeyDown (KeyCode.Alpha1)) {
			if (string.Compare(pot1.ItemName, "Empty") != 0) {
				currStamina += pot1.Stamina;
				if (currStamina > maxStamina) {
					currStamina = maxStamina;
				}
				strength += pot1.Strength;
				initiative += pot1.Initiative;
				pot1 = new BasePotion ();
				potion1.text = "Potion1: " + pot1.ItemName;
				str.text = "Strength: " + strength.ToString ();
				enemyAttack ();
			}
		}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			if (string.Compare(pot2.ItemName, "Empty") != 0) {
				currStamina += pot2.Stamina;
				if (currStamina > maxStamina) {
					currStamina = maxStamina;
				}
				strength += pot2.Strength;
				initiative += pot2.Initiative;
				pot2 = new BasePotion ();
				potion2.text = "Potion2: " + pot2.ItemName;
				str.text = "Strength: " + strength.ToString ();
				enemyAttack ();
			} 

		}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			if (string.Compare(pot3.ItemName, "Empty") != 0) {
				currStamina += pot3.Stamina;
				if (currStamina > maxStamina) {
					currStamina = maxStamina;
				}
				strength += pot3.Strength;
				initiative += pot3.Initiative;
				pot3 = new BasePotion ();
				potion3.text = "Potion3: " + pot3.ItemName;
				str.text = "Strength: " + strength.ToString ();
				enemyAttack ();
			}
		}
		
	}

	void enemyAttack() {
		currStamina = currStamina - enemy.strength;
		Debug.Log ("enemy attacked");

	}

	void SpawnEnemy() {
		if (enemy == null) {
			int prefabIndex = UnityEngine.Random.Range (0, 2);
			ctr++;
			round.text = "Round:" + ctr.ToString ();

			if (prefabIndex == 0) {
				enemy = new Skeleton (ctr);
			} else {
				enemy = new Zombie (ctr);
			}
			Instantiate (prefabList[prefabIndex], new Vector3 (-5, -2, -10), Quaternion.identity);
		}

		
	}
	
		

}
