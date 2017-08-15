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
    public class UnityEngineStateMachineBehaviourWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.StateMachineBehaviour), L, translator, 0, 7, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateEnter", _m_OnStateEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateUpdate", _m_OnStateUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateExit", _m_OnStateExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateMove", _m_OnStateMove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateIK", _m_OnStateIK);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateMachineEnter", _m_OnStateMachineEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateMachineExit", _m_OnStateMachineExit);
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.StateMachineBehaviour), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.StateMachineBehaviour), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.StateMachineBehaviour));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.StateMachineBehaviour), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.StateMachineBehaviour does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateEnter(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.StateMachineBehaviour __cl_gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.OnStateEnter( animator, stateInfo, layerIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Experimental.Director.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)translator.GetObject(L, 5, typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable));
                    
                    __cl_gen_to_be_invoked.OnStateEnter( animator, stateInfo, layerIndex, controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateEnter!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateUpdate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.StateMachineBehaviour __cl_gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.OnStateUpdate( animator, stateInfo, layerIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Experimental.Director.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)translator.GetObject(L, 5, typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable));
                    
                    __cl_gen_to_be_invoked.OnStateUpdate( animator, stateInfo, layerIndex, controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateUpdate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateExit(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.StateMachineBehaviour __cl_gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.OnStateExit( animator, stateInfo, layerIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Experimental.Director.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)translator.GetObject(L, 5, typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable));
                    
                    __cl_gen_to_be_invoked.OnStateExit( animator, stateInfo, layerIndex, controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateExit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateMove(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.StateMachineBehaviour __cl_gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.OnStateMove( animator, stateInfo, layerIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Experimental.Director.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)translator.GetObject(L, 5, typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable));
                    
                    __cl_gen_to_be_invoked.OnStateMove( animator, stateInfo, layerIndex, controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateMove!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateIK(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.StateMachineBehaviour __cl_gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.OnStateIK( animator, stateInfo, layerIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Experimental.Director.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo stateInfo;translator.Get(L, 3, out stateInfo);
                    int layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)translator.GetObject(L, 5, typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable));
                    
                    __cl_gen_to_be_invoked.OnStateIK( animator, stateInfo, layerIndex, controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateIK!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateMachineEnter(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.StateMachineBehaviour __cl_gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.OnStateMachineEnter( animator, stateMachinePathHash );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Experimental.Director.AnimatorControllerPlayable>(L, 4)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)translator.GetObject(L, 4, typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable));
                    
                    __cl_gen_to_be_invoked.OnStateMachineEnter( animator, stateMachinePathHash, controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateMachineEnter!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateMachineExit(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.StateMachineBehaviour __cl_gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.OnStateMachineExit( animator, stateMachinePathHash );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Experimental.Director.AnimatorControllerPlayable>(L, 4)) 
                {
                    UnityEngine.Animator animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Experimental.Director.AnimatorControllerPlayable controller = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)translator.GetObject(L, 4, typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable));
                    
                    __cl_gen_to_be_invoked.OnStateMachineExit( animator, stateMachinePathHash, controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateMachineExit!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
