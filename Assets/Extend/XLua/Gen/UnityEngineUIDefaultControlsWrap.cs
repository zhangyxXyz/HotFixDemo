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
    public class UnityEngineUIDefaultControlsWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.DefaultControls), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.UI.DefaultControls), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.DefaultControls), L, __CreateInstance, 12, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreatePanel", _m_CreatePanel_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateButton", _m_CreateButton_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateText", _m_CreateText_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateImage", _m_CreateImage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateRawImage", _m_CreateRawImage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateSlider", _m_CreateSlider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateScrollbar", _m_CreateScrollbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateToggle", _m_CreateToggle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateInputField", _m_CreateInputField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateDropdown", _m_CreateDropdown_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateScrollView", _m_CreateScrollView_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.DefaultControls));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.DefaultControls), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.DefaultControls does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreatePanel_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreatePanel( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateButton_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateButton( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateText_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateText( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateImage_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateImage( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateRawImage_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateRawImage( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateSlider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateSlider( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateScrollbar_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateScrollbar( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateToggle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateToggle( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateInputField_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateInputField( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateDropdown_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateDropdown( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateScrollView_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.DefaultControls.Resources resources;translator.Get(L, 1, out resources);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.UI.DefaultControls.CreateScrollView( resources );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
