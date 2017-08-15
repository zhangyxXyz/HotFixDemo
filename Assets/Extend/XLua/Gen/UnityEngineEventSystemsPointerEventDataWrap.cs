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
    public class UnityEngineEventSystemsPointerEventDataWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData), L, translator, 0, 3, 21, 18);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsPointerMoving", _m_IsPointerMoving);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsScrolling", _m_IsScrolling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerEnter", _g_get_pointerEnter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastPress", _g_get_lastPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rawPointerPress", _g_get_rawPointerPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerDrag", _g_get_pointerDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerCurrentRaycast", _g_get_pointerCurrentRaycast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerPressRaycast", _g_get_pointerPressRaycast);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eligibleForClick", _g_get_eligibleForClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerId", _g_get_pointerId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", _g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "delta", _g_get_delta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressPosition", _g_get_pressPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clickTime", _g_get_clickTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clickCount", _g_get_clickCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scrollDelta", _g_get_scrollDelta);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useDragThreshold", _g_get_useDragThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dragging", _g_get_dragging);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "button", _g_get_button);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enterEventCamera", _g_get_enterEventCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pressEventCamera", _g_get_pressEventCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointerPress", _g_get_pointerPress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hovered", _g_get_hovered);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerEnter", _s_set_pointerEnter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rawPointerPress", _s_set_rawPointerPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerDrag", _s_set_pointerDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerCurrentRaycast", _s_set_pointerCurrentRaycast);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerPressRaycast", _s_set_pointerPressRaycast);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eligibleForClick", _s_set_eligibleForClick);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerId", _s_set_pointerId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", _s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "delta", _s_set_delta);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pressPosition", _s_set_pressPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clickTime", _s_set_clickTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clickCount", _s_set_clickCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scrollDelta", _s_set_scrollDelta);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useDragThreshold", _s_set_useDragThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dragging", _s_set_dragging);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "button", _s_set_button);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pointerPress", _s_set_pointerPress);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hovered", _s_set_hovered);
            
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.PointerEventData), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.EventSystems.PointerEventData));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.EventSystems.PointerEventData), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.EventSystems.EventSystem>(L, 2))
				{
					UnityEngine.EventSystems.EventSystem eventSystem = (UnityEngine.EventSystems.EventSystem)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.EventSystem));
					
					UnityEngine.EventSystems.PointerEventData __cl_gen_ret = new UnityEngine.EventSystems.PointerEventData(eventSystem);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.EventSystems.PointerEventData constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsPointerMoving(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsPointerMoving(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsScrolling(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsScrolling(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
            
            
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
        static int _g_get_pointerEnter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pointerEnter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.lastPress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rawPointerPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rawPointerPress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerDrag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pointerDrag);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerCurrentRaycast(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pointerCurrentRaycast);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerPressRaycast(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pointerPressRaycast);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eligibleForClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.eligibleForClick);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerId(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.pointerId);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_position(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.position);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_delta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.delta);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pressPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.pressPosition);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clickTime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.clickTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clickCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.clickCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scrollDelta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.scrollDelta);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useDragThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.useDragThreshold);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dragging(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.dragging);
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
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.button);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enterEventCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.enterEventCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pressEventCamera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pressEventCamera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointerPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.pointerPress);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hovered(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hovered);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerEnter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.pointerEnter = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rawPointerPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.rawPointerPress = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerDrag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.pointerDrag = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerCurrentRaycast(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.EventSystems.RaycastResult __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pointerCurrentRaycast = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerPressRaycast(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.EventSystems.RaycastResult __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pointerPressRaycast = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_eligibleForClick(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.eligibleForClick = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerId(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.pointerId = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_position(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.position = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_delta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.delta = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pressPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.pressPosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clickTime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.clickTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clickCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.clickCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scrollDelta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.scrollDelta = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useDragThreshold(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.useDragThreshold = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dragging(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.dragging = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                UnityEngine.EventSystems.PointerEventData.InputButton __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.button = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pointerPress(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.pointerPress = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hovered(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.EventSystems.PointerEventData __cl_gen_to_be_invoked = (UnityEngine.EventSystems.PointerEventData)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hovered = (System.Collections.Generic.List<UnityEngine.GameObject>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
