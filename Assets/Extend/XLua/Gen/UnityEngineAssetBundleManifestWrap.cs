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
    public class UnityEngineAssetBundleManifestWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AssetBundleManifest), L, translator, 0, 5, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetBundles", _m_GetAllAssetBundles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetBundlesWithVariant", _m_GetAllAssetBundlesWithVariant);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleHash", _m_GetAssetBundleHash);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDirectDependencies", _m_GetDirectDependencies);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllDependencies", _m_GetAllDependencies);
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.AssetBundleManifest), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AssetBundleManifest), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AssetBundleManifest));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.AssetBundleManifest), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.AssetBundleManifest __cl_gen_ret = new UnityEngine.AssetBundleManifest();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AssetBundleManifest constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetBundles(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AssetBundleManifest __cl_gen_to_be_invoked = (UnityEngine.AssetBundleManifest)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllAssetBundles(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetBundlesWithVariant(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AssetBundleManifest __cl_gen_to_be_invoked = (UnityEngine.AssetBundleManifest)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllAssetBundlesWithVariant(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleHash(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AssetBundleManifest __cl_gen_to_be_invoked = (UnityEngine.AssetBundleManifest)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string assetBundleName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Hash128 __cl_gen_ret = __cl_gen_to_be_invoked.GetAssetBundleHash( assetBundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDirectDependencies(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AssetBundleManifest __cl_gen_to_be_invoked = (UnityEngine.AssetBundleManifest)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string assetBundleName = LuaAPI.lua_tostring(L, 2);
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetDirectDependencies( assetBundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllDependencies(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AssetBundleManifest __cl_gen_to_be_invoked = (UnityEngine.AssetBundleManifest)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string assetBundleName = LuaAPI.lua_tostring(L, 2);
                    
                        string[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllDependencies( assetBundleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
