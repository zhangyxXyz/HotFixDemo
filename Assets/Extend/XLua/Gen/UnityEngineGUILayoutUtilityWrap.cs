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
    public class UnityEngineGUILayoutUtilityWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUILayoutUtility), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.GUILayoutUtility), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUILayoutUtility), L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRect", _m_GetRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLastRect", _m_GetLastRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAspectRect", _m_GetAspectRect_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUILayoutUtility));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GUILayoutUtility), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUILayoutUtility __cl_gen_ret = new UnityEngine.GUILayoutUtility();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayoutUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float width = (float)LuaAPI.lua_tonumber(L, 1);
                    float height = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( width, height );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( minWidth, maxWidth, minHeight, maxHeight );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    float width = (float)LuaAPI.lua_tonumber(L, 1);
                    float height = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( width, height, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    float width = (float)LuaAPI.lua_tonumber(L, 1);
                    float height = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( width, height, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    float minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( minWidth, maxWidth, minHeight, maxHeight, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    float minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( minWidth, maxWidth, minHeight, maxHeight, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( content, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    float width = (float)LuaAPI.lua_tonumber(L, 1);
                    float height = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( width, height, style, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    float maxWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float minHeight = (float)LuaAPI.lua_tonumber(L, 3);
                    float maxHeight = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( minWidth, maxWidth, minHeight, maxHeight, style, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetRect( content, style, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayoutUtility.GetRect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLastRect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetLastRect(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAspectRect_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( aspect );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    float aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( aspect, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    float aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( aspect, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    float aspect = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayoutUtility.GetAspectRect( aspect, style, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayoutUtility.GetAspectRect!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
