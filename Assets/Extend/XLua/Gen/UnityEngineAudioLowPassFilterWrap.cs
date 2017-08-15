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
    public class UnityEngineAudioLowPassFilterWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AudioLowPassFilter), L, translator, 0, 0, 3, 3);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cutoffFrequency", _g_get_cutoffFrequency);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customCutoffCurve", _g_get_customCutoffCurve);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lowpassResonanceQ", _g_get_lowpassResonanceQ);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "cutoffFrequency", _s_set_cutoffFrequency);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customCutoffCurve", _s_set_customCutoffCurve);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lowpassResonanceQ", _s_set_lowpassResonanceQ);
            
			Utils.EndObjectRegister(typeof(UnityEngine.AudioLowPassFilter), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AudioLowPassFilter), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AudioLowPassFilter));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.AudioLowPassFilter), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.AudioLowPassFilter __cl_gen_ret = new UnityEngine.AudioLowPassFilter();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AudioLowPassFilter constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cutoffFrequency(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AudioLowPassFilter __cl_gen_to_be_invoked = (UnityEngine.AudioLowPassFilter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.cutoffFrequency);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customCutoffCurve(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AudioLowPassFilter __cl_gen_to_be_invoked = (UnityEngine.AudioLowPassFilter)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.customCutoffCurve);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lowpassResonanceQ(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AudioLowPassFilter __cl_gen_to_be_invoked = (UnityEngine.AudioLowPassFilter)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.lowpassResonanceQ);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cutoffFrequency(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AudioLowPassFilter __cl_gen_to_be_invoked = (UnityEngine.AudioLowPassFilter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cutoffFrequency = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customCutoffCurve(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AudioLowPassFilter __cl_gen_to_be_invoked = (UnityEngine.AudioLowPassFilter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.customCutoffCurve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lowpassResonanceQ(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AudioLowPassFilter __cl_gen_to_be_invoked = (UnityEngine.AudioLowPassFilter)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.lowpassResonanceQ = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
