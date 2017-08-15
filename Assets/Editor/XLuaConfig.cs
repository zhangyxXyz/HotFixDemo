using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XLua;



public static class XLuaConfig
{
	[CSObjectWrapEditor.GenPath]
	public static string common_path = Application.dataPath + "/Extend/XLua/Gen/";

	[LuaCallCSharp]
	public static List<Type> LuaCallCSharp = new List<Type>() {
		typeof(System.Type),
		typeof(System.Object),
		typeof(System.Array),
		typeof(System.Func<int>),
		typeof(System.Action<string>),
		typeof(System.Action<int, string>),
		typeof(System.Action<int, Dictionary<int, System.Object>>),
		typeof(System.Collections.Generic.Dictionary<int, System.Object>),
		typeof(System.Collections.Generic.Dictionary<int, UnityEngine.Object>),
		typeof(System.Collections.Generic.List<int>),
		typeof(System.Collections.Generic.List<System.Object>),
		typeof(System.Collections.Generic.List<UnityEngine.Object>),
		typeof(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry>),

		typeof(UnityEngine.Object),
		typeof(UnityEngine.Debug),
		typeof(UnityEngine.Vector2),
		typeof(UnityEngine.Vector3),
		typeof(UnityEngine.Vector4),
		typeof(UnityEngine.Quaternion),
		typeof(UnityEngine.Color),
		typeof(UnityEngine.Ray),
		typeof(UnityEngine.Bounds),
		typeof(UnityEngine.Ray2D),
		typeof(UnityEngine.Time),
		typeof(UnityEngine.GameObject),
		typeof(UnityEngine.Component),
		typeof(UnityEngine.Behaviour),
		typeof(UnityEngine.Transform),
		typeof(UnityEngine.RectTransform),
		typeof(UnityEngine.Resources),
		typeof(UnityEngine.TextAsset),
		typeof(UnityEngine.Keyframe),
		typeof(UnityEngine.AnimationCurve),
		typeof(UnityEngine.AnimationClip),
		typeof(UnityEngine.MonoBehaviour),
		typeof(UnityEngine.ParticleSystem),
		typeof(UnityEngine.SkinnedMeshRenderer),
		typeof(UnityEngine.Renderer),
		typeof(UnityEngine.WWW),
		typeof(UnityEngine.Events.UnityEvent),
		typeof(UnityEngine.Events.UnityEvent<bool>),
		typeof(UnityEngine.Events.UnityEvent<int>),
		typeof(UnityEngine.Events.UnityEvent<float>),
		typeof(UnityEngine.Events.UnityEvent<string>),
		typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>),
		typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector2>),

		typeof(UnityEngine.TextAlignment),
		typeof(UnityEngine.TextAnchor),
		typeof(UnityEngine.TouchPhase),
		typeof(UnityEngine.RectTransform.Axis),
		typeof(UnityEngine.RectTransform.Edge),
		typeof(UnityEngine.UI.Image.FillMethod),
		typeof(UnityEngine.UI.Image.Origin180),
		typeof(UnityEngine.UI.Image.Origin360),
		typeof(UnityEngine.UI.Image.Origin90),
		typeof(UnityEngine.UI.Image.OriginHorizontal),
		typeof(UnityEngine.UI.Image.OriginVertical),
		typeof(UnityEngine.UI.Image.Type),
		typeof(UnityEngine.Texture2D),
	};

	//C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
	[CSharpCallLua]
	public static List<Type> CSharpCallLua = new List<Type>() {
		typeof(System.Action),
		typeof(System.Action<bool>),
		typeof(System.Action<int>),
		typeof(System.Action<float>),
		typeof(System.Action<string>),
		typeof(System.Func<bool>),
		typeof(System.Func<UnityEngine.UI.ILayoutElement,System.Single>),
		typeof(UnityEngine.Events.UnityAction),
		typeof(UnityEngine.Events.UnityAction<bool>),
		typeof(UnityEngine.Events.UnityAction<int>),
		typeof(UnityEngine.Events.UnityAction<float>),
		typeof(UnityEngine.Events.UnityAction<string>),
		typeof(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>),
		typeof(UnityEngine.Application.AdvertisingIdentifierCallback),
		typeof(UnityEngine.Application.LogCallback),
		typeof(UnityEngine.AudioClip.PCMReaderCallback),
		typeof(UnityEngine.AudioClip.PCMSetPositionCallback),
		typeof(UnityEngine.AudioSettings.AudioConfigurationChangeHandler),
		typeof(UnityEngine.Camera.CameraCallback),
		typeof(UnityEngine.Canvas.WillRenderCanvases),
		typeof(UnityEngine.CullingGroup.StateChanged),
		typeof(UnityEngine.Display.DisplaysUpdatedDelegate),
		typeof(UnityEngine.Font.FontTextureRebuildCallback),
		typeof(UnityEngine.GUI.WindowFunction),
		typeof(UnityEngine.RectTransform.ReapplyDrivenProperties),
		typeof(UnityEngine.UI.InputField.OnValidateInput),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>),
		typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>),
	};

	[BlackList]
	public static List<List<string>> BlackList = new List<List<string>>()  {
		new List<string>(){"UnityEngine.AnimatorControllerParameter", "name"},
		new List<string>(){"UnityEngine.AnimationClip", "averageDuration"},
		new List<string>(){"UnityEngine.AnimationClip", "averageAngularSpeed"},
		new List<string>(){"UnityEngine.AnimationClip", "averageSpeed"},
		new List<string>(){"UnityEngine.AnimationClip", "apparentSpeed"},
		new List<string>(){"UnityEngine.AnimationClip", "isLooping"},
		new List<string>(){"UnityEngine.AnimationClip", "isAnimatorMotion"},
		new List<string>(){"UnityEngine.AnimationClip", "isHumanMotion"},
		new List<string>(){"UnityEngine.Caching", "SetNoBackupFlag", typeof(string).FullName, typeof(Hash128).FullName},
		new List<string>(){"UnityEngine.Caching", "SetNoBackupFlag", typeof(string).FullName, typeof(int).FullName},
		new List<string>(){"UnityEngine.Caching", "ResetNoBackupFlag", typeof(string).FullName, typeof(Hash128).FullName},
		new List<string>(){"UnityEngine.Caching", "ResetNoBackupFlag", typeof(string).FullName, typeof(int).FullName},
		new List<string>(){"UnityEngine.Light", "areaSize"},
		new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue", typeof(string).FullName},
		new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
		new List<string>(){"UnityEngine.WWW", "movie"},
		new List<string>(){"UnityEngine.Application", "ExternalEval", typeof(string).FullName},
		new List<string>(){"UnityEngine.GameObject", "networkView"},
		new List<string>(){"UnityEngine.Component", "networkView"},
		new List<string>(){"UnityEngine.AnimatorControllerParameter", "name"},
		new List<string>(){"UnityEngine.Input", "IsJoystickPreconfigured", typeof(string).FullName},
		new List<string>(){"UnityEngine.Resources", "LoadAssetAtPath", typeof(string).FullName, typeof(Type).FullName},
		new List<string>(){"UnityEngine.GUIStyleState", "scaledBackgrounds"},
		new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
		new List<string>(){"UnityEngine.UI.Graphic", "OnRebuildRequested"},
		new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
		new List<string>(){"UnityEngine.Physics", "Raycast", typeof(Ray).FullName},
		new List<string>(){"UnityEngine.Physics", "Raycast", typeof(Ray).FullName, typeof(float).FullName, typeof(int).FullName},
		new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
		new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},  
		new List<string>(){"UnityEngine.WWWAudioExtensions", "GetMovieTexture", typeof(UnityEngine.WWW).FullName}, 

	};
   
	
	 [LuaCallCSharp]
	public static List<Type> LuaCallCSharpGenerate
	{ 
		get
		{
			List<Type> exports = new List<Type>();

			Assembly assembly = Assembly.Load("UnityEngine");
			Type[] types = assembly.GetExportedTypes();
			foreach (Type t in types)
			{
				if (filterType(t))
					exports.Add(t);
			}

			Assembly ui_assembly = Assembly.Load("UnityEngine.UI");
			Type[] ui_types = ui_assembly.GetExportedTypes();
			foreach (Type t in ui_types)
			{
				if (filterType(t))
				{
					exports.Add(t);
				}
			}
			return exports;
		}
	}
	static bool filterType(Type t)
	{
		if (t.IsDefined(typeof(ObsoleteAttribute), true))
			return false;

		if (t.IsEnum)
			return false;

		if (t == typeof(YieldInstruction) || t == typeof(Coroutine))
			return false;

		if (noUseList != null && noUseList.Count > 0)
		{
			string fullName = t.FullName;
			// check type not in nouselist
			foreach (string str in noUseList)
			{
				if (fullName.Contains(str))
				{
					return false;
				}
			}
		}
		return true;
	}

	static List<string> noUseList = new List<string>
	{      
		"HideInInspector",
		"ExecuteInEditMode",
		"AddComponentMenu",
		"ContextMenu",
		"RequireComponent",
		"DisallowMultipleComponent",
		"SerializeField",
		"AssemblyIsEditorAssembly",
		"Attribute", 
		"Types",
		"UnitySurrogateSelector",
		"TrackedReference",
		"TypeInferenceRules",
		"FFTWindow",
		"RPC",
		"Network",
		"MasterServer",
		"BitStream",
		"HostData",
		"ConnectionTesterStatus",
		//"GUI",
		"EventType",
		"EventModifiers",
		"FontStyle",
		"TextEditor",
		"TextEditorDblClickSnapping",
		"TextGenerator",
		"TextClipping",
		"Gizmos",
		"ADBannerView",
		"ADInterstitialAd",            
		"Android",
		"Tizen",
		"jvalue",
		"iPhone",
		"iOS",
		"Windows",
		"CalendarIdentifier",
		"CalendarUnit",
		"CalendarUnit",
		"ClusterInput",
		"FullScreenMovieControlMode",
		"FullScreenMovieScalingMode",
		"Handheld",
		"LocalNotification",
		"NotificationServices",
		"RemoteNotificationType",      
		"RemoteNotification",
		"SamsungTV",
		"TextureCompressionQuality",
		"TouchScreenKeyboardType",
		"TouchScreenKeyboard",
		"MovieTexture",
		"UnityEngineInternal",
		"Terrain",                            
		"Tree",
		"SplatPrototype",
		"DetailPrototype",
		"DetailRenderMode",
		"MeshSubsetCombineUtility",
		"AOT",
		"Social",
		"Enumerator",       
		"SendMouseEvents",               
		"Cursor",
		"Flash",
		"ActionScript",
		"OnRequestRebuild",
		"Ping",
		"ShaderVariantCollection",
		"SimpleJson.Reflection",
		"CoroutineTween",
		"GraphicRebuildTracker",
		"Advertisements",
		"UnityEditor",
		"WSA",
		"EventProvider",
		"Apple",
		"ClusterInput",
		"JointProjectionMode",
		"WebCamTexture",
		"Experimental",
		"Collections",
		"UnityEngine.MovieTexture",
	};
}





