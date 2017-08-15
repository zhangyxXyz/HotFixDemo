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
    public class UnityEngineHumanPoseHandlerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.HumanPoseHandler), L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHumanPose", _m_GetHumanPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetHumanPose", _m_SetHumanPose);
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.HumanPoseHandler), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.HumanPoseHandler), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.HumanPoseHandler));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.HumanPoseHandler), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Avatar>(L, 2) && translator.Assignable<UnityEngine.Transform>(L, 3))
				{
					UnityEngine.Avatar avatar = (UnityEngine.Avatar)translator.GetObject(L, 2, typeof(UnityEngine.Avatar));
					UnityEngine.Transform root = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
					
					UnityEngine.HumanPoseHandler __cl_gen_ret = new UnityEngine.HumanPoseHandler(avatar, root);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.HumanPoseHandler constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.HumanPoseHandler __cl_gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHumanPose(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.HumanPoseHandler __cl_gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.HumanPose humanPose;translator.Get(L, 2, out humanPose);
                    
                    __cl_gen_to_be_invoked.GetHumanPose( ref humanPose );
                    translator.Push(L, humanPose);
                        translator.Update(L, 2, humanPose);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetHumanPose(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.HumanPoseHandler __cl_gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.HumanPose humanPose;translator.Get(L, 2, out humanPose);
                    
                    __cl_gen_to_be_invoked.SetHumanPose( ref humanPose );
                    translator.Push(L, humanPose);
                        translator.Update(L, 2, humanPose);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
