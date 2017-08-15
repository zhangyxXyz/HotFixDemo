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
    public class UnityEngineUIVertexHelperWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.VertexHelper), L, translator, 0, 11, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PopulateUIVertex", _m_PopulateUIVertex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetUIVertex", _m_SetUIVertex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FillMesh", _m_FillMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddVert", _m_AddVert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTriangle", _m_AddTriangle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUIVertexQuad", _m_AddUIVertexQuad);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUIVertexStream", _m_AddUIVertexStream);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUIVertexTriangleStream", _m_AddUIVertexTriangleStream);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUIVertexStream", _m_GetUIVertexStream);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentVertCount", _g_get_currentVertCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentIndexCount", _g_get_currentIndexCount);
            
			
			Utils.EndObjectRegister(typeof(UnityEngine.UI.VertexHelper), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.VertexHelper), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.VertexHelper));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.VertexHelper), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.UI.VertexHelper __cl_gen_ret = new UnityEngine.UI.VertexHelper();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Mesh>(L, 2))
				{
					UnityEngine.Mesh m = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
					
					UnityEngine.UI.VertexHelper __cl_gen_ret = new UnityEngine.UI.VertexHelper(m);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.VertexHelper constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_PopulateUIVertex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.UIVertex vertex;translator.Get(L, 2, out vertex);
                    int i = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.PopulateUIVertex( ref vertex, i );
                    translator.Push(L, vertex);
                        translator.Update(L, 2, vertex);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUIVertex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.UIVertex vertex;translator.Get(L, 2, out vertex);
                    int i = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetUIVertex( vertex, i );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillMesh(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    
                    __cl_gen_to_be_invoked.FillMesh( mesh );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddVert(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.UIVertex>(L, 2)) 
                {
                    UnityEngine.UIVertex v;translator.Get(L, 2, out v);
                    
                    __cl_gen_to_be_invoked.AddVert( v );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color32>(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Color32 color;translator.Get(L, 3, out color);
                    UnityEngine.Vector2 uv0;translator.Get(L, 4, out uv0);
                    
                    __cl_gen_to_be_invoked.AddVert( position, color, uv0 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color32>(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.Vector3>(L, 6)&& translator.Assignable<UnityEngine.Vector4>(L, 7)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Color32 color;translator.Get(L, 3, out color);
                    UnityEngine.Vector2 uv0;translator.Get(L, 4, out uv0);
                    UnityEngine.Vector2 uv1;translator.Get(L, 5, out uv1);
                    UnityEngine.Vector3 normal;translator.Get(L, 6, out normal);
                    UnityEngine.Vector4 tangent;translator.Get(L, 7, out tangent);
                    
                    __cl_gen_to_be_invoked.AddVert( position, color, uv0, uv1, normal, tangent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.VertexHelper.AddVert!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTriangle(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int idx0 = LuaAPI.xlua_tointeger(L, 2);
                    int idx1 = LuaAPI.xlua_tointeger(L, 3);
                    int idx2 = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.AddTriangle( idx0, idx1, idx2 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexQuad(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.UIVertex[] verts = (UnityEngine.UIVertex[])translator.GetObject(L, 2, typeof(UnityEngine.UIVertex[]));
                    
                    __cl_gen_to_be_invoked.AddUIVertexQuad( verts );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexStream(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<int> indices = (System.Collections.Generic.List<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<int>));
                    
                    __cl_gen_to_be_invoked.AddUIVertexStream( verts, indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexTriangleStream(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    
                    __cl_gen_to_be_invoked.AddUIVertexTriangleStream( verts );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUIVertexStream(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> stream = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    
                    __cl_gen_to_be_invoked.GetUIVertexStream( stream );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentVertCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.currentVertCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentIndexCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.VertexHelper __cl_gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.currentIndexCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
