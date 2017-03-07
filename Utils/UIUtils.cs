using UnityEngine;

public static class UIUtils
{
	// Your game has a maximum screen size right? That is the absolute screen size and should be passed
	// to this method as arguments. This method will ajust the GUI to your screen and you only have to
	// use a set of values when positioning things.
	// NOTE: This only applies to OnGUI methods and should be called before any gui element is drawn.
	public static void AutoResize(int absScreenWidth, int absScreenHeight)
	{
		Vector2 resizeRatio;
		
		resizeRatio.x = (float) Screen.width / absScreenWidth;
		resizeRatio.y = (float) Screen.height / absScreenHeight;
		
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f)); 
	}
}
