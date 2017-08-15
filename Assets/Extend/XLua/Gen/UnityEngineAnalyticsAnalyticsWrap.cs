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
    public class UnityEngineAnalyticsAnalyticsWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Analytics.Analytics), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Analytics.Analytics), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Analytics.Analytics), L, __CreateInstance, 7, 3, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FlushEvents", _m_FlushEvents_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetUserId", _m_SetUserId_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetUserGender", _m_SetUserGender_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetUserBirthYear", _m_SetUserBirthYear_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Transaction", _m_Transaction_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CustomEvent", _m_CustomEvent_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Analytics.Analytics));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "limitUserTracking", _g_get_limitUserTracking);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceStatsEnabled", _g_get_deviceStatsEnabled);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "enabled", _g_get_enabled);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "limitUserTracking", _s_set_limitUserTracking);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "deviceStatsEnabled", _s_set_deviceStatsEnabled);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "enabled", _s_set_enabled);
            
			Utils.EndClassRegister(typeof(UnityEngine.Analytics.Analytics), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Analytics.Analytics does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FlushEvents_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.FlushEvents(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUserId_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string userId = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.SetUserId( userId );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUserGender_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Analytics.Gender gender;translator.Get(L, 1, out gender);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.SetUserGender( gender );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUserBirthYear_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int birthYear = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.SetUserBirthYear( birthYear );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Transaction_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || translator.IsDecimal(L, 2))&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string productId = LuaAPI.lua_tostring(L, 1);
                    decimal amount;translator.Get(L, 2, out amount);
                    string currency = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.Transaction( productId, amount, currency );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || translator.IsDecimal(L, 2))&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)) 
                {
                    string productId = LuaAPI.lua_tostring(L, 1);
                    decimal amount;translator.Get(L, 2, out amount);
                    string currency = LuaAPI.lua_tostring(L, 3);
                    string receiptPurchaseData = LuaAPI.lua_tostring(L, 4);
                    string signature = LuaAPI.lua_tostring(L, 5);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.Transaction( productId, amount, currency, receiptPurchaseData, signature );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || translator.IsDecimal(L, 2))&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    string productId = LuaAPI.lua_tostring(L, 1);
                    decimal amount;translator.Get(L, 2, out amount);
                    string currency = LuaAPI.lua_tostring(L, 3);
                    string receiptPurchaseData = LuaAPI.lua_tostring(L, 4);
                    string signature = LuaAPI.lua_tostring(L, 5);
                    bool usingIAPService = LuaAPI.lua_toboolean(L, 6);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.Transaction( productId, amount, currency, receiptPurchaseData, signature, usingIAPService );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Analytics.Analytics.Transaction!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CustomEvent_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string customEventName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.CustomEvent( customEventName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    string customEventName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.CustomEvent( customEventName, position );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.IDictionary<string, object>>(L, 2)) 
                {
                    string customEventName = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.IDictionary<string, object> eventData = (System.Collections.Generic.IDictionary<string, object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IDictionary<string, object>));
                    
                        UnityEngine.Analytics.AnalyticsResult __cl_gen_ret = UnityEngine.Analytics.Analytics.CustomEvent( customEventName, eventData );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Analytics.Analytics.CustomEvent!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_limitUserTracking(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Analytics.Analytics.limitUserTracking);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceStatsEnabled(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Analytics.Analytics.deviceStatsEnabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Analytics.Analytics.enabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_limitUserTracking(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Analytics.Analytics.limitUserTracking = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_deviceStatsEnabled(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Analytics.Analytics.deviceStatsEnabled = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Analytics.Analytics.enabled = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
