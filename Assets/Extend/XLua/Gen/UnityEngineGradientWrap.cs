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
    public class UnityEngineGradientWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Gradient), L, translator, 0, 2, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Evaluate", _m_Evaluate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetKeys", _m_SetKeys);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorKeys", _g_get_colorKeys);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alphaKeys", _g_get_alphaKeys);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mode", _g_get_mode);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "colorKeys", _s_set_colorKeys);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alphaKeys", _s_set_alphaKeys);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mode", _s_set_mode);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Gradient), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Gradient), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Gradient));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Gradient), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Gradient __cl_gen_ret = new UnityEngine.Gradient();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Gradient constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Evaluate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float time = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Color __cl_gen_ret = __cl_gen_to_be_invoked.Evaluate( time );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetKeys(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.GradientColorKey[] colorKeys = (UnityEngine.GradientColorKey[])translator.GetObject(L, 2, typeof(UnityEngine.GradientColorKey[]));
                    UnityEngine.GradientAlphaKey[] alphaKeys = (UnityEngine.GradientAlphaKey[])translator.GetObject(L, 3, typeof(UnityEngine.GradientAlphaKey[]));
                    
                    __cl_gen_to_be_invoked.SetKeys( colorKeys, alphaKeys );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorKeys(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.colorKeys);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alphaKeys(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.alphaKeys);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.mode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colorKeys(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.colorKeys = (UnityEngine.GradientColorKey[])translator.GetObject(L, 2, typeof(UnityEngine.GradientColorKey[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alphaKeys(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.alphaKeys = (UnityEngine.GradientAlphaKey[])translator.GetObject(L, 2, typeof(UnityEngine.GradientAlphaKey[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Gradient __cl_gen_to_be_invoked = (UnityEngine.Gradient)translator.FastGetCSObj(L, 1);
                UnityEngine.GradientMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.mode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
