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
    public class UnityEngineAssertionsAssertWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Assertions.Assert), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Assertions.Assert), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Assertions.Assert), L, __CreateInstance, 9, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "IsTrue", _m_IsTrue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsFalse", _m_IsFalse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AreApproximatelyEqual", _m_AreApproximatelyEqual_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AreNotApproximatelyEqual", _m_AreNotApproximatelyEqual_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AreEqual", _m_AreEqual_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AreNotEqual", _m_AreNotEqual_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsNull", _m_IsNull_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsNotNull", _m_IsNotNull_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Assertions.Assert));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "raiseExceptions", _g_get_raiseExceptions);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "raiseExceptions", _s_set_raiseExceptions);
            
			Utils.EndClassRegister(typeof(UnityEngine.Assertions.Assert), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Assertions.Assert does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTrue_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    
                    UnityEngine.Assertions.Assert.IsTrue( condition );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    string message = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.Assertions.Assert.IsTrue( condition, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Assertions.Assert.IsTrue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsFalse_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    
                    UnityEngine.Assertions.Assert.IsFalse( condition );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    bool condition = LuaAPI.lua_toboolean(L, 1);
                    string message = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.Assertions.Assert.IsFalse( condition, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Assertions.Assert.IsFalse!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AreApproximatelyEqual_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Assertions.Assert.AreApproximatelyEqual( expected, actual );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    float tolerance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.Assertions.Assert.AreApproximatelyEqual( expected, actual, tolerance );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    string message = LuaAPI.lua_tostring(L, 3);
                    
                    UnityEngine.Assertions.Assert.AreApproximatelyEqual( expected, actual, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    float tolerance = (float)LuaAPI.lua_tonumber(L, 3);
                    string message = LuaAPI.lua_tostring(L, 4);
                    
                    UnityEngine.Assertions.Assert.AreApproximatelyEqual( expected, actual, tolerance, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Assertions.Assert.AreApproximatelyEqual!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AreNotApproximatelyEqual_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Assertions.Assert.AreNotApproximatelyEqual( expected, actual );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    float tolerance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.Assertions.Assert.AreNotApproximatelyEqual( expected, actual, tolerance );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    string message = LuaAPI.lua_tostring(L, 3);
                    
                    UnityEngine.Assertions.Assert.AreNotApproximatelyEqual( expected, actual, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    float tolerance = (float)LuaAPI.lua_tonumber(L, 3);
                    string message = LuaAPI.lua_tostring(L, 4);
                    
                    UnityEngine.Assertions.Assert.AreNotApproximatelyEqual( expected, actual, tolerance, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Assertions.Assert.AreNotApproximatelyEqual!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AreEqual_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object expected = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    UnityEngine.Object actual = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    string message = LuaAPI.lua_tostring(L, 3);
                    
                    UnityEngine.Assertions.Assert.AreEqual( expected, actual, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AreNotEqual_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object expected = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    UnityEngine.Object actual = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    string message = LuaAPI.lua_tostring(L, 3);
                    
                    UnityEngine.Assertions.Assert.AreNotEqual( expected, actual, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsNull_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object value = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string message = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.Assertions.Assert.IsNull( value, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsNotNull_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object value = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string message = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.Assertions.Assert.IsNotNull( value, message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raiseExceptions(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Assertions.Assert.raiseExceptions);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raiseExceptions(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Assertions.Assert.raiseExceptions = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
