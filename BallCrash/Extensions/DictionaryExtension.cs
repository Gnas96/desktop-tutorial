//  DictionaryExtensions.cs
//  ProductName Template
//
//  Created by kan.kikuchi on 2016.04.28.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Dictionaryの拡張クラス
/// </summary>
public static class DictionaryExtension {

	/// <summary>
	/// データを取得、ただしkeyが存在しない場合はデフォルトを返す
	/// </summary>
	public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key, TValue defaultValue) {
		if(source == null){
			return defaultValue;
		}
			
		if(source.ContainsKey(key)){
			return source[key];
		}
			
		return defaultValue;
	}

}