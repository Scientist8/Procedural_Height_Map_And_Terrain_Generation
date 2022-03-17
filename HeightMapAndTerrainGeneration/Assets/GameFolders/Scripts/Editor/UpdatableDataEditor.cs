using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(UpdatableData), true)]
public class UpdatableDataEditor : Editor
{
	//Will have a button "generate" when the auto update is off
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		UpdatableData data = (UpdatableData)target;

		if (GUILayout.Button("Update"))
		{
			data.NotifyOfUpdatedValues();
			EditorUtility.SetDirty(target);
		}
	}

}
