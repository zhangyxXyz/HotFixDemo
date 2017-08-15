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
    public class UnityEngineGUILayoutAreaScopeWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUILayout.AreaScope), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.GUILayout.AreaScope), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUILayout.AreaScope), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUILayout.AreaScope));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GUILayout.AreaScope), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Rect>(L, 2))
				{
					UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
					
					UnityEngine.GUILayout.AreaScope __cl_gen_ret = new UnityEngine.GUILayout.AreaScope(screenRect);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
					string text = LuaAPI.lua_tostring(L, 3);
					
					UnityEngine.GUILayout.AreaScope __cl_gen_ret = new UnityEngine.GUILayout.AreaScope(screenRect, text);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Texture>(L, 3))
				{
					UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
					UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
					
					UnityEngine.GUILayout.AreaScope __cl_gen_ret = new UnityEngine.GUILayout.AreaScope(screenRect, image);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.GUIContent>(L, 3))
				{
					UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
					UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
					
					UnityEngine.GUILayout.AreaScope __cl_gen_ret = new UnityEngine.GUILayout.AreaScope(screenRect, content);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.GUIStyle>(L, 4))
				{
					UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
					string text = LuaAPI.lua_tostring(L, 3);
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUILayout.AreaScope __cl_gen_ret = new UnityEngine.GUILayout.AreaScope(screenRect, text, style);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Texture>(L, 3) && translator.Assignable<UnityEngine.GUIStyle>(L, 4))
				{
					UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
					UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUILayout.AreaScope __cl_gen_ret = new UnityEngine.GUILayout.AreaScope(screenRect, image, style);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.GUIContent>(L, 3) && translator.Assignable<UnityEngine.GUIStyle>(L, 4))
				{
					UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
					UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUILayout.AreaScope __cl_gen_ret = new UnityEngine.GUILayout.AreaScope(screenRect, content, style);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.AreaScope constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
