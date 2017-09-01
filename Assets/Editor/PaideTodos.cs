using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomPropertyDrawer(typeof(TagSelectorAttribute))]
public class PaideTodos : PropertyDrawer
{
	int index = -1;
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{

		GUIContent[] contents = new GUIContent[UnityEditorInternal.InternalEditorUtility.tags.Length];
		for (int i =0;i<contents.Length;i++)
		{
			contents[i] = new GUIContent(UnityEditorInternal.InternalEditorUtility.tags[i]);
		}
		index = getIndex(contents, property.stringValue);
		EditorGUI.LabelField(position, "Tag ");
		index = EditorGUI.Popup(new Rect(position.xMax -150, position.y, 150, position.height), index, contents);
		property.stringValue = contents[index].text;

	}
	int getIndex(GUIContent[]array,string content)
	{
		for (int i = 0; i < array.Length; i++) {
			if (array [i].text == content)
				return i;
		}
	
		return 0;
	
	}


}