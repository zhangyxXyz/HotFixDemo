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
    public class UnityEngineAnimatorOverrideControllerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AnimatorOverrideController), L, translator, 0, 2, 2, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOverrides", _m_GetOverrides);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyOverrides", _m_ApplyOverrides);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "runtimeAnimatorController", _g_get_runtimeAnimatorController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overridesCount", _g_get_overridesCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "runtimeAnimatorController", _s_set_runtimeAnimatorController);
            
			Utils.EndObjectRegister(typeof(UnityEngine.AnimatorOverrideController), L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AnimatorOverrideController), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AnimatorOverrideController));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.AnimatorOverrideController), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.AnimatorOverrideController __cl_gen_ret = new UnityEngine.AnimatorOverrideController();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.RuntimeAnimatorController>(L, 2))
				{
					UnityEngine.RuntimeAnimatorController controller = (UnityEngine.RuntimeAnimatorController)translator.GetObject(L, 2, typeof(UnityEngine.RuntimeAnimatorController));
					
					UnityEngine.AnimatorOverrideController __cl_gen_ret = new UnityEngine.AnimatorOverrideController(controller);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimatorOverrideController constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				
				if (translator.Assignable<UnityEngine.AnimatorOverrideController>(L, 1) && translator.Assignable<UnityEngine.AnimationClip>(L, 2))
				{
					
					UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
					UnityEngine.AnimationClip index = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
					LuaAPI.lua_pushboolean(L, true);
					translator.Push(L, __cl_gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<UnityEngine.AnimatorOverrideController>(L, 1) && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.AnimationClip>(L, 3))
				{
					
					UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
					string key = LuaAPI.lua_tostring(L, 2);
					__cl_gen_to_be_invoked[key] = (UnityEngine.AnimationClip)translator.GetObject(L, 3, typeof(UnityEngine.AnimationClip));
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
				if (translator.Assignable<UnityEngine.AnimatorOverrideController>(L, 1) && translator.Assignable<UnityEngine.AnimationClip>(L, 2) && translator.Assignable<UnityEngine.AnimationClip>(L, 3))
				{
					
					UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
					UnityEngine.AnimationClip key = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
					__cl_gen_to_be_invoked[key] = (UnityEngine.AnimationClip)translator.GetObject(L, 3, typeof(UnityEngine.AnimationClip));
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOverrides(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides = (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>));
                    
                    __cl_gen_to_be_invoked.GetOverrides( overrides );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyOverrides(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides = (System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>));
                    
                    __cl_gen_to_be_invoked.ApplyOverrides( overrides );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_runtimeAnimatorController(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.runtimeAnimatorController);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overridesCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.overridesCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_runtimeAnimatorController(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimatorOverrideController __cl_gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.runtimeAnimatorController = (UnityEngine.RuntimeAnimatorController)translator.GetObject(L, 2, typeof(UnityEngine.RuntimeAnimatorController));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
