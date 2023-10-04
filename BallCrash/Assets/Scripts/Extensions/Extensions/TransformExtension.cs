//  TransformExtension.cs
//  
//
//  Created by kan.kikuchi

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Transformの拡張クラス
/// </summary>
public static class TransformExtension{

	//=================================================================================
	//Position
	//=================================================================================

	public static void SetPosition(this Transform transform, float x, float y, float z) {
		transform.position = new Vector3(x, y, z);
	}
	public static void SetPositionX(this Transform transform, float x) {
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}
	public static void SetPositionY(this Transform transform, float y) {
		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}
	public static void SetPositionZ(this Transform transform, float z) {
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	}

	public static void SetLocalPosition(this Transform transform, float x, float y, float z) {
		transform.localPosition = new Vector3(x, y, z);
	}
	public static void SetLocalPositionX(this Transform transform, float x) {
		transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
	}
	public static void SetLocalPositionY(this Transform transform, float y) {
		transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
	}
	public static void SetLocalPositionZ(this Transform transform, float z) {
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
	}

	public static void AddPosition(this Transform transform, float x, float y, float z) {
		transform.position = transform.position + new Vector3(x, y, z);
	}
	public static void AddPositionX(this Transform transform, float x) {
		transform.position = transform.position + new Vector3(x, 0, 0);
	}
	public static void AddPositionY(this Transform transform, float y) {
		transform.position = transform.position + new Vector3(0, y, 0);
	}
	public static void AddPositionZ(this Transform transform, float z) {
		transform.position = transform.position + new Vector3(0, 0, z);
	}

	public static void AddLocalPosition(this Transform transform, float x, float y, float z) {
		transform.localPosition = transform.localPosition + new Vector3(x, y, z);
	}
	public static void AddLocalPositionX(this Transform transform, float x) {
		transform.localPosition = transform.localPosition + new Vector3(x, 0, 0);
	}
	public static void AddLocalPositionY(this Transform transform, float y) {
		transform.localPosition = transform.localPosition + new Vector3(0, y, 0);
	}
	public static void AddLocalPositionZ(this Transform transform, float z) {
		transform.localPosition = transform.localPosition + new Vector3(0, 0, z);
	}

	//=================================================================================
	//Scale
	//=================================================================================

	public static void SetLocalScale(this Transform transform, float x, float y, float z) {
		transform.localScale = new Vector3(x, y, z);
	}
	public static void SetLocalScaleX(this Transform transform, float x) {
		transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
	}
	public static void SetLocalScaleY(this Transform transform, float y) {
		transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);
	}
	public static void SetLocalScaleZ(this Transform transform, float z) {
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, z);
	}

	public static void AddLocalScale(this Transform transform, float x, float y, float z) {
		transform.localScale = transform.localScale + new Vector3(x, y, z);
	}
	public static void AddLocalScaleX(this Transform transform, float x) {
		transform.localScale = transform.localScale + new Vector3(x, 0, 0);
	}
	public static void AddLocalScaleY(this Transform transform, float y) {
		transform.localScale = transform.localScale + new Vector3(0, y, 0);
	}
	public static void AddLocalScaleZ(this Transform transform, float z) {
		transform.localScale = transform.localScale + new Vector3(0, 0, z);
	}

	//=================================================================================
	//Rotation
	//=================================================================================

	public static void SetEulerAngles(this Transform transform, float x, float y, float z) {
		transform.eulerAngles = new Vector3(x, y, z);
	}
	public static void SetEulerAngleX(this Transform transform, float x) {
		transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);
	}
	public static void SetEulerAngleY(this Transform transform, float y) {
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, y, transform.eulerAngles.z);
	}
	public static void SetEulerAngleZ(this Transform transform, float z) {
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, z);
	}

	public static void SetLocalEulerAngles(this Transform transform, float x, float y, float z) {
		transform.localEulerAngles = new Vector3(x, y, z);
	}
	public static void SetLocalEulerAngleX(this Transform transform, float x) {
		transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, transform.localEulerAngles.z);
	}
	public static void SetLocalEulerAngleY(this Transform transform, float y) {
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, y, transform.localEulerAngles.z);
	}
	public static void SetLocalEulerAngleZ(this Transform transform, float z) {
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, z);
	}

	public static void AddEulerAngles(this Transform transform, float x, float y, float z) {
		transform.eulerAngles = transform.eulerAngles + new Vector3(x, y, z);
	}
	public static void AddEulerAngleX(this Transform transform, float x) {
		transform.eulerAngles = transform.eulerAngles + new Vector3(x, 0, 0);
	}
	public static void AddEulerAngleY(this Transform transform, float y) {
		transform.eulerAngles = transform.eulerAngles + new Vector3(0, y, 0);
	}
	public static void AddEulerAngleZ(this Transform transform, float z) {
		transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, z);
	}

	public static void AddLocalEulerAngles(this Transform transform, float x, float y, float z) {
		transform.localEulerAngles = transform.localEulerAngles + new Vector3(x, y, z);
	}
	public static void AddLocalEulerAngleX(this Transform transform, float x) {
		transform.localEulerAngles = transform.localEulerAngles + new Vector3(x, 0, 0);
	}
	public static void AddLocalEulerAngleY(this Transform transform, float y) {
		transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, y, 0);
	}
	public static void AddLocalEulerAngleZ(this Transform transform, float z) {
		transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, 0, z);
	}

	//=================================================================================
	//角度
	//=================================================================================

	/// <summary>
	/// 指定のオブジェクトの方向に回転する
	/// </summary>
	/// <param name="self">Self.</param>
	/// <param name="target">Target.</param>
	/// <param name="forward">正面方向</param>
	public static void LookAt2D(this Transform self, Vector3 target, Vector2 forward){
		self.rotation = GetForwardRotation2D(self, target, forward);
	}

	/// <summary>
	/// 指定のオブジェクトの方向の角度を取得する
	/// </summary>
	public static Quaternion GetForwardRotation2D(this Transform self, Vector3 target, Vector2 forward){
		var forwardDiff = GetForwardDiffPoint (forward);
		Vector3 direction = target - self.position;
		float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
		return Quaternion.AngleAxis(angle - forwardDiff, Vector3.forward);
	}

	/// <summary>
	/// 正面の方向の差分を算出する
	/// </summary>
	/// <returns>The forward diff point.</returns>
	/// <param name="forward">Forward.</param>
	private static float GetForwardDiffPoint(Vector2 forward){
		if (Equals (forward, Vector2.up)) return 90;
		if (Equals (forward, Vector2.right)) return 0;
		return 0;
	}

	//=================================================================================
	//取得
	//=================================================================================

	/// <summary>
	/// 全ての子オブジェクトを取得
	/// </summary>
	public static List<GameObject> GetChildren(this GameObject gameObject){
		List<GameObject> childList = new List<GameObject>();

		foreach (Transform child in gameObject.transform) {
			childList.Add (child.gameObject);
		}

		return childList;
	}
}