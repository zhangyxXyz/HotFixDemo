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
    public class UnityEngineILogHandlerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.ILogHandler), L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogFormat", _m_LogFormat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogException", _m_LogException);
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.ILogHandler), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.ILogHandler), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.ILogHandler));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.ILogHandler), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.ILogHandler does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogFormat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ILogHandler __cl_gen_to_be_invoked = (UnityEngine.ILogHandler)translator.FastGetCSObj(L, 1);
            
            
            try {
                
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
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogException(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ILogHandler __cl_gen_to_be_invoked = (UnityEngine.ILogHandler)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Exception exception = (System.Exception)translator.GetObject(L, 2, typeof(System.Exception));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.LogException( exception, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
