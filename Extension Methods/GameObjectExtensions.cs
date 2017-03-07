using UnityEngine;

public static class GameObjectExtensions
{
	// This method is used so you can find a child in a faster way and convert it directly to a GameObject
	public static GameObject FindChild(this GameObject obj, string name)
	{
		return obj.transform.FindChild(name).gameObject;
	}
	
	// This method is used for that times we need to find a parent of a GameObject, it returns itself when
	// there isn't any parent
	public static GameObject FindParent(this GameObject obj, string name)
	{
		if (obj.transform.parent == null)
			return obj;
		
		Transform parent = obj.transform.parent;
		
		if (parent.name.Equals(name))
			return parent.gameObject;
		
		return parent.gameObject.FindParent(name);
	}
	
	// This method will use the root object of the given game object to find a object in that object tree,
	// it returns the root object if the name searched matches the name of the root object.
	// WARNING: This can return unwanted objects if more then one object has the same name, avoid this by giving
	// a path instead of a simple name.
	public static GameObject FindInRoot(this GameObject obj, string name)
	{
		Transform root = obj.transform.root;
		
		if (root.name.Equals(name))
			return root.gameObject;
		
		return root.gameObject.FindChild(name);
	}
	
	// A derivated method from FindInRoot, this will only search for childs of the root ignoring the
	// root object when searching.
	// WARNING: This can return unwanted objects if more then one object has the same name, avoid this by giving
	// a path instead of a simple name.
	public static GameObject FindChildInRoot(this GameObject obj, string name)
	{
		Transform root = obj.transform.root;

		return root.gameObject.FindChild(name);
	}
}
