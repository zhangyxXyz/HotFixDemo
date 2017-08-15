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
    public class UnityEngineGUILayoutWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GUILayout), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.GUILayout), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GUILayout), L, __CreateInstance, 34, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Label", _m_Label_xlua_st_);
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
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HorizontalScrollbar", _m_HorizontalScrollbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VerticalScrollbar", _m_VerticalScrollbar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Space", _m_Space_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FlexibleSpace", _m_FlexibleSpace_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginHorizontal", _m_BeginHorizontal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndHorizontal", _m_EndHorizontal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginVertical", _m_BeginVertical_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndVertical", _m_EndVertical_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginArea", _m_BeginArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndArea", _m_EndArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BeginScrollView", _m_BeginScrollView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndScrollView", _m_EndScrollView_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Window", _m_Window_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Width", _m_Width_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MinWidth", _m_MinWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MaxWidth", _m_MaxWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Height", _m_Height_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MinHeight", _m_MinHeight_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MaxHeight", _m_MaxHeight_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExpandWidth", _m_ExpandWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExpandHeight", _m_ExpandHeight_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GUILayout));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GUILayout), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GUILayout __cl_gen_ret = new UnityEngine.GUILayout();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Label_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Label( image, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Label( text, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Label( content, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Label( image, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Label( text, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Label( content, style, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Label!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Box_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Box( image, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Box( text, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.Box( content, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Box( image, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Box( text, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.Box( content, style, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Box!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Button_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Button( image, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Button( text, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Button( content, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Button( image, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Button( text, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Button( content, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Button!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatButton_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.Texture>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.RepeatButton( image, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.RepeatButton( text, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.RepeatButton( content, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.RepeatButton( image, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.RepeatButton( text, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.RepeatButton( content, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.RepeatButton!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextField_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextField( text, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextField( text, maxLength, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextField( text, style, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextField( text, maxLength, style, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.TextField!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PasswordField_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string password = LuaAPI.lua_tostring(L, 1);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.PasswordField( password, maskChar, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string password = LuaAPI.lua_tostring(L, 1);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    int maxLength = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.PasswordField( password, maskChar, maxLength, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string password = LuaAPI.lua_tostring(L, 1);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.PasswordField( password, maskChar, style, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    string password = LuaAPI.lua_tostring(L, 1);
                    char maskChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    int maxLength = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.PasswordField( password, maskChar, maxLength, style, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.PasswordField!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextArea_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextArea( text, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextArea( text, maxLength, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextArea( text, style, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    int maxLength = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        string __cl_gen_ret = UnityEngine.GUILayout.TextArea( text, maxLength, style, options );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.TextArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toggle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    bool value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Toggle( value, image, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    bool value = LuaAPI.lua_toboolean(L, 1);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Toggle( value, text, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    bool value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Toggle( value, content, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    bool value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Toggle( value, image, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    bool value = LuaAPI.lua_toboolean(L, 1);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Toggle( value, text, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    bool value = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        bool __cl_gen_ret = UnityEngine.GUILayout.Toggle( value, content, style, options );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Toggle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Toolbar_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.Toolbar( selected, texts, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.Toolbar( selected, images, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] content = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.Toolbar( selected, content, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.Toolbar( selected, texts, style, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.Toolbar( selected, images, style, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] contents = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.Toolbar( selected, contents, style, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Toolbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectionGrid_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.SelectionGrid( selected, texts, xCount, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.SelectionGrid( selected, images, xCount, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] content = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.SelectionGrid( selected, content, xCount, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<string[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    string[] texts = (string[])translator.GetObject(L, 2, typeof(string[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.SelectionGrid( selected, texts, xCount, style, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture[] images = (UnityEngine.Texture[])translator.GetObject(L, 2, typeof(UnityEngine.Texture[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.SelectionGrid( selected, images, xCount, style, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GUIContent[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int selected = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GUIContent[] contents = (UnityEngine.GUIContent[])translator.GetObject(L, 2, typeof(UnityEngine.GUIContent[]));
                    int xCount = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        int __cl_gen_ret = UnityEngine.GUILayout.SelectionGrid( selected, contents, xCount, style, options );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.SelectionGrid!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HorizontalSlider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.HorizontalSlider( value, leftValue, rightValue, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUIStyle slider = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle thumb = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.HorizontalSlider( value, leftValue, rightValue, slider, thumb, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.HorizontalSlider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VerticalSlider_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.VerticalSlider( value, leftValue, rightValue, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 2);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.GUIStyle slider = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle thumb = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.VerticalSlider( value, leftValue, rightValue, slider, thumb, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.VerticalSlider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HorizontalScrollbar_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float size = (float)LuaAPI.lua_tonumber(L, 2);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.HorizontalScrollbar( value, size, leftValue, rightValue, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float size = (float)LuaAPI.lua_tonumber(L, 2);
                    float leftValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float rightValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.HorizontalScrollbar( value, size, leftValue, rightValue, style, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.HorizontalScrollbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VerticalScrollbar_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float size = (float)LuaAPI.lua_tonumber(L, 2);
                    float topValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float bottomValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.VerticalScrollbar( value, size, topValue, bottomValue, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    float size = (float)LuaAPI.lua_tonumber(L, 2);
                    float topValue = (float)LuaAPI.lua_tonumber(L, 3);
                    float bottomValue = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        float __cl_gen_ret = UnityEngine.GUILayout.VerticalScrollbar( value, size, topValue, bottomValue, style, options );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.VerticalScrollbar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Space_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float pixels = (float)LuaAPI.lua_tonumber(L, 1);
                    
                    UnityEngine.GUILayout.Space( pixels );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FlexibleSpace_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUILayout.FlexibleSpace(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginHorizontal_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 1))) 
                {
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 1);
                    
                    UnityEngine.GUILayout.BeginHorizontal( options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIStyle>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 1, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.BeginHorizontal( style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginHorizontal( text, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginHorizontal( image, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginHorizontal( content, style, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginHorizontal!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndHorizontal_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUILayout.EndHorizontal(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginVertical_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count >= 0&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 1) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 1))) 
                {
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 1);
                    
                    UnityEngine.GUILayout.BeginVertical( options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.GUIStyle>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 1, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                    UnityEngine.GUILayout.BeginVertical( style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginVertical( text, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginVertical( image, style, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.GUIContent>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 1, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                    UnityEngine.GUILayout.BeginVertical( content, style, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginVertical!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndVertical_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUILayout.EndVertical(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginArea_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Rect>(L, 1)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    
                    UnityEngine.GUILayout.BeginArea( screenRect );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                    UnityEngine.GUILayout.BeginArea( screenRect, text );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.GUILayout.BeginArea( screenRect, image );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    
                    UnityEngine.GUILayout.BeginArea( screenRect, content );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( screenRect, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    string text = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( screenRect, text, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( screenRect, image, style );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.GUIContent>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)) 
                {
                    UnityEngine.Rect screenRect;translator.Get(L, 1, out screenRect);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 2, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    
                    UnityEngine.GUILayout.BeginArea( screenRect, content, style );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndArea_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUILayout.EndArea(  );
                    
                    
                    
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
                if(__gen_param_count >= 1&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 2))) 
                {
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 1, out scrollPosition);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 2);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUILayout.BeginScrollView( scrollPosition, options );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)) 
                {
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 1, out scrollPosition);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUILayout.BeginScrollView( scrollPosition, style );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 1, out scrollPosition);
                    bool alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 2);
                    bool alwaysShowVertical = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUILayout.BeginScrollView( scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 3))) 
                {
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 1, out scrollPosition);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 3);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUILayout.BeginScrollView( scrollPosition, style, options );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.GUIStyle>(L, 2)&& translator.Assignable<UnityEngine.GUIStyle>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 4))) 
                {
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 1, out scrollPosition);
                    UnityEngine.GUIStyle horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 2, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 3, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 4);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUILayout.BeginScrollView( scrollPosition, horizontalScrollbar, verticalScrollbar, options );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 1, out scrollPosition);
                    bool alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 2);
                    bool alwaysShowVertical = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.GUIStyle horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUILayout.BeginScrollView( scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, options );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GUIStyle>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& translator.Assignable<UnityEngine.GUIStyle>(L, 6)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 7) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 7))) 
                {
                    UnityEngine.Vector2 scrollPosition;translator.Get(L, 1, out scrollPosition);
                    bool alwaysShowHorizontal = LuaAPI.lua_toboolean(L, 2);
                    bool alwaysShowVertical = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.GUIStyle horizontalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 4, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle verticalScrollbar = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUIStyle background = (UnityEngine.GUIStyle)translator.GetObject(L, 6, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 7);
                    
                        UnityEngine.Vector2 __cl_gen_ret = UnityEngine.GUILayout.BeginScrollView( scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.BeginScrollView!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndScrollView_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.GUILayout.EndScrollView(  );
                    
                    
                    
                    return 0;
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
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string text = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayout.Window( id, screenRect, func, text, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayout.Window( id, screenRect, func, image, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 5))) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 5);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayout.Window( id, screenRect, func, content, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    string text = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayout.Window( id, screenRect, func, text, style, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.Texture image = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayout.Window( id, screenRect, func, image, style, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Rect>(L, 2)&& translator.Assignable<UnityEngine.GUI.WindowFunction>(L, 3)&& translator.Assignable<UnityEngine.GUIContent>(L, 4)&& translator.Assignable<UnityEngine.GUIStyle>(L, 5)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 6) || translator.Assignable<UnityEngine.GUILayoutOption>(L, 6))) 
                {
                    int id = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Rect screenRect;translator.Get(L, 2, out screenRect);
                    UnityEngine.GUI.WindowFunction func = translator.GetDelegate<UnityEngine.GUI.WindowFunction>(L, 3);
                    UnityEngine.GUIContent content = (UnityEngine.GUIContent)translator.GetObject(L, 4, typeof(UnityEngine.GUIContent));
                    UnityEngine.GUIStyle style = (UnityEngine.GUIStyle)translator.GetObject(L, 5, typeof(UnityEngine.GUIStyle));
                    UnityEngine.GUILayoutOption[] options = translator.GetParams<UnityEngine.GUILayoutOption>(L, 6);
                    
                        UnityEngine.Rect __cl_gen_ret = UnityEngine.GUILayout.Window( id, screenRect, func, content, style, options );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GUILayout.Window!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Width_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float width = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.Width( width );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MinWidth_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float minWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.MinWidth( minWidth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MaxWidth_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float maxWidth = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.MaxWidth( maxWidth );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Height_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float height = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.Height( height );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MinHeight_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float minHeight = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.MinHeight( minHeight );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MaxHeight_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float maxHeight = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.MaxHeight( maxHeight );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExpandWidth_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    bool expand = LuaAPI.lua_toboolean(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.ExpandWidth( expand );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExpandHeight_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    bool expand = LuaAPI.lua_toboolean(L, 1);
                    
                        UnityEngine.GUILayoutOption __cl_gen_ret = UnityEngine.GUILayout.ExpandHeight( expand );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
