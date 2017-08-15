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
    public class UnityEngineEventSystemsStandaloneInputModuleWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.StandaloneInputModule), L, translator, 0, 6, 7, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateModule", _m_UpdateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsModuleSupported", _m_IsModuleSupported);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShouldActivateModule", _m_ShouldActivateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ActivateModule", _m_ActivateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeactivateModule", _m_DeactivateModule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceModuleActive", _g_get_forceModuleActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inputActionsPerSecond", _g_get_inputActionsPerSecond);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "repeatDelay", _g_get_repeatDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalAxis", _g_get_horizontalAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalAxis", _g_get_verticalAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "submitButton", _g_get_submitButton);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cancelButton", _g_get_cancelButton);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "forceModuleActive", _s_set_forceModuleActive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inputActionsPerSecond", _s_set_inputActionsPerSecond);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "repeatDelay", _s_set_repeatDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalAxis", _s_set_horizontalAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalAxis", _s_set_verticalAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "submitButton", _s_set_submitButton);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cancelButton", _s_set_cancelButton);
            
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.StandaloneInputModule), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.StandaloneInputModule), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.EventSystems.StandaloneInputModule));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.EventSystems.StandaloneInputModule), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.EventSystems.StandaloneInputModule does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateModule(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.UpdateModule(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsModuleSupported(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsModuleSupported(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShouldActivateModule(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ShouldActivateModule(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ActivateModule(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ActivateModule(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeactivateModule(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.DeactivateModule(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Process(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Process(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forceModuleActive(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.forceModuleActive);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputActionsPerSecond(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.inputActionsPerSecond);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_repeatDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.repeatDelay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.horizontalAxis);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.verticalAxis);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_submitButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.submitButton);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cancelButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.cancelButton);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forceModuleActive(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.forceModuleActive = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputActionsPerSecond(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.inputActionsPerSecond = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_repeatDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.repeatDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalAxis = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalAxis = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_submitButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.submitButton = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cancelButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.StandaloneInputModule __cl_gen_to_be_invoked = (UnityEngine.EventSystems.StandaloneInputModule)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cancelButton = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
