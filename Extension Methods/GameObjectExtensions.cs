using UnityEngine;

public static class GameObjectExtensions
{
	// This method is used so you can find a child in a faster way and convert it directly to a GameObject
	public static GameObject FindChild(this GameObject obj, string name)
	{
		return obj.tranform.FindChild(name).gameObject;
	}
	
	// This method asdasd
	public static GameObject FindParent
}
