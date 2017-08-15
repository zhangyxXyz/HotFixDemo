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
    public class UnityEngineHumanTraitWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.HumanTrait), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.HumanTrait), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.HumanTrait), L, __CreateInstance, 7, 5, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "MuscleFromBone", _m_MuscleFromBone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoneFromMuscle", _m_BoneFromMuscle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RequiredBone", _m_RequiredBone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMuscleDefaultMin", _m_GetMuscleDefaultMin_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMuscleDefaultMax", _m_GetMuscleDefaultMax_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetParentBone", _m_GetParentBone_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.HumanTrait));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MuscleCount", _g_get_MuscleCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MuscleName", _g_get_MuscleName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BoneCount", _g_get_BoneCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BoneName", _g_get_BoneName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RequiredBoneCount", _g_get_RequiredBoneCount);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.HumanTrait), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.HumanTrait __cl_gen_ret = new UnityEngine.HumanTrait();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.HumanTrait constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MuscleFromBone_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int i = LuaAPI.xlua_tointeger(L, 1);
                    int dofIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = UnityEngine.HumanTrait.MuscleFromBone( i, dofIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoneFromMuscle_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int i = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.HumanTrait.BoneFromMuscle( i );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RequiredBone_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int i = LuaAPI.xlua_tointeger(L, 1);
                    
                        bool __cl_gen_ret = UnityEngine.HumanTrait.RequiredBone( i );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMuscleDefaultMin_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int i = LuaAPI.xlua_tointeger(L, 1);
                    
                        float __cl_gen_ret = UnityEngine.HumanTrait.GetMuscleDefaultMin( i );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMuscleDefaultMax_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int i = LuaAPI.xlua_tointeger(L, 1);
                    
                        float __cl_gen_ret = UnityEngine.HumanTrait.GetMuscleDefaultMax( i );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetParentBone_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int i = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = UnityEngine.HumanTrait.GetParentBone( i );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MuscleCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.HumanTrait.MuscleCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MuscleName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.HumanTrait.MuscleName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BoneCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.HumanTrait.BoneCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BoneName(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.HumanTrait.BoneName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RequiredBoneCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.HumanTrait.RequiredBoneCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
