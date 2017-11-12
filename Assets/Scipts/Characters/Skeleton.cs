using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy {


	public Skeleton(int round) {
		maxStamina = 7 + (int) (round * 0.65);
		currStamina = 7 + (int)(round * 0.65) ;
		strength = 2 + (int)(round * 0.2);
		initiative = 10 + (int) (round * 0.5);
	}
}
