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
    public class UnityEngineCubemapArrayWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.CubemapArray), L, translator, 0, 5, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels", _m_SetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels32", _m_SetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels", _m_GetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels32", _m_GetPixels32);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cubemapCount", _g_get_cubemapCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "format", _g_get_format);
            
			
			Utils.EndObjectRegister(typeof(UnityEngine.CubemapArray), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.CubemapArray), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.CubemapArray));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.CubemapArray), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5))
				{
					int faceSize = LuaAPI.xlua_tointeger(L, 2);
					int cubemapCount = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat format;translator.Get(L, 4, out format);
					bool mipmap = LuaAPI.lua_toboolean(L, 5);
					
					UnityEngine.CubemapArray __cl_gen_ret = new UnityEngine.CubemapArray(faceSize, cubemapCount, format, mipmap);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					int faceSize = LuaAPI.xlua_tointeger(L, 2);
					int cubemapCount = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat format;translator.Get(L, 4, out format);
					bool mipmap = LuaAPI.lua_toboolean(L, 5);
					bool linear = LuaAPI.lua_toboolean(L, 6);
					
					UnityEngine.CubemapArray __cl_gen_ret = new UnityEngine.CubemapArray(faceSize, cubemapCount, format, mipmap, linear);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CubemapArray constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CubemapArray __cl_gen_to_be_invoked = (UnityEngine.CubemapArray)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Apply(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Apply( updateMipmaps );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    bool makeNoLongerReadable = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Apply( updateMipmaps, makeNoLongerReadable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CubemapArray.Apply!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CubemapArray __cl_gen_to_be_invoked = (UnityEngine.CubemapArray)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Color[] colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    UnityEngine.CubemapFace face;translator.Get(L, 3, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.SetPixels( colors, face, arrayElement );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Color[] colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    UnityEngine.CubemapFace face;translator.Get(L, 3, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 4);
                    int miplevel = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.SetPixels( colors, face, arrayElement, miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CubemapArray.SetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels32(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CubemapArray __cl_gen_to_be_invoked = (UnityEngine.CubemapArray)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Color32[] colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    UnityEngine.CubemapFace face;translator.Get(L, 3, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.SetPixels32( colors, face, arrayElement );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Color32[] colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    UnityEngine.CubemapFace face;translator.Get(L, 3, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 4);
                    int miplevel = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.SetPixels32( colors, face, arrayElement, miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CubemapArray.SetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CubemapArray __cl_gen_to_be_invoked = (UnityEngine.CubemapArray)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.CubemapFace>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.CubemapFace face;translator.Get(L, 2, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Color[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels( face, arrayElement );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.CubemapFace>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.CubemapFace face;translator.Get(L, 2, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    int miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Color[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels( face, arrayElement, miplevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CubemapArray.GetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels32(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CubemapArray __cl_gen_to_be_invoked = (UnityEngine.CubemapArray)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.CubemapFace>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.CubemapFace face;translator.Get(L, 2, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.Color32[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels32( face, arrayElement );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.CubemapFace>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.CubemapFace face;translator.Get(L, 2, out face);
                    int arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    int miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                        UnityEngine.Color32[] __cl_gen_ret = __cl_gen_to_be_invoked.GetPixels32( face, arrayElement, miplevel );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CubemapArray.GetPixels32!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cubemapCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CubemapArray __cl_gen_to_be_invoked = (UnityEngine.CubemapArray)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.cubemapCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_format(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CubemapArray __cl_gen_to_be_invoked = (UnityEngine.CubemapArray)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.format);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
