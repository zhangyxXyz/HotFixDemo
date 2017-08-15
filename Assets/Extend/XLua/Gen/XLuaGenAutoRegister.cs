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
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(System.Type), SystemTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Array), SystemArrayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.Dictionary<int, object>), SystemCollectionsGenericDictionary_2_SystemInt32SystemObject_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>), SystemCollectionsGenericDictionary_2_SystemInt32UnityEngineObject_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<object>), SystemCollectionsGenericList_1_SystemObject_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<UnityEngine.Object>), SystemCollectionsGenericList_1_UnityEngineObject_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry>), SystemCollectionsGenericList_1_UnityEngineEventSystemsEventTriggerEntry_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent), UnityEngineEventsUnityEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<bool>), UnityEngineEventsUnityEvent_1_SystemBoolean_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<int>), UnityEngineEventsUnityEvent_1_SystemInt32_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<float>), UnityEngineEventsUnityEvent_1_SystemSingle_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<string>), UnityEngineEventsUnityEvent_1_SystemString_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>), UnityEngineEventsUnityEvent_1_UnityEngineEventSystemsBaseEventData_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector2>), UnityEngineEventsUnityEvent_1_UnityEngineVector2_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAlignment), UnityEngineTextAlignmentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextAnchor), UnityEngineTextAnchorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TouchPhase), UnityEngineTouchPhaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectTransform.Axis), UnityEngineRectTransformAxisWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectTransform.Edge), UnityEngineRectTransformEdgeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.FillMethod), UnityEngineUIImageFillMethodWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin180), UnityEngineUIImageOrigin180Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin360), UnityEngineUIImageOrigin360Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin90), UnityEngineUIImageOrigin90Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.OriginHorizontal), UnityEngineUIImageOriginHorizontalWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.OriginVertical), UnityEngineUIImageOriginVerticalWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Type), UnityEngineUIImageTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Texture2D), UnityEngineTexture2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleCreateRequest), UnityEngineAssetBundleCreateRequestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleRequest), UnityEngineAssetBundleRequestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngineAssetBundleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AssetBundleManifest), UnityEngineAssetBundleManifestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AsyncOperation), UnityEngineAsyncOperationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SystemInfo), UnityEngineSystemInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitForFixedUpdate), UnityEngineWaitForFixedUpdateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitForEndOfFrame), UnityEngineWaitForEndOfFrameWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CustomYieldInstruction), UnityEngineCustomYieldInstructionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitWhile), UnityEngineWaitWhileWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitUntil), UnityEngineWaitUntilWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Coroutine), UnityEngineCoroutineWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ScriptableObject), UnityEngineScriptableObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BillboardAsset), UnityEngineBillboardAssetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BillboardRenderer), UnityEngineBillboardRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Caching), UnityEngineCachingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Camera), UnityEngineCameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ColorUtility), UnityEngineColorUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ComputeShader), UnityEngineComputeShaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ComputeBuffer), UnityEngineComputeBufferWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CrashReport), UnityEngineCrashReportWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BoundingSphere), UnityEngineBoundingSphereWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CullingGroupEvent), UnityEngineCullingGroupEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CullingGroup), UnityEngineCullingGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Display), UnityEngineDisplayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ExposedPropertyResolver), UnityEngineExposedPropertyResolverWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.FlareLayer), UnityEngineFlareLayerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GradientColorKey), UnityEngineGradientColorKeyWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GradientAlphaKey), UnityEngineGradientAlphaKeyWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Gradient), UnityEngineGradientWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.OcclusionArea), UnityEngineOcclusionAreaWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.OcclusionPortal), UnityEngineOcclusionPortalWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderSettings), UnityEngineRenderSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.QualitySettings), UnityEngineQualitySettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MeshFilter), UnityEngineMeshFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Flare), UnityEngineFlareWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LensFlare), UnityEngineLensFlareWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RendererExtensions), UnityEngineRendererExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Projector), UnityEngineProjectorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Skybox), UnityEngineSkyboxWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TrailRenderer), UnityEngineTrailRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LineRenderer), UnityEngineLineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MaterialPropertyBlock), UnityEngineMaterialPropertyBlockWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Graphics), UnityEngineGraphicsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightmapData), UnityEngineLightmapDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightProbes), UnityEngineLightProbesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightmapSettings), UnityEngineLightmapSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GeometryUtility), UnityEngineGeometryUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Screen), UnityEngineScreenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SleepTimeout), UnityEngineSleepTimeoutWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GL), UnityEngineGLWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MeshRenderer), UnityEngineMeshRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectTransformsToLDR), UnityEngineImageEffectTransformsToLDRWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectAllowedInSceneView), UnityEngineImageEffectAllowedInSceneViewWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ImageEffectOpaque), UnityEngineImageEffectOpaqueWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectOffset), UnityEngineRectOffsetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIElement), UnityEngineGUIElementWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUITexture), UnityEngineGUITextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayer), UnityEngineGUILayerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Touch), UnityEngineTouchWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AccelerationEvent), UnityEngineAccelerationEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Gyroscope), UnityEngineGyroscopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LocationInfo), UnityEngineLocationInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LocationService), UnityEngineLocationServiceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Compass), UnityEngineCompassWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightProbeGroup), UnityEngineLightProbeGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LightProbeProxyVolume), UnityEngineLightProbeProxyVolumeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LOD), UnityEngineLODWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.LODGroup), UnityEngineLODGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Matrix4x4), UnityEngineMatrix4x4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mesh), UnityEngineMeshWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Diagnostics.PlayerConnection), UnityEngineDiagnosticsPlayerConnectionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefsException), UnityEnginePlayerPrefsExceptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefs), UnityEnginePlayerPrefsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Random), UnityEngineRandomWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Random.State), UnityEngineRandomStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ReflectionProbe), UnityEngineReflectionProbeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rendering.GraphicsSettings), UnityEngineRenderingGraphicsSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rendering.CommandBuffer), UnityEngineRenderingCommandBufferWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ResourceRequest), UnityEngineResourceRequestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Security), UnityEngineSecurityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Shader), UnityEngineShaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Material), UnityEngineMaterialWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SortingLayer), UnityEngineSortingLayerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rendering.SphericalHarmonicsL2), UnityEngineRenderingSphericalHarmonicsL2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rendering.SplashScreen), UnityEngineRenderingSplashScreenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Sprite), UnityEngineSpriteWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SpriteRenderer), UnityEngineSpriteRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Sprites.DataUtility), UnityEngineSpritesDataUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ProceduralPropertyDescription), UnityEngineProceduralPropertyDescriptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ProceduralMaterial), UnityEngineProceduralMaterialWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ProceduralTexture), UnityEngineProceduralTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Texture), UnityEngineTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Cubemap), UnityEngineCubemapWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Texture3D), UnityEngineTexture3DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Texture2DArray), UnityEngineTexture2DArrayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CubemapArray), UnityEngineCubemapArrayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SparseTexture), UnityEngineSparseTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderTexture), UnityEngineRenderTextureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Hash128), UnityEngineHash128Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWWForm), UnityEngineWWWFormWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UnityEventQueueSystem), UnityEngineUnityEventQueueSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.DynamicGI), UnityEngineDynamicGIWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.Scene), UnityEngineSceneManagementSceneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneManager), UnityEngineSceneManagementSceneManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SceneManagement.SceneUtility), UnityEngineSceneManagementSceneUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Profiling.Profiler), UnityEngineProfilingProfilerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Profiling.Recorder), UnityEngineProfilingRecorderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Profiling.Sampler), UnityEngineProfilingSamplerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Profiling.CustomSampler), UnityEngineProfilingCustomSamplerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WindZone), UnityEngineWindZoneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.DrivenRectTransformTracker), UnityEngineDrivenRectTransformTrackerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rendering.SortingGroup), UnityEngineRenderingSortingGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.Burst), UnityEngineParticleSystemBurstWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MinMaxCurve), UnityEngineParticleSystemMinMaxCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MinMaxGradient), UnityEngineParticleSystemMinMaxGradientWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MainModule), UnityEngineParticleSystemMainModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.EmissionModule), UnityEngineParticleSystemEmissionModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ShapeModule), UnityEngineParticleSystemShapeModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.VelocityOverLifetimeModule), UnityEngineParticleSystemVelocityOverLifetimeModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule), UnityEngineParticleSystemLimitVelocityOverLifetimeModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.InheritVelocityModule), UnityEngineParticleSystemInheritVelocityModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ForceOverLifetimeModule), UnityEngineParticleSystemForceOverLifetimeModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ColorOverLifetimeModule), UnityEngineParticleSystemColorOverLifetimeModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ColorBySpeedModule), UnityEngineParticleSystemColorBySpeedModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.SizeOverLifetimeModule), UnityEngineParticleSystemSizeOverLifetimeModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.SizeBySpeedModule), UnityEngineParticleSystemSizeBySpeedModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.RotationOverLifetimeModule), UnityEngineParticleSystemRotationOverLifetimeModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.RotationBySpeedModule), UnityEngineParticleSystemRotationBySpeedModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.ExternalForcesModule), UnityEngineParticleSystemExternalForcesModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.NoiseModule), UnityEngineParticleSystemNoiseModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.CollisionModule), UnityEngineParticleSystemCollisionModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.TriggerModule), UnityEngineParticleSystemTriggerModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.SubEmittersModule), UnityEngineParticleSystemSubEmittersModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.TextureSheetAnimationModule), UnityEngineParticleSystemTextureSheetAnimationModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.LightsModule), UnityEngineParticleSystemLightsModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.TrailModule), UnityEngineParticleSystemTrailModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.CustomDataModule), UnityEngineParticleSystemCustomDataModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.Particle), UnityEngineParticleSystemParticleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.EmitParams), UnityEngineParticleSystemEmitParamsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystemRenderer), UnityEngineParticleSystemRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleCollisionEvent), UnityEngineParticleCollisionEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticlePhysicsExtensions), UnityEngineParticlePhysicsExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WheelFrictionCurve), UnityEngineWheelFrictionCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SoftJointLimit), UnityEngineSoftJointLimitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SoftJointLimitSpring), UnityEngineSoftJointLimitSpringWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointDrive), UnityEngineJointDriveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointMotor), UnityEngineJointMotorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointSpring), UnityEngineJointSpringWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointLimits), UnityEngineJointLimitsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ControllerColliderHit), UnityEngineControllerColliderHitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Collision), UnityEngineCollisionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ContactPoint), UnityEngineContactPointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rigidbody), UnityEngineRigidbodyWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Joint), UnityEngineJointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HingeJoint), UnityEngineHingeJointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SpringJoint), UnityEngineSpringJointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.FixedJoint), UnityEngineFixedJointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CharacterJoint), UnityEngineCharacterJointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ConfigurableJoint), UnityEngineConfigurableJointWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ConstantForce), UnityEngineConstantForceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Collider), UnityEngineColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BoxCollider), UnityEngineBoxColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SphereCollider), UnityEngineSphereColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MeshCollider), UnityEngineMeshColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CapsuleCollider), UnityEngineCapsuleColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), UnityEngineRaycastHitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PhysicMaterial), UnityEnginePhysicMaterialWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CharacterController), UnityEngineCharacterControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit2D), UnityEngineRaycastHit2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CircleCollider2D), UnityEngineCircleCollider2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BoxCollider2D), UnityEngineBoxCollider2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Joint2D), UnityEngineJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AreaEffector2D), UnityEngineAreaEffector2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PlatformEffector2D), UnityEnginePlatformEffector2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Physics2D), UnityEnginePhysics2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ContactFilter2D), UnityEngineContactFilter2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rigidbody2D), UnityEngineRigidbody2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Collider2D), UnityEngineCollider2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EdgeCollider2D), UnityEngineEdgeCollider2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CapsuleCollider2D), UnityEngineCapsuleCollider2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CompositeCollider2D), UnityEngineCompositeCollider2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PolygonCollider2D), UnityEnginePolygonCollider2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ColliderDistance2D), UnityEngineColliderDistance2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ContactPoint2D), UnityEngineContactPoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Collision2D), UnityEngineCollision2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointAngleLimits2D), UnityEngineJointAngleLimits2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointTranslationLimits2D), UnityEngineJointTranslationLimits2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointMotor2D), UnityEngineJointMotor2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JointSuspension2D), UnityEngineJointSuspension2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnchoredJoint2D), UnityEngineAnchoredJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SpringJoint2D), UnityEngineSpringJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.DistanceJoint2D), UnityEngineDistanceJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.FrictionJoint2D), UnityEngineFrictionJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HingeJoint2D), UnityEngineHingeJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RelativeJoint2D), UnityEngineRelativeJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SliderJoint2D), UnityEngineSliderJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TargetJoint2D), UnityEngineTargetJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.FixedJoint2D), UnityEngineFixedJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WheelJoint2D), UnityEngineWheelJoint2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PhysicsMaterial2D), UnityEnginePhysicsMaterial2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PhysicsUpdateBehaviour2D), UnityEnginePhysicsUpdateBehaviour2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ConstantForce2D), UnityEngineConstantForce2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Effector2D), UnityEngineEffector2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BuoyancyEffector2D), UnityEngineBuoyancyEffector2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PointEffector2D), UnityEnginePointEffector2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SurfaceEffector2D), UnityEngineSurfaceEffector2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WheelHit), UnityEngineWheelHitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WheelCollider), UnityEngineWheelColliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ClothSkinningCoefficient), UnityEngineClothSkinningCoefficientWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ClothSphereColliderPair), UnityEngineClothSphereColliderPairWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Cloth), UnityEngineClothWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMesh), UnityEngineAINavMeshWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshHit), UnityEngineAINavMeshHitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshTriangulation), UnityEngineAINavMeshTriangulationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshData), UnityEngineAINavMeshDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshDataInstance), UnityEngineAINavMeshDataInstanceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshLinkData), UnityEngineAINavMeshLinkDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshLinkInstance), UnityEngineAINavMeshLinkInstanceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshQueryFilter), UnityEngineAINavMeshQueryFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshAgent), UnityEngineAINavMeshAgentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshObstacle), UnityEngineAINavMeshObstacleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshPath), UnityEngineAINavMeshPathWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.OffMeshLinkData), UnityEngineAIOffMeshLinkDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.OffMeshLink), UnityEngineAIOffMeshLinkWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildSettings), UnityEngineAINavMeshBuildSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildSource), UnityEngineAINavMeshBuildSourceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuildMarkup), UnityEngineAINavMeshBuildMarkupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AI.NavMeshBuilder), UnityEngineAINavMeshBuilderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioSettings), UnityEngineAudioSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioSource), UnityEngineAudioSourceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioLowPassFilter), UnityEngineAudioLowPassFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioHighPassFilter), UnityEngineAudioHighPassFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioReverbFilter), UnityEngineAudioReverbFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWWAudioExtensions), UnityEngineWWWAudioExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioConfiguration), UnityEngineAudioConfigurationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioBehaviour), UnityEngineAudioBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioListener), UnityEngineAudioListenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioReverbZone), UnityEngineAudioReverbZoneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioDistortionFilter), UnityEngineAudioDistortionFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioEchoFilter), UnityEngineAudioEchoFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioChorusFilter), UnityEngineAudioChorusFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Microphone), UnityEngineMicrophoneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Audio.AudioMixer), UnityEngineAudioAudioMixerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Audio.AudioMixerSnapshot), UnityEngineAudioAudioMixerSnapshotWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Audio.AudioMixerGroup), UnityEngineAudioAudioMixerGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WebCamDevice), UnityEngineWebCamDeviceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.StateMachineBehaviour), UnityEngineStateMachineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorOverrideController), UnityEngineAnimatorOverrideControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationEvent), UnityEngineAnimationEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Animation), UnityEngineAnimationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimationState), UnityEngineAnimationStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorClipInfo), UnityEngineAnimatorClipInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorStateInfo), UnityEngineAnimatorStateInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorTransitionInfo), UnityEngineAnimatorTransitionInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MatchTargetWeightMask), UnityEngineMatchTargetWeightMaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorControllerParameter), UnityEngineAnimatorControllerParameterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AnimatorUtility), UnityEngineAnimatorUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SkeletonBone), UnityEngineSkeletonBoneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HumanLimit), UnityEngineHumanLimitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HumanBone), UnityEngineHumanBoneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HumanDescription), UnityEngineHumanDescriptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AvatarBuilder), UnityEngineAvatarBuilderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RuntimeAnimatorController), UnityEngineRuntimeAnimatorControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Avatar), UnityEngineAvatarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HumanTrait), UnityEngineHumanTraitWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AvatarMask), UnityEngineAvatarMaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HumanPose), UnityEngineHumanPoseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.HumanPoseHandler), UnityEngineHumanPoseHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Motion), UnityEngineMotionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextGenerationSettings), UnityEngineTextGenerationSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIText), UnityEngineGUITextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.TextMesh), UnityEngineTextMeshWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CharacterInfo), UnityEngineCharacterInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Font), UnityEngineFontWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UICharInfo), UnityEngineUICharInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UILineInfo), UnityEngineUILineInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UIVertex), UnityEngineUIVertexWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RectTransformUtility), UnityEngineRectTransformUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Canvas), UnityEngineCanvasWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ICanvasRaycastFilter), UnityEngineICanvasRaycastFilterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CanvasGroup), UnityEngineCanvasGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CanvasRenderer), UnityEngineCanvasRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Event), UnityEngineEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUI), UnityEngineGUIWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUI.Scope), UnityEngineGUIScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUI.GroupScope), UnityEngineGUIGroupScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUI.ScrollViewScope), UnityEngineGUIScrollViewScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUI.ClipScope), UnityEngineGUIClipScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIContent), UnityEngineGUIContentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayout), UnityEngineGUILayoutWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayout.HorizontalScope), UnityEngineGUILayoutHorizontalScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayout.VerticalScope), UnityEngineGUILayoutVerticalScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayout.AreaScope), UnityEngineGUILayoutAreaScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayout.ScrollViewScope), UnityEngineGUILayoutScrollViewScopeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayoutOption), UnityEngineGUILayoutOptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUILayoutUtility), UnityEngineGUILayoutUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUISettings), UnityEngineGUISettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUISkin), UnityEngineGUISkinWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIStyleState), UnityEngineGUIStyleStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIStyle), UnityEngineGUIStyleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ExitGUIException), UnityEngineExitGUIExceptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GUIUtility), UnityEngineGUIUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.JsonUtility), UnityEngineJsonUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Analytics.Analytics), UnityEngineAnalyticsAnalyticsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CrashReportHandler.CrashReportHandler), UnityEngineCrashReportHandlerCrashReportHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Analytics.PerformanceReporting), UnityEngineAnalyticsPerformanceReportingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RemoteSettings), UnityEngineRemoteSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.VR.VRSettings), UnityEngineVRVRSettingsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.VR.VRDevice), UnityEngineVRVRDeviceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.VR.VRStats), UnityEngineVRVRStatsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.VR.InputTracking), UnityEngineVRInputTrackingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Internal.VR.VRTestMock), UnityEngineInternalVRVRTestMockWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Video.VideoPlayer), UnityEngineVideoVideoPlayerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Video.VideoClip), UnityEngineVideoVideoClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.DefaultExecutionOrder), UnityEngineDefaultExecutionOrderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color32), UnityEngineColor32Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resolution), UnityEngineResolutionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderBuffer), UnityEngineRenderBufferWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RenderTargetSetup), UnityEngineRenderTargetSetupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rendering.RenderTargetIdentifier), UnityEngineRenderingRenderTargetIdentifierWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo), UnityEngineRenderingReflectionProbeBlendInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.BoneWeight), UnityEngineBoneWeightWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CombineInstance), UnityEngineCombineInstanceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Plane), UnityEnginePlaneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PropertyName), UnityEnginePropertyNameWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RangeInt), UnityEngineRangeIntWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PreferBinarySerialization), UnityEnginePreferBinarySerializationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ISerializationCallbackReceiver), UnityEngineISerializationCallbackReceiverWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.StackTraceUtility), UnityEngineStackTraceUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UnityException), UnityEngineUnityExceptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MissingComponentException), UnityEngineMissingComponentExceptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UnassignedReferenceException), UnityEngineUnassignedReferenceExceptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MissingReferenceException), UnityEngineMissingReferenceExceptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Events.UnityEventBase), UnityEngineEventsUnityEventBaseWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WaitForSecondsRealtime), UnityEngineWaitForSecondsRealtimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Assertions.Assert), UnityEngineAssertionsAssertWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Assertions.AssertionException), UnityEngineAssertionsAssertionExceptionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Assertions.Comparers.FloatComparer), UnityEngineAssertionsComparersFloatComparerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ILogger), UnityEngineILoggerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ILogHandler), UnityEngineILogHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Logger), UnityEngineLoggerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.StaticBatchingUtility), UnityEngineStaticBatchingUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IEventSystemHandler), UnityEngineEventSystemsIEventSystemHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerEnterHandler), UnityEngineEventSystemsIPointerEnterHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerExitHandler), UnityEngineEventSystemsIPointerExitHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerDownHandler), UnityEngineEventSystemsIPointerDownHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerUpHandler), UnityEngineEventSystemsIPointerUpHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerClickHandler), UnityEngineEventSystemsIPointerClickHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IBeginDragHandler), UnityEngineEventSystemsIBeginDragHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IInitializePotentialDragHandler), UnityEngineEventSystemsIInitializePotentialDragHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDragHandler), UnityEngineEventSystemsIDragHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IEndDragHandler), UnityEngineEventSystemsIEndDragHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDropHandler), UnityEngineEventSystemsIDropHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IScrollHandler), UnityEngineEventSystemsIScrollHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IUpdateSelectedHandler), UnityEngineEventSystemsIUpdateSelectedHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ISelectHandler), UnityEngineEventSystemsISelectHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDeselectHandler), UnityEngineEventSystemsIDeselectHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IMoveHandler), UnityEngineEventSystemsIMoveHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ISubmitHandler), UnityEngineEventSystemsISubmitHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ICancelHandler), UnityEngineEventSystemsICancelHandlerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventSystem), UnityEngineEventSystemsEventSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger), UnityEngineEventSystemsEventTriggerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent), UnityEngineEventSystemsEventTriggerTriggerEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.Entry), UnityEngineEventSystemsEventTriggerEntryWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ExecuteEvents), UnityEngineEventSystemsExecuteEventsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.RaycastResult), UnityEngineEventSystemsRaycastResultWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.UIBehaviour), UnityEngineEventSystemsUIBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.AxisEventData), UnityEngineEventSystemsAxisEventDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.AbstractEventData), UnityEngineEventSystemsAbstractEventDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseEventData), UnityEngineEventSystemsBaseEventDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData), UnityEngineEventSystemsPointerEventDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseInput), UnityEngineEventSystemsBaseInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseInputModule), UnityEngineEventSystemsBaseInputModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerInputModule), UnityEngineEventSystemsPointerInputModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), UnityEngineEventSystemsPointerInputModuleMouseButtonEventDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.StandaloneInputModule), UnityEngineEventSystemsStandaloneInputModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseRaycaster), UnityEngineEventSystemsBaseRaycasterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.Physics2DRaycaster), UnityEngineEventSystemsPhysics2DRaycasterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PhysicsRaycaster), UnityEngineEventSystemsPhysicsRaycasterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.AnimationTriggers), UnityEngineUIAnimationTriggersWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), UnityEngineUIButtonButtonClickedEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ICanvasElement), UnityEngineUIICanvasElementWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasUpdateRegistry), UnityEngineUICanvasUpdateRegistryWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ColorBlock), UnityEngineUIColorBlockWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls), UnityEngineUIDefaultControlsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls.Resources), UnityEngineUIDefaultControlsResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown), UnityEngineUIDropdownWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.OptionData), UnityEngineUIDropdownOptionDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.OptionDataList), UnityEngineUIDropdownOptionDataListWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.DropdownEvent), UnityEngineUIDropdownDropdownEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.FontData), UnityEngineUIFontDataWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.FontUpdateTracker), UnityEngineUIFontUpdateTrackerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Graphic), UnityEngineUIGraphicWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster), UnityEngineUIGraphicRaycasterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRegistry), UnityEngineUIGraphicRegistryWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.IMaskable), UnityEngineUIIMaskableWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField), UnityEngineUIInputFieldWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.SubmitEvent), UnityEngineUIInputFieldSubmitEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.OnChangeEvent), UnityEngineUIInputFieldOnChangeEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Mask), UnityEngineUIMaskWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic), UnityEngineUIMaskableGraphicWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent), UnityEngineUIMaskableGraphicCullStateChangedEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskUtilities), UnityEngineUIMaskUtilitiesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Navigation), UnityEngineUINavigationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.RawImage), UnityEngineUIRawImageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.RectMask2D), UnityEngineUIRectMask2DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar), UnityEngineUIScrollbarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar.ScrollEvent), UnityEngineUIScrollbarScrollEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), UnityEngineUIScrollRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent), UnityEngineUIScrollRectScrollRectEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable), UnityEngineUISelectableWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider.SliderEvent), UnityEngineUISliderSliderEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.SpriteState), UnityEngineUISpriteStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.StencilMaterial), UnityEngineUIStencilMaterialWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngineUIToggleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle.ToggleEvent), UnityEngineUIToggleToggleEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ToggleGroup), UnityEngineUIToggleGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ClipperRegistry), UnityEngineUIClipperRegistryWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Clipping), UnityEngineUIClippingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.IClipper), UnityEngineUIIClipperWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.IClippable), UnityEngineUIIClippableWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.AspectRatioFitter), UnityEngineUIAspectRatioFitterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler), UnityEngineUICanvasScalerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter), UnityEngineUIContentSizeFitterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup), UnityEngineUIGridLayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalLayoutGroup), UnityEngineUIHorizontalLayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), UnityEngineUIHorizontalOrVerticalLayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutElement), UnityEngineUIILayoutElementWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutController), UnityEngineUIILayoutControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutGroup), UnityEngineUIILayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutSelfController), UnityEngineUIILayoutSelfControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutIgnorer), UnityEngineUIILayoutIgnorerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutElement), UnityEngineUILayoutElementWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutGroup), UnityEngineUILayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutRebuilder), UnityEngineUILayoutRebuilderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutUtility), UnityEngineUILayoutUtilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.VerticalLayoutGroup), UnityEngineUIVerticalLayoutGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.IMaterialModifier), UnityEngineUIIMaterialModifierWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.VertexHelper), UnityEngineUIVertexHelperWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.BaseMeshEffect), UnityEngineUIBaseMeshEffectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.IMeshModifier), UnityEngineUIIMeshModifierWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Outline), UnityEngineUIOutlineWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.PositionAsUV1), UnityEngineUIPositionAsUV1Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.UI.Shadow), UnityEngineUIShadowWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaBehaviour), LuaBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.Pedding), XLuaTestPeddingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.MyStruct), XLuaTestMyStructWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.MyEnum), XLuaTestMyEnumWrap.__Register);
				
				translator.DelayWrapLoader(typeof(XLuaTest.NoGc), XLuaTestNoGcWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Coroutine_Runner), Coroutine_RunnerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo1Parent), Foo1ParentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo2Parent), Foo2ParentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo1Child), Foo1ChildWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo2Child), Foo2ChildWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Foo), FooWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FooExtension), FooExtensionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.DrivenClass), TutorialDrivenClassWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.DrivenClass.TestEnumInner), TutorialDrivenClassTestEnumInnerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.Calc), TutorialCalcWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Tutorial.DrivenClassExtensions), TutorialDrivenClassExtensionsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(AssetBundleManager), AssetBundleManagerWrap.__Register);
				
				
				translator.AddInterfaceBridgeCreator(typeof(InvokeLua.ICalc), InvokeLuaICalcBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(XLuaTest.IExchanger), XLuaTestIExchangerBridge.__Create);
				
				translator.AddInterfaceBridgeCreator(typeof(CSCallLua.ItfD), CSCallLuaItfDBridge.__Create);
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
