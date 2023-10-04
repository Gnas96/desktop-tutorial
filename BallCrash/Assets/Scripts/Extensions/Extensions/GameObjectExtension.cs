//  GameObjectExtension.cs
//  
//
//  Created by kan.kikuchi

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// GameObjectの拡張クラス
/// </summary>
public static class GameObjectExtension{

	//=================================================================================
	//作成
	//=================================================================================

	/// <summary>
	/// 子にゲームオブジェクトを作成する
	/// </summary>
	public static GameObject CreateChild (this GameObject gameObject, string childName){
		GameObject child = new GameObject (childName);
		child.transform.SetParent (gameObject.transform);
		return child;
	}

	//=================================================================================
	//設定
	//=================================================================================

	/// <summary>
	/// 自分と子にレイヤーを設定する
	/// </summary>
	public static void SetLayerInChildren(this GameObject gameObject, int layerNo){
		if(gameObject == null){
			return;
		}
		gameObject.layer = layerNo;

		//子のレイヤーにも設定する
		foreach(Transform childTransform in gameObject.transform){
			SetLayerInChildren (childTransform.gameObject, layerNo);
		}
	}

	/// <summary>
	/// タグを設定する
	/// </summary>
	public static void SetTagInChildren(this GameObject gameObject, string tagName){
		if(gameObject == null){
			return;
		}
		gameObject.tag = tagName;

		//子のタグにも設定する
		foreach(Transform childTransform in gameObject.transform){
			SetTagInChildren (childTransform.gameObject, tagName);
		}
	}

	/// <summary>
	/// マテリアル設定
	/// </summary>
	public static void SetMaterialInChildren(this GameObject gameObject, Material setMaterial){
		if(gameObject == null){
			return;
		}

		//レンダラーがあればそのマテリアルを変更
		if(gameObject.GetComponent<Renderer>()){
			gameObject.GetComponent<Renderer>().material = setMaterial;
		}

		//子のマテリアルにも設定する
		foreach(Transform childTransform in gameObject.transform){
			SetMaterialInChildren (childTransform.gameObject, setMaterial);
		}

	}

}