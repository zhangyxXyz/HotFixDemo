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
    public class UnityEngineSceneManagementSceneUtilityWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.SceneManagement.SceneUtility), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.SceneManagement.SceneUtility), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.SceneManagement.SceneUtility), L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetScenePathByBuildIndex", _m_GetScenePathByBuildIndex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBuildIndexByScenePath", _m_GetBuildIndexByScenePath_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.SceneManagement.SceneUtility));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.SceneManagement.SceneUtility), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.SceneManagement.SceneUtility does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetScenePathByBuildIndex_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int buildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        string __cl_gen_ret = UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex( buildIndex );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBuildIndexByScenePath_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string scenePath = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.SceneManagement.SceneUtility.GetBuildIndexByScenePath( scenePath );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
