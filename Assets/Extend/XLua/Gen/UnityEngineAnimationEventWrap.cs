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
    public class UnityEngineAnimationEventWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AnimationEvent), L, translator, 0, 0, 12, 7);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "stringParameter", _g_get_stringParameter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "floatParameter", _g_get_floatParameter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "intParameter", _g_get_intParameter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "objectReferenceParameter", _g_get_objectReferenceParameter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "functionName", _g_get_functionName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "time", _g_get_time);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "messageOptions", _g_get_messageOptions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFiredByLegacy", _g_get_isFiredByLegacy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFiredByAnimator", _g_get_isFiredByAnimator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animationState", _g_get_animationState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animatorStateInfo", _g_get_animatorStateInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animatorClipInfo", _g_get_animatorClipInfo);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "stringParameter", _s_set_stringParameter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "floatParameter", _s_set_floatParameter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "intParameter", _s_set_intParameter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "objectReferenceParameter", _s_set_objectReferenceParameter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "functionName", _s_set_functionName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "time", _s_set_time);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "messageOptions", _s_set_messageOptions);
            
			Utils.EndObjectRegister(typeof(UnityEngine.AnimationEvent), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AnimationEvent), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AnimationEvent));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.AnimationEvent), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.AnimationEvent __cl_gen_ret = new UnityEngine.AnimationEvent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimationEvent constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stringParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.stringParameter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_floatParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.floatParameter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_intParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.intParameter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_objectReferenceParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.objectReferenceParameter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_functionName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.functionName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_time(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.time);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_messageOptions(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.messageOptions);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFiredByLegacy(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isFiredByLegacy);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFiredByAnimator(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isFiredByAnimator);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animationState(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.animationState);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animatorStateInfo(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.animatorStateInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animatorClipInfo(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.animatorClipInfo);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stringParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stringParameter = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_floatParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.floatParameter = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_intParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.intParameter = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_objectReferenceParameter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.objectReferenceParameter = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_functionName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.functionName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_time(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.time = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_messageOptions(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationEvent __cl_gen_to_be_invoked = (UnityEngine.AnimationEvent)translator.FastGetCSObj(L, 1);
                UnityEngine.SendMessageOptions __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.messageOptions = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
