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
    public class UnityEngineRenderingCommandBufferWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Rendering.CommandBuffer), L, translator, 0, 44, 2, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Release", _m_Release);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetComputeFloatParam", _m_SetComputeFloatParam);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetComputeIntParam", _m_SetComputeIntParam);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetComputeVectorParam", _m_SetComputeVectorParam);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetComputeFloatParams", _m_SetComputeFloatParams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetComputeIntParams", _m_SetComputeIntParams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetComputeTextureParam", _m_SetComputeTextureParam);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetComputeBufferParam", _m_SetComputeBufferParam);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DispatchCompute", _m_DispatchCompute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyCounterValue", _m_CopyCounterValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawMesh", _m_DrawMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawRenderer", _m_DrawRenderer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawProcedural", _m_DrawProcedural);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawProceduralIndirect", _m_DrawProceduralIndirect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawMeshInstanced", _m_DrawMeshInstanced);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DrawMeshInstancedIndirect", _m_DrawMeshInstancedIndirect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRenderTarget", _m_SetRenderTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyTexture", _m_CopyTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetViewport", _m_SetViewport);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Blit", _m_Blit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTemporaryRT", _m_GetTemporaryRT);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReleaseTemporaryRT", _m_ReleaseTemporaryRT);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearRenderTarget", _m_ClearRenderTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalFloat", _m_SetGlobalFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalVector", _m_SetGlobalVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalColor", _m_SetGlobalColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalMatrix", _m_SetGlobalMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnableShaderKeyword", _m_EnableShaderKeyword);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableShaderKeyword", _m_DisableShaderKeyword);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetViewMatrix", _m_SetViewMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetProjectionMatrix", _m_SetProjectionMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetViewProjectionMatrices", _m_SetViewProjectionMatrices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalDepthBias", _m_SetGlobalDepthBias);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalFloatArray", _m_SetGlobalFloatArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalVectorArray", _m_SetGlobalVectorArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalMatrixArray", _m_SetGlobalMatrixArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalTexture", _m_SetGlobalTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGlobalBuffer", _m_SetGlobalBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetShadowSamplingMode", _m_SetShadowSamplingMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IssuePluginEvent", _m_IssuePluginEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginSample", _m_BeginSample);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndSample", _m_EndSample);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sizeInBytes", _g_get_sizeInBytes);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Rendering.CommandBuffer), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Rendering.CommandBuffer), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Rendering.CommandBuffer));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Rendering.CommandBuffer), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Rendering.CommandBuffer __cl_gen_ret = new UnityEngine.Rendering.CommandBuffer();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_Release(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Release(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetComputeFloatParam(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float val = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.SetComputeFloatParam( computeShader, name, val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetComputeIntParam(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int val = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.SetComputeIntParam( computeShader, name, val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetComputeVectorParam(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    string name = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Vector4 val;translator.Get(L, 4, out val);
                    
                    __cl_gen_to_be_invoked.SetComputeVectorParam( computeShader, name, val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetComputeFloatParams(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float[] values = translator.GetParams<float>(L, 4);
                    
                    __cl_gen_to_be_invoked.SetComputeFloatParams( computeShader, name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetComputeIntParams(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int[] values = translator.GetParams<int>(L, 4);
                    
                    __cl_gen_to_be_invoked.SetComputeIntParams( computeShader, name, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetComputeTextureParam(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    int kernelIndex = LuaAPI.xlua_tointeger(L, 3);
                    string name = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.Rendering.RenderTargetIdentifier rt;translator.Get(L, 5, out rt);
                    
                    __cl_gen_to_be_invoked.SetComputeTextureParam( computeShader, kernelIndex, name, rt );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetComputeBufferParam(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    int kernelIndex = LuaAPI.xlua_tointeger(L, 3);
                    string name = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.ComputeBuffer buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    
                    __cl_gen_to_be_invoked.SetComputeBufferParam( computeShader, kernelIndex, name, buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DispatchCompute(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.ComputeShader>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    int kernelIndex = LuaAPI.xlua_tointeger(L, 3);
                    int threadGroupsX = LuaAPI.xlua_tointeger(L, 4);
                    int threadGroupsY = LuaAPI.xlua_tointeger(L, 5);
                    int threadGroupsZ = LuaAPI.xlua_tointeger(L, 6);
                    
                    __cl_gen_to_be_invoked.DispatchCompute( computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.ComputeShader>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.ComputeShader computeShader = (UnityEngine.ComputeShader)translator.GetObject(L, 2, typeof(UnityEngine.ComputeShader));
                    int kernelIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.ComputeBuffer indirectBuffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    uint argsOffset = LuaAPI.xlua_touint(L, 5);
                    
                    __cl_gen_to_be_invoked.DispatchCompute( computeShader, kernelIndex, indirectBuffer, argsOffset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.DispatchCompute!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyCounterValue(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ComputeBuffer src = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    UnityEngine.ComputeBuffer dst = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    uint dstOffset = LuaAPI.xlua_touint(L, 4);
                    
                    __cl_gen_to_be_invoked.CopyCounterValue( src, dst, dstOffset );
                    
                    
                    
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
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
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
        static int _m_DrawMesh(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 3, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    
                    __cl_gen_to_be_invoked.DrawMesh( mesh, matrix, material );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 3, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.DrawMesh( mesh, matrix, material, submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 3, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 5);
                    int shaderPass = LuaAPI.xlua_tointeger(L, 6);
                    
                    __cl_gen_to_be_invoked.DrawMesh( mesh, matrix, material, submeshIndex, shaderPass );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 3, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 5);
                    int shaderPass = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    __cl_gen_to_be_invoked.DrawMesh( mesh, matrix, material, submeshIndex, shaderPass, properties );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.DrawMesh!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawRenderer(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Renderer>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)) 
                {
                    UnityEngine.Renderer renderer = (UnityEngine.Renderer)translator.GetObject(L, 2, typeof(UnityEngine.Renderer));
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    
                    __cl_gen_to_be_invoked.DrawRenderer( renderer, material );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Renderer>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Renderer renderer = (UnityEngine.Renderer)translator.GetObject(L, 2, typeof(UnityEngine.Renderer));
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.DrawRenderer( renderer, material, submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Renderer>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Renderer renderer = (UnityEngine.Renderer)translator.GetObject(L, 2, typeof(UnityEngine.Renderer));
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 4);
                    int shaderPass = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.DrawRenderer( renderer, material, submeshIndex, shaderPass );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.DrawRenderer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProcedural(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.MeshTopology>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.MeshTopology topology;translator.Get(L, 5, out topology);
                    int vertexCount = LuaAPI.xlua_tointeger(L, 6);
                    
                    __cl_gen_to_be_invoked.DrawProcedural( matrix, material, shaderPass, topology, vertexCount );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.MeshTopology>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.MeshTopology topology;translator.Get(L, 5, out topology);
                    int vertexCount = LuaAPI.xlua_tointeger(L, 6);
                    int instanceCount = LuaAPI.xlua_tointeger(L, 7);
                    
                    __cl_gen_to_be_invoked.DrawProcedural( matrix, material, shaderPass, topology, vertexCount, instanceCount );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.MeshTopology>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.MeshTopology topology;translator.Get(L, 5, out topology);
                    int vertexCount = LuaAPI.xlua_tointeger(L, 6);
                    int instanceCount = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    __cl_gen_to_be_invoked.DrawProcedural( matrix, material, shaderPass, topology, vertexCount, instanceCount, properties );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.DrawProcedural!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProceduralIndirect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.MeshTopology>(L, 5)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 6)) 
                {
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.MeshTopology topology;translator.Get(L, 5, out topology);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 6, typeof(UnityEngine.ComputeBuffer));
                    
                    __cl_gen_to_be_invoked.DrawProceduralIndirect( matrix, material, shaderPass, topology, bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.MeshTopology>(L, 5)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.MeshTopology topology;translator.Get(L, 5, out topology);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 6, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 7);
                    
                    __cl_gen_to_be_invoked.DrawProceduralIndirect( matrix, material, shaderPass, topology, bufferWithArgs, argsOffset );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.MeshTopology>(L, 5)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Matrix4x4 matrix;translator.Get(L, 2, out matrix);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.MeshTopology topology;translator.Get(L, 5, out topology);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 6, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    __cl_gen_to_be_invoked.DrawProceduralIndirect( matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.DrawProceduralIndirect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshInstanced(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 6, typeof(UnityEngine.Matrix4x4[]));
                    
                    __cl_gen_to_be_invoked.DrawMeshInstanced( mesh, submeshIndex, material, shaderPass, matrices );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 6, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 7);
                    
                    __cl_gen_to_be_invoked.DrawMeshInstanced( mesh, submeshIndex, material, shaderPass, matrices, count );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Matrix4x4[] matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 6, typeof(UnityEngine.Matrix4x4[]));
                    int count = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    __cl_gen_to_be_invoked.DrawMeshInstanced( mesh, submeshIndex, material, shaderPass, matrices, count, properties );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.DrawMeshInstanced!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshInstancedIndirect(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 6)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 6, typeof(UnityEngine.ComputeBuffer));
                    
                    __cl_gen_to_be_invoked.DrawMeshInstancedIndirect( mesh, submeshIndex, material, shaderPass, bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 6, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 7);
                    
                    __cl_gen_to_be_invoked.DrawMeshInstancedIndirect( mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    int submeshIndex = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Material material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int shaderPass = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.ComputeBuffer bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 6, typeof(UnityEngine.ComputeBuffer));
                    int argsOffset = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    __cl_gen_to_be_invoked.DrawMeshInstancedIndirect( mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.DrawMeshInstancedIndirect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRenderTarget(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier rt;translator.Get(L, 2, out rt);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( rt );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier rt;translator.Get(L, 2, out rt);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( rt, mipLevel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier color;translator.Get(L, 2, out color);
                    UnityEngine.Rendering.RenderTargetIdentifier depth;translator.Get(L, 3, out depth);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( color, depth );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier[]>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier[] colors = (UnityEngine.Rendering.RenderTargetIdentifier[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.RenderTargetIdentifier[]));
                    UnityEngine.Rendering.RenderTargetIdentifier depth;translator.Get(L, 3, out depth);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( colors, depth );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.CubemapFace>(L, 4)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier rt;translator.Get(L, 2, out rt);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.CubemapFace cubemapFace;translator.Get(L, 4, out cubemapFace);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( rt, mipLevel, cubemapFace );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier color;translator.Get(L, 2, out color);
                    UnityEngine.Rendering.RenderTargetIdentifier depth;translator.Get(L, 3, out depth);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( color, depth, mipLevel );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.CubemapFace>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier rt;translator.Get(L, 2, out rt);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.CubemapFace cubemapFace;translator.Get(L, 4, out cubemapFace);
                    int depthSlice = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( rt, mipLevel, cubemapFace, depthSlice );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.CubemapFace>(L, 5)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier color;translator.Get(L, 2, out color);
                    UnityEngine.Rendering.RenderTargetIdentifier depth;translator.Get(L, 3, out depth);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.CubemapFace cubemapFace;translator.Get(L, 5, out cubemapFace);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( color, depth, mipLevel, cubemapFace );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.CubemapFace>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier color;translator.Get(L, 2, out color);
                    UnityEngine.Rendering.RenderTargetIdentifier depth;translator.Get(L, 3, out depth);
                    int mipLevel = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.CubemapFace cubemapFace;translator.Get(L, 5, out cubemapFace);
                    int depthSlice = LuaAPI.xlua_tointeger(L, 6);
                    
                    __cl_gen_to_be_invoked.SetRenderTarget( color, depth, mipLevel, cubemapFace, depthSlice );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetRenderTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyTexture(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier src;translator.Get(L, 2, out src);
                    UnityEngine.Rendering.RenderTargetIdentifier dst;translator.Get(L, 3, out dst);
                    
                    __cl_gen_to_be_invoked.CopyTexture( src, dst );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier src;translator.Get(L, 2, out src);
                    int srcElement = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Rendering.RenderTargetIdentifier dst;translator.Get(L, 4, out dst);
                    int dstElement = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.CopyTexture( src, srcElement, dst, dstElement );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier src;translator.Get(L, 2, out src);
                    int srcElement = LuaAPI.xlua_tointeger(L, 3);
                    int srcMip = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Rendering.RenderTargetIdentifier dst;translator.Get(L, 5, out dst);
                    int dstElement = LuaAPI.xlua_tointeger(L, 6);
                    int dstMip = LuaAPI.xlua_tointeger(L, 7);
                    
                    __cl_gen_to_be_invoked.CopyTexture( src, srcElement, srcMip, dst, dstElement, dstMip );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 13&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 13)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier src;translator.Get(L, 2, out src);
                    int srcElement = LuaAPI.xlua_tointeger(L, 3);
                    int srcMip = LuaAPI.xlua_tointeger(L, 4);
                    int srcX = LuaAPI.xlua_tointeger(L, 5);
                    int srcY = LuaAPI.xlua_tointeger(L, 6);
                    int srcWidth = LuaAPI.xlua_tointeger(L, 7);
                    int srcHeight = LuaAPI.xlua_tointeger(L, 8);
                    UnityEngine.Rendering.RenderTargetIdentifier dst;translator.Get(L, 9, out dst);
                    int dstElement = LuaAPI.xlua_tointeger(L, 10);
                    int dstMip = LuaAPI.xlua_tointeger(L, 11);
                    int dstX = LuaAPI.xlua_tointeger(L, 12);
                    int dstY = LuaAPI.xlua_tointeger(L, 13);
                    
                    __cl_gen_to_be_invoked.CopyTexture( src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.CopyTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetViewport(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rect pixelRect;translator.Get(L, 2, out pixelRect);
                    
                    __cl_gen_to_be_invoked.SetViewport( pixelRect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Blit(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rendering.RenderTargetIdentifier dest;translator.Get(L, 3, out dest);
                    
                    __cl_gen_to_be_invoked.Blit( source, dest );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier source;translator.Get(L, 2, out source);
                    UnityEngine.Rendering.RenderTargetIdentifier dest;translator.Get(L, 3, out dest);
                    
                    __cl_gen_to_be_invoked.Blit( source, dest );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rendering.RenderTargetIdentifier dest;translator.Get(L, 3, out dest);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    
                    __cl_gen_to_be_invoked.Blit( source, dest, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier source;translator.Get(L, 2, out source);
                    UnityEngine.Rendering.RenderTargetIdentifier dest;translator.Get(L, 3, out dest);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    
                    __cl_gen_to_be_invoked.Blit( source, dest, mat );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Texture source = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rendering.RenderTargetIdentifier dest;translator.Get(L, 3, out dest);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.Blit( source, dest, mat, pass );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rendering.RenderTargetIdentifier source;translator.Get(L, 2, out source);
                    UnityEngine.Rendering.RenderTargetIdentifier dest;translator.Get(L, 3, out dest);
                    UnityEngine.Material mat = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int pass = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.Blit( source, dest, mat, pass );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.Blit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTemporaryRT(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    int width = LuaAPI.xlua_tointeger(L, 3);
                    int height = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.GetTemporaryRT( nameID, width, height );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    int width = LuaAPI.xlua_tointeger(L, 3);
                    int height = LuaAPI.xlua_tointeger(L, 4);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.GetTemporaryRT( nameID, width, height, depthBuffer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.FilterMode>(L, 6)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    int width = LuaAPI.xlua_tointeger(L, 3);
                    int height = LuaAPI.xlua_tointeger(L, 4);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.FilterMode filter;translator.Get(L, 6, out filter);
                    
                    __cl_gen_to_be_invoked.GetTemporaryRT( nameID, width, height, depthBuffer, filter );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 7&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.FilterMode>(L, 6)&& translator.Assignable<UnityEngine.RenderTextureFormat>(L, 7)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    int width = LuaAPI.xlua_tointeger(L, 3);
                    int height = LuaAPI.xlua_tointeger(L, 4);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.FilterMode filter;translator.Get(L, 6, out filter);
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 7, out format);
                    
                    __cl_gen_to_be_invoked.GetTemporaryRT( nameID, width, height, depthBuffer, filter, format );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 8&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.FilterMode>(L, 6)&& translator.Assignable<UnityEngine.RenderTextureFormat>(L, 7)&& translator.Assignable<UnityEngine.RenderTextureReadWrite>(L, 8)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    int width = LuaAPI.xlua_tointeger(L, 3);
                    int height = LuaAPI.xlua_tointeger(L, 4);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.FilterMode filter;translator.Get(L, 6, out filter);
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 7, out format);
                    UnityEngine.RenderTextureReadWrite readWrite;translator.Get(L, 8, out readWrite);
                    
                    __cl_gen_to_be_invoked.GetTemporaryRT( nameID, width, height, depthBuffer, filter, format, readWrite );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 9&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.FilterMode>(L, 6)&& translator.Assignable<UnityEngine.RenderTextureFormat>(L, 7)&& translator.Assignable<UnityEngine.RenderTextureReadWrite>(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    int width = LuaAPI.xlua_tointeger(L, 3);
                    int height = LuaAPI.xlua_tointeger(L, 4);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.FilterMode filter;translator.Get(L, 6, out filter);
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 7, out format);
                    UnityEngine.RenderTextureReadWrite readWrite;translator.Get(L, 8, out readWrite);
                    int antiAliasing = LuaAPI.xlua_tointeger(L, 9);
                    
                    __cl_gen_to_be_invoked.GetTemporaryRT( nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 10&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.FilterMode>(L, 6)&& translator.Assignable<UnityEngine.RenderTextureFormat>(L, 7)&& translator.Assignable<UnityEngine.RenderTextureReadWrite>(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    int width = LuaAPI.xlua_tointeger(L, 3);
                    int height = LuaAPI.xlua_tointeger(L, 4);
                    int depthBuffer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.FilterMode filter;translator.Get(L, 6, out filter);
                    UnityEngine.RenderTextureFormat format;translator.Get(L, 7, out format);
                    UnityEngine.RenderTextureReadWrite readWrite;translator.Get(L, 8, out readWrite);
                    int antiAliasing = LuaAPI.xlua_tointeger(L, 9);
                    bool enableRandomWrite = LuaAPI.lua_toboolean(L, 10);
                    
                    __cl_gen_to_be_invoked.GetTemporaryRT( nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.GetTemporaryRT!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseTemporaryRT(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.ReleaseTemporaryRT( nameID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearRenderTarget(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Color>(L, 4)) 
                {
                    bool clearDepth = LuaAPI.lua_toboolean(L, 2);
                    bool clearColor = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.Color backgroundColor;translator.Get(L, 4, out backgroundColor);
                    
                    __cl_gen_to_be_invoked.ClearRenderTarget( clearDepth, clearColor, backgroundColor );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Color>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    bool clearDepth = LuaAPI.lua_toboolean(L, 2);
                    bool clearColor = LuaAPI.lua_toboolean(L, 3);
                    UnityEngine.Color backgroundColor;translator.Get(L, 4, out backgroundColor);
                    float depth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.ClearRenderTarget( clearDepth, clearColor, backgroundColor, depth );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.ClearRenderTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalFloat(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetGlobalFloat( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetGlobalFloat( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalVector(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector4>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4 value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalVector( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector4 value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalVector( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalColor(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Color value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalColor( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Color value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalColor( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalMatrix(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Matrix4x4 value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalMatrix( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Matrix4x4 value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalMatrix( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableShaderKeyword(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.EnableShaderKeyword( keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableShaderKeyword(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string keyword = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.DisableShaderKeyword( keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetViewMatrix(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Matrix4x4 view;translator.Get(L, 2, out view);
                    
                    __cl_gen_to_be_invoked.SetViewMatrix( view );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetProjectionMatrix(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Matrix4x4 proj;translator.Get(L, 2, out proj);
                    
                    __cl_gen_to_be_invoked.SetProjectionMatrix( proj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetViewProjectionMatrices(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Matrix4x4 view;translator.Get(L, 2, out view);
                    UnityEngine.Matrix4x4 proj;translator.Get(L, 3, out proj);
                    
                    __cl_gen_to_be_invoked.SetViewProjectionMatrices( view, proj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalDepthBias(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float bias = (float)LuaAPI.lua_tonumber(L, 2);
                    float slopeBias = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetGlobalDepthBias( bias, slopeBias );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalFloatArray(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<float> values = (System.Collections.Generic.List<float>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<float>));
                    
                    __cl_gen_to_be_invoked.SetGlobalFloatArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<float[]>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    float[] values = (float[])translator.GetObject(L, 3, typeof(float[]));
                    
                    __cl_gen_to_be_invoked.SetGlobalFloatArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 3)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<float> values = (System.Collections.Generic.List<float>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<float>));
                    
                    __cl_gen_to_be_invoked.SetGlobalFloatArray( propertyName, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<float[]>(L, 3)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 2);
                    float[] values = (float[])translator.GetObject(L, 3, typeof(float[]));
                    
                    __cl_gen_to_be_invoked.SetGlobalFloatArray( propertyName, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalFloatArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalVectorArray(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    __cl_gen_to_be_invoked.SetGlobalVectorArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector4[]>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4[] values = (UnityEngine.Vector4[])translator.GetObject(L, 3, typeof(UnityEngine.Vector4[]));
                    
                    __cl_gen_to_be_invoked.SetGlobalVectorArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    __cl_gen_to_be_invoked.SetGlobalVectorArray( propertyName, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4[]>(L, 3)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector4[] values = (UnityEngine.Vector4[])translator.GetObject(L, 3, typeof(UnityEngine.Vector4[]));
                    
                    __cl_gen_to_be_invoked.SetGlobalVectorArray( propertyName, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalMatrixArray(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    __cl_gen_to_be_invoked.SetGlobalMatrixArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Matrix4x4[] values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 3, typeof(UnityEngine.Matrix4x4[]));
                    
                    __cl_gen_to_be_invoked.SetGlobalMatrixArray( nameID, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 3)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    __cl_gen_to_be_invoked.SetGlobalMatrixArray( propertyName, values );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 3)) 
                {
                    string propertyName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Matrix4x4[] values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 3, typeof(UnityEngine.Matrix4x4[]));
                    
                    __cl_gen_to_be_invoked.SetGlobalMatrixArray( propertyName, values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalMatrixArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalTexture(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.RenderTargetIdentifier value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalTexture( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Rendering.RenderTargetIdentifier>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Rendering.RenderTargetIdentifier value;translator.Get(L, 3, out value);
                    
                    __cl_gen_to_be_invoked.SetGlobalTexture( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalBuffer(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)) 
                {
                    int nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.ComputeBuffer value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    
                    __cl_gen_to_be_invoked.SetGlobalBuffer( nameID, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)) 
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.ComputeBuffer value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    
                    __cl_gen_to_be_invoked.SetGlobalBuffer( name, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rendering.CommandBuffer.SetGlobalBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetShadowSamplingMode(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Rendering.RenderTargetIdentifier shadowmap;translator.Get(L, 2, out shadowmap);
                    UnityEngine.Rendering.ShadowSamplingMode mode;translator.Get(L, 3, out mode);
                    
                    __cl_gen_to_be_invoked.SetShadowSamplingMode( shadowmap, mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IssuePluginEvent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.IntPtr callback = LuaAPI.lua_touserdata(L, 2);
                    int eventID = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.IssuePluginEvent( callback, eventID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginSample(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.BeginSample( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndSample(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.EndSample( name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.name);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sizeInBytes(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.sizeInBytes);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Rendering.CommandBuffer __cl_gen_to_be_invoked = (UnityEngine.Rendering.CommandBuffer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
