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
    public class UnityEngineSparseTextureWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.SparseTexture), L, translator, 0, 3, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateTile", _m_UpdateTile);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateTileRaw", _m_UpdateTileRaw);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadTile", _m_UnloadTile);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "tileWidth", _g_get_tileWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tileHeight", _g_get_tileHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isCreated", _g_get_isCreated);
            
			
			Utils.EndObjectRegister(typeof(UnityEngine.SparseTexture), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.SparseTexture), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.SparseTexture));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.SparseTexture), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat format;translator.Get(L, 4, out format);
					int mipCount = LuaAPI.xlua_tointeger(L, 5);
					
					UnityEngine.SparseTexture __cl_gen_ret = new UnityEngine.SparseTexture(width, height, format, mipCount);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					int width = LuaAPI.xlua_tointeger(L, 2);
					int height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat format;translator.Get(L, 4, out format);
					int mipCount = LuaAPI.xlua_tointeger(L, 5);
					bool linear = LuaAPI.lua_toboolean(L, 6);
					
					UnityEngine.SparseTexture __cl_gen_ret = new UnityEngine.SparseTexture(width, height, format, mipCount, linear);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SparseTexture constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateTile(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.SparseTexture __cl_gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int tileX = LuaAPI.xlua_tointeger(L, 2);
                    int tileY = LuaAPI.xlua_tointeger(L, 3);
                    int miplevel = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Color32[] data = (UnityEngine.Color32[])translator.GetObject(L, 5, typeof(UnityEngine.Color32[]));
                    
                    __cl_gen_to_be_invoked.UpdateTile( tileX, tileY, miplevel, data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateTileRaw(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.SparseTexture __cl_gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int tileX = LuaAPI.xlua_tointeger(L, 2);
                    int tileY = LuaAPI.xlua_tointeger(L, 3);
                    int miplevel = LuaAPI.xlua_tointeger(L, 4);
                    byte[] data = LuaAPI.lua_tobytes(L, 5);
                    
                    __cl_gen_to_be_invoked.UpdateTileRaw( tileX, tileY, miplevel, data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadTile(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.SparseTexture __cl_gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int tileX = LuaAPI.xlua_tointeger(L, 2);
                    int tileY = LuaAPI.xlua_tointeger(L, 3);
                    int miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.UnloadTile( tileX, tileY, miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tileWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SparseTexture __cl_gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.tileWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tileHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SparseTexture __cl_gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.tileHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isCreated(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SparseTexture __cl_gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isCreated);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
