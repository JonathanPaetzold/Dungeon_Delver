using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy {


	public Zombie(int round) {
		maxStamina = 10 + (int)(round * 0.85);
		currStamina = 10 + (int)(round * 0.85);
		strength = 3 + (int)(round * 0.4);
		initiative = 3 + (int)(round * 0.2);
	}
}
