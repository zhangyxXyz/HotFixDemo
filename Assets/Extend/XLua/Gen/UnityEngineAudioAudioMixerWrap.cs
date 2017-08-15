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
    public class UnityEngineAudioAudioMixerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Audio.AudioMixer), L, translator, 0, 6, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindMatchingGroups", _m_FindMatchingGroups);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindSnapshot", _m_FindSnapshot);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransitionToSnapshots", _m_TransitionToSnapshots);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloat", _m_SetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearFloat", _m_ClearFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloat", _m_GetFloat);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "outputAudioMixerGroup", _g_get_outputAudioMixerGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updateMode", _g_get_updateMode);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "outputAudioMixerGroup", _s_set_outputAudioMixerGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updateMode", _s_set_updateMode);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Audio.AudioMixer), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Audio.AudioMixer), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Audio.AudioMixer));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Audio.AudioMixer), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Audio.AudioMixer does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindMatchingGroups(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string subPath = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Audio.AudioMixerGroup[] __cl_gen_ret = __cl_gen_to_be_invoked.FindMatchingGroups( subPath );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindSnapshot(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Audio.AudioMixerSnapshot __cl_gen_ret = __cl_gen_to_be_invoked.FindSnapshot( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TransitionToSnapshots(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Audio.AudioMixerSnapshot[] snapshots = (UnityEngine.Audio.AudioMixerSnapshot[])translator.GetObject(L, 2, typeof(UnityEngine.Audio.AudioMixerSnapshot[]));
                    float[] weights = (float[])translator.GetObject(L, 3, typeof(float[]));
                    float timeToReach = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.TransitionToSnapshots( snapshots, weights, timeToReach );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.SetFloat( name, value );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearFloat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ClearFloat( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    float value;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetFloat( name, out value );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    LuaAPI.lua_pushnumber(L, value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_outputAudioMixerGroup(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.outputAudioMixerGroup);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updateMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.updateMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_outputAudioMixerGroup(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.outputAudioMixerGroup = (UnityEngine.Audio.AudioMixerGroup)translator.GetObject(L, 2, typeof(UnityEngine.Audio.AudioMixerGroup));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_updateMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Audio.AudioMixer __cl_gen_to_be_invoked = (UnityEngine.Audio.AudioMixer)translator.FastGetCSObj(L, 1);
                UnityEngine.Audio.AudioMixerUpdateMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.updateMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
