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
    public class UnityEngineGUIWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUI), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.GUI), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUI), L, __CreateInstance, 36, 9, 9);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Label", _m_Label_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawTexture", _m_DrawTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawTextureWithTexCoords", _m_DrawTextureWithTexCoords_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Box", _m_Box_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Button", _m_Button_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RepeatButton", _m_RepeatButton_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TextField", _m_TextField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PasswordField", _m_PasswordField_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TextArea", _m_TextArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Toggle", _m_Toggle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Toolbar", _m_Toolbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SelectionGrid", _m_SelectionGrid_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HorizontalSlider", _m_HorizontalSlider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VerticalSlider", _m_VerticalSlider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Slider", _m_Slider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HorizontalScrollbar", _m_HorizontalScrollbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VerticalScrollbar", _m_VerticalScrollbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginClip", _m_BeginClip_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginGroup", _m_BeginGroup_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndGroup", _m_EndGroup_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndClip", _m_EndClip_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginScrollView", _m_BeginScrollView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndScrollView", _m_EndScrollView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScrollTo", _m_ScrollTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ScrollTowards", _m_ScrollTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Window", _m_Window_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ModalWindow", _m_ModalWindow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DragWindow", _m_DragWindow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetNextControlName", _m_SetNextControlName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetNameOfFocusedControl", _m_GetNameOfFocusedControl_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FocusControl", _m_FocusControl_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BringWindowToFront", _m_BringWindowToFront_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BringWindowToBack", _m_BringWindowToBack_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FocusWindow", _m_FocusWindow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnfocusWindow", _m_UnfocusWindow_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUI));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "skin", _g_get_skin);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "matrix", _g_get_matrix);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "tooltip", _g_get_tooltip);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "color", _g_get_color);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "backgroundColor", _g_get_backgroundColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "contentColor", _g_get_contentColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "changed", _g_get_changed);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "depth", _g_get_depth);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "skin", _s_set_skin);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "matrix", _s_set_matrix);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "tooltip", _s_set_tooltip);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "color", _s_set_color);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "backgroundColor", _s_set_backgroundColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "contentColor", _s_set_contentColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "changed", _s_set_changed);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "enabled", _s_set_enabled);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "depth", _s_set_depth);
            
			Utils.EndClassRegister(typeof(UnityEngine.GUI), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUI __cl_gen_ret = new UnityEngine.GUI();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Label_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.GUI.Label( position, text );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.GUI.Label( position, image );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                    UnityEngine.GUI.Label( position, content );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.Label( position, text, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.Label( position, image, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.Label( position, content, style );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.Label!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawTexture_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.GUI.DrawTexture( position, image );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.ScaleMode>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.ScaleMode scaleMode;translator.Get(L, 3, out scaleMode);
                    
                    UnityEngine.GUI.DrawTexture( position, image, scaleMode );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.ScaleMode>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.ScaleMode scaleMode;translator.Get(L, 3, out scaleMode);
                    bool alphaBlend = LuaAPI.lua_toboolean(L, 4);
                    
                    UnityEngine.GUI.DrawTexture( position, image, scaleMode, alphaBlend );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.ScaleMode>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.ScaleMode scaleMode;translator.Get(L, 3, out scaleMode);
                    bool alphaBlend = LuaAPI.lua_toboolean(L, 4);
                    float imageAspect = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    UnityEngine.GUI.DrawTexture( position, image, scaleMode, alphaBlend, imageAspect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.DrawTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawTextureWithTexCoords_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect texCoords;translator.Get(L, 3, out texCoords);
                    
                    UnityEngine.GUI.DrawTextureWithTexCoords( position, image, texCoords );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect texCoords;translator.Get(L, 3, out texCoords);
                    bool alphaBlend = LuaAPI.lua_toboolean(L, 4);
                    
                    UnityEngine.GUI.DrawTextureWithTexCoords( position, image, texCoords, alphaBlend );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.DrawTextureWithTexCoords!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Box_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.GUI.Box( position, text );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.GUI.Box( position, image );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                    UnityEngine.GUI.Box( position, content );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.Box( position, text, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.Box( position, image, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.Box( position, content, style );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.Box!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Button_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Button( position, text );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Button( position, image );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Button( position, content );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Button( position, text, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Button( position, image, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Button( position, content, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.Button!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatButton_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUI.RepeatButton( position, text );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.RepeatButton( position, image );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.RepeatButton( position, content );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.RepeatButton( position, text, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.RepeatButton( position, image, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.RepeatButton( position, content, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.RepeatButton!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextField_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextField( position, text );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    int maxLength = LuaAPI.xlua_tointeger(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextField( position, text, maxLength );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextField( position, text, style );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    int maxLength = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextField( position, text, maxLength, style );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.TextField!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PasswordField_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string password = LuaAPI.lua_tostring(L, 2);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUI.PasswordField( position, password, maskChar );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string password = LuaAPI.lua_tostring(L, 2);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 3);
                    int maxLength = LuaAPI.xlua_tointeger(L, 4);
                    
                        string __cl_gen_ret = UnityEngine.GUI.PasswordField( position, password, maskChar, maxLength );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string password = LuaAPI.lua_tostring(L, 2);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        string __cl_gen_ret = UnityEngine.GUI.PasswordField( position, password, maskChar, style );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string password = LuaAPI.lua_tostring(L, 2);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 3);
                    int maxLength = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        string __cl_gen_ret = UnityEngine.GUI.PasswordField( position, password, maskChar, maxLength, style );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.PasswordField!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextArea_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextArea( position, text );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    int maxLength = LuaAPI.xlua_tointeger(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextArea( position, text, maxLength );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextArea( position, text, style );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    int maxLength = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        string __cl_gen_ret = UnityEngine.GUI.TextArea( position, text, maxLength, style );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.TextArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toggle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    bool value = LuaAPI.lua_toboolean(L, 2);
                    string text = LuaAPI.lua_tostring(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Toggle( position, value, text );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    bool value = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Toggle( position, value, image );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIContent>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    bool value = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Toggle( position, value, content );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    bool value = LuaAPI.lua_toboolean(L, 2);
                    string text = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Toggle( position, value, text, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    bool value = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Toggle( position, value, image, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIContent>(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    bool value = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Toggle( position, value, content, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int id = LuaAPI.xlua_tointeger(L, 2);
                    bool value = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        bool __cl_gen_ret = UnityEngine.GUI.Toggle( position, id, value, content, style );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.Toggle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toolbar_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<string[]>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    string[] texts = (string[])translator.GetObject(L, 3, typeof(string[]));
                    
                        int __cl_gen_ret = UnityEngine.GUI.Toolbar( position, selected, texts );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture[]>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 3, typeof(UnityEngine.Texture[]));
                    
                        int __cl_gen_ret = UnityEngine.GUI.Toolbar( position, selected, images );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIContent[] content = (UnityEngine.GUIContent[])translator.GetObject(L, 3, typeof(UnityEngine.GUIContent[]));
                    
                        int __cl_gen_ret = UnityEngine.GUI.Toolbar( position, selected, content );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<string[]>(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    string[] texts = (string[])translator.GetObject(L, 3, typeof(string[]));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        int __cl_gen_ret = UnityEngine.GUI.Toolbar( position, selected, texts, style );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture[]>(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 3, typeof(UnityEngine.Texture[]));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        int __cl_gen_ret = UnityEngine.GUI.Toolbar( position, selected, images, style );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIContent[] contents = (UnityEngine.GUIContent[])translator.GetObject(L, 3, typeof(UnityEngine.GUIContent[]));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    
                        int __cl_gen_ret = UnityEngine.GUI.Toolbar( position, selected, contents, style );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.Toolbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectionGrid_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<string[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    string[] texts = (string[])translator.GetObject(L, 3, typeof(string[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUI.SelectionGrid( position, selected, texts, xCount );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 3, typeof(UnityEngine.Texture[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUI.SelectionGrid( position, selected, images, xCount );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIContent[] content = (UnityEngine.GUIContent[])translator.GetObject(L, 3, typeof(UnityEngine.GUIContent[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUI.SelectionGrid( position, selected, content, xCount );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<string[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    string[] texts = (string[])translator.GetObject(L, 3, typeof(string[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        int __cl_gen_ret = UnityEngine.GUI.SelectionGrid( position, selected, texts, xCount, style );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 3, typeof(UnityEngine.Texture[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        int __cl_gen_ret = UnityEngine.GUI.SelectionGrid( position, selected, images, xCount, style );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    int selected = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIContent[] contents = (UnityEngine.GUIContent[])translator.GetObject(L, 3, typeof(UnityEngine.GUIContent[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        int __cl_gen_ret = UnityEngine.GUI.SelectionGrid( position, selected, contents, xCount, style );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.SelectionGrid!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HorizontalSlider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        float __cl_gen_ret = UnityEngine.GUI.HorizontalSlider( position, value, leftValue, rightValue );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& translator.Assignable<UnityEngine.GUIStyle>(L, 6)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle slider = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle thumb = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    
                        float __cl_gen_ret = UnityEngine.GUI.HorizontalSlider( position, value, leftValue, rightValue, slider, thumb );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.HorizontalSlider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VerticalSlider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float topValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float bottomValue = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        float __cl_gen_ret = UnityEngine.GUI.VerticalSlider( position, value, topValue, bottomValue );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& translator.Assignable<UnityEngine.GUIStyle>(L, 6)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float topValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float bottomValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle slider = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle thumb = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    
                        float __cl_gen_ret = UnityEngine.GUI.VerticalSlider( position, value, topValue, bottomValue, slider, thumb );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.VerticalSlider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Slider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float size = (float)LuaAPI.lua_tonumber(L, 3);
                    float start = (float)LuaAPI.lua_tonumber(L, 4);
                    float end = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.GUIStyle slider = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle thumb = (UnityEngine.GUIStyle)translator.GetObject(L, 7, typeof(UnityEngine.GUIStyle));
                    bool horiz = LuaAPI.lua_toboolean(L, 8);
                    int id = LuaAPI.xlua_tointeger(L, 9);
                    
                        float __cl_gen_ret = UnityEngine.GUI.Slider( position, value, size, start, end, slider, thumb, horiz, id );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HorizontalScrollbar_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float size = (float)LuaAPI.lua_tonumber(L, 3);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 4);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        float __cl_gen_ret = UnityEngine.GUI.HorizontalScrollbar( position, value, size, leftValue, rightValue );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.GUIStyle>(L, 6)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float size = (float)LuaAPI.lua_tonumber(L, 3);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 4);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    
                        float __cl_gen_ret = UnityEngine.GUI.HorizontalScrollbar( position, value, size, leftValue, rightValue, style );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.HorizontalScrollbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VerticalScrollbar_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float size = (float)LuaAPI.lua_tonumber(L, 3);
                    float topValue = (float)LuaAPI.lua_tonumber(L, 4);
                    float bottomValue = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        float __cl_gen_ret = UnityEngine.GUI.VerticalScrollbar( position, value, size, topValue, bottomValue );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.GUIStyle>(L, 6)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float value = (float)LuaAPI.lua_tonumber(L, 2);
                    float size = (float)LuaAPI.lua_tonumber(L, 3);
                    float topValue = (float)LuaAPI.lua_tonumber(L, 4);
                    float bottomValue = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    
                        float __cl_gen_ret = UnityEngine.GUI.VerticalScrollbar( position, value, size, topValue, bottomValue, style );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.VerticalScrollbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginClip_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Rect>(L, 1)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    
                    UnityEngine.GUI.BeginClip( position );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Vector2 scrollOffset;translator.Get(L, 2, out scrollOffset);
                    UnityEngine.Vector2 renderOffset;translator.Get(L, 3, out renderOffset);
                    bool resetOffset = LuaAPI.lua_toboolean(L, 4);
                    
                    UnityEngine.GUI.BeginClip( position, scrollOffset, renderOffset, resetOffset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.BeginClip!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginGroup_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Rect>(L, 1)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    
                    UnityEngine.GUI.BeginGroup( position );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.GUI.BeginGroup( position, text );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.GUI.BeginGroup( position, image );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                    UnityEngine.GUI.BeginGroup( position, content );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.BeginGroup( position, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.BeginGroup( position, text, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.BeginGroup( position, image, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUI.BeginGroup( position, content, style );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.BeginGroup!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndGroup_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUI.EndGroup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndClip_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUI.EndClip(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginScrollView_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 2, out scrollPosition);
                    UnityEngine.Rect viewRect;translator.Get(L, 3, out viewRect);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUI.BeginScrollView( position, scrollPosition, viewRect );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 2, out scrollPosition);
                    UnityEngine.Rect viewRect;translator.Get(L, 3, out viewRect);
                    bool alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 4);
                    bool alwaysShowVertical = LuaAPI.lua_toboolean(L, 5);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUI.BeginScrollView( position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 2, out scrollPosition);
                    UnityEngine.Rect viewRect;translator.Get(L, 3, out viewRect);
                    UnityEngine.GUIStyle horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUI.BeginScrollView( position, scrollPosition, viewRect, horizontalScrollbar, verticalScrollbar );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.GUIStyle>(L, 6)&& translator.Assignable<UnityEngine.GUIStyle>(L, 7)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 2, out scrollPosition);
                    UnityEngine.Rect viewRect;translator.Get(L, 3, out viewRect);
                    bool alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 4);
                    bool alwaysShowVertical = LuaAPI.lua_toboolean(L, 5);
                    UnityEngine.GUIStyle horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 7, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUI.BeginScrollView( position, scrollPosition, viewRect, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.BeginScrollView!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndScrollView_xlua_st_(RealStatePtr L)
        {
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 0) 
                {
                    
                    UnityEngine.GUI.EndScrollView(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool handleScrollWheel = LuaAPI.lua_toboolean(L, 1);
                    
                    UnityEngine.GUI.EndScrollView( handleScrollWheel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.EndScrollView!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollTo_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    
                    UnityEngine.GUI.ScrollTo( position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ScrollTowards_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    float maxDelta = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUI.ScrollTowards( position, maxDelta );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Window_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string text = LuaAPI.lua_tostring(L, 4);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.Window( id, clientRect, func, text );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.Window( id, clientRect, func, image );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.Window( id, clientRect, func, content );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string text = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.Window( id, clientRect, func, text, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.Window( id, clientRect, func, image, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent title = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.Window( id, clientRect, func, title, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.Window!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ModalWindow_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string text = LuaAPI.lua_tostring(L, 4);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.ModalWindow( id, clientRect, func, text );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.ModalWindow( id, clientRect, func, image );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.ModalWindow( id, clientRect, func, content );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string text = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.ModalWindow( id, clientRect, func, text, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.ModalWindow( id, clientRect, func, image, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect clientRect;translator.Get(L, 2, out clientRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUI.ModalWindow( id, clientRect, func, content, style );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.ModalWindow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DragWindow_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 0) 
                {
                    
                    UnityEngine.GUI.DragWindow(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Rect>(L, 1)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 1, out position);
                    
                    UnityEngine.GUI.DragWindow( position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUI.DragWindow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetNextControlName_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.GUI.SetNextControlName( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNameOfFocusedControl_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                        string __cl_gen_ret = UnityEngine.GUI.GetNameOfFocusedControl(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FocusControl_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.GUI.FocusControl( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BringWindowToFront_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int windowID = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.GUI.BringWindowToFront( windowID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BringWindowToBack_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int windowID = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.GUI.BringWindowToBack( windowID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FocusWindow_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    int windowID = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.GUI.FocusWindow( windowID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnfocusWindow_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUI.UnfocusWindow(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_skin(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.GUI.skin);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_matrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.GUI.matrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tooltip(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushstring(L, UnityEngine.GUI.tooltip);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.GUI.color);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_backgroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.GUI.backgroundColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contentColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.GUI.contentColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_changed(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.GUI.changed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.GUI.enabled);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.GUI.depth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_skin(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    UnityEngine.GUI.skin = (UnityEngine.GUISkin)translator.GetObject(L, 1, typeof(UnityEngine.GUISkin));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_matrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Matrix4x4 __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.GUI.matrix = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tooltip(RealStatePtr L)
        {
            
            try {
			    UnityEngine.GUI.tooltip = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.GUI.color = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_backgroundColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.GUI.backgroundColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_contentColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			UnityEngine.Color __cl_gen_value;translator.Get(L, 1, out __cl_gen_value);
				UnityEngine.GUI.contentColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_changed(RealStatePtr L)
        {
            
            try {
			    UnityEngine.GUI.changed = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
            
            try {
			    UnityEngine.GUI.enabled = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depth(RealStatePtr L)
        {
            
            try {
			    UnityEngine.GUI.depth = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
