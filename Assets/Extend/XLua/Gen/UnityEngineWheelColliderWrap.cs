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
    public class UnityEngineWheelColliderWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.WheelCollider), L, translator, 0, 3, 15, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConfigureVehicleSubsteps", _m_ConfigureVehicleSubsteps);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGroundHit", _m_GetGroundHit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWorldPose", _m_GetWorldPose);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "center", _g_get_center);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radius", _g_get_radius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "suspensionDistance", _g_get_suspensionDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "suspensionSpring", _g_get_suspensionSpring);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceAppPointDistance", _g_get_forceAppPointDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mass", _g_get_mass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wheelDampingRate", _g_get_wheelDampingRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forwardFriction", _g_get_forwardFriction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sidewaysFriction", _g_get_sidewaysFriction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motorTorque", _g_get_motorTorque);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "brakeTorque", _g_get_brakeTorque);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "steerAngle", _g_get_steerAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isGrounded", _g_get_isGrounded);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sprungMass", _g_get_sprungMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rpm", _g_get_rpm);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "center", _s_set_center);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radius", _s_set_radius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "suspensionDistance", _s_set_suspensionDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "suspensionSpring", _s_set_suspensionSpring);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forceAppPointDistance", _s_set_forceAppPointDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mass", _s_set_mass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wheelDampingRate", _s_set_wheelDampingRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forwardFriction", _s_set_forwardFriction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sidewaysFriction", _s_set_sidewaysFriction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motorTorque", _s_set_motorTorque);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "brakeTorque", _s_set_brakeTorque);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "steerAngle", _s_set_steerAngle);
            
			Utils.EndObjectRegister(typeof(UnityEngine.WheelCollider), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.WheelCollider), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.WheelCollider));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.WheelCollider), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.WheelCollider __cl_gen_ret = new UnityEngine.WheelCollider();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.WheelCollider constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConfigureVehicleSubsteps(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float speedThreshold = (float)LuaAPI.lua_tonumber(L, 2);
                    int stepsBelowThreshold = LuaAPI.xlua_tointeger(L, 3);
                    int stepsAboveThreshold = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.ConfigureVehicleSubsteps( speedThreshold, stepsBelowThreshold, stepsAboveThreshold );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGroundHit(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.WheelHit hit;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetGroundHit( out hit );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWorldPose(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 pos;
                    UnityEngine.Quaternion quat;
                    
                    __cl_gen_to_be_invoked.GetWorldPose( out pos, out quat );
                    translator.PushUnityEngineVector3(L, pos);
                        
                    translator.PushUnityEngineQuaternion(L, quat);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_center(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.center);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_radius(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.radius);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_suspensionDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.suspensionDistance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_suspensionSpring(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.suspensionSpring);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forceAppPointDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.forceAppPointDistance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mass(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.mass);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wheelDampingRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.wheelDampingRate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forwardFriction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.forwardFriction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sidewaysFriction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sidewaysFriction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_motorTorque(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.motorTorque);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_brakeTorque(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.brakeTorque);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_steerAngle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.steerAngle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isGrounded(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isGrounded);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sprungMass(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.sprungMass);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rpm(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.rpm);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_center(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.center = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_radius(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.radius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_suspensionDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.suspensionDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_suspensionSpring(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.JointSpring __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.suspensionSpring = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forceAppPointDistance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.forceAppPointDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mass(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.mass = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wheelDampingRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.wheelDampingRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forwardFriction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.WheelFrictionCurve __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.forwardFriction = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sidewaysFriction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.WheelFrictionCurve __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.sidewaysFriction = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_motorTorque(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.motorTorque = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_brakeTorque(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.brakeTorque = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_steerAngle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.WheelCollider __cl_gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.steerAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
