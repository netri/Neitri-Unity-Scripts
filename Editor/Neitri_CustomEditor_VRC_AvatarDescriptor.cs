// by Neitri, free of charge, free to redistribute
// downloaded from https://github.com/netri/Neitri-Unity-Scripts

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


using VRCSDK2;

[CustomEditor(typeof(VRC_AvatarDescriptor))]
//[CanEditMultipleObjects]
public class Neitri_CustomEditor_VRC_AvatarDescriptor : Editor
{

	public static readonly string[] VismesShapeKeys = {
		"vrc.v_sil",
		"vrc.v_pp",
		"vrc.v_ff",
		"vrc.v_th",
		"vrc.v_dd",
		"vrc.v_kk",
		"vrc.v_ch",
		"vrc.v_ss",
		"vrc.v_nn",
		"vrc.v_rr",
		"vrc.v_aa",
		"vrc.v_e",
		"vrc.v_ih",
		"vrc.v_oh",
		"vrc.v_ou",
	};

	public override void OnInspectorGUI()
	{
		var avatarDescriptor = target as VRC_AvatarDescriptor;

		if (avatarDescriptor)
		{
			SkinnedMeshRenderer bodySkinnedMeshRenderer = null;
			if (avatarDescriptor)
			{
				var bodyGameObject = avatarDescriptor.transform.Find("Body");
				if (bodyGameObject)
				{
					bodySkinnedMeshRenderer = bodyGameObject.GetComponent<SkinnedMeshRenderer>();
				}
			}

			if (GUILayout.Button("Add VRCGlobalRoot tag", GUILayout.ExpandWidth(false)))
			{
				AddTag("VRCGlobalRoot");
			}


			if (GUILayout.Button("Assign Standard Vismes Shapekeys", GUILayout.ExpandWidth(false)))
			{
				Undo.RecordObjects(targets, "Use Vismes Shapekeys");
				avatarDescriptor.lipSync = VRC_AvatarDescriptor.LipSyncStyle.VisemeBlendShape;
				avatarDescriptor.VisemeBlendShapes = VismesShapeKeys;
			}

			if (GUILayout.Button("Assign Body Skinned Mesh", GUILayout.ExpandWidth(false)))
			{
				Undo.RecordObjects(targets, "Use Body");
				avatarDescriptor.VisemeSkinnedMesh = bodySkinnedMeshRenderer;
			}

			if (avatarDescriptor.VisemeSkinnedMesh != bodySkinnedMeshRenderer)
			{
				EditorGUILayout.HelpBox("Wrong Vismes Skinned Mesh assigned", MessageType.Error);
			}
			else if (avatarDescriptor.VisemeSkinnedMesh)
			{
				string missingShapeKeys = "";
				foreach (string shapeKey in avatarDescriptor.VisemeBlendShapes)
				{
					if (avatarDescriptor.VisemeSkinnedMesh.sharedMesh.GetBlendShapeIndex(shapeKey) == -1)
					{
						missingShapeKeys += shapeKey + " ";
					}
				}
				if (missingShapeKeys.Length > 0)
				{
					EditorGUILayout.HelpBox("Shape keys missing on Vismes Skinned Mesh: " + missingShapeKeys, MessageType.Error);
				}
			}
			else
			{
				EditorGUILayout.HelpBox("Vismes Skinned Mesh not assigned", MessageType.Error);
			}

		}
		DrawDefaultInspector();
	}



	// https://answers.unity.com/questions/33597/is-it-possible-to-create-a-tag-programmatically.html
	public static void AddTag(string tag)
	{
		var asset = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset");
		if (asset != null && asset.Length > 0)
		{
			SerializedObject so = new SerializedObject(asset[0]);
			SerializedProperty tags = so.FindProperty("tags");
			for (int i = 0; i < tags.arraySize; ++i)
			{
				if (tags.GetArrayElementAtIndex(i).stringValue == tag)
				{
					return; // Tag already present, nothing to do.
				}
			}

			tags.InsertArrayElementAtIndex(0);
			tags.GetArrayElementAtIndex(0).stringValue = tag;
			so.ApplyModifiedProperties();
			so.Update();
		}
	}

}