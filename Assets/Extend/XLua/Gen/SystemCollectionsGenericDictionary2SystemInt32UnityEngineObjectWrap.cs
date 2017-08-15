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
    public class SystemCollectionsGenericDictionary_2_SystemInt32UnityEngineObject_Wrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>), L, translator, 0, 9, 4, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsKey", _m_ContainsKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsValue", _m_ContainsValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObjectData", _m_GetObjectData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDeserialization", _m_OnDeserialization);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetValue", _m_TryGetValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Comparer", _g_get_Comparer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Keys", _g_get_Keys);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Values", _g_get_Values);
            
			
			Utils.EndObjectRegister(typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>), L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>));
			
			
			Utils.EndClassRegister(typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_ret = new System.Collections.Generic.Dictionary<int, UnityEngine.Object>();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEqualityComparer<int>>(L, 2))
				{
					System.Collections.Generic.IEqualityComparer<int> comparer = (System.Collections.Generic.IEqualityComparer<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEqualityComparer<int>));
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_ret = new System.Collections.Generic.Dictionary<int, UnityEngine.Object>(comparer);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IDictionary<int, UnityEngine.Object>>(L, 2))
				{
					System.Collections.Generic.IDictionary<int, UnityEngine.Object> dictionary = (System.Collections.Generic.IDictionary<int, UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IDictionary<int, UnityEngine.Object>));
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_ret = new System.Collections.Generic.Dictionary<int, UnityEngine.Object>(dictionary);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int capacity = LuaAPI.xlua_tointeger(L, 2);
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_ret = new System.Collections.Generic.Dictionary<int, UnityEngine.Object>(capacity);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IDictionary<int, UnityEngine.Object>>(L, 2) && translator.Assignable<System.Collections.Generic.IEqualityComparer<int>>(L, 3))
				{
					System.Collections.Generic.IDictionary<int, UnityEngine.Object> dictionary = (System.Collections.Generic.IDictionary<int, UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IDictionary<int, UnityEngine.Object>));
					System.Collections.Generic.IEqualityComparer<int> comparer = (System.Collections.Generic.IEqualityComparer<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEqualityComparer<int>));
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_ret = new System.Collections.Generic.Dictionary<int, UnityEngine.Object>(dictionary, comparer);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<System.Collections.Generic.IEqualityComparer<int>>(L, 3))
				{
					int capacity = LuaAPI.xlua_tointeger(L, 2);
					System.Collections.Generic.IEqualityComparer<int> comparer = (System.Collections.Generic.IEqualityComparer<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEqualityComparer<int>));
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_ret = new System.Collections.Generic.Dictionary<int, UnityEngine.Object>(capacity, comparer);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.Dictionary<int, UnityEngine.Object> constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				
				if (translator.Assignable<System.Collections.Generic.Dictionary<int, UnityEngine.Object>>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					translator.Push(L, __cl_gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<System.Collections.Generic.Dictionary<int, UnityEngine.Object>>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<UnityEngine.Object>(L, 3))
				{
					
					System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
					int key = LuaAPI.xlua_tointeger(L, 2);
					__cl_gen_to_be_invoked[key] = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int key = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Object value = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    __cl_gen_to_be_invoked.Add( key, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsKey(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int key = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ContainsKey( key );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsValue(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Object value = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ContainsValue( value );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectData(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Runtime.Serialization.SerializationInfo info = (System.Runtime.Serialization.SerializationInfo)translator.GetObject(L, 2, typeof(System.Runtime.Serialization.SerializationInfo));
                    System.Runtime.Serialization.StreamingContext context;translator.Get(L, 3, out context);
                    
                    __cl_gen_to_be_invoked.GetObjectData( info, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDeserialization(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    object sender = translator.GetObject(L, 2, typeof(object));
                    
                    __cl_gen_to_be_invoked.OnDeserialization( sender );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int key = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Remove( key );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetValue(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int key = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Object value;
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.TryGetValue( key, out value );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    translator.Push(L, value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        System.Collections.Generic.Dictionary<int, UnityEngine.Object>.Enumerator __cl_gen_ret = __cl_gen_to_be_invoked.GetEnumerator(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Count);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Comparer(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.Comparer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keys(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.Keys);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Values(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                System.Collections.Generic.Dictionary<int, UnityEngine.Object> __cl_gen_to_be_invoked = (System.Collections.Generic.Dictionary<int, UnityEngine.Object>)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.Values);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
