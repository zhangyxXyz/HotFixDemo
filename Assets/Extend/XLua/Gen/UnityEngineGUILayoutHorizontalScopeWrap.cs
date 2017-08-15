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
    public class UnityEngineGUILayoutHorizontalScopeWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUILayout.HorizontalScope), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.GUILayout.HorizontalScope), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUILayout.HorizontalScope), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUILayout.HorizontalScope));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GUILayout.HorizontalScope), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) >= 1 && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2)))
				{
					UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
					
					UnityEngine.GUILayout.HorizontalScope __cl_gen_ret = new UnityEngine.GUILayout.HorizontalScope(options);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 2 && translator.Assignable<UnityEngine.GUIStyle>(L, 2) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3)))
				{
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
					
					UnityEngine.GUILayout.HorizontalScope __cl_gen_ret = new UnityEngine.GUILayout.HorizontalScope(style, options);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4)))
				{
					string text = LuaAPI.lua_tostring(L, 2);
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
					
					UnityEngine.GUILayout.HorizontalScope __cl_gen_ret = new UnityEngine.GUILayout.HorizontalScope(text, style, options);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && translator.Assignable<UnityEngine.Texture>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4)))
				{
					UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
					
					UnityEngine.GUILayout.HorizontalScope __cl_gen_ret = new UnityEngine.GUILayout.HorizontalScope(image, style, options);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 3 && translator.Assignable<UnityEngine.GUIContent>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4)))
				{
					UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
					
					UnityEngine.GUILayout.HorizontalScope __cl_gen_ret = new UnityEngine.GUILayout.HorizontalScope(content, style, options);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.HorizontalScope constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
