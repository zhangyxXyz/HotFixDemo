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
    public class UnityEngineClothWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Cloth), L, translator, 0, 2, 20, 18);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearTransformMotion", _m_ClearTransformMotion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetEnabledFading", _m_SetEnabledFading);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "sleepThreshold", _g_get_sleepThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bendingStiffness", _g_get_bendingStiffness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stretchingStiffness", _g_get_stretchingStiffness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "damping", _g_get_damping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "externalAcceleration", _g_get_externalAcceleration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "randomAcceleration", _g_get_randomAcceleration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useGravity", _g_get_useGravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertices", _g_get_vertices);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normals", _g_get_normals);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "friction", _g_get_friction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collisionMassScale", _g_get_collisionMassScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useContinuousCollision", _g_get_useContinuousCollision);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useVirtualParticles", _g_get_useVirtualParticles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "coefficients", _g_get_coefficients);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldVelocityScale", _g_get_worldVelocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldAccelerationScale", _g_get_worldAccelerationScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "solverFrequency", _g_get_solverFrequency);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "capsuleColliders", _g_get_capsuleColliders);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sphereColliders", _g_get_sphereColliders);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "sleepThreshold", _s_set_sleepThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bendingStiffness", _s_set_bendingStiffness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stretchingStiffness", _s_set_stretchingStiffness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "damping", _s_set_damping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "externalAcceleration", _s_set_externalAcceleration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "randomAcceleration", _s_set_randomAcceleration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useGravity", _s_set_useGravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enabled", _s_set_enabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "friction", _s_set_friction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "collisionMassScale", _s_set_collisionMassScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useContinuousCollision", _s_set_useContinuousCollision);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useVirtualParticles", _s_set_useVirtualParticles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "coefficients", _s_set_coefficients);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldVelocityScale", _s_set_worldVelocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldAccelerationScale", _s_set_worldAccelerationScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "solverFrequency", _s_set_solverFrequency);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "capsuleColliders", _s_set_capsuleColliders);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sphereColliders", _s_set_sphereColliders);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Cloth), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Cloth), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Cloth));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Cloth), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Cloth __cl_gen_ret = new UnityEngine.Cloth();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Cloth constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearTransformMotion(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ClearTransformMotion(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetEnabledFading(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool enabled = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.SetEnabledFading( enabled );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    bool enabled = LuaAPI.lua_toboolean(L, 2);
                    float interpolationTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetEnabledFading( enabled, interpolationTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Cloth.SetEnabledFading!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sleepThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.sleepThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bendingStiffness(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.bendingStiffness);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stretchingStiffness(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.stretchingStiffness);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_damping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.damping);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_externalAcceleration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.externalAcceleration);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_randomAcceleration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.randomAcceleration);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useGravity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useGravity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.enabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertices(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.vertices);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normals(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.normals);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_friction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.friction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_collisionMassScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.collisionMassScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useContinuousCollision(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.useContinuousCollision);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useVirtualParticles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.useVirtualParticles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_coefficients(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.coefficients);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldVelocityScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.worldVelocityScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldAccelerationScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.worldAccelerationScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_solverFrequency(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.solverFrequency);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_capsuleColliders(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.capsuleColliders);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sphereColliders(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sphereColliders);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sleepThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sleepThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bendingStiffness(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bendingStiffness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stretchingStiffness(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stretchingStiffness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_damping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.damping = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_externalAcceleration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.externalAcceleration = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_randomAcceleration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.randomAcceleration = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useGravity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useGravity = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.enabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_friction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.friction = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_collisionMassScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.collisionMassScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useContinuousCollision(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useContinuousCollision = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useVirtualParticles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useVirtualParticles = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_coefficients(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.coefficients = (UnityEngine.ClothSkinningCoefficient[])translator.GetObject(L, 2, typeof(UnityEngine.ClothSkinningCoefficient[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_worldVelocityScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.worldVelocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_worldAccelerationScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.worldAccelerationScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_solverFrequency(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.solverFrequency = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_capsuleColliders(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.capsuleColliders = (UnityEngine.CapsuleCollider[])translator.GetObject(L, 2, typeof(UnityEngine.CapsuleCollider[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sphereColliders(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Cloth __cl_gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sphereColliders = (UnityEngine.ClothSphereColliderPair[])translator.GetObject(L, 2, typeof(UnityEngine.ClothSphereColliderPair[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
