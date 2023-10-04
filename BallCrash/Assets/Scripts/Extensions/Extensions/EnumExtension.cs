//  EnumExtensions.cs
//  ProductName ゴール神3D
//
//  Created by kan.kikuchi on 2016.03.16

using System;

/// <summary>
/// Enumの拡張クラス
/// </summary>
public static class EnumExtension {

	//=================================================================================
	//判定
	//=================================================================================

	/// <summary>
	/// 現在のインスタンスで 1 つ以上のビット フィールドが設定されているかどうかを判断します
	/// </summary>
	public static bool HasFlag(this Enum self, Enum flag){
		if (self.GetType() != flag.GetType()){
			throw new ArgumentException( "flag の型が、現在のインスタンスの型と異なっています。" );
		}

		var selfValue = Convert.ToUInt64(self);
		var flagValue = Convert.ToUInt64(flag);

		return (selfValue & flagValue) == flagValue;
	}

}