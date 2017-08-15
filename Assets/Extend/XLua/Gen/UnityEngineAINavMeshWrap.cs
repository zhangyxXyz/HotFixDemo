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
    public class UnityEngineAINavMeshWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AI.NavMesh), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.AI.NavMesh), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AI.NavMesh), L, __CreateInstance, 20, 3, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Raycast", _m_Raycast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculatePath", _m_CalculatePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindClosestEdge", _m_FindClosestEdge_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SamplePosition", _m_SamplePosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAreaCost", _m_SetAreaCost_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAreaCost", _m_GetAreaCost_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAreaFromName", _m_GetAreaFromName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateTriangulation", _m_CalculateTriangulation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddNavMeshData", _m_AddNavMeshData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveNavMeshData", _m_RemoveNavMeshData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddLink", _m_AddLink_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveLink", _m_RemoveLink_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateSettings", _m_CreateSettings_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveSettings", _m_RemoveSettings_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSettingsByID", _m_GetSettingsByID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSettingsCount", _m_GetSettingsCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSettingsByIndex", _m_GetSettingsByIndex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSettingsNameFromID", _m_GetSettingsNameFromID_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllAreas", UnityEngine.AI.NavMesh.AllAreas);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AI.NavMesh));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "avoidancePredictionTime", _g_get_avoidancePredictionTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "pathfindingIterationsPerFrame", _g_get_pathfindingIterationsPerFrame);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPreUpdate", _g_get_onPreUpdate);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "avoidancePredictionTime", _s_set_avoidancePredictionTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "pathfindingIterationsPerFrame", _s_set_pathfindingIterationsPerFrame);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPreUpdate", _s_set_onPreUpdate);
            
			Utils.EndClassRegister(typeof(UnityEngine.AI.NavMesh), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.AI.NavMesh does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.Vector3 targetPosition;translator.Get(L, 2, out targetPosition);
                    UnityEngine.AI.NavMeshHit hit;
                    int areaMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.Raycast( sourcePosition, targetPosition, out hit, areaMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.AI.NavMeshQueryFilter>(L, 3)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.Vector3 targetPosition;translator.Get(L, 2, out targetPosition);
                    UnityEngine.AI.NavMeshHit hit;
                    UnityEngine.AI.NavMeshQueryFilter filter;translator.Get(L, 3, out filter);
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.Raycast( sourcePosition, targetPosition, out hit, filter );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.NavMesh.Raycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculatePath_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.AI.NavMeshPath>(L, 4)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.Vector3 targetPosition;translator.Get(L, 2, out targetPosition);
                    int areaMask = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.AI.NavMeshPath path = (UnityEngine.AI.NavMeshPath)translator.GetObject(L, 4, typeof(UnityEngine.AI.NavMeshPath));
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.CalculatePath( sourcePosition, targetPosition, areaMask, path );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.AI.NavMeshQueryFilter>(L, 3)&& translator.Assignable<UnityEngine.AI.NavMeshPath>(L, 4)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.Vector3 targetPosition;translator.Get(L, 2, out targetPosition);
                    UnityEngine.AI.NavMeshQueryFilter filter;translator.Get(L, 3, out filter);
                    UnityEngine.AI.NavMeshPath path = (UnityEngine.AI.NavMeshPath)translator.GetObject(L, 4, typeof(UnityEngine.AI.NavMeshPath));
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.CalculatePath( sourcePosition, targetPosition, filter, path );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.NavMesh.CalculatePath!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindClosestEdge_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.AI.NavMeshHit hit;
                    int areaMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.FindClosestEdge( sourcePosition, out hit, areaMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.AI.NavMeshQueryFilter>(L, 2)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.AI.NavMeshHit hit;
                    UnityEngine.AI.NavMeshQueryFilter filter;translator.Get(L, 2, out filter);
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.FindClosestEdge( sourcePosition, out hit, filter );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.NavMesh.FindClosestEdge!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SamplePosition_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.AI.NavMeshHit hit;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    int areaMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.SamplePosition( sourcePosition, out hit, maxDistance, areaMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.AI.NavMeshQueryFilter>(L, 3)) 
                {
                    UnityEngine.Vector3 sourcePosition;translator.Get(L, 1, out sourcePosition);
                    UnityEngine.AI.NavMeshHit hit;
                    float maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.AI.NavMeshQueryFilter filter;translator.Get(L, 3, out filter);
                    
                        bool __cl_gen_ret = UnityEngine.AI.NavMesh.SamplePosition( sourcePosition, out hit, maxDistance, filter );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.NavMesh.SamplePosition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAreaCost_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int areaIndex = LuaAPI.xlua_tointeger(L, 1);
                    float cost = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.AI.NavMesh.SetAreaCost( areaIndex, cost );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAreaCost_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int areaIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        float __cl_gen_ret = UnityEngine.AI.NavMesh.GetAreaCost( areaIndex );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAreaFromName_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string areaName = LuaAPI.lua_tostring(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.AI.NavMesh.GetAreaFromName( areaName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateTriangulation_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    
                        UnityEngine.AI.NavMeshTriangulation __cl_gen_ret = UnityEngine.AI.NavMesh.CalculateTriangulation(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddNavMeshData_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.AI.NavMeshData>(L, 1)) 
                {
                    UnityEngine.AI.NavMeshData navMeshData = (UnityEngine.AI.NavMeshData)translator.GetObject(L, 1, typeof(UnityEngine.AI.NavMeshData));
                    
                        UnityEngine.AI.NavMeshDataInstance __cl_gen_ret = UnityEngine.AI.NavMesh.AddNavMeshData( navMeshData );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.AI.NavMeshData>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.AI.NavMeshData navMeshData = (UnityEngine.AI.NavMeshData)translator.GetObject(L, 1, typeof(UnityEngine.AI.NavMeshData));
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    
                        UnityEngine.AI.NavMeshDataInstance __cl_gen_ret = UnityEngine.AI.NavMesh.AddNavMeshData( navMeshData, position, rotation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.NavMesh.AddNavMeshData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveNavMeshData_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.AI.NavMeshDataInstance handle;translator.Get(L, 1, out handle);
                    
                    UnityEngine.AI.NavMesh.RemoveNavMeshData( handle );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLink_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.AI.NavMeshLinkData>(L, 1)) 
                {
                    UnityEngine.AI.NavMeshLinkData link;translator.Get(L, 1, out link);
                    
                        UnityEngine.AI.NavMeshLinkInstance __cl_gen_ret = UnityEngine.AI.NavMesh.AddLink( link );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.AI.NavMeshLinkData>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.AI.NavMeshLinkData link;translator.Get(L, 1, out link);
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Quaternion rotation;translator.Get(L, 3, out rotation);
                    
                        UnityEngine.AI.NavMeshLinkInstance __cl_gen_ret = UnityEngine.AI.NavMesh.AddLink( link, position, rotation );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AI.NavMesh.AddLink!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveLink_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.AI.NavMeshLinkInstance handle;translator.Get(L, 1, out handle);
                    
                    UnityEngine.AI.NavMesh.RemoveLink( handle );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateSettings_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    
                        UnityEngine.AI.NavMeshBuildSettings __cl_gen_ret = UnityEngine.AI.NavMesh.CreateSettings(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveSettings_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int agentTypeID = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.AI.NavMesh.RemoveSettings( agentTypeID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSettingsByID_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int agentTypeID = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.AI.NavMeshBuildSettings __cl_gen_ret = UnityEngine.AI.NavMesh.GetSettingsByID( agentTypeID );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSettingsCount_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = UnityEngine.AI.NavMesh.GetSettingsCount(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSettingsByIndex_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.AI.NavMeshBuildSettings __cl_gen_ret = UnityEngine.AI.NavMesh.GetSettingsByIndex( index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSettingsNameFromID_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int agentTypeID = LuaAPI.xlua_tointeger(L, 1);
                    
                        string __cl_gen_ret = UnityEngine.AI.NavMesh.GetSettingsNameFromID( agentTypeID );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_avoidancePredictionTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.AI.NavMesh.avoidancePredictionTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pathfindingIterationsPerFrame(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.AI.NavMesh.pathfindingIterationsPerFrame);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPreUpdate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.AI.NavMesh.onPreUpdate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_avoidancePredictionTime(RealStatePtr L)
        {
            
            try {
			    UnityEngine.AI.NavMesh.avoidancePredictionTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pathfindingIterationsPerFrame(RealStatePtr L)
        {
            
            try {
			    UnityEngine.AI.NavMesh.pathfindingIterationsPerFrame = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPreUpdate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.AI.NavMesh.onPreUpdate = translator.GetDelegate<UnityEngine.AI.NavMesh.OnNavMeshPreUpdate>(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
