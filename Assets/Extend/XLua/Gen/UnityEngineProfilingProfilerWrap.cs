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
    public class UnityEngineProfilingProfilerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Profiling.Profiler), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Profiling.Profiler), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Profiling.Profiler), L, __CreateInstance, 12, 5, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddFramesFromFile", _m_AddFramesFromFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginSample", _m_BeginSample_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndSample", _m_EndSample_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRuntimeMemorySizeLong", _m_GetRuntimeMemorySizeLong_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMonoHeapSizeLong", _m_GetMonoHeapSizeLong_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMonoUsedSizeLong", _m_GetMonoUsedSizeLong_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetTempAllocatorRequestedSize", _m_SetTempAllocatorRequestedSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTempAllocatorSize", _m_GetTempAllocatorSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalAllocatedMemoryLong", _m_GetTotalAllocatedMemoryLong_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalUnusedReservedMemoryLong", _m_GetTotalUnusedReservedMemoryLong_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalReservedMemoryLong", _m_GetTotalReservedMemoryLong_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Profiling.Profiler));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supported", _g_get_supported);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "logFile", _g_get_logFile);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "enableBinaryLog", _g_get_enableBinaryLog);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "usedHeapSizeLong", _g_get_usedHeapSizeLong);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "logFile", _s_set_logFile);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "enableBinaryLog", _s_set_enableBinaryLog);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "enabled", _s_set_enabled);
            
			Utils.EndClassRegister(typeof(UnityEngine.Profiling.Profiler), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Profiling.Profiler does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddFramesFromFile_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string file = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Profiling.Profiler.AddFramesFromFile( file );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSample_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Profiling.Profiler.BeginSample( name );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Object targetObject = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    UnityEngine.Profiling.Profiler.BeginSample( name, targetObject );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Profiling.Profiler.BeginSample!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSample_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.Profiling.Profiler.EndSample(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRuntimeMemorySizeLong_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Object o = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        long __cl_gen_ret = UnityEngine.Profiling.Profiler.GetRuntimeMemorySizeLong( o );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMonoHeapSizeLong_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        long __cl_gen_ret = UnityEngine.Profiling.Profiler.GetMonoHeapSizeLong(  );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMonoUsedSizeLong_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        long __cl_gen_ret = UnityEngine.Profiling.Profiler.GetMonoUsedSizeLong(  );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTempAllocatorRequestedSize_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    uint size = LuaAPI.xlua_touint(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.Profiling.Profiler.SetTempAllocatorRequestedSize( size );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTempAllocatorSize_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        uint __cl_gen_ret = UnityEngine.Profiling.Profiler.GetTempAllocatorSize(  );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalAllocatedMemoryLong_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        long __cl_gen_ret = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong(  );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalUnusedReservedMemoryLong_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        long __cl_gen_ret = UnityEngine.Profiling.Profiler.GetTotalUnusedReservedMemoryLong(  );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalReservedMemoryLong_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        long __cl_gen_ret = UnityEngine.Profiling.Profiler.GetTotalReservedMemoryLong(  );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supported(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Profiling.Profiler.supported);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logFile(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, UnityEngine.Profiling.Profiler.logFile);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableBinaryLog(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Profiling.Profiler.enableBinaryLog);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Profiling.Profiler.enabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usedHeapSizeLong(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushint64(L, UnityEngine.Profiling.Profiler.usedHeapSizeLong);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_logFile(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Profiling.Profiler.logFile = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableBinaryLog(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Profiling.Profiler.enableBinaryLog = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Profiling.Profiler.enabled = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
