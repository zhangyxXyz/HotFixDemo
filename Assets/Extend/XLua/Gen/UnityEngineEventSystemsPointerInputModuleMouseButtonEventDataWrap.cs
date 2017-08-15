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
    public class UnityEngineEventSystemsPointerInputModuleMouseButtonEventDataWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), L, translator, 0, 2, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PressedThisFrame", _m_PressedThisFrame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReleasedThisFrame", _m_ReleasedThisFrame);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "buttonState", _g_get_buttonState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "buttonData", _g_get_buttonData);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "buttonState", _s_set_buttonState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "buttonData", _s_set_buttonData);
            
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData __cl_gen_ret = new UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PressedThisFrame(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.PressedThisFrame(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleasedThisFrame(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ReleasedThisFrame(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_buttonState(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.buttonState);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_buttonData(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.buttonData);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_buttonState(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.EventSystems.PointerEventData.FramePressState __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.buttonState = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_buttonData(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.buttonData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
