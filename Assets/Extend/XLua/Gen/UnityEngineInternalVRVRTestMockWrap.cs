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
    public class UnityEngineInternalVRVRTestMockWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Internal.VR.VRTestMock), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Internal.VR.VRTestMock), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Internal.VR.VRTestMock), L, __CreateInstance, 11, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Reset", _m_Reset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddTrackedDevice", _m_AddTrackedDevice_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateTrackedDevice", _m_UpdateTrackedDevice_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateLeftEye", _m_UpdateLeftEye_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateRightEye", _m_UpdateRightEye_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateLeftHand", _m_UpdateLeftHand_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateRightHand", _m_UpdateRightHand_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddController", _m_AddController_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateControllerAxis", _m_UpdateControllerAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateControllerButton", _m_UpdateControllerButton_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Internal.VR.VRTestMock));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Internal.VR.VRTestMock), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Internal.VR.VRTestMock does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.Internal.VR.VRTestMock.Reset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTrackedDevice_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string deviceName = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Internal.VR.VRTestMock.AddTrackedDevice( deviceName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateTrackedDevice_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string deviceName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    
                    UnityEngine.Internal.VR.VRTestMock.UpdateTrackedDevice( deviceName, position, rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateLeftEye_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 2, out rotation);
                    
                    UnityEngine.Internal.VR.VRTestMock.UpdateLeftEye( position, rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateRightEye_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 2, out rotation);
                    
                    UnityEngine.Internal.VR.VRTestMock.UpdateRightEye( position, rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateLeftHand_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 2, out rotation);
                    
                    UnityEngine.Internal.VR.VRTestMock.UpdateLeftHand( position, rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateRightHand_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 position;translator.Get(L, 1, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 2, out rotation);
                    
                    UnityEngine.Internal.VR.VRTestMock.UpdateRightHand( position, rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddController_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string controllerName = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Internal.VR.VRTestMock.AddController( controllerName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateControllerAxis_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string controllerName = LuaAPI.lua_tostring(L, 1);
                    int axis = LuaAPI.xlua_tointeger(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.Internal.VR.VRTestMock.UpdateControllerAxis( controllerName, axis, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateControllerButton_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string controllerName = LuaAPI.lua_tostring(L, 1);
                    int button = LuaAPI.xlua_tointeger(L, 2);
                    bool pressed = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Internal.VR.VRTestMock.UpdateControllerButton( controllerName, button, pressed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
