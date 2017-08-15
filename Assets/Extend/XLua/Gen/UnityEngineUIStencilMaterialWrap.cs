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
    public class UnityEngineUIStencilMaterialWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.StencilMaterial), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.UI.StencilMaterial), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.StencilMaterial), L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Add", _m_Add_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Remove", _m_Remove_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearAll", _m_ClearAll_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.StencilMaterial));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.StencilMaterial), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.StencilMaterial does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Material>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Rendering.StencilOp>(L, 3)&& translator.Assignable<UnityEngine.Rendering.CompareFunction>(L, 4)&& translator.Assignable<UnityEngine.Rendering.ColorWriteMask>(L, 5)) 
                {
                    UnityEngine.Material baseMat = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    int stencilID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.StencilOp operation;translator.Get(L, 3, out operation);
                    UnityEngine.Rendering.CompareFunction compareFunction;translator.Get(L, 4, out compareFunction);
                    UnityEngine.Rendering.ColorWriteMask colorWriteMask;translator.Get(L, 5, out colorWriteMask);
                    
                        UnityEngine.Material __cl_gen_ret = UnityEngine.UI.StencilMaterial.Add( baseMat, stencilID, operation, compareFunction, colorWriteMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<UnityEngine.Material>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Rendering.StencilOp>(L, 3)&& translator.Assignable<UnityEngine.Rendering.CompareFunction>(L, 4)&& translator.Assignable<UnityEngine.Rendering.ColorWriteMask>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Material baseMat = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    int stencilID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.StencilOp operation;translator.Get(L, 3, out operation);
                    UnityEngine.Rendering.CompareFunction compareFunction;translator.Get(L, 4, out compareFunction);
                    UnityEngine.Rendering.ColorWriteMask colorWriteMask;translator.Get(L, 5, out colorWriteMask);
                    int readMask = LuaAPI.xlua_tointeger(L, 6);
                    int writeMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        UnityEngine.Material __cl_gen_ret = UnityEngine.UI.StencilMaterial.Add( baseMat, stencilID, operation, compareFunction, colorWriteMask, readMask, writeMask );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.StencilMaterial.Add!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Material customMat = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    
                    UnityEngine.UI.StencilMaterial.Remove( customMat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearAll_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.UI.StencilMaterial.ClearAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
