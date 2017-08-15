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
    public class UnityEngineGUISkinWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUISkin), L, translator, 0, 3, 23, 22);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetStyle", _m_GetStyle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindStyle", _m_FindStyle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "font", _g_get_font);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "box", _g_get_box);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "label", _g_get_label);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textField", _g_get_textField);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textArea", _g_get_textArea);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "button", _g_get_button);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "toggle", _g_get_toggle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "window", _g_get_window);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalSlider", _g_get_horizontalSlider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalSliderThumb", _g_get_horizontalSliderThumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalSlider", _g_get_verticalSlider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalSliderThumb", _g_get_verticalSliderThumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollbar", _g_get_horizontalScrollbar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollbarThumb", _g_get_horizontalScrollbarThumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollbarLeftButton", _g_get_horizontalScrollbarLeftButton);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "horizontalScrollbarRightButton", _g_get_horizontalScrollbarRightButton);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollbar", _g_get_verticalScrollbar);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollbarThumb", _g_get_verticalScrollbarThumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollbarUpButton", _g_get_verticalScrollbarUpButton);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "verticalScrollbarDownButton", _g_get_verticalScrollbarDownButton);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollView", _g_get_scrollView);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customStyles", _g_get_customStyles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "settings", _g_get_settings);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "font", _s_set_font);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "box", _s_set_box);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "label", _s_set_label);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "textField", _s_set_textField);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "textArea", _s_set_textArea);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "button", _s_set_button);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "toggle", _s_set_toggle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "window", _s_set_window);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalSlider", _s_set_horizontalSlider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalSliderThumb", _s_set_horizontalSliderThumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalSlider", _s_set_verticalSlider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalSliderThumb", _s_set_verticalSliderThumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollbar", _s_set_horizontalScrollbar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollbarThumb", _s_set_horizontalScrollbarThumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollbarLeftButton", _s_set_horizontalScrollbarLeftButton);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "horizontalScrollbarRightButton", _s_set_horizontalScrollbarRightButton);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollbar", _s_set_verticalScrollbar);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollbarThumb", _s_set_verticalScrollbarThumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollbarUpButton", _s_set_verticalScrollbarUpButton);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "verticalScrollbarDownButton", _s_set_verticalScrollbarDownButton);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollView", _s_set_scrollView);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customStyles", _s_set_customStyles);
            
			Utils.EndObjectRegister(typeof(UnityEngine.GUISkin), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUISkin), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUISkin));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GUISkin), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUISkin __cl_gen_ret = new UnityEngine.GUISkin();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUISkin constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStyle(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string styleName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.GUIStyle __cl_gen_ret = __cl_gen_to_be_invoked.GetStyle( styleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindStyle(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string styleName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.GUIStyle __cl_gen_ret = __cl_gen_to_be_invoked.FindStyle( styleName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.GetEnumerator(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_font(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.font);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_box(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.box);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_label(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.label);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_textField(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.textField);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_textArea(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.textArea);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_button(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.button);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_toggle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.toggle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_window(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.window);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalSlider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.horizontalSlider);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalSliderThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.horizontalSliderThumb);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalSlider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalSlider);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalSliderThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalSliderThumb);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalScrollbar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.horizontalScrollbar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalScrollbarThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.horizontalScrollbarThumb);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalScrollbarLeftButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.horizontalScrollbarLeftButton);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_horizontalScrollbarRightButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.horizontalScrollbarRightButton);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalScrollbar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalScrollbar);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalScrollbarThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalScrollbarThumb);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalScrollbarUpButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalScrollbarUpButton);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_verticalScrollbarDownButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.verticalScrollbarDownButton);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollView(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.scrollView);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customStyles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.customStyles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_settings(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.settings);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_font(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.font = (UnityEngine.Font)translator.GetObject(L, 2, typeof(UnityEngine.Font));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_box(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.box = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_label(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.label = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_textField(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.textField = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_textArea(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.textArea = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_button(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.button = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_toggle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.toggle = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_window(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.window = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalSlider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalSlider = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalSliderThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalSliderThumb = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalSlider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalSlider = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalSliderThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalSliderThumb = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalScrollbar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalScrollbarThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalScrollbarThumb = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalScrollbarLeftButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalScrollbarLeftButton = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_horizontalScrollbarRightButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.horizontalScrollbarRightButton = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalScrollbar(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalScrollbarThumb(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalScrollbarThumb = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalScrollbarUpButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalScrollbarUpButton = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_verticalScrollbarDownButton(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.verticalScrollbarDownButton = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollView(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.scrollView = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customStyles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUISkin __cl_gen_to_be_invoked = (UnityEngine.GUISkin)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.customStyles = (UnityEngine.GUIStyle[])translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
