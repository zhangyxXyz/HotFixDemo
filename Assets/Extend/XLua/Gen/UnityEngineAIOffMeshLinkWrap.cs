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
    public class UnityEngineAIOffMeshLinkWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AI.OffMeshLink), L, translator, 0, 1, 8, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePositions", _m_UpdatePositions);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "activated", _g_get_activated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "occupied", _g_get_occupied);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "costOverride", _g_get_costOverride);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "biDirectional", _g_get_biDirectional);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "area", _g_get_area);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoUpdatePositions", _g_get_autoUpdatePositions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startTransform", _g_get_startTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endTransform", _g_get_endTransform);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "activated", _s_set_activated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "costOverride", _s_set_costOverride);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "biDirectional", _s_set_biDirectional);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "area", _s_set_area);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoUpdatePositions", _s_set_autoUpdatePositions);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startTransform", _s_set_startTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endTransform", _s_set_endTransform);
            
			Utils.EndObjectRegister(typeof(UnityEngine.AI.OffMeshLink), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AI.OffMeshLink), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AI.OffMeshLink));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.AI.OffMeshLink), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.AI.OffMeshLink __cl_gen_ret = new UnityEngine.AI.OffMeshLink();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.OffMeshLink constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePositions(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.UpdatePositions(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.activated);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_occupied(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.occupied);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_costOverride(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.costOverride);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_biDirectional(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.biDirectional);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_area(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.area);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoUpdatePositions(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.autoUpdatePositions);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.startTransform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.endTransform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_activated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.activated = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_costOverride(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.costOverride = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_biDirectional(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.biDirectional = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_area(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.area = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoUpdatePositions(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.autoUpdatePositions = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endTransform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AI.OffMeshLink __cl_gen_to_be_invoked = (UnityEngine.AI.OffMeshLink)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.endTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
