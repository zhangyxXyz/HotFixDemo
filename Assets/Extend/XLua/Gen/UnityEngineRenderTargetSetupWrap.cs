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
    public class UnityEngineRenderTargetSetupWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.RenderTargetSetup), L, translator, 0, 0, 9, 9);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "color", _g_get_color);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mipLevel", _g_get_mipLevel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cubemapFace", _g_get_cubemapFace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthSlice", _g_get_depthSlice);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorLoad", _g_get_colorLoad);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorStore", _g_get_colorStore);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthLoad", _g_get_depthLoad);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthStore", _g_get_depthStore);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "color", _s_set_color);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depth", _s_set_depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mipLevel", _s_set_mipLevel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cubemapFace", _s_set_cubemapFace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthSlice", _s_set_depthSlice);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colorLoad", _s_set_colorLoad);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colorStore", _s_set_colorStore);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthLoad", _s_set_depthLoad);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthStore", _s_set_depthStore);
            
			Utils.EndObjectRegister(typeof(UnityEngine.RenderTargetSetup), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.RenderTargetSetup), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.RenderTargetSetup));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.RenderTargetSetup), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 9 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5) && translator.Assignable<UnityEngine.Rendering.RenderBufferLoadAction[]>(L, 6) && translator.Assignable<UnityEngine.Rendering.RenderBufferStoreAction[]>(L, 7) && translator.Assignable<UnityEngine.Rendering.RenderBufferLoadAction>(L, 8) && translator.Assignable<UnityEngine.Rendering.RenderBufferStoreAction>(L, 9))
				{
					UnityEngine.RenderBuffer[] color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					int mip = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace face;translator.Get(L, 5, out face);
					UnityEngine.Rendering.RenderBufferLoadAction[] colorLoad = (UnityEngine.Rendering.RenderBufferLoadAction[])translator.GetObject(L, 6, typeof(UnityEngine.Rendering.RenderBufferLoadAction[]));
					UnityEngine.Rendering.RenderBufferStoreAction[] colorStore = (UnityEngine.Rendering.RenderBufferStoreAction[])translator.GetObject(L, 7, typeof(UnityEngine.Rendering.RenderBufferStoreAction[]));
					UnityEngine.Rendering.RenderBufferLoadAction depthLoad;translator.Get(L, 8, out depthLoad);
					UnityEngine.Rendering.RenderBufferStoreAction depthStore;translator.Get(L, 9, out depthStore);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth, mip, face, colorLoad, colorStore, depthLoad, depthStore);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3))
				{
					UnityEngine.RenderBuffer color;translator.Get(L, 2, out color);
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					UnityEngine.RenderBuffer color;translator.Get(L, 2, out color);
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					int mipLevel = LuaAPI.xlua_tointeger(L, 4);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth, mipLevel);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5))
				{
					UnityEngine.RenderBuffer color;translator.Get(L, 2, out color);
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					int mipLevel = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace face;translator.Get(L, 5, out face);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth, mipLevel, face);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6))
				{
					UnityEngine.RenderBuffer color;translator.Get(L, 2, out color);
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					int mipLevel = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace face;translator.Get(L, 5, out face);
					int depthSlice = LuaAPI.xlua_tointeger(L, 6);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth, mipLevel, face, depthSlice);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3))
				{
					UnityEngine.RenderBuffer[] color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					UnityEngine.RenderBuffer[] color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					int mipLevel = LuaAPI.xlua_tointeger(L, 4);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth, mipLevel);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5))
				{
					UnityEngine.RenderBuffer[] color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer depth;translator.Get(L, 3, out depth);
					int mip = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace face;translator.Get(L, 5, out face);
					
					UnityEngine.RenderTargetSetup __cl_gen_ret = new UnityEngine.RenderTargetSetup(color, depth, mip, face);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(UnityEngine.RenderTargetSetup));
			        return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RenderTargetSetup constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.Push(L, __cl_gen_to_be_invoked.color);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.Push(L, __cl_gen_to_be_invoked.depth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mipLevel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.mipLevel);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cubemapFace(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.Push(L, __cl_gen_to_be_invoked.cubemapFace);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthSlice(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.depthSlice);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorLoad(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.Push(L, __cl_gen_to_be_invoked.colorLoad);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorStore(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.Push(L, __cl_gen_to_be_invoked.colorStore);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthLoad(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.Push(L, __cl_gen_to_be_invoked.depthLoad);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthStore(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.Push(L, __cl_gen_to_be_invoked.depthStore);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_color(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                UnityEngine.RenderBuffer __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.depth = __cl_gen_value;
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mipLevel(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.mipLevel = LuaAPI.xlua_tointeger(L, 2);
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cubemapFace(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                UnityEngine.CubemapFace __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.cubemapFace = __cl_gen_value;
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthSlice(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.depthSlice = LuaAPI.xlua_tointeger(L, 2);
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colorLoad(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.colorLoad = (UnityEngine.Rendering.RenderBufferLoadAction[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.RenderBufferLoadAction[]));
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colorStore(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.colorStore = (UnityEngine.Rendering.RenderBufferStoreAction[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.RenderBufferStoreAction[]));
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthLoad(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                UnityEngine.Rendering.RenderBufferLoadAction __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.depthLoad = __cl_gen_value;
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthStore(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.RenderTargetSetup __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                UnityEngine.Rendering.RenderBufferStoreAction __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.depthStore = __cl_gen_value;
            
                translator.Update(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
