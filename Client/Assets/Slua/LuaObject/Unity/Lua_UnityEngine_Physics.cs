﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Physics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Physics o;
			o=new UnityEngine.Physics();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				var ret=UnityEngine.Physics.Raycast(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.Raycast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(LuaOut))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				var ret=UnityEngine.Physics.Raycast(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.Raycast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(LuaOut),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Raycast(a1,out a2,a3);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				var ret=UnityEngine.Physics.Raycast(a1,a2,out a3);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(LuaOut),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Raycast(a1,out a2,a3,a4);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4,a5);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RaycastAll_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				var ret=UnityEngine.Physics.RaycastAll(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Linecast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.Linecast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				var ret=UnityEngine.Physics.Linecast(a1,a2,out a3);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.Linecast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.Linecast(a1,a2,out a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapSphere_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.OverlapSphere(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.OverlapSphere(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CapsuleCast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5);
				pushValue(l,ret);
				pushValue(l,a5);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Single a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6);
				pushValue(l,ret);
				pushValue(l,a5);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float),typeof(int))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6,a7);
				pushValue(l,ret);
				pushValue(l,a5);
				return 2;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SphereCast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.SphereCast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(LuaOut))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(LuaOut),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4);
				pushValue(l,ret);
				pushValue(l,a4);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(LuaOut),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4,a5);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(LuaOut),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5);
				pushValue(l,ret);
				pushValue(l,a4);
				return 2;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5,a6);
				pushValue(l,ret);
				pushValue(l,a4);
				return 2;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CapsuleCastAll_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SphereCastAll_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(UnityEngine.Vector3),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Ray),typeof(float),typeof(float),typeof(int))){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckSphere_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Physics.CheckSphere(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.CheckSphere(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckCapsule_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreCollision_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Collider a1;
				checkType(l,1,out a1);
				UnityEngine.Collider a2;
				checkType(l,2,out a2);
				UnityEngine.Physics.IgnoreCollision(a1,a2);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Collider a1;
				checkType(l,1,out a1);
				UnityEngine.Collider a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics.IgnoreCollision(a1,a2,a3);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreLayerCollision_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Physics.IgnoreLayerCollision(a1,a2);
				return 0;
			}
			else if(argc==3){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics.IgnoreLayerCollision(a1,a2,a3);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIgnoreLayerCollision_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.GetIgnoreLayerCollision(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kIgnoreRaycastLayer(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.kIgnoreRaycastLayer);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kDefaultRaycastLayers(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.kDefaultRaycastLayers);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kAllLayers(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.kAllLayers);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_IgnoreRaycastLayer(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.IgnoreRaycastLayer);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultRaycastLayers(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.DefaultRaycastLayers);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AllLayers(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.AllLayers);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravity(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.gravity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravity(IntPtr l) {
		try {
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			UnityEngine.Physics.gravity=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultContactOffset(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.defaultContactOffset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultContactOffset(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.defaultContactOffset=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounceThreshold(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.bounceThreshold);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounceThreshold(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.bounceThreshold=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_solverIterationCount(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.solverIterationCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_solverIterationCount(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Physics.solverIterationCount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepThreshold(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Physics.sleepThreshold);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepThreshold(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.sleepThreshold=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Physics");
		addMember(l,Raycast_s);
		addMember(l,RaycastAll_s);
		addMember(l,Linecast_s);
		addMember(l,OverlapSphere_s);
		addMember(l,CapsuleCast_s);
		addMember(l,SphereCast_s);
		addMember(l,CapsuleCastAll_s);
		addMember(l,SphereCastAll_s);
		addMember(l,CheckSphere_s);
		addMember(l,CheckCapsule_s);
		addMember(l,IgnoreCollision_s);
		addMember(l,IgnoreLayerCollision_s);
		addMember(l,GetIgnoreLayerCollision_s);
		addMember(l,"kIgnoreRaycastLayer",get_kIgnoreRaycastLayer,null,false);
		addMember(l,"kDefaultRaycastLayers",get_kDefaultRaycastLayers,null,false);
		addMember(l,"kAllLayers",get_kAllLayers,null,false);
		addMember(l,"IgnoreRaycastLayer",get_IgnoreRaycastLayer,null,false);
		addMember(l,"DefaultRaycastLayers",get_DefaultRaycastLayers,null,false);
		addMember(l,"AllLayers",get_AllLayers,null,false);
		addMember(l,"gravity",get_gravity,set_gravity,false);
		addMember(l,"defaultContactOffset",get_defaultContactOffset,set_defaultContactOffset,false);
		addMember(l,"bounceThreshold",get_bounceThreshold,set_bounceThreshold,false);
		addMember(l,"solverIterationCount",get_solverIterationCount,set_solverIterationCount,false);
		addMember(l,"sleepThreshold",get_sleepThreshold,set_sleepThreshold,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Physics));
	}
}
