// by Neitri, free of charge, free to redistribute
// downloaded from https://github.com/netri/Neitri-Unity-Scripts

using UnityEngine;

// Allows for easier setup of VRChat portrait capture
// Add it under Camera that you want to use as VRC Portrait Camera
// Propagates Camera Component position rotation and other properties to camera used for VRChat portrait capture
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PropagateToVRCPortraitCamera : MonoBehaviour
{
	void Update()
	{
		// We can clone more Camera parameters into runtime Camera Component than into Avatar or Scene Descriptor
		PropagateToCaptureCamera();

		// In case you give this scene to someone and they dont have this script you want to at least keep correct portrait camera position and rotation
		PropagateToSceneDescriptors();
		PropagateToAvatarDescriptors();
	}

	void PropagateToCaptureCamera()
	{
		var vrcCamGO = GameObject.Find("VRCCam");
		if (!vrcCamGO) return;

		vrcCamGO.transform.position = this.transform.position;
		vrcCamGO.transform.rotation = this.transform.rotation;

		var sourceCam = this.GetComponent<Camera>();
		var targetCam = vrcCamGO.GetComponent<Camera>();
		if (!sourceCam || !targetCam) return;
		
		var targetTexture = targetCam.targetTexture;
		targetCam.CopyFrom(sourceCam);
		targetCam.targetTexture = targetTexture;
	}

	void PropagateToSceneDescriptors()
	{
		var sourceCam = this.GetComponent<Camera>();
		if (!sourceCam) return;

		foreach (var sceneDescriptor in GameObject.FindObjectsOfType<VRCSDK2.VRC_SceneDescriptor>())
		{
			if (!sceneDescriptor.isActiveAndEnabled) continue;
			sceneDescriptor.portraitCameraPositionOffset = sceneDescriptor.transform.InverseTransformPoint(sourceCam.transform.position);
			sceneDescriptor.portraitCameraRotationOffset = Quaternion.Inverse(sceneDescriptor.transform.rotation) * sourceCam.transform.rotation;
		}
	}

	void PropagateToAvatarDescriptors()
	{
		var sourceCam = this.GetComponent<Camera>();
		if (!sourceCam) return;

		foreach (var avatarDescriptor in GameObject.FindObjectsOfType<VRCSDK2.VRC_AvatarDescriptor>())
		{
			if (!avatarDescriptor.isActiveAndEnabled) continue;
			avatarDescriptor.portraitCameraPositionOffset = avatarDescriptor.transform.InverseTransformPoint(sourceCam.transform.position);
			avatarDescriptor.portraitCameraRotationOffset = Quaternion.Inverse(avatarDescriptor.transform.rotation) * sourceCam.transform.rotation;
		}
	}
}
