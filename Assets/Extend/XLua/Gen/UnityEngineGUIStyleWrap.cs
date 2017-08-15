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
    public class UnityEngineGUIStyleWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUIStyle), L, translator, 0, 10, 28, 26);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Draw", _m_Draw);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawCursor", _m_DrawCursor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawWithTextSelection", _m_DrawWithTextSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCursorPixelPosition", _m_GetCursorPixelPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCursorStringIndex", _m_GetCursorStringIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalcSize", _m_CalcSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalcScreenSize", _m_CalcScreenSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalcHeight", _m_CalcHeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalcMinMaxWidth", _m_CalcMinMaxWidth);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "normal", _g_get_normal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hover", _g_get_hover);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "active", _g_get_active);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onNormal", _g_get_onNormal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onHover", _g_get_onHover);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onActive", _g_get_onActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focused", _g_get_focused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFocused", _g_get_onFocused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "border", _g_get_border);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "margin", _g_get_margin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "padding", _g_get_padding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overflow", _g_get_overflow);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "font", _g_get_font);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineHeight", _g_get_lineHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHeightDependantOnWidth", _g_get_isHeightDependantOnWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "imagePosition", _g_get_imagePosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alignment", _g_get_alignment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wordWrap", _g_get_wordWrap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clipping", _g_get_clipping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "contentOffset", _g_get_contentOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fixedWidth", _g_get_fixedWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fixedHeight", _g_get_fixedHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stretchWidth", _g_get_stretchWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stretchHeight", _g_get_stretchHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontSize", _g_get_fontSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fontStyle", _g_get_fontStyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "richText", _g_get_richText);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "normal", _s_set_normal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hover", _s_set_hover);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "active", _s_set_active);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onNormal", _s_set_onNormal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onHover", _s_set_onHover);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onActive", _s_set_onActive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "focused", _s_set_focused);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onFocused", _s_set_onFocused);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "border", _s_set_border);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "margin", _s_set_margin);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "padding", _s_set_padding);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overflow", _s_set_overflow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "font", _s_set_font);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "imagePosition", _s_set_imagePosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "alignment", _s_set_alignment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wordWrap", _s_set_wordWrap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clipping", _s_set_clipping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "contentOffset", _s_set_contentOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fixedWidth", _s_set_fixedWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fixedHeight", _s_set_fixedHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stretchWidth", _s_set_stretchWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stretchHeight", _s_set_stretchHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontSize", _s_set_fontSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fontStyle", _s_set_fontStyle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "richText", _s_set_richText);
            
			Utils.EndObjectRegister(typeof(UnityEngine.GUIStyle), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUIStyle), L, __CreateInstance, 1, 1, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUIStyle));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "none", _g_get_none);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.GUIStyle), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUIStyle __cl_gen_ret = new UnityEngine.GUIStyle();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.GUIStyle>(L, 2))
				{
					UnityEngine.GUIStyle other = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
					
					UnityEngine.GUIStyle __cl_gen_ret = new UnityEngine.GUIStyle(other);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUIStyle constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Draw(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    bool isHover = LuaAPI.lua_toboolean(L, 3);
                    bool isActive = LuaAPI.lua_toboolean(L, 4);
                    bool on = LuaAPI.lua_toboolean(L, 5);
                    bool hasKeyboardFocus = LuaAPI.lua_toboolean(L, 6);
                    
                    __cl_gen_to_be_invoked.Draw( position, isHover, isActive, on, hasKeyboardFocus );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUIContent>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    int controlID = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.Draw( position, content, controlID );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUIContent>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    int controlID = LuaAPI.xlua_tointeger(L, 4);
                    bool on = LuaAPI.lua_toboolean(L, 5);
                    
                    __cl_gen_to_be_invoked.Draw( position, content, controlID, on );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    string text = LuaAPI.lua_tostring(L, 3);
                    bool isHover = LuaAPI.lua_toboolean(L, 4);
                    bool isActive = LuaAPI.lua_toboolean(L, 5);
                    bool on = LuaAPI.lua_toboolean(L, 6);
                    bool hasKeyboardFocus = LuaAPI.lua_toboolean(L, 7);
                    
                    __cl_gen_to_be_invoked.Draw( position, text, isHover, isActive, on, hasKeyboardFocus );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    bool isHover = LuaAPI.lua_toboolean(L, 4);
                    bool isActive = LuaAPI.lua_toboolean(L, 5);
                    bool on = LuaAPI.lua_toboolean(L, 6);
                    bool hasKeyboardFocus = LuaAPI.lua_toboolean(L, 7);
                    
                    __cl_gen_to_be_invoked.Draw( position, image, isHover, isActive, on, hasKeyboardFocus );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUIContent>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    bool isHover = LuaAPI.lua_toboolean(L, 4);
                    bool isActive = LuaAPI.lua_toboolean(L, 5);
                    bool on = LuaAPI.lua_toboolean(L, 6);
                    bool hasKeyboardFocus = LuaAPI.lua_toboolean(L, 7);
                    
                    __cl_gen_to_be_invoked.Draw( position, content, isHover, isActive, on, hasKeyboardFocus );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUIStyle.Draw!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawCursor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    int controlID = LuaAPI.xlua_tointeger(L, 4);
                    int Character = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.DrawCursor( position, content, controlID, Character );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawWithTextSelection(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    int controlID = LuaAPI.xlua_tointeger(L, 4);
                    int firstSelectedCharacter = LuaAPI.xlua_tointeger(L, 5);
                    int lastSelectedCharacter = LuaAPI.xlua_tointeger(L, 6);
                    
                    __cl_gen_to_be_invoked.DrawWithTextSelection( position, content, controlID, firstSelectedCharacter, lastSelectedCharacter );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCursorPixelPosition(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    int cursorStringIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.GetCursorPixelPosition( position, content, cursorStringIndex );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCursorStringIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect position;translator.Get(L, 2, out position);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 3, typeof(UnityEngine.GUIContent));
                    UnityEngine.Vector2 cursorPixelPosition;translator.Get(L, 4, out cursorPixelPosition);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetCursorStringIndex( position, content, cursorPixelPosition );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalcSize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.CalcSize( content );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalcScreenSize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector2 contentSize;translator.Get(L, 2, out contentSize);
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.CalcScreenSize( contentSize );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalcHeight(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    float width = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.CalcHeight( content, width );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalcMinMaxWidth(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    float minWidth;
                    float maxWidth;
                    
                    __cl_gen_to_be_invoked.CalcMinMaxWidth( content, out minWidth, out maxWidth );
                    LuaAPI.lua_pushnumber(L, minWidth);
                        
                    LuaAPI.lua_pushnumber(L, maxWidth);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normal(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.normal);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hover(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hover);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_active(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.active);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onNormal(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onNormal);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onHover(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onHover);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onActive(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onActive);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focused(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.focused);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFocused(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.onFocused);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_border(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.border);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_margin(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.margin);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_padding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.padding);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overflow(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.overflow);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_font(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.font);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lineHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.lineHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_none(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.Push(L, UnityEngine.GUIStyle.none);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isHeightDependantOnWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isHeightDependantOnWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.name);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_imagePosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.imagePosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineTextAnchor(L, __cl_gen_to_be_invoked.alignment);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wordWrap(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.wordWrap);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clipping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.clipping);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contentOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.contentOffset);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fixedWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.fixedWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fixedHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.fixedHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stretchWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.stretchWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stretchHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.stretchHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.fontSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.fontStyle);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_richText(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.richText);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_normal(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.normal = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hover(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hover = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_active(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.active = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onNormal(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onNormal = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onHover(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onHover = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onActive(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onActive = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_focused(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.focused = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onFocused(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.onFocused = (UnityEngine.GUIStyleState)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyleState));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_border(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.border = (UnityEngine.RectOffset)translator.GetObject(L, 2, typeof(UnityEngine.RectOffset));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_margin(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.margin = (UnityEngine.RectOffset)translator.GetObject(L, 2, typeof(UnityEngine.RectOffset));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_padding(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.padding = (UnityEngine.RectOffset)translator.GetObject(L, 2, typeof(UnityEngine.RectOffset));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overflow(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.overflow = (UnityEngine.RectOffset)translator.GetObject(L, 2, typeof(UnityEngine.RectOffset));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_font(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.font = (UnityEngine.Font)translator.GetObject(L, 2, typeof(UnityEngine.Font));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_imagePosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                UnityEngine.ImagePosition __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.imagePosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alignment(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                UnityEngine.TextAnchor __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.alignment = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wordWrap(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.wordWrap = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clipping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                UnityEngine.TextClipping __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.clipping = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_contentOffset(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.contentOffset = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fixedWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fixedWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fixedHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fixedHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stretchWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stretchWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stretchHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.stretchHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.fontSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fontStyle(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                UnityEngine.FontStyle __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.fontStyle = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_richText(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GUIStyle __cl_gen_to_be_invoked = (UnityEngine.GUIStyle)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.richText = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
