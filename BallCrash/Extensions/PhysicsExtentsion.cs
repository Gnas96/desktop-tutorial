//  PhysicsExtentsion.cs
//  ProductName BreakoutTower
//
//  Created by kikuchikan on 2015.08.05.

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Physicsの拡張クラス
/// </summary>
public static class PhysicsExtentsion {

	//Rayの表示時間
	private const float RAY_DISPLAY_TIME = 1;

	//=================================================================================
	//DrawRay
	//=================================================================================

	/// <summary>
	/// Rayを飛ばすと同時に画面に線を描画する
	/// </summary>
	public static RaycastHit RaycastAndDraw(Ray ray, float maxDistance, int layerMask){
		return RaycastAndDraw(ray.origin, ray.direction, maxDistance, layerMask);
	}

	/// <summary>
	/// Rayを飛ばすと同時に画面に線を描画する
	/// </summary>
	public static RaycastHit RaycastAndDraw(Vector3 origin, Vector3 direction, float maxDistance, int layerMask){
		RaycastHit hit;

		if (Physics.Raycast(origin, direction, out hit, maxDistance, layerMask)){
			//衝突時のRayを画面に表示
			Debug.DrawRay(origin, hit.point - origin, Color.blue, RAY_DISPLAY_TIME, false);
			return hit;
		} 

		//非衝突時のRayを画面に表示
		Debug.DrawRay(origin, direction * maxDistance, Color.green, RAY_DISPLAY_TIME, false);
		return hit;
	}

}