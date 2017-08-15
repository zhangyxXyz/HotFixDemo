#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;


namespace XLua
{
    public partial class ObjectTranslator
    {
        
        class IniterAdderXLuaTestPedding
        {
            static IniterAdderXLuaTestPedding()
            {
                LuaEnv.AddIniter(Init);
            }
			
			static void Init(LuaEnv luaenv, ObjectTranslator translator)
			{
			
				translator.RegisterPushAndGetAndUpdate<XLuaTest.Pedding>(translator.PushXLuaTestPedding, translator.Get, translator.UpdateXLuaTestPedding);
				translator.RegisterPushAndGetAndUpdate<XLuaTest.MyStruct>(translator.PushXLuaTestMyStruct, translator.Get, translator.UpdateXLuaTestMyStruct);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector2>(translator.PushUnityEngineVector2, translator.Get, translator.UpdateUnityEngineVector2);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector3>(translator.PushUnityEngineVector3, translator.Get, translator.UpdateUnityEngineVector3);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Vector4>(translator.PushUnityEngineVector4, translator.Get, translator.UpdateUnityEngineVector4);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Color>(translator.PushUnityEngineColor, translator.Get, translator.UpdateUnityEngineColor);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Quaternion>(translator.PushUnityEngineQuaternion, translator.Get, translator.UpdateUnityEngineQuaternion);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Ray>(translator.PushUnityEngineRay, translator.Get, translator.UpdateUnityEngineRay);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Bounds>(translator.PushUnityEngineBounds, translator.Get, translator.UpdateUnityEngineBounds);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.Ray2D>(translator.PushUnityEngineRay2D, translator.Get, translator.UpdateUnityEngineRay2D);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TextAlignment>(translator.PushUnityEngineTextAlignment, translator.Get, translator.UpdateUnityEngineTextAlignment);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TextAnchor>(translator.PushUnityEngineTextAnchor, translator.Get, translator.UpdateUnityEngineTextAnchor);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.TouchPhase>(translator.PushUnityEngineTouchPhase, translator.Get, translator.UpdateUnityEngineTouchPhase);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RectTransform.Axis>(translator.PushUnityEngineRectTransformAxis, translator.Get, translator.UpdateUnityEngineRectTransformAxis);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.RectTransform.Edge>(translator.PushUnityEngineRectTransformEdge, translator.Get, translator.UpdateUnityEngineRectTransformEdge);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.FillMethod>(translator.PushUnityEngineUIImageFillMethod, translator.Get, translator.UpdateUnityEngineUIImageFillMethod);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin180>(translator.PushUnityEngineUIImageOrigin180, translator.Get, translator.UpdateUnityEngineUIImageOrigin180);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin360>(translator.PushUnityEngineUIImageOrigin360, translator.Get, translator.UpdateUnityEngineUIImageOrigin360);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Origin90>(translator.PushUnityEngineUIImageOrigin90, translator.Get, translator.UpdateUnityEngineUIImageOrigin90);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.OriginHorizontal>(translator.PushUnityEngineUIImageOriginHorizontal, translator.Get, translator.UpdateUnityEngineUIImageOriginHorizontal);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.OriginVertical>(translator.PushUnityEngineUIImageOriginVertical, translator.Get, translator.UpdateUnityEngineUIImageOriginVertical);
				translator.RegisterPushAndGetAndUpdate<UnityEngine.UI.Image.Type>(translator.PushUnityEngineUIImageType, translator.Get, translator.UpdateUnityEngineUIImageType);
				translator.RegisterPushAndGetAndUpdate<XLuaTest.MyEnum>(translator.PushXLuaTestMyEnum, translator.Get, translator.UpdateXLuaTestMyEnum);
				translator.RegisterPushAndGetAndUpdate<Tutorial.TestEnum>(translator.PushTutorialTestEnum, translator.Get, translator.UpdateTutorialTestEnum);
				translator.RegisterPushAndGetAndUpdate<Tutorial.DrivenClass.TestEnumInner>(translator.PushTutorialDrivenClassTestEnumInner, translator.Get, translator.UpdateTutorialDrivenClassTestEnumInner);
			
			}
        }
        
        static IniterAdderXLuaTestPedding s_IniterAdderXLuaTestPedding_dumb_obj = new IniterAdderXLuaTestPedding();
        static IniterAdderXLuaTestPedding IniterAdderXLuaTestPedding_dumb_obj {get{return s_IniterAdderXLuaTestPedding_dumb_obj;}}
        
        
        int XLuaTestPedding_TypeID = -1;
        public void PushXLuaTestPedding(RealStatePtr L, XLuaTest.Pedding val)
        {
            if (XLuaTestPedding_TypeID == -1)
            {
			    bool is_first;
                XLuaTestPedding_TypeID = getTypeId(L, typeof(XLuaTest.Pedding), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 1, XLuaTestPedding_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for XLuaTest.Pedding ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out XLuaTest.Pedding val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XLuaTestPedding_TypeID)
				{
				    throw new Exception("invalid userdata for XLuaTest.Pedding");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for XLuaTest.Pedding");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (XLuaTest.Pedding)objectCasters.GetCaster(typeof(XLuaTest.Pedding))(L, index, null);
            }
        }
		
        public void UpdateXLuaTestPedding(RealStatePtr L, int index, XLuaTest.Pedding val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XLuaTestPedding_TypeID)
				{
				    throw new Exception("invalid userdata for XLuaTest.Pedding");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for XLuaTest.Pedding ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int XLuaTestMyStruct_TypeID = -1;
        public void PushXLuaTestMyStruct(RealStatePtr L, XLuaTest.MyStruct val)
        {
            if (XLuaTestMyStruct_TypeID == -1)
            {
			    bool is_first;
                XLuaTestMyStruct_TypeID = getTypeId(L, typeof(XLuaTest.MyStruct), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 25, XLuaTestMyStruct_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for XLuaTest.MyStruct ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out XLuaTest.MyStruct val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XLuaTestMyStruct_TypeID)
				{
				    throw new Exception("invalid userdata for XLuaTest.MyStruct");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for XLuaTest.MyStruct");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (XLuaTest.MyStruct)objectCasters.GetCaster(typeof(XLuaTest.MyStruct))(L, index, null);
            }
        }
		
        public void UpdateXLuaTestMyStruct(RealStatePtr L, int index, XLuaTest.MyStruct val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XLuaTestMyStruct_TypeID)
				{
				    throw new Exception("invalid userdata for XLuaTest.MyStruct");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for XLuaTest.MyStruct ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVector2_TypeID = -1;
        public void PushUnityEngineVector2(RealStatePtr L, UnityEngine.Vector2 val)
        {
            if (UnityEngineVector2_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector2_TypeID = getTypeId(L, typeof(UnityEngine.Vector2), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 8, UnityEngineVector2_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector2 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector2 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector2_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector2");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector2");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector2)objectCasters.GetCaster(typeof(UnityEngine.Vector2))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector2(RealStatePtr L, int index, UnityEngine.Vector2 val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector2_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector2");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector2 ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVector3_TypeID = -1;
        public void PushUnityEngineVector3(RealStatePtr L, UnityEngine.Vector3 val)
        {
            if (UnityEngineVector3_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector3_TypeID = getTypeId(L, typeof(UnityEngine.Vector3), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 12, UnityEngineVector3_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector3 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector3 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector3_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector3");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector3");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector3)objectCasters.GetCaster(typeof(UnityEngine.Vector3))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector3(RealStatePtr L, int index, UnityEngine.Vector3 val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector3_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector3");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector3 ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineVector4_TypeID = -1;
        public void PushUnityEngineVector4(RealStatePtr L, UnityEngine.Vector4 val)
        {
            if (UnityEngineVector4_TypeID == -1)
            {
			    bool is_first;
                UnityEngineVector4_TypeID = getTypeId(L, typeof(UnityEngine.Vector4), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineVector4_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Vector4 ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Vector4 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector4_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector4");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Vector4");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Vector4)objectCasters.GetCaster(typeof(UnityEngine.Vector4))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineVector4(RealStatePtr L, int index, UnityEngine.Vector4 val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineVector4_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Vector4");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Vector4 ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineColor_TypeID = -1;
        public void PushUnityEngineColor(RealStatePtr L, UnityEngine.Color val)
        {
            if (UnityEngineColor_TypeID == -1)
            {
			    bool is_first;
                UnityEngineColor_TypeID = getTypeId(L, typeof(UnityEngine.Color), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineColor_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Color ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Color val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Color");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Color");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Color)objectCasters.GetCaster(typeof(UnityEngine.Color))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineColor(RealStatePtr L, int index, UnityEngine.Color val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineColor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Color");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Color ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineQuaternion_TypeID = -1;
        public void PushUnityEngineQuaternion(RealStatePtr L, UnityEngine.Quaternion val)
        {
            if (UnityEngineQuaternion_TypeID == -1)
            {
			    bool is_first;
                UnityEngineQuaternion_TypeID = getTypeId(L, typeof(UnityEngine.Quaternion), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineQuaternion_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Quaternion ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Quaternion val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQuaternion_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Quaternion");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Quaternion");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Quaternion)objectCasters.GetCaster(typeof(UnityEngine.Quaternion))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineQuaternion(RealStatePtr L, int index, UnityEngine.Quaternion val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineQuaternion_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Quaternion");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Quaternion ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRay_TypeID = -1;
        public void PushUnityEngineRay(RealStatePtr L, UnityEngine.Ray val)
        {
            if (UnityEngineRay_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRay_TypeID = getTypeId(L, typeof(UnityEngine.Ray), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 24, UnityEngineRay_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Ray ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Ray val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Ray");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Ray)objectCasters.GetCaster(typeof(UnityEngine.Ray))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRay(RealStatePtr L, int index, UnityEngine.Ray val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Ray ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineBounds_TypeID = -1;
        public void PushUnityEngineBounds(RealStatePtr L, UnityEngine.Bounds val)
        {
            if (UnityEngineBounds_TypeID == -1)
            {
			    bool is_first;
                UnityEngineBounds_TypeID = getTypeId(L, typeof(UnityEngine.Bounds), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 24, UnityEngineBounds_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Bounds ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Bounds val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBounds_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Bounds");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Bounds");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Bounds)objectCasters.GetCaster(typeof(UnityEngine.Bounds))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineBounds(RealStatePtr L, int index, UnityEngine.Bounds val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineBounds_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Bounds");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Bounds ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRay2D_TypeID = -1;
        public void PushUnityEngineRay2D(RealStatePtr L, UnityEngine.Ray2D val)
        {
            if (UnityEngineRay2D_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRay2D_TypeID = getTypeId(L, typeof(UnityEngine.Ray2D), out is_first);
				
            }
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 16, UnityEngineRay2D_TypeID);
            if (!CopyByValue.Pack(buff, 0, val))
            {
                throw new Exception("pack fail fail for UnityEngine.Ray2D ,value="+val);
            }
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.Ray2D val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);if (!CopyByValue.UnPack(buff, 0, out val))
                {
                    throw new Exception("unpack fail for UnityEngine.Ray2D");
                }
            }
			else if (type ==LuaTypes.LUA_TTABLE)
			{
			    CopyByValue.UnPack(this, L, index, out val);
			}
            else
            {
                val = (UnityEngine.Ray2D)objectCasters.GetCaster(typeof(UnityEngine.Ray2D))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRay2D(RealStatePtr L, int index, UnityEngine.Ray2D val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRay2D_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.Ray2D");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  val))
                {
                    throw new Exception("pack fail for UnityEngine.Ray2D ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTextAlignment_TypeID = -1;
		int UnityEngineTextAlignment_EnumRef = -1;
        
        public void PushUnityEngineTextAlignment(RealStatePtr L, UnityEngine.TextAlignment val)
        {
            if (UnityEngineTextAlignment_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTextAlignment_TypeID = getTypeId(L, typeof(UnityEngine.TextAlignment), out is_first);
				
				if (UnityEngineTextAlignment_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TextAlignment));
				    UnityEngineTextAlignment_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTextAlignment_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTextAlignment_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TextAlignment ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTextAlignment_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TextAlignment val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextAlignment_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextAlignment");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TextAlignment");
                }
				val = (UnityEngine.TextAlignment)e;
                
            }
            else
            {
                val = (UnityEngine.TextAlignment)objectCasters.GetCaster(typeof(UnityEngine.TextAlignment))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTextAlignment(RealStatePtr L, int index, UnityEngine.TextAlignment val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextAlignment_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextAlignment");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TextAlignment ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTextAnchor_TypeID = -1;
		int UnityEngineTextAnchor_EnumRef = -1;
        
        public void PushUnityEngineTextAnchor(RealStatePtr L, UnityEngine.TextAnchor val)
        {
            if (UnityEngineTextAnchor_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTextAnchor_TypeID = getTypeId(L, typeof(UnityEngine.TextAnchor), out is_first);
				
				if (UnityEngineTextAnchor_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TextAnchor));
				    UnityEngineTextAnchor_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTextAnchor_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTextAnchor_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TextAnchor ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTextAnchor_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TextAnchor val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextAnchor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextAnchor");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TextAnchor");
                }
				val = (UnityEngine.TextAnchor)e;
                
            }
            else
            {
                val = (UnityEngine.TextAnchor)objectCasters.GetCaster(typeof(UnityEngine.TextAnchor))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTextAnchor(RealStatePtr L, int index, UnityEngine.TextAnchor val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTextAnchor_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TextAnchor");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TextAnchor ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineTouchPhase_TypeID = -1;
		int UnityEngineTouchPhase_EnumRef = -1;
        
        public void PushUnityEngineTouchPhase(RealStatePtr L, UnityEngine.TouchPhase val)
        {
            if (UnityEngineTouchPhase_TypeID == -1)
            {
			    bool is_first;
                UnityEngineTouchPhase_TypeID = getTypeId(L, typeof(UnityEngine.TouchPhase), out is_first);
				
				if (UnityEngineTouchPhase_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.TouchPhase));
				    UnityEngineTouchPhase_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineTouchPhase_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineTouchPhase_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.TouchPhase ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineTouchPhase_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.TouchPhase val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTouchPhase_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TouchPhase");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.TouchPhase");
                }
				val = (UnityEngine.TouchPhase)e;
                
            }
            else
            {
                val = (UnityEngine.TouchPhase)objectCasters.GetCaster(typeof(UnityEngine.TouchPhase))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineTouchPhase(RealStatePtr L, int index, UnityEngine.TouchPhase val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineTouchPhase_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.TouchPhase");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.TouchPhase ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRectTransformAxis_TypeID = -1;
		int UnityEngineRectTransformAxis_EnumRef = -1;
        
        public void PushUnityEngineRectTransformAxis(RealStatePtr L, UnityEngine.RectTransform.Axis val)
        {
            if (UnityEngineRectTransformAxis_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRectTransformAxis_TypeID = getTypeId(L, typeof(UnityEngine.RectTransform.Axis), out is_first);
				
				if (UnityEngineRectTransformAxis_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RectTransform.Axis));
				    UnityEngineRectTransformAxis_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRectTransformAxis_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRectTransformAxis_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RectTransform.Axis ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRectTransformAxis_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RectTransform.Axis val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RectTransform.Axis");
                }
				val = (UnityEngine.RectTransform.Axis)e;
                
            }
            else
            {
                val = (UnityEngine.RectTransform.Axis)objectCasters.GetCaster(typeof(UnityEngine.RectTransform.Axis))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRectTransformAxis(RealStatePtr L, int index, UnityEngine.RectTransform.Axis val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformAxis_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Axis");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RectTransform.Axis ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineRectTransformEdge_TypeID = -1;
		int UnityEngineRectTransformEdge_EnumRef = -1;
        
        public void PushUnityEngineRectTransformEdge(RealStatePtr L, UnityEngine.RectTransform.Edge val)
        {
            if (UnityEngineRectTransformEdge_TypeID == -1)
            {
			    bool is_first;
                UnityEngineRectTransformEdge_TypeID = getTypeId(L, typeof(UnityEngine.RectTransform.Edge), out is_first);
				
				if (UnityEngineRectTransformEdge_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.RectTransform.Edge));
				    UnityEngineRectTransformEdge_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineRectTransformEdge_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineRectTransformEdge_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.RectTransform.Edge ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineRectTransformEdge_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.RectTransform.Edge val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformEdge_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Edge");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.RectTransform.Edge");
                }
				val = (UnityEngine.RectTransform.Edge)e;
                
            }
            else
            {
                val = (UnityEngine.RectTransform.Edge)objectCasters.GetCaster(typeof(UnityEngine.RectTransform.Edge))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineRectTransformEdge(RealStatePtr L, int index, UnityEngine.RectTransform.Edge val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineRectTransformEdge_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.RectTransform.Edge");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.RectTransform.Edge ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageFillMethod_TypeID = -1;
		int UnityEngineUIImageFillMethod_EnumRef = -1;
        
        public void PushUnityEngineUIImageFillMethod(RealStatePtr L, UnityEngine.UI.Image.FillMethod val)
        {
            if (UnityEngineUIImageFillMethod_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageFillMethod_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.FillMethod), out is_first);
				
				if (UnityEngineUIImageFillMethod_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.FillMethod));
				    UnityEngineUIImageFillMethod_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageFillMethod_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageFillMethod_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.FillMethod ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageFillMethod_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.FillMethod val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.FillMethod");
                }
				val = (UnityEngine.UI.Image.FillMethod)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.FillMethod)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.FillMethod))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageFillMethod(RealStatePtr L, int index, UnityEngine.UI.Image.FillMethod val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageFillMethod_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.FillMethod");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.FillMethod ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin180_TypeID = -1;
		int UnityEngineUIImageOrigin180_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin180(RealStatePtr L, UnityEngine.UI.Image.Origin180 val)
        {
            if (UnityEngineUIImageOrigin180_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin180_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin180), out is_first);
				
				if (UnityEngineUIImageOrigin180_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin180));
				    UnityEngineUIImageOrigin180_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin180_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin180_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin180 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin180_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin180 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin180");
                }
				val = (UnityEngine.UI.Image.Origin180)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin180)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin180))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin180(RealStatePtr L, int index, UnityEngine.UI.Image.Origin180 val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin180_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin180");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin180 ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin360_TypeID = -1;
		int UnityEngineUIImageOrigin360_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin360(RealStatePtr L, UnityEngine.UI.Image.Origin360 val)
        {
            if (UnityEngineUIImageOrigin360_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin360_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin360), out is_first);
				
				if (UnityEngineUIImageOrigin360_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin360));
				    UnityEngineUIImageOrigin360_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin360_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin360_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin360 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin360_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin360 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin360");
                }
				val = (UnityEngine.UI.Image.Origin360)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin360)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin360))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin360(RealStatePtr L, int index, UnityEngine.UI.Image.Origin360 val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin360_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin360");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin360 ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOrigin90_TypeID = -1;
		int UnityEngineUIImageOrigin90_EnumRef = -1;
        
        public void PushUnityEngineUIImageOrigin90(RealStatePtr L, UnityEngine.UI.Image.Origin90 val)
        {
            if (UnityEngineUIImageOrigin90_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOrigin90_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Origin90), out is_first);
				
				if (UnityEngineUIImageOrigin90_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Origin90));
				    UnityEngineUIImageOrigin90_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOrigin90_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOrigin90_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Origin90 ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOrigin90_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Origin90 val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Origin90");
                }
				val = (UnityEngine.UI.Image.Origin90)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Origin90)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Origin90))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOrigin90(RealStatePtr L, int index, UnityEngine.UI.Image.Origin90 val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOrigin90_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Origin90");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Origin90 ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOriginHorizontal_TypeID = -1;
		int UnityEngineUIImageOriginHorizontal_EnumRef = -1;
        
        public void PushUnityEngineUIImageOriginHorizontal(RealStatePtr L, UnityEngine.UI.Image.OriginHorizontal val)
        {
            if (UnityEngineUIImageOriginHorizontal_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOriginHorizontal_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.OriginHorizontal), out is_first);
				
				if (UnityEngineUIImageOriginHorizontal_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.OriginHorizontal));
				    UnityEngineUIImageOriginHorizontal_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOriginHorizontal_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOriginHorizontal_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.OriginHorizontal ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOriginHorizontal_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.OriginHorizontal val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.OriginHorizontal");
                }
				val = (UnityEngine.UI.Image.OriginHorizontal)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.OriginHorizontal)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.OriginHorizontal))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOriginHorizontal(RealStatePtr L, int index, UnityEngine.UI.Image.OriginHorizontal val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginHorizontal_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginHorizontal");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.OriginHorizontal ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageOriginVertical_TypeID = -1;
		int UnityEngineUIImageOriginVertical_EnumRef = -1;
        
        public void PushUnityEngineUIImageOriginVertical(RealStatePtr L, UnityEngine.UI.Image.OriginVertical val)
        {
            if (UnityEngineUIImageOriginVertical_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageOriginVertical_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.OriginVertical), out is_first);
				
				if (UnityEngineUIImageOriginVertical_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.OriginVertical));
				    UnityEngineUIImageOriginVertical_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageOriginVertical_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageOriginVertical_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.OriginVertical ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageOriginVertical_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.OriginVertical val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.OriginVertical");
                }
				val = (UnityEngine.UI.Image.OriginVertical)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.OriginVertical)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.OriginVertical))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageOriginVertical(RealStatePtr L, int index, UnityEngine.UI.Image.OriginVertical val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageOriginVertical_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.OriginVertical");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.OriginVertical ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int UnityEngineUIImageType_TypeID = -1;
		int UnityEngineUIImageType_EnumRef = -1;
        
        public void PushUnityEngineUIImageType(RealStatePtr L, UnityEngine.UI.Image.Type val)
        {
            if (UnityEngineUIImageType_TypeID == -1)
            {
			    bool is_first;
                UnityEngineUIImageType_TypeID = getTypeId(L, typeof(UnityEngine.UI.Image.Type), out is_first);
				
				if (UnityEngineUIImageType_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(UnityEngine.UI.Image.Type));
				    UnityEngineUIImageType_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, UnityEngineUIImageType_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, UnityEngineUIImageType_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for UnityEngine.UI.Image.Type ,value="+val);
            }
			
			LuaAPI.lua_getref(L, UnityEngineUIImageType_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out UnityEngine.UI.Image.Type val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for UnityEngine.UI.Image.Type");
                }
				val = (UnityEngine.UI.Image.Type)e;
                
            }
            else
            {
                val = (UnityEngine.UI.Image.Type)objectCasters.GetCaster(typeof(UnityEngine.UI.Image.Type))(L, index, null);
            }
        }
		
        public void UpdateUnityEngineUIImageType(RealStatePtr L, int index, UnityEngine.UI.Image.Type val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != UnityEngineUIImageType_TypeID)
				{
				    throw new Exception("invalid userdata for UnityEngine.UI.Image.Type");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for UnityEngine.UI.Image.Type ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int XLuaTestMyEnum_TypeID = -1;
		int XLuaTestMyEnum_EnumRef = -1;
        
        public void PushXLuaTestMyEnum(RealStatePtr L, XLuaTest.MyEnum val)
        {
            if (XLuaTestMyEnum_TypeID == -1)
            {
			    bool is_first;
                XLuaTestMyEnum_TypeID = getTypeId(L, typeof(XLuaTest.MyEnum), out is_first);
				
				if (XLuaTestMyEnum_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(XLuaTest.MyEnum));
				    XLuaTestMyEnum_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, XLuaTestMyEnum_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, XLuaTestMyEnum_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for XLuaTest.MyEnum ,value="+val);
            }
			
			LuaAPI.lua_getref(L, XLuaTestMyEnum_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out XLuaTest.MyEnum val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XLuaTestMyEnum_TypeID)
				{
				    throw new Exception("invalid userdata for XLuaTest.MyEnum");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for XLuaTest.MyEnum");
                }
				val = (XLuaTest.MyEnum)e;
                
            }
            else
            {
                val = (XLuaTest.MyEnum)objectCasters.GetCaster(typeof(XLuaTest.MyEnum))(L, index, null);
            }
        }
		
        public void UpdateXLuaTestMyEnum(RealStatePtr L, int index, XLuaTest.MyEnum val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != XLuaTestMyEnum_TypeID)
				{
				    throw new Exception("invalid userdata for XLuaTest.MyEnum");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for XLuaTest.MyEnum ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int TutorialTestEnum_TypeID = -1;
		int TutorialTestEnum_EnumRef = -1;
        
        public void PushTutorialTestEnum(RealStatePtr L, Tutorial.TestEnum val)
        {
            if (TutorialTestEnum_TypeID == -1)
            {
			    bool is_first;
                TutorialTestEnum_TypeID = getTypeId(L, typeof(Tutorial.TestEnum), out is_first);
				
				if (TutorialTestEnum_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(Tutorial.TestEnum));
				    TutorialTestEnum_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, TutorialTestEnum_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, TutorialTestEnum_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for Tutorial.TestEnum ,value="+val);
            }
			
			LuaAPI.lua_getref(L, TutorialTestEnum_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out Tutorial.TestEnum val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != TutorialTestEnum_TypeID)
				{
				    throw new Exception("invalid userdata for Tutorial.TestEnum");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for Tutorial.TestEnum");
                }
				val = (Tutorial.TestEnum)e;
                
            }
            else
            {
                val = (Tutorial.TestEnum)objectCasters.GetCaster(typeof(Tutorial.TestEnum))(L, index, null);
            }
        }
		
        public void UpdateTutorialTestEnum(RealStatePtr L, int index, Tutorial.TestEnum val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != TutorialTestEnum_TypeID)
				{
				    throw new Exception("invalid userdata for Tutorial.TestEnum");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for Tutorial.TestEnum ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        int TutorialDrivenClassTestEnumInner_TypeID = -1;
		int TutorialDrivenClassTestEnumInner_EnumRef = -1;
        
        public void PushTutorialDrivenClassTestEnumInner(RealStatePtr L, Tutorial.DrivenClass.TestEnumInner val)
        {
            if (TutorialDrivenClassTestEnumInner_TypeID == -1)
            {
			    bool is_first;
                TutorialDrivenClassTestEnumInner_TypeID = getTypeId(L, typeof(Tutorial.DrivenClass.TestEnumInner), out is_first);
				
				if (TutorialDrivenClassTestEnumInner_EnumRef == -1)
				{
				    Utils.LoadCSTable(L, typeof(Tutorial.DrivenClass.TestEnumInner));
				    TutorialDrivenClassTestEnumInner_EnumRef = LuaAPI.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
				
            }
			
			if (LuaAPI.xlua_tryget_cachedud(L, (int)val, TutorialDrivenClassTestEnumInner_EnumRef) == 1)
            {
			    return;
			}
			
            IntPtr buff = LuaAPI.xlua_pushstruct(L, 4, TutorialDrivenClassTestEnumInner_TypeID);
            if (!CopyByValue.Pack(buff, 0, (int)val))
            {
                throw new Exception("pack fail fail for Tutorial.DrivenClass.TestEnumInner ,value="+val);
            }
			
			LuaAPI.lua_getref(L, TutorialDrivenClassTestEnumInner_EnumRef);
			LuaAPI.lua_pushvalue(L, -2);
			LuaAPI.xlua_rawseti(L, -2, (int)val);
			LuaAPI.lua_pop(L, 1);
			
        }
		
        public void Get(RealStatePtr L, int index, out Tutorial.DrivenClass.TestEnumInner val)
        {
		    LuaTypes type = LuaAPI.lua_type(L, index);
            if (type == LuaTypes.LUA_TUSERDATA )
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != TutorialDrivenClassTestEnumInner_TypeID)
				{
				    throw new Exception("invalid userdata for Tutorial.DrivenClass.TestEnumInner");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
				int e;
                if (!CopyByValue.UnPack(buff, 0, out e))
                {
                    throw new Exception("unpack fail for Tutorial.DrivenClass.TestEnumInner");
                }
				val = (Tutorial.DrivenClass.TestEnumInner)e;
                
            }
            else
            {
                val = (Tutorial.DrivenClass.TestEnumInner)objectCasters.GetCaster(typeof(Tutorial.DrivenClass.TestEnumInner))(L, index, null);
            }
        }
		
        public void UpdateTutorialDrivenClassTestEnumInner(RealStatePtr L, int index, Tutorial.DrivenClass.TestEnumInner val)
        {
            if (LuaAPI.lua_type(L, index) == LuaTypes.LUA_TUSERDATA)
            {
			    if (LuaAPI.xlua_gettypeid(L, index) != TutorialDrivenClassTestEnumInner_TypeID)
				{
				    throw new Exception("invalid userdata for Tutorial.DrivenClass.TestEnumInner");
				}
				
                IntPtr buff = LuaAPI.lua_touserdata(L, index);
                if (!CopyByValue.Pack(buff, 0,  (int)val))
                {
                    throw new Exception("pack fail for Tutorial.DrivenClass.TestEnumInner ,value="+val);
                }
            }
            else
            {
                throw new Exception("try to update a data with lua type:" + LuaAPI.lua_type(L, index));
            }
        }
        
        
		// table cast optimze
		
        
    }
	
	public partial class StaticLuaCallbacks
    {
	    internal static bool __tryArrayGet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int index)
		{
		
			if (type == typeof(XLuaTest.Pedding[]))
			{
			    XLuaTest.Pedding[] array = obj as XLuaTest.Pedding[];
				translator.PushXLuaTestPedding(L, array[index]);
				return true;
			}
			else if (type == typeof(XLuaTest.MyStruct[]))
			{
			    XLuaTest.MyStruct[] array = obj as XLuaTest.MyStruct[];
				translator.PushXLuaTestMyStruct(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector2[]))
			{
			    UnityEngine.Vector2[] array = obj as UnityEngine.Vector2[];
				translator.PushUnityEngineVector2(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector3[]))
			{
			    UnityEngine.Vector3[] array = obj as UnityEngine.Vector3[];
				translator.PushUnityEngineVector3(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector4[]))
			{
			    UnityEngine.Vector4[] array = obj as UnityEngine.Vector4[];
				translator.PushUnityEngineVector4(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Color[]))
			{
			    UnityEngine.Color[] array = obj as UnityEngine.Color[];
				translator.PushUnityEngineColor(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Quaternion[]))
			{
			    UnityEngine.Quaternion[] array = obj as UnityEngine.Quaternion[];
				translator.PushUnityEngineQuaternion(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray[]))
			{
			    UnityEngine.Ray[] array = obj as UnityEngine.Ray[];
				translator.PushUnityEngineRay(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Bounds[]))
			{
			    UnityEngine.Bounds[] array = obj as UnityEngine.Bounds[];
				translator.PushUnityEngineBounds(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray2D[]))
			{
			    UnityEngine.Ray2D[] array = obj as UnityEngine.Ray2D[];
				translator.PushUnityEngineRay2D(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextAlignment[]))
			{
			    UnityEngine.TextAlignment[] array = obj as UnityEngine.TextAlignment[];
				translator.PushUnityEngineTextAlignment(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextAnchor[]))
			{
			    UnityEngine.TextAnchor[] array = obj as UnityEngine.TextAnchor[];
				translator.PushUnityEngineTextAnchor(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.TouchPhase[]))
			{
			    UnityEngine.TouchPhase[] array = obj as UnityEngine.TouchPhase[];
				translator.PushUnityEngineTouchPhase(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Axis[]))
			{
			    UnityEngine.RectTransform.Axis[] array = obj as UnityEngine.RectTransform.Axis[];
				translator.PushUnityEngineRectTransformAxis(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Edge[]))
			{
			    UnityEngine.RectTransform.Edge[] array = obj as UnityEngine.RectTransform.Edge[];
				translator.PushUnityEngineRectTransformEdge(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.FillMethod[]))
			{
			    UnityEngine.UI.Image.FillMethod[] array = obj as UnityEngine.UI.Image.FillMethod[];
				translator.PushUnityEngineUIImageFillMethod(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin180[]))
			{
			    UnityEngine.UI.Image.Origin180[] array = obj as UnityEngine.UI.Image.Origin180[];
				translator.PushUnityEngineUIImageOrigin180(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin360[]))
			{
			    UnityEngine.UI.Image.Origin360[] array = obj as UnityEngine.UI.Image.Origin360[];
				translator.PushUnityEngineUIImageOrigin360(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin90[]))
			{
			    UnityEngine.UI.Image.Origin90[] array = obj as UnityEngine.UI.Image.Origin90[];
				translator.PushUnityEngineUIImageOrigin90(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginHorizontal[]))
			{
			    UnityEngine.UI.Image.OriginHorizontal[] array = obj as UnityEngine.UI.Image.OriginHorizontal[];
				translator.PushUnityEngineUIImageOriginHorizontal(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginVertical[]))
			{
			    UnityEngine.UI.Image.OriginVertical[] array = obj as UnityEngine.UI.Image.OriginVertical[];
				translator.PushUnityEngineUIImageOriginVertical(L, array[index]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Type[]))
			{
			    UnityEngine.UI.Image.Type[] array = obj as UnityEngine.UI.Image.Type[];
				translator.PushUnityEngineUIImageType(L, array[index]);
				return true;
			}
			else if (type == typeof(XLuaTest.MyEnum[]))
			{
			    XLuaTest.MyEnum[] array = obj as XLuaTest.MyEnum[];
				translator.PushXLuaTestMyEnum(L, array[index]);
				return true;
			}
			else if (type == typeof(Tutorial.TestEnum[]))
			{
			    Tutorial.TestEnum[] array = obj as Tutorial.TestEnum[];
				translator.PushTutorialTestEnum(L, array[index]);
				return true;
			}
			else if (type == typeof(Tutorial.DrivenClass.TestEnumInner[]))
			{
			    Tutorial.DrivenClass.TestEnumInner[] array = obj as Tutorial.DrivenClass.TestEnumInner[];
				translator.PushTutorialDrivenClassTestEnumInner(L, array[index]);
				return true;
			}
            return false;
		}
		
		internal static bool __tryArraySet(Type type, RealStatePtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx)
		{
		
			if (type == typeof(XLuaTest.Pedding[]))
			{
			    XLuaTest.Pedding[] array = obj as XLuaTest.Pedding[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(XLuaTest.MyStruct[]))
			{
			    XLuaTest.MyStruct[] array = obj as XLuaTest.MyStruct[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector2[]))
			{
			    UnityEngine.Vector2[] array = obj as UnityEngine.Vector2[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector3[]))
			{
			    UnityEngine.Vector3[] array = obj as UnityEngine.Vector3[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Vector4[]))
			{
			    UnityEngine.Vector4[] array = obj as UnityEngine.Vector4[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Color[]))
			{
			    UnityEngine.Color[] array = obj as UnityEngine.Color[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Quaternion[]))
			{
			    UnityEngine.Quaternion[] array = obj as UnityEngine.Quaternion[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray[]))
			{
			    UnityEngine.Ray[] array = obj as UnityEngine.Ray[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Bounds[]))
			{
			    UnityEngine.Bounds[] array = obj as UnityEngine.Bounds[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.Ray2D[]))
			{
			    UnityEngine.Ray2D[] array = obj as UnityEngine.Ray2D[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextAlignment[]))
			{
			    UnityEngine.TextAlignment[] array = obj as UnityEngine.TextAlignment[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TextAnchor[]))
			{
			    UnityEngine.TextAnchor[] array = obj as UnityEngine.TextAnchor[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.TouchPhase[]))
			{
			    UnityEngine.TouchPhase[] array = obj as UnityEngine.TouchPhase[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Axis[]))
			{
			    UnityEngine.RectTransform.Axis[] array = obj as UnityEngine.RectTransform.Axis[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.RectTransform.Edge[]))
			{
			    UnityEngine.RectTransform.Edge[] array = obj as UnityEngine.RectTransform.Edge[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.FillMethod[]))
			{
			    UnityEngine.UI.Image.FillMethod[] array = obj as UnityEngine.UI.Image.FillMethod[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin180[]))
			{
			    UnityEngine.UI.Image.Origin180[] array = obj as UnityEngine.UI.Image.Origin180[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin360[]))
			{
			    UnityEngine.UI.Image.Origin360[] array = obj as UnityEngine.UI.Image.Origin360[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Origin90[]))
			{
			    UnityEngine.UI.Image.Origin90[] array = obj as UnityEngine.UI.Image.Origin90[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginHorizontal[]))
			{
			    UnityEngine.UI.Image.OriginHorizontal[] array = obj as UnityEngine.UI.Image.OriginHorizontal[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.OriginVertical[]))
			{
			    UnityEngine.UI.Image.OriginVertical[] array = obj as UnityEngine.UI.Image.OriginVertical[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(UnityEngine.UI.Image.Type[]))
			{
			    UnityEngine.UI.Image.Type[] array = obj as UnityEngine.UI.Image.Type[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(XLuaTest.MyEnum[]))
			{
			    XLuaTest.MyEnum[] array = obj as XLuaTest.MyEnum[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(Tutorial.TestEnum[]))
			{
			    Tutorial.TestEnum[] array = obj as Tutorial.TestEnum[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
			else if (type == typeof(Tutorial.DrivenClass.TestEnumInner[]))
			{
			    Tutorial.DrivenClass.TestEnumInner[] array = obj as Tutorial.DrivenClass.TestEnumInner[];
				translator.Get(L, obj_idx, out array[array_idx]);
				return true;
			}
            return false;
		}
	}
}