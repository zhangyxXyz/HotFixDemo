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
    public class UnityEngineUIMaskUtilitiesWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.MaskUtilities), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.UI.MaskUtilities), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.MaskUtilities), L, __CreateInstance, 8, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Notify2DMaskStateChanged", _m_Notify2DMaskStateChanged_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NotifyStencilStateChanged", _m_NotifyStencilStateChanged_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindRootSortOverrideCanvas", _m_FindRootSortOverrideCanvas_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStencilDepth", _m_GetStencilDepth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsDescendantOrSelf", _m_IsDescendantOrSelf_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRectMaskForClippable", _m_GetRectMaskForClippable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRectMasksForClip", _m_GetRectMasksForClip_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.MaskUtilities));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.MaskUtilities), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.UI.MaskUtilities __cl_gen_ret = new UnityEngine.UI.MaskUtilities();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.MaskUtilities constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Notify2DMaskStateChanged_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Component mask = (UnityEngine.Component)translator.GetObject(L, 1, typeof(UnityEngine.Component));
                    
                    UnityEngine.UI.MaskUtilities.Notify2DMaskStateChanged( mask );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NotifyStencilStateChanged_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Component mask = (UnityEngine.Component)translator.GetObject(L, 1, typeof(UnityEngine.Component));
                    
                    UnityEngine.UI.MaskUtilities.NotifyStencilStateChanged( mask );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindRootSortOverrideCanvas_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform start = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                        UnityEngine.Transform __cl_gen_ret = UnityEngine.UI.MaskUtilities.FindRootSortOverrideCanvas( start );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStencilDepth_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform stopAfter = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        int __cl_gen_ret = UnityEngine.UI.MaskUtilities.GetStencilDepth( transform, stopAfter );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsDescendantOrSelf_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Transform father = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    UnityEngine.Transform child = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        bool __cl_gen_ret = UnityEngine.UI.MaskUtilities.IsDescendantOrSelf( father, child );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRectMaskForClippable_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.IClippable clippable = (UnityEngine.UI.IClippable)translator.GetObject(L, 1, typeof(UnityEngine.UI.IClippable));
                    
                        UnityEngine.UI.RectMask2D __cl_gen_ret = UnityEngine.UI.MaskUtilities.GetRectMaskForClippable( clippable );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRectMasksForClip_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.UI.RectMask2D clipper = (UnityEngine.UI.RectMask2D)translator.GetObject(L, 1, typeof(UnityEngine.UI.RectMask2D));
                    System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks = (System.Collections.Generic.List<UnityEngine.UI.RectMask2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UI.RectMask2D>));
                    
                    UnityEngine.UI.MaskUtilities.GetRectMasksForClip( clipper, masks );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
