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
    public class AssetBundleManagerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(AssetBundleManager), L, translator, 0, 14, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetBundle", _m_LoadAssetBundle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBundleName", _m_GetBundleName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsLoading", _m_IsLoading);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsFinsh", _m_IsFinsh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsset", _m_LoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAllAssets", _m_LoadAllAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetWithSubAssets", _m_LoadAssetWithSubAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnLoadAsset", _m_UnLoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnLoadAllAsset", _m_UnLoadAllAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnLoadAll", _m_UnLoadAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisposeAll", _m_DisposeAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisposeAndUnLoadAll", _m_DisposeAndUnLoadAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetNames", _m_GetAllAssetNames);
			
			
			
			
			Utils.EndObjectRegister(typeof(AssetBundleManager), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(AssetBundleManager), L, __CreateInstance, 1, 1, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(AssetBundleManager));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			Utils.EndClassRegister(typeof(AssetBundleManager), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					AssetBundleManager __cl_gen_ret = new AssetBundleManager();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundleManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetBundle(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    LoadProgress lp = translator.GetDelegate<LoadProgress>(L, 4);
                    
                    __cl_gen_to_be_invoked.LoadAssetBundle( sceneName, folderName, lp );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBundleName(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetBundleName( sceneName, folderName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLoading(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsLoading( sceneName, folderName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsFinsh(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsFinsh( sceneName, folderName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsset(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    string assetName = LuaAPI.lua_tostring(L, 4);
                    
                        UnityEngine.Object __cl_gen_ret = __cl_gen_to_be_invoked.LoadAsset( sceneName, folderName, assetName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAllAssets(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.Object[] __cl_gen_ret = __cl_gen_to_be_invoked.LoadAllAssets( sceneName, folderName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetWithSubAssets(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    string assetName = LuaAPI.lua_tostring(L, 4);
                    
                        UnityEngine.Object[] __cl_gen_ret = __cl_gen_to_be_invoked.LoadAssetWithSubAssets( sceneName, folderName, assetName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnLoadAsset(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    string assetName = LuaAPI.lua_tostring(L, 4);
                    
                    __cl_gen_to_be_invoked.UnLoadAsset( sceneName, folderName, assetName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnLoadAllAsset(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.UnLoadAllAsset( sceneName, folderName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnLoadAll(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.UnLoadAll( sceneName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.Dispose( sceneName, folderName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisposeAll(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.DisposeAll( sceneName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisposeAndUnLoadAll(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.DisposeAndUnLoadAll( sceneName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetNames(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            AssetBundleManager __cl_gen_to_be_invoked = (AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string sceneName = LuaAPI.lua_tostring(L, 2);
                    string folderName = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.GetAllAssetNames( sceneName, folderName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, AssetBundleManager.Instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
