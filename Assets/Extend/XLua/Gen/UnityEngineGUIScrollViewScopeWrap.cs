#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineGUIScrollViewScopeWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUI.ScrollViewScope), L, translator, 0, 0, 2, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollPosition", _g_get_scrollPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "handleScrollWheel", _g_get_handleScrollWheel);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "handleScrollWheel", _s_set_handleScrollWheel);
            
			Utils.EndObjectRegister(typeof(UnityEngine.GUI.ScrollViewScope), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUI.ScrollViewScope), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUI.ScrollViewScope));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GUI.ScrollViewScope), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Vector2>(L, 3) && translator.Assignable<UnityEngine.Rect>(L, 4))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.Vector2 scrollPosition;translator.Get(L, 3, out scrollPosition);
					UnityEngine.Rect viewRect;translator.Get(L, 4, out viewRect);
					
					UnityEngine.GUI.ScrollViewScope __cl_gen_ret = new UnityEngine.GUI.ScrollViewScope(position, scrollPosition, viewRect);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Vector2>(L, 3) && translator.Assignable<UnityEngine.Rect>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.Vector2 scrollPosition;translator.Get(L, 3, out scrollPosition);
					UnityEngine.Rect viewRect;translator.Get(L, 4, out viewRect);
					bool alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 5);
					bool alwaysShowVertical = LuaAPI.lua_toboolean(L, 6);
					
					UnityEngine.GUI.ScrollViewScope __cl_gen_ret = new UnityEngine.GUI.ScrollViewScope(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Vector2>(L, 3) && translator.Assignable<UnityEngine.Rect>(L, 4) && translator.Assignable<UnityEngine.GUIStyle>(L, 5) && translator.Assignable<UnityEngine.GUIStyle>(L, 6))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.Vector2 scrollPosition;translator.Get(L, 3, out scrollPosition);
					UnityEngine.Rect viewRect;translator.Get(L, 4, out viewRect);
					UnityEngine.GUIStyle horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUIStyle verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.ScrollViewScope __cl_gen_ret = new UnityEngine.GUI.ScrollViewScope(position, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 8 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Vector2>(L, 3) && translator.Assignable<UnityEngine.Rect>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6) && translator.Assignable<UnityEngine.GUIStyle>(L, 7) && translator.Assignable<UnityEngine.GUIStyle>(L, 8))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.Vector2 scrollPosition;translator.Get(L, 3, out scrollPosition);
					UnityEngine.Rect viewRect;translator.Get(L, 4, out viewRect);
					bool alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 5);
					bool alwaysShowVertical = LuaAPI.lua_toboolean(L, 6);
					UnityEngine.GUIStyle horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 7, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUIStyle verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 8, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.ScrollViewScope __cl_gen_ret = new UnityEngine.GUI.ScrollViewScope(position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.ScrollViewScope constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUI.ScrollViewScope __cl_gen_to_be_invoked = (UnityEngine.GUI.ScrollViewScope)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.scrollPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_handleScrollWheel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUI.ScrollViewScope __cl_gen_to_be_invoked = (UnityEngine.GUI.ScrollViewScope)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.handleScrollWheel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_handleScrollWheel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUI.ScrollViewScope __cl_gen_to_be_invoked = (UnityEngine.GUI.ScrollViewScope)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.handleScrollWheel = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
