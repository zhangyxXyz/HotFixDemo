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
    public class UnityEngineProceduralMaterialWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.ProceduralMaterial), L, translator, 0, 23, 9, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProceduralPropertyDescriptions", _m_GetProceduralPropertyDescriptions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasProceduralProperty", _m_HasProceduralProperty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProceduralBoolean", _m_GetProceduralBoolean);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsProceduralPropertyVisible", _m_IsProceduralPropertyVisible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetProceduralBoolean", _m_SetProceduralBoolean);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProceduralFloat", _m_GetProceduralFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetProceduralFloat", _m_SetProceduralFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProceduralVector", _m_GetProceduralVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetProceduralVector", _m_SetProceduralVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProceduralColor", _m_GetProceduralColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetProceduralColor", _m_SetProceduralColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProceduralEnum", _m_GetProceduralEnum);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetProceduralEnum", _m_SetProceduralEnum);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProceduralTexture", _m_GetProceduralTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetProceduralTexture", _m_SetProceduralTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsProceduralPropertyCached", _m_IsProceduralPropertyCached);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CacheProceduralProperty", _m_CacheProceduralProperty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearCache", _m_ClearCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RebuildTextures", _m_RebuildTextures);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RebuildTexturesImmediately", _m_RebuildTexturesImmediately);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGeneratedTextures", _m_GetGeneratedTextures);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGeneratedTexture", _m_GetGeneratedTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FreezeAndReleaseSourceData", _m_FreezeAndReleaseSourceData);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cacheSize", _g_get_cacheSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animationUpdateRate", _g_get_animationUpdateRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isProcessing", _g_get_isProcessing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isCachedDataAvailable", _g_get_isCachedDataAvailable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isLoadTimeGenerated", _g_get_isLoadTimeGenerated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loadingBehavior", _g_get_loadingBehavior);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preset", _g_get_preset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isReadable", _g_get_isReadable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFrozen", _g_get_isFrozen);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "cacheSize", _s_set_cacheSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "animationUpdateRate", _s_set_animationUpdateRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isLoadTimeGenerated", _s_set_isLoadTimeGenerated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "preset", _s_set_preset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isReadable", _s_set_isReadable);
            
			Utils.EndObjectRegister(typeof(UnityEngine.ProceduralMaterial), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.ProceduralMaterial), L, __CreateInstance, 2, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "StopRebuilds", _m_StopRebuilds_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.ProceduralMaterial));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isSupported", _g_get_isSupported);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "substanceProcessorUsage", _g_get_substanceProcessorUsage);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "substanceProcessorUsage", _s_set_substanceProcessorUsage);
            
			Utils.EndClassRegister(typeof(UnityEngine.ProceduralMaterial), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.ProceduralMaterial does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProceduralPropertyDescriptions(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UnityEngine.ProceduralPropertyDescription[] __cl_gen_ret = __cl_gen_to_be_invoked.GetProceduralPropertyDescriptions(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasProceduralProperty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasProceduralProperty( inputName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProceduralBoolean(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetProceduralBoolean( inputName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsProceduralPropertyVisible(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsProceduralPropertyVisible( inputName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetProceduralBoolean(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    bool value = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetProceduralBoolean( inputName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProceduralFloat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetProceduralFloat( inputName );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetProceduralFloat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetProceduralFloat( inputName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProceduralVector(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Vector4 __cl_gen_ret = __cl_gen_to_be_invoked.GetProceduralVector( inputName );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetProceduralVector(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector4 value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetProceduralVector( inputName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProceduralColor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Color __cl_gen_ret = __cl_gen_to_be_invoked.GetProceduralColor( inputName );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetProceduralColor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Color value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetProceduralColor( inputName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProceduralEnum(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetProceduralEnum( inputName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetProceduralEnum(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    int value = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetProceduralEnum( inputName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProceduralTexture(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Texture2D __cl_gen_ret = __cl_gen_to_be_invoked.GetProceduralTexture( inputName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetProceduralTexture(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Texture2D value = (UnityEngine.Texture2D)translator.GetObject(L, 3, typeof(UnityEngine.Texture2D));
                    
                    __cl_gen_to_be_invoked.SetProceduralTexture( inputName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsProceduralPropertyCached(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsProceduralPropertyCached( inputName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CacheProceduralProperty(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string inputName = LuaAPI.lua_tostring(L, 2);
                    bool value = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.CacheProceduralProperty( inputName, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearCache(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ClearCache(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RebuildTextures(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RebuildTextures(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RebuildTexturesImmediately(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.RebuildTexturesImmediately(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StopRebuilds_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.ProceduralMaterial.StopRebuilds(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGeneratedTextures(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UnityEngine.Texture[] __cl_gen_ret = __cl_gen_to_be_invoked.GetGeneratedTextures(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGeneratedTexture(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string textureName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.ProceduralTexture __cl_gen_ret = __cl_gen_to_be_invoked.GetGeneratedTexture( textureName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FreezeAndReleaseSourceData(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.FreezeAndReleaseSourceData(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cacheSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.cacheSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animationUpdateRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.animationUpdateRate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isProcessing(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isProcessing);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isCachedDataAvailable(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isCachedDataAvailable);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isLoadTimeGenerated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isLoadTimeGenerated);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadingBehavior(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.loadingBehavior);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isSupported(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.ProceduralMaterial.isSupported);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_substanceProcessorUsage(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.ProceduralMaterial.substanceProcessorUsage);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_preset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.preset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isReadable(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isReadable);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFrozen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isFrozen);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cacheSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                UnityEngine.ProceduralCacheSize __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cacheSize = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_animationUpdateRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.animationUpdateRate = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isLoadTimeGenerated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isLoadTimeGenerated = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_substanceProcessorUsage(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.ProceduralProcessorUsage __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.ProceduralMaterial.substanceProcessorUsage = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_preset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.preset = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isReadable(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ProceduralMaterial __cl_gen_to_be_invoked = (UnityEngine.ProceduralMaterial)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isReadable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
