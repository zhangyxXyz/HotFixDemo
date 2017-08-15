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
    public class UnityEnginePlatformEffector2DWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.PlatformEffector2D), L, translator, 0, 0, 7, 7);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "useOneWay", _g_get_useOneWay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useOneWayGrouping", _g_get_useOneWayGrouping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useSideFriction", _g_get_useSideFriction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useSideBounce", _g_get_useSideBounce);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "surfaceArc", _g_get_surfaceArc);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sideArc", _g_get_sideArc);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationalOffset", _g_get_rotationalOffset);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "useOneWay", _s_set_useOneWay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useOneWayGrouping", _s_set_useOneWayGrouping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useSideFriction", _s_set_useSideFriction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useSideBounce", _s_set_useSideBounce);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "surfaceArc", _s_set_surfaceArc);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sideArc", _s_set_sideArc);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotationalOffset", _s_set_rotationalOffset);
            
			Utils.EndObjectRegister(typeof(UnityEngine.PlatformEffector2D), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.PlatformEffector2D), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.PlatformEffector2D));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.PlatformEffector2D), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.PlatformEffector2D __cl_gen_ret = new UnityEngine.PlatformEffector2D();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PlatformEffector2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useOneWay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useOneWay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useOneWayGrouping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useOneWayGrouping);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useSideFriction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useSideFriction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useSideBounce(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useSideBounce);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_surfaceArc(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.surfaceArc);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sideArc(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.sideArc);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationalOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.rotationalOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useOneWay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useOneWay = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useOneWayGrouping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useOneWayGrouping = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useSideFriction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useSideFriction = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useSideBounce(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useSideBounce = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_surfaceArc(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.surfaceArc = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sideArc(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sideArc = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotationalOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.PlatformEffector2D __cl_gen_to_be_invoked = (UnityEngine.PlatformEffector2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.rotationalOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
