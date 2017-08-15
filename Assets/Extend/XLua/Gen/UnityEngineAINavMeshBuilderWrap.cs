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
    public class UnityEngineAINavMeshBuilderWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AI.NavMeshBuilder), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.AI.NavMeshBuilder), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AI.NavMeshBuilder), L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CollectSources", _m_CollectSources_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BuildNavMeshData", _m_BuildNavMeshData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateNavMeshData", _m_UpdateNavMeshData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateNavMeshDataAsync", _m_UpdateNavMeshDataAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Cancel", _m_Cancel_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AI.NavMeshBuilder));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.AI.NavMeshBuilder), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.AI.NavMeshBuilder does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CollectSources_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Bounds>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.AI.NavMeshCollectGeometry>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>(L, 6)) 
                {
                    UnityEngine.Bounds includedWorldBounds;translator.Get(L, 1, out includedWorldBounds);
                    int includedLayerMask = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.AI.NavMeshCollectGeometry geometry;translator.Get(L, 3, out geometry);
                    int defaultArea = LuaAPI.xlua_tointeger(L, 4);
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>));
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>));
                    
                    UnityEngine.AI.NavMeshBuilder.CollectSources( includedWorldBounds, includedLayerMask, geometry, defaultArea, markups, results );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Transform>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.AI.NavMeshCollectGeometry>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>(L, 6)) 
                {
                    UnityEngine.Transform root = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    int includedLayerMask = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.AI.NavMeshCollectGeometry geometry;translator.Get(L, 3, out geometry);
                    int defaultArea = LuaAPI.xlua_tointeger(L, 4);
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>));
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>));
                    
                    UnityEngine.AI.NavMeshBuilder.CollectSources( root, includedLayerMask, geometry, defaultArea, markups, results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.NavMeshBuilder.CollectSources!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BuildNavMeshData_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.AI.NavMeshBuildSettings buildSettings;translator.Get(L, 1, out buildSettings);
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>));
                    UnityEngine.Bounds localBounds;translator.Get(L, 3, out localBounds);
                    UnityEngine.Vector3 position;translator.Get(L, 4, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 5, out rotation);
                    
                        UnityEngine.AI.NavMeshData __cl_gen_ret = UnityEngine.AI.NavMeshBuilder.BuildNavMeshData( buildSettings, sources, localBounds, position, rotation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateNavMeshData_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.AI.NavMeshData data = (UnityEngine.AI.NavMeshData)translator.GetObject(L, 1, typeof(UnityEngine.AI.NavMeshData));
                    UnityEngine.AI.NavMeshBuildSettings buildSettings;translator.Get(L, 2, out buildSettings);
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>));
                    UnityEngine.Bounds localBounds;translator.Get(L, 4, out localBounds);
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMeshBuilder.UpdateNavMeshData( data, buildSettings, sources, localBounds );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateNavMeshDataAsync_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.AI.NavMeshData data = (UnityEngine.AI.NavMeshData)translator.GetObject(L, 1, typeof(UnityEngine.AI.NavMeshData));
                    UnityEngine.AI.NavMeshBuildSettings buildSettings;translator.Get(L, 2, out buildSettings);
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>));
                    UnityEngine.Bounds localBounds;translator.Get(L, 4, out localBounds);
                    
                        UnityEngine.AsyncOperation __cl_gen_ret = UnityEngine.AI.NavMeshBuilder.UpdateNavMeshDataAsync( data, buildSettings, sources, localBounds );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cancel_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.AI.NavMeshData data = (UnityEngine.AI.NavMeshData)translator.GetObject(L, 1, typeof(UnityEngine.AI.NavMeshData));
                    
                    UnityEngine.AI.NavMeshBuilder.Cancel( data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
