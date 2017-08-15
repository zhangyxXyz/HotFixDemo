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
    public class UnityEngineGUIGroupScopeWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUI.GroupScope), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.GUI.GroupScope), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUI.GroupScope), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUI.GroupScope));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GUI.GroupScope), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Rect>(L, 2))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					
					UnityEngine.GUI.GroupScope __cl_gen_ret = new UnityEngine.GUI.GroupScope(position);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					string text = LuaAPI.lua_tostring(L, 3);
					
					UnityEngine.GUI.GroupScope __cl_gen_ret = new UnityEngine.GUI.GroupScope(position, text);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Texture>(L, 3))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
					
					UnityEngine.GUI.GroupScope __cl_gen_ret = new UnityEngine.GUI.GroupScope(position, image);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.GUIContent>(L, 3))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
					
					UnityEngine.GUI.GroupScope __cl_gen_ret = new UnityEngine.GUI.GroupScope(position, content);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.GUIStyle>(L, 3))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.GroupScope __cl_gen_ret = new UnityEngine.GUI.GroupScope(position, style);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.GUIStyle>(L, 4))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					string text = LuaAPI.lua_tostring(L, 3);
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.GroupScope __cl_gen_ret = new UnityEngine.GUI.GroupScope(position, text, style);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.Rect>(L, 2) && translator.Assignable<UnityEngine.Texture>(L, 3) && translator.Assignable<UnityEngine.GUIStyle>(L, 4))
				{
					UnityEngine.Rect position;translator.Get(L, 2, out position);
					UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
					UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUI.GroupScope __cl_gen_ret = new UnityEngine.GUI.GroupScope(position, image, style);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.GroupScope constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
