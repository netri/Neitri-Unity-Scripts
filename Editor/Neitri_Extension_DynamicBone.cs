// by Neitri, free of charge, free to redistribute
// downloaded from https://github.com/netri/Neitri-Unity-Scripts

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DynamicBone))]
[CanEditMultipleObjects]
public class Neitri_Extension_DynamicBone : Editor
{
	static void AddPresets()
	{
		AddPreset("Breasts Naelly", (DynamicBone db) =>
		{
			db.m_Damping = 0.2f;
			db.m_Elasticity = 0.1f;
			db.m_Stiffness = 0.2f;
			db.m_Inert = 0.9f;
		});

		AddPreset("Butt Naelly", (DynamicBone db) =>
		{
			db.m_Damping = 0.05f;
			db.m_Elasticity = 0.075f;
			db.m_Stiffness = 0.4f;
			db.m_Inert = 0.3f;
		});

		AddPreset("Ears Cat Naelly", (DynamicBone db) =>
		{
			db.m_Damping = 0.2f;
			db.m_Elasticity = 0.05f;
			db.m_Stiffness = 0.2f;
			db.m_Inert = 0.9f;
			db.m_Force = new Vector3(0.0f, -0.0001f, 0.0f);
		});

		AddPreset("Thighs Naelly", (DynamicBone db) =>
		{
			db.m_Damping = 0.05f;
			db.m_Elasticity = 0.075f;
			db.m_Stiffness = 0.9f;
			db.m_Inert = 0.7f;
		});

		AddPreset("Tongue Naelly", (DynamicBone db) =>
		{
			db.m_Damping = 0.75f;
			db.m_Elasticity = 0.1f;
			db.m_Stiffness = 0.95f;
			db.m_Inert = 0.05f;
			db.m_StiffnessDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(0.8f, 1), new Keyframe(0.9f, 0.03f), new Keyframe(1, 0.03f));
		});

		AddPreset("Tail Naelly", (DynamicBone db) =>
		{
			db.m_Damping = 0.1f;
			db.m_Elasticity = 0.01f;
			db.m_Stiffness = 0.5f;
			db.m_Inert = 0.6f;
		});

		AddPreset("Hair Short Naelly", (DynamicBone db) =>
		{
			db.m_Damping = 0.2f;
			db.m_Elasticity = 0.04f;
			db.m_Stiffness = 0.2f;
			db.m_Inert = 0.92f;
		});


		AddPreset("Breasts Neitri", (DynamicBone db) =>
		{
			db.m_Damping = 0.1f;
			db.m_Elasticity = 0.05f;
			db.m_Stiffness = 0.8f;
			db.m_Inert = 0.5f;
		});

		AddPreset("Tail Neitri", (DynamicBone db) =>
		{
			db.m_Damping = 0.01f;
			db.m_Elasticity = 0.01f;
			db.m_Stiffness = 0.05f;
		});

		AddPreset("Tongue Neitri", (DynamicBone db) =>
		{
			db.m_Damping = 0.6f;
			db.m_Elasticity = 0.1f;
			db.m_Stiffness = 0.8f;
			db.m_Inert = 0.3f;
		});

		AddPreset("Hair Long Neitri - old", (DynamicBone db) =>
		{
			db.m_Damping = 0.5f;
			db.m_Elasticity = 0.5f;
			db.m_Stiffness = 0.8f;
			db.m_Inert = 0.5f;
		});

		AddPreset("Hair Short Front Neitri", (DynamicBone db) =>
		{
			db.m_Damping = 0.2f;
			db.m_Elasticity = 0.06f;
			db.m_Stiffness = 0.4f;
			db.m_Inert = 0.7f;
		});

		AddPreset("Hair Long Back Neitri", (DynamicBone db) =>
		{
			db.m_Damping = 0.5f;
			db.m_Elasticity = 0.04f;
			db.m_Stiffness = 0.2f;
			db.m_Inert = 0.3f;
			db.m_Force = new Vector3(0, -0.00002f, 0);
		});

		AddPreset("Ears Cat Neitri", (DynamicBone db) =>
		{
			db.m_Damping = 0.3f;
			db.m_Elasticity = 0.1f;
			db.m_Stiffness = 1;
			db.m_StiffnessDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 0));
			db.m_Inert = 0.6f;
			db.m_Radius = 0.02f;
		});



		AddPreset("Ears Cat Larens", (DynamicBone db) =>
		{
			db.m_Damping = 0.1f;
			db.m_Elasticity = 0.05f;
			db.m_Stiffness = 1;
			db.m_StiffnessDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 0));
			db.m_Inert = 0.8f;
			db.m_Radius = 0.02f;
		});


		/*
		AddPreset("Example", (DynamicBone db) =>
		{
			db.m_Damping = 0.1f;
			db.m_DampingDistrib = new AnimationCurve(new Keyframe(0, 3, 0.3f, 1), new Keyframe(1, 1, 3, 1));
			db.m_Elasticity = 0.1f;
			db.m_ElasticityDistrib = new AnimationCurve(new Keyframe(0, 3, 0.3f, 1), new Keyframe(1, 1, 3, 1));
			db.m_Stiffness = 0.1f;
			db.m_StiffnessDistrib = new AnimationCurve(new Keyframe(0, 3, 0.3f, 1), new Keyframe(1, 1, 3, 1));
			db.m_Inert = 0;
			db.m_InertDistrib = new AnimationCurve(new Keyframe(0, 3, 0.3f, 1), new Keyframe(1, 1, 3, 1));
			db.m_Radius = 0;
			db.m_RadiusDistrib = new AnimationCurve(new Keyframe(0, 3, 0.3f, 1), new Keyframe(1, 1, 3, 1));
			db.m_EndLength = 0;
			db.m_EndOffset = Vector3.zero;
			db.m_Gravity = Vector3.zero;
			db.m_Force = Vector3.zero;
		});
		*/

	}

	static Action<DynamicBone> resetPreset = (DynamicBone db) =>
	{
		db.m_Damping = 0.1f;
		db.m_DampingDistrib = null;
		db.m_Elasticity = 0.1f;
		db.m_ElasticityDistrib = null;
		db.m_Stiffness = 0.1f;
		db.m_StiffnessDistrib = null;
		db.m_Inert = 0.0f;
		db.m_InertDistrib = null;
		db.m_Radius = 0.0f;
		db.m_RadiusDistrib = null;
		db.m_EndLength = 0.0f;
		db.m_EndOffset = Vector3.zero;
		db.m_Gravity = Vector3.zero;
		db.m_Force = Vector3.zero;

		//db.m_DampingDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 1));
		//db.m_ElasticityDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 1));
		//db.m_StiffnessDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 1));
		//db.m_InertDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 1));
		//db.m_RadiusDistrib = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 1));

		//db.m_Exclusions = new List<Transform>();
		//db.m_Colliders = new List<DynamicBoneColliderBase>();
	};

	static Dictionary<string, Action<DynamicBone>> Presets = new Dictionary<string, Action<DynamicBone>>();
	static void AddPreset(string Name, Action<DynamicBone> Preset)
	{
		Presets.Add(Name, Preset);
	}


	void ApplyPreset(Action<DynamicBone> Preset)
	{
		foreach (var target in targets)
		{
			DynamicBone db = (DynamicBone)target;
			if (db == null) continue;
			resetPreset(db);
			Preset(db);

			if (db.m_Radius != 0)
			{
				var s = db.transform.lossyScale;
				db.m_Radius /= Mathf.Abs((s.x + s.y + s.z) / 3.0f);
			}
		}
	}


	static bool ShowPresets = true;
	static int LastNumPerRow = 3;

	static bool ShowUtilities = true;

	static bool ShowOtherBones = false;

	public override void OnInspectorGUI()
	{
		if (Presets.Count == 0)
		{
			AddPresets();
		}

		ShowUtilities = EditorGUILayout.Foldout(ShowUtilities, "Utilities");
		if (ShowUtilities)
		{
			GUILayout.BeginHorizontal();

			if (GUILayout.Button("Reset", GUILayout.ExpandWidth(false)))
			{
				Undo.RecordObjects(targets, "Reset");
				ApplyPreset(resetPreset);
			}

			if (GUILayout.Button("Use all colliders", GUILayout.ExpandWidth(false)))
			{
				Undo.RecordObjects(targets, "Use all colliders");
				UseAllColliders();
			}

			if (GUILayout.Button("Set root transform", GUILayout.ExpandWidth(false)))
			{
				Undo.RecordObjects(targets, "Set root transform");
				foreach (var target in targets)
				{
					DynamicBone db = (DynamicBone)target;
					if (db == null) continue;
					db.m_Root = db.transform;
				}
			}

			if (GUILayout.Button("Exclude root transform", GUILayout.ExpandWidth(false)))
			{
				Undo.RecordObjects(targets, "Exclude root transform");
				foreach (var target in targets)
				{
					DynamicBone db = (DynamicBone)target;
					if (db == null) continue;
					if (db.m_Exclusions == null)
					{
						db.m_Exclusions = new List<Transform>();
					}

					if (!db.m_Exclusions.Contains(db.transform))
					{
						db.m_Exclusions.Add(db.transform);
					}
				}
			}

			GUILayout.EndHorizontal();
		}

		ShowPresets = EditorGUILayout.Foldout(ShowPresets, "Presets");
		if (ShowPresets)
		{
			int numPerRow = 3;

			/*if (Event.current.type == EventType.Repaint)
			{ 
				int newNumPerRow = 1 + Mathf.CeilToInt(GUILayoutUtility.GetLastRect().width / 200);
				if (newNumPerRow > 1) numPerRow = newNumPerRow;
			}*/

			int numPerColumn = Mathf.CeilToInt(Presets.Count / (float)numPerRow);
			GUILayout.BeginHorizontal();
			int i = 0;
			GUILayout.BeginVertical();
			foreach (var item in Presets)
			{
				if (GUILayout.Button(item.Key, GUILayout.ExpandWidth(false)))
				{
					ApplyPreset(item.Value);
				}

				++i;
				if (i % numPerColumn == 0)
				{
					GUILayout.EndVertical();
					GUILayout.BeginVertical();
				}
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}

		ShowOtherBones = EditorGUILayout.Foldout(ShowOtherBones, "Other bones in avatar");
		if (ShowOtherBones)
		{
			DynamicBone[] bones = GetAllBonesInAvatar();
			if (bones != null)
			{
				foreach (var bone in bones)
				{
					EditorGUILayout.ObjectField(bone.name, bone, bone.GetType(), true);
				}
			}

		}

		EditorGUILayout.HelpBox(@"Damping = How much are the bones slowed down.
Elasticity = How much force is applied to return each bone to original orientation.
Stiffness = How much bone's original orientation are preserved.
Inert = How much character's position change is ignored in physics simulation.", MessageType.Info);

		DrawDefaultInspector();
	}


	Transform FindAvatarRoot()
	{
		Transform root = null;

		// find dynamic bone transform
		foreach (var target in targets)
		{
			DynamicBone db = (DynamicBone)target;
			if (db == null) continue;
			root = db.transform;
			break;
		}

		if (root == null) return null;

		// find avatar transform
		int safe = 0;
		while (root.parent != null && root.GetComponent<VRCSDK2.VRC_AvatarDescriptor>() == null && ++safe < 1000)
		{
			root = root.parent;
		}

		return root;
	}

	DynamicBoneColliderBase[] GetAllCollidersInAvatar()
	{
		Transform root = FindAvatarRoot();
		if (root == null) return null;
		return root.GetComponentsInChildren<DynamicBoneColliderBase>();
	}
	DynamicBone[] GetAllBonesInAvatar()
	{
		Transform root = FindAvatarRoot();
		if (root == null) return null;
		return root.GetComponentsInChildren<DynamicBone>();
	}

	void UseAllColliders()
	{
		DynamicBoneColliderBase[] collidersArray = GetAllCollidersInAvatar();
		List<DynamicBoneColliderBase> collidersList = new List<DynamicBoneColliderBase>(collidersArray);

		// sort by name
		collidersList.Sort((DynamicBoneColliderBase a, DynamicBoneColliderBase b) => a.transform.name.CompareTo(b.transform.name));

		// sort so hand colliders are on top
		// so user can just change colliders count to 2 to use only hands
		collidersList.Sort((DynamicBoneColliderBase a, DynamicBoneColliderBase b) =>
		{
			bool b1 = a.transform.name.ToLowerInvariant().Contains("hand");
			bool b2 = b.transform.name.ToLowerInvariant().Contains("hand");
			if (b1 || b2) return 1;
			else if (b1) return -1;
			else return 1;
		});

		// apply colliders
		foreach (var target in targets)
		{
			DynamicBone db = (DynamicBone)target;
			if (db == null) continue;
			db.m_Colliders = collidersList;
		}
	}
}



