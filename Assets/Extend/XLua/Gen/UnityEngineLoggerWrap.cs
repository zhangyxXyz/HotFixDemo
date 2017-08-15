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
    public class UnityEngineLoggerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Logger), L, translator, 0, 6, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsLogTypeAllowed", _m_IsLogTypeAllowed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Log", _m_Log);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogWarning", _m_LogWarning);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogError", _m_LogError);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogFormat", _m_LogFormat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogException", _m_LogException);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "logHandler", _g_get_logHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "logEnabled", _g_get_logEnabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filterLogType", _g_get_filterLogType);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "logHandler", _s_set_logHandler);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "logEnabled", _s_set_logEnabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filterLogType", _s_set_filterLogType);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Logger), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Logger), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Logger));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Logger), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.ILogHandler>(L, 2))
				{
					UnityEngine.ILogHandler logHandler = (UnityEngine.ILogHandler)translator.GetObject(L, 2, typeof(UnityEngine.ILogHandler));
					
					UnityEngine.Logger __cl_gen_ret = new UnityEngine.Logger(logHandler);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLogTypeAllowed(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.LogType logType;translator.Get(L, 2, out logType);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsLogTypeAllowed( logType );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Log(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 2, typeof(object));
                    
                    __cl_gen_to_be_invoked.Log( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.LogType>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    UnityEngine.LogType logType;translator.Get(L, 2, out logType);
                    object message = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.Log( logType, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    object message = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.Log( tag, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.LogType>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    UnityEngine.LogType logType;translator.Get(L, 2, out logType);
                    object message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.Log( logType, message, context );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.LogType>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 4)) 
                {
                    UnityEngine.LogType logType;translator.Get(L, 2, out logType);
                    string tag = LuaAPI.lua_tostring(L, 3);
                    object message = translator.GetObject(L, 4, typeof(object));
                    
                    __cl_gen_to_be_invoked.Log( logType, tag, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    object message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.Log( tag, message, context );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.LogType>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 4)&& translator.Assignable<UnityEngine.Object>(L, 5)) 
                {
                    UnityEngine.LogType logType;translator.Get(L, 2, out logType);
                    string tag = LuaAPI.lua_tostring(L, 3);
                    object message = translator.GetObject(L, 4, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 5, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.Log( logType, tag, message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.Log!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogWarning(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    object message = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.LogWarning( tag, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    object message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.LogWarning( tag, message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogWarning!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogError(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    object message = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.LogError( tag, message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    object message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.LogError( tag, message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogError!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogFormat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 3&& translator.Assignable<UnityEngine.LogType>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<object>(L, 4))) 
                {
                    UnityEngine.LogType logType;translator.Get(L, 2, out logType);
                    string format = LuaAPI.lua_tostring(L, 3);
                    object[] args = translator.GetParams<object>(L, 4);
                    
                    __cl_gen_to_be_invoked.LogFormat( logType, format, args );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 4&& translator.Assignable<UnityEngine.LogType>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<object>(L, 5))) 
                {
                    UnityEngine.LogType logType;translator.Get(L, 2, out logType);
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    string format = LuaAPI.lua_tostring(L, 4);
                    object[] args = translator.GetParams<object>(L, 5);
                    
                    __cl_gen_to_be_invoked.LogFormat( logType, context, format, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogFormat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogException(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Exception>(L, 2)) 
                {
                    System.Exception exception = (System.Exception)translator.GetObject(L, 2, typeof(System.Exception));
                    
                    __cl_gen_to_be_invoked.LogException( exception );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Exception>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)) 
                {
                    System.Exception exception = (System.Exception)translator.GetObject(L, 2, typeof(System.Exception));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.LogException( exception, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogException!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logHandler(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.logHandler);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logEnabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.logEnabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filterLogType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.filterLogType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_logHandler(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.logHandler = (UnityEngine.ILogHandler)translator.GetObject(L, 2, typeof(UnityEngine.ILogHandler));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_logEnabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.logEnabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filterLogType(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Logger __cl_gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                UnityEngine.LogType __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.filterLogType = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
