using System.Collections;
using UnityEngine;

public class UpdatableData : ScriptableObject
{
    //Acts as a parent class for other data classes
    //So the map generator can update the map automatically when adjusted the values


    public event System.Action OnValuesUpdated;
    public bool autoUpdate;

    #if UNITY_EDITOR //compile this code only in unity editor, because it doesn't build the game, this solves the problem

    protected virtual void OnValidate()
    {
        if (autoUpdate)
        {
            // This will delay the calling until the shader is compiled
            UnityEditor.EditorApplication.update += NotifyOfUpdatedValues;
        }
    }

    public void NotifyOfUpdatedValues()
    {
        if (OnValuesUpdated != null)
        {
            // This will delay the calling until the shader is compiled
            UnityEditor.EditorApplication.update -= NotifyOfUpdatedValues;
            if (OnValuesUpdated != null)
            {
                OnValuesUpdated();
            }
        }
    }


    #endif

}
