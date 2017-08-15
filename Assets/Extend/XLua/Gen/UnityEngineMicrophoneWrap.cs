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
    public class UnityEngineMicrophoneWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Microphone), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Microphone), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Microphone), L, __CreateInstance, 6, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Start", _m_Start_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "End", _m_End_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsRecording", _m_IsRecording_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPosition", _m_GetPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDeviceCaps", _m_GetDeviceCaps_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Microphone));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "devices", _g_get_devices);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.Microphone), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Microphone __cl_gen_ret = new UnityEngine.Microphone();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Microphone constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Start_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string deviceName = LuaAPI.lua_tostring(L, 1);
                    bool loop = LuaAPI.lua_toboolean(L, 2);
                    int lengthSec = LuaAPI.xlua_tointeger(L, 3);
                    int frequency = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.AudioClip __cl_gen_ret = UnityEngine.Microphone.Start( deviceName, loop, lengthSec, frequency );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_End_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string deviceName = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Microphone.End( deviceName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRecording_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string deviceName = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.Microphone.IsRecording( deviceName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPosition_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string deviceName = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.Microphone.GetPosition( deviceName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDeviceCaps_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string deviceName = LuaAPI.lua_tostring(L, 1);
                    int minFreq;
                    int maxFreq;
                    
                    UnityEngine.Microphone.GetDeviceCaps( deviceName, out minFreq, out maxFreq );
                    LuaAPI.xlua_pushinteger(L, minFreq);
                        
                    LuaAPI.xlua_pushinteger(L, maxFreq);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_devices(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Microphone.devices);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
