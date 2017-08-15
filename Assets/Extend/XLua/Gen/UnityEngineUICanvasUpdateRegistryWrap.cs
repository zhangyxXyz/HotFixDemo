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
    public class UnityEngineUICanvasUpdateRegistryWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasUpdateRegistry), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasUpdateRegistry), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasUpdateRegistry), L, __CreateInstance, 8, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterCanvasElementForLayoutRebuild", _m_RegisterCanvasElementForLayoutRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryRegisterCanvasElementForLayoutRebuild", _m_TryRegisterCanvasElementForLayoutRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterCanvasElementForGraphicRebuild", _m_RegisterCanvasElementForGraphicRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryRegisterCanvasElementForGraphicRebuild", _m_TryRegisterCanvasElementForGraphicRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnRegisterCanvasElementForRebuild", _m_UnRegisterCanvasElementForRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsRebuildingLayout", _m_IsRebuildingLayout_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsRebuildingGraphics", _m_IsRebuildingGraphics_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.CanvasUpdateRegistry));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "instance", _g_get_instance);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasUpdateRegistry), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.CanvasUpdateRegistry does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterCanvasElementForLayoutRebuild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.ICanvasElement element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                    UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild( element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryRegisterCanvasElementForLayoutRebuild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.ICanvasElement element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                        bool __cl_gen_ret = UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild( element );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterCanvasElementForGraphicRebuild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.ICanvasElement element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                    UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild( element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryRegisterCanvasElementForGraphicRebuild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.ICanvasElement element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                        bool __cl_gen_ret = UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild( element );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnRegisterCanvasElementForRebuild_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.ICanvasElement element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                    UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild( element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRebuildingLayout_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingLayout(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRebuildingGraphics_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingGraphics(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_instance(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.UI.CanvasUpdateRegistry.instance);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
