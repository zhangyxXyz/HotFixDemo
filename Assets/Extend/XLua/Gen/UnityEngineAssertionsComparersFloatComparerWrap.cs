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
    public class UnityEngineAssertionsComparersFloatComparerWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Assertions.Comparers.FloatComparer), L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Assertions.Comparers.FloatComparer), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Assertions.Comparers.FloatComparer), L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AreEqual", _m_AreEqual_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AreEqualRelative", _m_AreEqualRelative_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "s_ComparerWithDefaultTolerance", UnityEngine.Assertions.Comparers.FloatComparer.s_ComparerWithDefaultTolerance);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "kEpsilon", UnityEngine.Assertions.Comparers.FloatComparer.kEpsilon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Assertions.Comparers.FloatComparer));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Assertions.Comparers.FloatComparer), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Assertions.Comparers.FloatComparer __cl_gen_ret = new UnityEngine.Assertions.Comparers.FloatComparer();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2))
				{
					bool relative = LuaAPI.lua_toboolean(L, 2);
					
					UnityEngine.Assertions.Comparers.FloatComparer __cl_gen_ret = new UnityEngine.Assertions.Comparers.FloatComparer(relative);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					float error = (float)LuaAPI.lua_tonumber(L, 2);
					
					UnityEngine.Assertions.Comparers.FloatComparer __cl_gen_ret = new UnityEngine.Assertions.Comparers.FloatComparer(error);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					float error = (float)LuaAPI.lua_tonumber(L, 2);
					bool relative = LuaAPI.lua_toboolean(L, 3);
					
					UnityEngine.Assertions.Comparers.FloatComparer __cl_gen_ret = new UnityEngine.Assertions.Comparers.FloatComparer(error, relative);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Assertions.Comparers.FloatComparer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Assertions.Comparers.FloatComparer __cl_gen_to_be_invoked = (UnityEngine.Assertions.Comparers.FloatComparer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float a = (float)LuaAPI.lua_tonumber(L, 2);
                    float b = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Equals( a, b );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Assertions.Comparers.FloatComparer __cl_gen_to_be_invoked = (UnityEngine.Assertions.Comparers.FloatComparer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float obj = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetHashCode( obj );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AreEqual_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    float error = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Assertions.Comparers.FloatComparer.AreEqual( expected, actual, error );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AreEqualRelative_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    float expected = (float)LuaAPI.lua_tonumber(L, 1);
                    float actual = (float)LuaAPI.lua_tonumber(L, 2);
                    float error = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool __cl_gen_ret = UnityEngine.Assertions.Comparers.FloatComparer.AreEqualRelative( expected, actual, error );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
