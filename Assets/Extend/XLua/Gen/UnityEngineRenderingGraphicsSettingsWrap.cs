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
    public class UnityEngineRenderingGraphicsSettingsWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Rendering.GraphicsSettings), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Rendering.GraphicsSettings), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Rendering.GraphicsSettings), L, __CreateInstance, 5, 5, 5);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetShaderMode", _m_SetShaderMode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetShaderMode", _m_GetShaderMode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCustomShader", _m_SetCustomShader_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCustomShader", _m_GetCustomShader_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Rendering.GraphicsSettings));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "renderPipelineAsset", _g_get_renderPipelineAsset);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "transparencySortMode", _g_get_transparencySortMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "transparencySortAxis", _g_get_transparencySortAxis);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "lightsUseLinearIntensity", _g_get_lightsUseLinearIntensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "lightsUseColorTemperature", _g_get_lightsUseColorTemperature);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "renderPipelineAsset", _s_set_renderPipelineAsset);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "transparencySortMode", _s_set_transparencySortMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "transparencySortAxis", _s_set_transparencySortAxis);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "lightsUseLinearIntensity", _s_set_lightsUseLinearIntensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "lightsUseColorTemperature", _s_set_lightsUseColorTemperature);
            
			Utils.EndClassRegister(typeof(UnityEngine.Rendering.GraphicsSettings), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Rendering.GraphicsSettings __cl_gen_ret = new UnityEngine.Rendering.GraphicsSettings();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.GraphicsSettings constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetShaderMode_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rendering.BuiltinShaderType type;translator.Get(L, 1, out type);
                    UnityEngine.Rendering.BuiltinShaderMode mode;translator.Get(L, 2, out mode);
                    
                    UnityEngine.Rendering.GraphicsSettings.SetShaderMode( type, mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetShaderMode_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rendering.BuiltinShaderType type;translator.Get(L, 1, out type);
                    
                        UnityEngine.Rendering.BuiltinShaderMode __cl_gen_ret = UnityEngine.Rendering.GraphicsSettings.GetShaderMode( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCustomShader_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rendering.BuiltinShaderType type;translator.Get(L, 1, out type);
                    UnityEngine.Shader shader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
                    
                    UnityEngine.Rendering.GraphicsSettings.SetCustomShader( type, shader );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCustomShader_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rendering.BuiltinShaderType type;translator.Get(L, 1, out type);
                    
                        UnityEngine.Shader __cl_gen_ret = UnityEngine.Rendering.GraphicsSettings.GetCustomShader( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderPipelineAsset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transparencySortMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.Rendering.GraphicsSettings.transparencySortMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transparencySortAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineVector3(L, UnityEngine.Rendering.GraphicsSettings.transparencySortAxis);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightsUseLinearIntensity(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightsUseColorTemperature(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderPipelineAsset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset = (UnityEngine.Experimental.Rendering.RenderPipelineAsset)translator.GetObject(L, 1, typeof(UnityEngine.Experimental.Rendering.RenderPipelineAsset));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_transparencySortMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.TransparencySortMode __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Rendering.GraphicsSettings.transparencySortMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_transparencySortAxis(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Rendering.GraphicsSettings.transparencySortAxis = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightsUseLinearIntensity(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightsUseColorTemperature(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
