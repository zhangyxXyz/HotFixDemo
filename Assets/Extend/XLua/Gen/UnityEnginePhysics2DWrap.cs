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
    public class UnityEnginePhysics2DWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Physics2D), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Physics2D), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Physics2D), L, __CreateInstance, 48, 27, 27);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "IgnoreCollision", _m_IgnoreCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIgnoreCollision", _m_GetIgnoreCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IgnoreLayerCollision", _m_IgnoreLayerCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIgnoreLayerCollision", _m_GetIgnoreLayerCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLayerCollisionMask", _m_SetLayerCollisionMask_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLayerCollisionMask", _m_GetLayerCollisionMask_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsTouching", _m_IsTouching_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsTouchingLayers", _m_IsTouchingLayers_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Distance", _m_Distance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Linecast", _m_Linecast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LinecastAll", _m_LinecastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LinecastNonAlloc", _m_LinecastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Raycast", _m_Raycast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RaycastAll", _m_RaycastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RaycastNonAlloc", _m_RaycastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CircleCast", _m_CircleCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CircleCastAll", _m_CircleCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CircleCastNonAlloc", _m_CircleCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCast", _m_BoxCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCastAll", _m_BoxCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCastNonAlloc", _m_BoxCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCast", _m_CapsuleCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCastAll", _m_CapsuleCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCastNonAlloc", _m_CapsuleCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRayIntersection", _m_GetRayIntersection_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRayIntersectionAll", _m_GetRayIntersectionAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRayIntersectionNonAlloc", _m_GetRayIntersectionNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapPoint", _m_OverlapPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapPointAll", _m_OverlapPointAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapPointNonAlloc", _m_OverlapPointNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCircle", _m_OverlapCircle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCircleAll", _m_OverlapCircleAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCircleNonAlloc", _m_OverlapCircleNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBox", _m_OverlapBox_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBoxAll", _m_OverlapBoxAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBoxNonAlloc", _m_OverlapBoxNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapArea", _m_OverlapArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapAreaAll", _m_OverlapAreaAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapAreaNonAlloc", _m_OverlapAreaNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsule", _m_OverlapCapsule_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsuleAll", _m_OverlapCapsuleAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsuleNonAlloc", _m_OverlapCapsuleNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCollider", _m_OverlapCollider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetContacts", _m_GetContacts_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreRaycastLayer", UnityEngine.Physics2D.IgnoreRaycastLayer);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultRaycastLayers", UnityEngine.Physics2D.DefaultRaycastLayers);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllLayers", UnityEngine.Physics2D.AllLayers);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Physics2D));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "velocityIterations", _g_get_velocityIterations);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "positionIterations", _g_get_positionIterations);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gravity", _g_get_gravity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "queriesHitTriggers", _g_get_queriesHitTriggers);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "queriesStartInColliders", _g_get_queriesStartInColliders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "changeStopsCallbacks", _g_get_changeStopsCallbacks);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "callbacksOnDisable", _g_get_callbacksOnDisable);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "velocityThreshold", _g_get_velocityThreshold);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxLinearCorrection", _g_get_maxLinearCorrection);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxAngularCorrection", _g_get_maxAngularCorrection);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxTranslationSpeed", _g_get_maxTranslationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxRotationSpeed", _g_get_maxRotationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultContactOffset", _g_get_defaultContactOffset);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "baumgarteScale", _g_get_baumgarteScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "baumgarteTOIScale", _g_get_baumgarteTOIScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeToSleep", _g_get_timeToSleep);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "linearSleepTolerance", _g_get_linearSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "angularSleepTolerance", _g_get_angularSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "alwaysShowColliders", _g_get_alwaysShowColliders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showColliderSleep", _g_get_showColliderSleep);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showColliderContacts", _g_get_showColliderContacts);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showColliderAABB", _g_get_showColliderAABB);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "contactArrowScale", _g_get_contactArrowScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderAwakeColor", _g_get_colliderAwakeColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderAsleepColor", _g_get_colliderAsleepColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderContactColor", _g_get_colliderContactColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderAABBColor", _g_get_colliderAABBColor);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "velocityIterations", _s_set_velocityIterations);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "positionIterations", _s_set_positionIterations);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "gravity", _s_set_gravity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "queriesHitTriggers", _s_set_queriesHitTriggers);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "queriesStartInColliders", _s_set_queriesStartInColliders);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "changeStopsCallbacks", _s_set_changeStopsCallbacks);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "callbacksOnDisable", _s_set_callbacksOnDisable);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "velocityThreshold", _s_set_velocityThreshold);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxLinearCorrection", _s_set_maxLinearCorrection);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxAngularCorrection", _s_set_maxAngularCorrection);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxTranslationSpeed", _s_set_maxTranslationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxRotationSpeed", _s_set_maxRotationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultContactOffset", _s_set_defaultContactOffset);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "baumgarteScale", _s_set_baumgarteScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "baumgarteTOIScale", _s_set_baumgarteTOIScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "timeToSleep", _s_set_timeToSleep);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "linearSleepTolerance", _s_set_linearSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "angularSleepTolerance", _s_set_angularSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "alwaysShowColliders", _s_set_alwaysShowColliders);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showColliderSleep", _s_set_showColliderSleep);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showColliderContacts", _s_set_showColliderContacts);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showColliderAABB", _s_set_showColliderAABB);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "contactArrowScale", _s_set_contactArrowScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderAwakeColor", _s_set_colliderAwakeColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderAsleepColor", _s_set_colliderAsleepColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderContactColor", _s_set_colliderContactColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderAABBColor", _s_set_colliderAABBColor);
            
			Utils.EndClassRegister(typeof(UnityEngine.Physics2D), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Physics2D __cl_gen_ret = new UnityEngine.Physics2D();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IgnoreCollision_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)) 
                {
                    UnityEngine.Collider2D collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                    UnityEngine.Physics2D.IgnoreCollision( collider1, collider2 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Collider2D collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    bool ignore = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Physics2D.IgnoreCollision( collider1, collider2, ignore );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IgnoreCollision!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIgnoreCollision_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Collider2D collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        bool __cl_gen_ret = UnityEngine.Physics2D.GetIgnoreCollision( collider1, collider2 );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IgnoreLayerCollision_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int layer2 = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Physics2D.IgnoreLayerCollision( layer1, layer2 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int layer2 = LuaAPI.xlua_tointeger(L, 2);
                    bool ignore = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Physics2D.IgnoreLayerCollision( layer1, layer2, ignore );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IgnoreLayerCollision!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIgnoreLayerCollision_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int layer2 = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.Physics2D.GetIgnoreLayerCollision( layer1, layer2 );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLayerCollisionMask_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int layer = LuaAPI.xlua_tointeger(L, 1);
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Physics2D.SetLayerCollisionMask( layer, layerMask );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayerCollisionMask_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int layer = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetLayerCollisionMask( layer );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTouching_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)) 
                {
                    UnityEngine.Collider2D collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        bool __cl_gen_ret = UnityEngine.Physics2D.IsTouching( collider1, collider2 );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)) 
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 2, out contactFilter);
                    
                        bool __cl_gen_ret = UnityEngine.Physics2D.IsTouching( collider, contactFilter );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)) 
                {
                    UnityEngine.Collider2D collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 3, out contactFilter);
                    
                        bool __cl_gen_ret = UnityEngine.Physics2D.IsTouching( collider1, collider2, contactFilter );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IsTouching!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTouchingLayers_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Collider2D>(L, 1)) 
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    
                        bool __cl_gen_ret = UnityEngine.Physics2D.IsTouchingLayers( collider );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.Physics2D.IsTouchingLayers( collider, layerMask );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IsTouchingLayers!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Distance_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Collider2D colliderA = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D colliderB = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        UnityEngine.ColliderDistance2D __cl_gen_ret = UnityEngine.Physics2D.Distance( colliderA, colliderB );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Linecast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Linecast( start, end );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Linecast( start, end, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Linecast( start, end, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Linecast( start, end, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 3, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.Linecast( start, end, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.Linecast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LinecastAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.LinecastAll( start, end );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.LinecastAll( start, end, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.LinecastAll( start, end, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.LinecastAll( start, end, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.LinecastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LinecastNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( start, end, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( start, end, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( start, end, results, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector2 end;translator.Get(L, 2, out end);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( start, end, results, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.LinecastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Raycast( origin, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Raycast( origin, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Raycast( origin, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Raycast( origin, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.Raycast( origin, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 3, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.Raycast( origin, direction, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 3, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.Raycast( origin, direction, contactFilter, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.Raycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaycastAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.RaycastAll( origin, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.RaycastAll( origin, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.RaycastAll( origin, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.RaycastAll( origin, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.RaycastAll( origin, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.RaycastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaycastNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( origin, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( origin, direction, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( origin, direction, results, distance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( origin, direction, results, distance, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 direction;translator.Get(L, 2, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( origin, direction, results, distance, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.RaycastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CircleCast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CircleCast( origin, radius, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CircleCast( origin, radius, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CircleCast( origin, radius, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CircleCast( origin, radius, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CircleCast( origin, radius, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 4, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CircleCast( origin, radius, direction, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 4, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CircleCast( origin, radius, direction, contactFilter, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CircleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CircleCastAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CircleCastAll( origin, radius, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CircleCastAll( origin, radius, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CircleCastAll( origin, radius, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CircleCastAll( origin, radius, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CircleCastAll( origin, radius, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CircleCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CircleCastNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( origin, radius, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( origin, radius, direction, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( origin, radius, direction, results, distance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( origin, radius, direction, results, distance, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 direction;translator.Get(L, 3, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( origin, radius, direction, results, distance, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CircleCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.BoxCast( origin, size, angle, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.BoxCast( origin, size, angle, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.BoxCast( origin, size, angle, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.BoxCast( origin, size, angle, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.BoxCast( origin, size, angle, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 5, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.BoxCast( origin, size, angle, direction, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 5, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.BoxCast( origin, size, angle, direction, contactFilter, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.BoxCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCastAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.BoxCastAll( origin, size, angle, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.BoxCastAll( origin, size, angle, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.BoxCastAll( origin, size, angle, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.BoxCastAll( origin, size, angle, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.BoxCastAll( origin, size, angle, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.BoxCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCastNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( origin, size, angle, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( origin, size, angle, direction, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( origin, size, angle, direction, results, distance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( origin, size, angle, direction, results, distance, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 direction;translator.Get(L, 4, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( origin, size, angle, direction, results, distance, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.BoxCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCast_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CapsuleCast( origin, size, capsuleDirection, angle, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CapsuleCast( origin, size, capsuleDirection, angle, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CapsuleCast( origin, size, capsuleDirection, angle, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CapsuleCast( origin, size, capsuleDirection, angle, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.CapsuleCast( origin, size, capsuleDirection, angle, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 6, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 7, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CapsuleCast( origin, size, capsuleDirection, angle, direction, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 6, out contactFilter);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 7, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CapsuleCast( origin, size, capsuleDirection, angle, direction, contactFilter, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CapsuleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCastAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastAll( origin, size, capsuleDirection, angle, direction );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastAll( origin, size, capsuleDirection, angle, direction, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastAll( origin, size, capsuleDirection, angle, direction, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastAll( origin, size, capsuleDirection, angle, direction, distance, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    float distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastAll( origin, size, capsuleDirection, angle, direction, distance, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CapsuleCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCastNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( origin, size, capsuleDirection, angle, direction, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( origin, size, capsuleDirection, angle, direction, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 7);
                    int layerMask = LuaAPI.xlua_tointeger(L, 8);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( origin, size, capsuleDirection, angle, direction, results, distance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 7);
                    int layerMask = LuaAPI.xlua_tointeger(L, 8);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( origin, size, capsuleDirection, angle, direction, results, distance, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 10&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Vector2 origin;translator.Get(L, 1, out origin);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D capsuleDirection;translator.Get(L, 3, out capsuleDirection);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 direction;translator.Get(L, 5, out direction);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 7);
                    int layerMask = LuaAPI.xlua_tointeger(L, 8);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 10);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( origin, size, capsuleDirection, angle, direction, results, distance, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CapsuleCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRayIntersection_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersection( ray );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float distance = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersection( ray, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float distance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.RaycastHit2D __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersection( ray, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetRayIntersection!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRayIntersectionAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersectionAll( ray );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float distance = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersectionAll( ray, distance );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    float distance = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.RaycastHit2D[] __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersectionAll( ray, distance, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetRayIntersectionAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRayIntersectionNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 2)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersectionNonAlloc( ray, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersectionNonAlloc( ray, results, distance );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray ray;translator.Get(L, 1, out ray);
                    UnityEngine.RaycastHit2D[] results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit2D[]));
                    float distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetRayIntersectionNonAlloc( ray, results, distance, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetRayIntersectionNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPoint_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Vector2>(L, 1)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapPoint( point );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapPoint( point, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapPoint( point, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapPoint( point, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 2, out contactFilter);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapPoint( point, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPointAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Vector2>(L, 1)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapPointAll( point );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapPointAll( point, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapPointAll( point, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    int layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapPointAll( point, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapPointAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPointNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( point, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( point, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( point, results, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( point, results, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapPointNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCircle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCircle( point, radius );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCircle( point, radius, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCircle( point, radius, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCircle( point, radius, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 3, out contactFilter);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCircle( point, radius, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCircle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCircleAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleAll( point, radius );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleAll( point, radius, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleAll( point, radius, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleAll( point, radius, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCircleAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCircleNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( point, radius, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( point, radius, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( point, radius, results, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    float radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( point, radius, results, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCircleNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBox_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapBox( point, size, angle );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapBox( point, size, angle, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapBox( point, size, angle, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapBox( point, size, angle, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 4, out contactFilter);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapBox( point, size, angle, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapBox!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBoxAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxAll( point, size, angle );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxAll( point, size, angle, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxAll( point, size, angle, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxAll( point, size, angle, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapBoxAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBoxNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( point, size, angle, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( point, size, angle, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( point, size, angle, results, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( point, size, angle, results, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapBoxNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapArea_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapArea( pointA, pointB );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapArea( pointA, pointB, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapArea( pointA, pointB, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapArea( pointA, pointB, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 3, out contactFilter);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapArea( pointA, pointB, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapAreaAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaAll( pointA, pointB );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaAll( pointA, pointB, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaAll( pointA, pointB, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    int layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaAll( pointA, pointB, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapAreaAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapAreaNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( pointA, pointB, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( pointA, pointB, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( pointA, pointB, results, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 pointA;translator.Get(L, 1, out pointA);
                    UnityEngine.Vector2 pointB;translator.Get(L, 2, out pointB);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( pointA, pointB, results, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapAreaNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsule_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsule( point, size, direction, angle );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsule( point, size, direction, angle, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsule( point, size, direction, angle, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        UnityEngine.Collider2D __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsule( point, size, direction, angle, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 5, out contactFilter);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 6, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsule( point, size, direction, angle, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCapsule!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsuleAll_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( point, size, direction, angle );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( point, size, direction, angle, layerMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( point, size, direction, angle, layerMask, minDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        UnityEngine.Collider2D[] __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( point, size, direction, angle, layerMask, minDepth, maxDepth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCapsuleAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsuleNonAlloc_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( point, size, direction, angle, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( point, size, direction, angle, results, layerMask );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( point, size, direction, angle, results, layerMask, minDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 point;translator.Get(L, 1, out point);
                    UnityEngine.Vector2 size;translator.Get(L, 2, out size);
                    UnityEngine.CapsuleDirection2D direction;translator.Get(L, 3, out direction);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    int layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( point, size, direction, angle, results, layerMask, minDepth, maxDepth );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCapsuleNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCollider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 2, out contactFilter);
                    UnityEngine.Collider2D[] results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.OverlapCollider( collider, contactFilter, results );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetContacts_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 2)) 
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactPoint2D[] contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 2, typeof(UnityEngine.ContactPoint2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( collider, contacts );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D[] colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( collider, colliders );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 2)) 
                {
                    UnityEngine.Rigidbody2D rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactPoint2D[] contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 2, typeof(UnityEngine.ContactPoint2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( rigidbody, contacts );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Rigidbody2D rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.Collider2D[] colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( rigidbody, colliders );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 3)) 
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 2, out contactFilter);
                    UnityEngine.ContactPoint2D[] contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 3, typeof(UnityEngine.ContactPoint2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( collider, contactFilter, contacts );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Collider2D collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 2, out contactFilter);
                    UnityEngine.Collider2D[] colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( collider, contactFilter, colliders );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 3)) 
                {
                    UnityEngine.Rigidbody2D rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 2, out contactFilter);
                    UnityEngine.ContactPoint2D[] contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 3, typeof(UnityEngine.ContactPoint2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( rigidbody, contactFilter, contacts );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Rigidbody2D rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactFilter2D contactFilter;translator.Get(L, 2, out contactFilter);
                    UnityEngine.Collider2D[] colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        int __cl_gen_ret = UnityEngine.Physics2D.GetContacts( rigidbody, contactFilter, colliders );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetContacts!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocityIterations(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Physics2D.velocityIterations);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_positionIterations(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Physics2D.positionIterations);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineVector2(L, UnityEngine.Physics2D.gravity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_queriesHitTriggers(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.queriesHitTriggers);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_queriesStartInColliders(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.queriesStartInColliders);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_changeStopsCallbacks(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.changeStopsCallbacks);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_callbacksOnDisable(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.callbacksOnDisable);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocityThreshold(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.velocityThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxLinearCorrection(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxLinearCorrection);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxAngularCorrection(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxAngularCorrection);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxTranslationSpeed(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxTranslationSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxRotationSpeed(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxRotationSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultContactOffset(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.defaultContactOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baumgarteScale(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.baumgarteScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baumgarteTOIScale(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.baumgarteTOIScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeToSleep(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.timeToSleep);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearSleepTolerance(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.linearSleepTolerance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularSleepTolerance(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.angularSleepTolerance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alwaysShowColliders(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.alwaysShowColliders);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showColliderSleep(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.showColliderSleep);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showColliderContacts(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.showColliderContacts);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showColliderAABB(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.showColliderAABB);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contactArrowScale(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.contactArrowScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderAwakeColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderAwakeColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderAsleepColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderAsleepColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderContactColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderContactColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderAABBColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderAABBColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocityIterations(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.velocityIterations = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_positionIterations(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.positionIterations = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gravity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Physics2D.gravity = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_queriesHitTriggers(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.queriesHitTriggers = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_queriesStartInColliders(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.queriesStartInColliders = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_changeStopsCallbacks(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.changeStopsCallbacks = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_callbacksOnDisable(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.callbacksOnDisable = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocityThreshold(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.velocityThreshold = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxLinearCorrection(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.maxLinearCorrection = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxAngularCorrection(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.maxAngularCorrection = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxTranslationSpeed(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.maxTranslationSpeed = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxRotationSpeed(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.maxRotationSpeed = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultContactOffset(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.defaultContactOffset = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baumgarteScale(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.baumgarteScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baumgarteTOIScale(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.baumgarteTOIScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeToSleep(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.timeToSleep = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearSleepTolerance(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.linearSleepTolerance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularSleepTolerance(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.angularSleepTolerance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alwaysShowColliders(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.alwaysShowColliders = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showColliderSleep(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.showColliderSleep = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showColliderContacts(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.showColliderContacts = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showColliderAABB(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.showColliderAABB = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_contactArrowScale(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Physics2D.contactArrowScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderAwakeColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Physics2D.colliderAwakeColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderAsleepColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Physics2D.colliderAsleepColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderContactColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Physics2D.colliderContactColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderAABBColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.Physics2D.colliderAABBColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
