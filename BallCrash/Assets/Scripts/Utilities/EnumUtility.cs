using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class EnumUtility {

	public static void ExcuteActionInAllValue<T>(Action<T> action){
		foreach(T t in Enum.GetValues(typeof(T))){
			action (t);
		}
	}
	public static bool ContainsKey<T>(string tagetKey){

		foreach(T t in Enum.GetValues(typeof(T))){
			if(t.ToString() == tagetKey){
				return true;
			}
		}

		return false;
	}

	public static T KeyToType<T>(string targetKey){
		return (T)Enum.Parse (typeof(T), targetKey);
	}

	public static T NoToType<T>(int targetNo){
		return (T)Enum.ToObject (typeof(T), targetNo);
	}

	public static int GetTypeNum<T>(){
		return Enum.GetValues (typeof(T)).Length;
	}

}