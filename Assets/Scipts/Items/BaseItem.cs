using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem{

	private string itemName;
	public enum ItemTypes{
		EQUIPEMENT,
		WEAPON,
		POTION
	}

	private ItemTypes itemType;

	public string ItemName {
		get{ return itemName; }
		set{ itemName = value; }
	}

	public ItemTypes ItemType {
		get{ return itemType; }
		set{ itemType = value; }
	}

}
