/**
 * Resizing functions
 *
 * @author Rodrigo Rutkoski Rodrigues <rutkoski@gmail.com>
 */

using UnityEngine;
using System.Collections;

public static class Resize : MonoBehaviour
{

	public static Rect fitOutside (float width, float height, float containerWidth, float containerHeight)
	{
		float prop;
		Rect rect = new Rect ();
		if ((width / height) > (containerWidth / containerHeight)) {
			rect.height = containerHeight;
			prop = rect.height / height;
			rect.width = width * prop;
		} else {
			rect.width = containerWidth;
			prop = rect.width / width;
			rect.height = height * prop;
		}
		return rect;
	}
	
	public static Rect fitInside (float width, float height, float containerWidth, float containerHeight)
	{
		float prop;
		Rect rect = new Rect ();
		if ((width / height) > (containerWidth / containerHeight)) {
			rect.width = containerWidth;
			prop = rect.width / width;
			rect.height = height * prop;
		} else {
			rect.height = containerHeight;
			prop = rect.height / height;
			rect.width = width * prop;
		}
		return rect;
	}

}
