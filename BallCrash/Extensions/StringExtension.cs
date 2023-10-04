//  StringExtensions.cs
//  
//
//  Created by kan.kikuchi

using System;
using System.Collections.Generic;

/// <summary>
/// string 型の拡張メソッドを管理するクラス
/// </summary>
public static partial class StringExtension {

	//=================================================================================
	//判定
	//=================================================================================

	/// <summary>
	/// いずれかの文字列と同じ
	/// </summary>
	public static bool AnyEqual(this string self, params string[] targets){
		return new List<string>(targets).Contains(self);
	}

	/// <summary>
	/// 入力されたtargetの前にformatが含まれているかどうか
	/// </summary>
	public static bool ContainsFormatInFront(this string self, string format){

		if(self.Length < format.Length){
			return false;
		}
		if(self.Substring(0, format.Length) != format){
			return false;
		} 

		return true;
	}

	/// <summary>
	/// Nullまたはから文字か
	/// </summary>
	public static bool IsNullOrEmpty(this string self){
		return string.IsNullOrEmpty(self);
	}

	//=================================================================================
	//取得
	//=================================================================================

	/// <summary>
	/// 指定された文字列で区切られた部分文字列を格納する文字列配列を返します
	/// </summary>
	public static List<string> Split(this string self, string separator){
		return new List<string> (self.Split(new []{ separator }, StringSplitOptions.None));
	}

	/// <summary>
	/// 指定した文字列がいくつあるか
	/// </summary>
	public static int CountOf(this string self, params string[] strArray){
		int count = 0;

		foreach (string str in strArray) {
			int index = self.IndexOf (str, 0);
			while (index != -1) {
				count++;
				index = self.IndexOf (str, index + 1);
			}
		}

		return count;
	}

	//=================================================================================
	//装飾関係
	//=================================================================================

	public static string Coloring(this string str, string color) {
		return string.Format ("<color={0}>{1}</color>", color, str);
	}
	public static string Red(this string str) {
		return str.Coloring ("red");
	}
	public static string Green(this string str) {
		return str.Coloring ("green");
	}
	public static string Blue(this string str) {
		return str.Coloring ("blue");
	}

	public static string Resize(this string str, int size) {
		return string.Format ("<size={0}>{1}</size>", size, str);
	}
	public static string Medium(this string str) {
		return str.Resize (11);
	}
	public static string Small(this string str) {
		return str.Resize (9);
	}
	public static string Large(this string str) {
		return str.Resize (16);
	}

	public static string Bold(this string str) {
		return string.Format ("<b>{0}</b>", str);
	}
	public static string Italic(this string str) {
		return string.Format ("<i>{0}</i>", str);
	}
}