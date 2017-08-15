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
    public class UnityEngineVRVRStatsWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.VR.VRStats), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.VR.VRStats), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.VR.VRStats), L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "TryGetGPUTimeLastFrame", _m_TryGetGPUTimeLastFrame_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryGetDroppedFrameCount", _m_TryGetDroppedFrameCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryGetFramePresentCount", _m_TryGetFramePresentCount_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.VR.VRStats));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.VR.VRStats), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.VR.VRStats does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetGPUTimeLastFrame_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float gpuTimeLastFrame;
                    
                        bool __cl_gen_ret = UnityEngine.VR.VRStats.TryGetGPUTimeLastFrame( out gpuTimeLastFrame );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushnumber(L, gpuTimeLastFrame);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetDroppedFrameCount_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int droppedFrameCount;
                    
                        bool __cl_gen_ret = UnityEngine.VR.VRStats.TryGetDroppedFrameCount( out droppedFrameCount );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.xlua_pushinteger(L, droppedFrameCount);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetFramePresentCount_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int framePresentCount;
                    
                        bool __cl_gen_ret = UnityEngine.VR.VRStats.TryGetFramePresentCount( out framePresentCount );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.xlua_pushinteger(L, framePresentCount);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
