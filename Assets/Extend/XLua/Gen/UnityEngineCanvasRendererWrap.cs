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
    public class UnityEngineCanvasRendererWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.CanvasRenderer), L, translator, 0, 14, 8, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetColor", _m_SetColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetColor", _m_GetColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAlpha", _m_GetAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAlpha", _m_SetAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnableRectClipping", _m_EnableRectClipping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableRectClipping", _m_DisableRectClipping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMaterial", _m_SetMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMaterial", _m_GetMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPopMaterial", _m_SetPopMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPopMaterial", _m_GetPopMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTexture", _m_SetTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAlphaTexture", _m_SetAlphaTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMesh", _m_SetMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasRectClipping", _g_get_hasRectClipping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasPopInstruction", _g_get_hasPopInstruction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materialCount", _g_get_materialCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "popMaterialCount", _g_get_popMaterialCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "relativeDepth", _g_get_relativeDepth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cull", _g_get_cull);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "absoluteDepth", _g_get_absoluteDepth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasMoved", _g_get_hasMoved);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "hasPopInstruction", _s_set_hasPopInstruction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materialCount", _s_set_materialCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "popMaterialCount", _s_set_popMaterialCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cull", _s_set_cull);
            
			Utils.EndObjectRegister(typeof(UnityEngine.CanvasRenderer), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.CanvasRenderer), L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SplitUIVertexStreams", _m_SplitUIVertexStreams_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateUIVertexStream", _m_CreateUIVertexStream_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddUIVertexStream", _m_AddUIVertexStream_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.CanvasRenderer));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.CanvasRenderer), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.CanvasRenderer __cl_gen_ret = new UnityEngine.CanvasRenderer();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetColor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Color color;translator.Get(L, 2, out color);
                    
                    __cl_gen_to_be_invoked.SetColor( color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetColor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        UnityEngine.Color __cl_gen_ret = __cl_gen_to_be_invoked.GetColor(  );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAlpha(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetAlpha(  );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAlpha(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float alpha = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    __cl_gen_to_be_invoked.SetAlpha( alpha );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableRectClipping(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect rect;translator.Get(L, 2, out rect);
                    
                    __cl_gen_to_be_invoked.EnableRectClipping( rect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableRectClipping(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.DisableRectClipping(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMaterial(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Material>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetMaterial( material, index );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Material>(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)) 
                {
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    
                    __cl_gen_to_be_invoked.SetMaterial( material, texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer.SetMaterial!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMaterial(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        UnityEngine.Material __cl_gen_ret = __cl_gen_to_be_invoked.GetMaterial(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Material __cl_gen_ret = __cl_gen_to_be_invoked.GetMaterial( index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer.GetMaterial!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPopMaterial(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetPopMaterial( material, index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPopMaterial(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Material __cl_gen_ret = __cl_gen_to_be_invoked.GetPopMaterial( index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTexture(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    __cl_gen_to_be_invoked.SetTexture( texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAlphaTexture(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Texture texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    __cl_gen_to_be_invoked.SetAlphaTexture( texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMesh(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    
                    __cl_gen_to_be_invoked.SetMesh( mesh );
                    
                    
                    
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
            
            
            UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_SplitUIVertexStreams_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Vector3> normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<int> indicies = (System.Collections.Generic.List<int>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.CanvasRenderer.SplitUIVertexStreams( verts, positions, colors, uv0S, uv1S, normals, tangents, indicies );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateUIVertexStream_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Vector3> normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<int> indicies = (System.Collections.Generic.List<int>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.CanvasRenderer.CreateUIVertexStream( verts, positions, colors, uv0S, uv1S, normals, tangents, indicies );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexStream_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uv0S = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Vector2> uv1S = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    System.Collections.Generic.List<UnityEngine.Vector3> normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.CanvasRenderer.AddUIVertexStream( verts, positions, colors, uv0S, uv1S, normals, tangents );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasRectClipping(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasRectClipping);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasPopInstruction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasPopInstruction);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_materialCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.materialCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_popMaterialCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.popMaterialCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_relativeDepth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.relativeDepth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cull(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.cull);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_absoluteDepth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.absoluteDepth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasMoved(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasMoved);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hasPopInstruction(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hasPopInstruction = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_materialCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.materialCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_popMaterialCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.popMaterialCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cull(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.CanvasRenderer __cl_gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.cull = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
