Shader "Amazing Assets/Curved World/Nature/SpeedTree8"
{
    Properties
    {
        [CurvedWorldBendSettings] _CurvedWorldBendSettings("0|1|1", Vector) = (0, 0, 0, 0)

        _MainTex ("Base (RGB) Transparency (A)", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)

        [Toggle(EFFECT_HUE_VARIATION)] _HueVariationKwToggle("Hue Variation", Float) = 0
        _HueVariationColor ("Hue Variation Color", Color) = (1.0,0.5,0.0,0.1)

        [Toggle(EFFECT_BUMP)] _NormalMapKwToggle("Normal Mapping", Float) = 0
        _BumpMap("Normal Map", 2D) = "bump" {}

        _ExtraTex ("Smoothness (R), Metallic (G), AO (B)", 2D) = "(0.5, 0.0, 1.0)" {}
        _Glossiness ("Smoothness", Range(0.0, 1.0)) = 0.5
        _Metallic ("Metallic", Range(0.0, 1.0)) = 0.0

        [Toggle(EFFECT_SUBSURFACE)] _SubsurfaceKwToggle("Subsurface", Float) = 0
        _SubsurfaceTex ("Subsurface (RGB)", 2D) = "white" {}
        _SubsurfaceColor ("Subsurface Color", Color) = (1,1,1,1)
        _SubsurfaceIndirect ("Subsurface Indirect", Range(0.0, 1.0)) = 0.25

        [Toggle(EFFECT_BILLBOARD)] _BillboardKwToggle("Billboard", Float) = 0
        _BillboardShadowFade ("Billboard Shadow Fade", Range(0.0, 1.0)) = 0.5

        [Enum(No,2,Yes,0)] _TwoSided ("Two Sided", Int) = 2 // enum matches cull mode
        [KeywordEnum(None,Fastest,Fast,Better,Best,Palm)] _WindQuality ("Wind Quality", Range(0,5)) = 0
    }

    SubShader
    {
        Tags
        {
            "Queue"="AlphaTest"
            "IgnoreProjector"="True"
            "RenderType"="TransparentCutout"
            "DisableBatching"="LODFading"
            "RenderPipeline" = "UniversalPipeline"
            "UniversalMaterialType" = "Lit"
        }
        LOD 400
        Cull [_TwoSided]

        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }

            HLSLPROGRAM

            #pragma vertex SpeedTree8Vert
            #pragma fragment SpeedTree8Frag

            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile _ _SHADOWS_SOFT
            #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
            #pragma multi_compile_vertex LOD_FADE_PERCENTAGE
            #pragma multi_compile __ LOD_FADE_CROSSFADE
            #pragma multi_compile_fog

            #pragma multi_compile_instancing
            #pragma instancing_options assumeuniformscaling maxcount:50

            #pragma shader_feature_local _WINDQUALITY_NONE _WINDQUALITY_FASTEST _WINDQUALITY_FAST _WINDQUALITY_BETTER _WINDQUALITY_BEST _WINDQUALITY_PALM
            #pragma shader_feature_local EFFECT_BILLBOARD
            #pragma shader_feature_local EFFECT_HUE_VARIATION
            #pragma shader_feature_local EFFECT_SUBSURFACE
            #pragma shader_feature_local EFFECT_BUMP
            #pragma shader_feature_local EFFECT_EXTRA_TEX

            #define ENABLE_WIND
            #define EFFECT_BACKSIDE_NORMALS

            #include "Packages/com.unity.render-pipelines.universal/Shaders/Nature/SpeedTree8Input.hlsl"


#define CURVEDWORLD_BEND_TYPE_CLASSICRUNNER_X_POSITIVE
#define CURVEDWORLD_BEND_ID_1
#pragma shader_feature_local CURVEDWORLD_DISABLED_ON
#pragma shader_feature_local CURVEDWORLD_NORMAL_TRANSFORMATION_ON    
#include "../../Core/CurvedWorldTransform.cginc"

            #include "SpeedTree8Passes.hlsl"

            ENDHLSL
        }		

        Pass
        {
            Name "SceneSelectionPass"
            Tags{"LightMode" = "SceneSelectionPass"}

            HLSLPROGRAM

            #pragma vertex SpeedTree8VertDepth
            #pragma fragment SpeedTree8FragDepth

            #pragma multi_compile_vertex LOD_FADE_PERCENTAGE
            #pragma multi_compile __ LOD_FADE_CROSSFADE
            #pragma multi_compile_instancing
            #pragma instancing_options assumeuniformscaling maxcount:50

            #pragma shader_feature_local _WINDQUALITY_NONE _WINDQUALITY_FASTEST _WINDQUALITY_FAST _WINDQUALITY_BETTER _WINDQUALITY_BEST _WINDQUALITY_PALM
            #pragma shader_feature_local EFFECT_BILLBOARD

            #define ENABLE_WIND
            #define DEPTH_ONLY
            #define SCENESELECTIONPASS

            #include "Packages/com.unity.render-pipelines.universal/Shaders/Nature/SpeedTree8Input.hlsl"


#define CURVEDWORLD_BEND_TYPE_CLASSICRUNNER_X_POSITIVE
#define CURVEDWORLD_BEND_ID_1
#pragma shader_feature_local CURVEDWORLD_DISABLED_ON
#pragma shader_feature_local CURVEDWORLD_NORMAL_TRANSFORMATION_ON    
#include "../../Core/CurvedWorldTransform.cginc"


            #include "SpeedTree8Passes.hlsl"

            ENDHLSL
        }
        
        Pass
        {
            Name "GBuffer"
            Tags{"LightMode" = "UniversalGBuffer"}

            HLSLPROGRAM
            #pragma exclude_renderers gles
            #pragma vertex SpeedTree8Vert
            #pragma fragment SpeedTree8Frag

            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_CASCADE
            //#pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            //#pragma multi_compile _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile _ _SHADOWS_SOFT
            #pragma multi_compile_vertex LOD_FADE_PERCENTAGE
            #pragma multi_compile __ LOD_FADE_CROSSFADE
            #pragma multi_compile_fragment _ _GBUFFER_NORMALS_OCT

            #pragma multi_compile_instancing
            #pragma instancing_options assumeuniformscaling maxcount:50

            #pragma shader_feature_local _WINDQUALITY_NONE _WINDQUALITY_FASTEST _WINDQUALITY_FAST _WINDQUALITY_BETTER _WINDQUALITY_BEST _WINDQUALITY_PALM
            #pragma shader_feature_local EFFECT_BILLBOARD
            #pragma shader_feature_local EFFECT_HUE_VARIATION
            #pragma shader_feature_local EFFECT_SUBSURFACE
            #pragma shader_feature_local EFFECT_BUMP
            #pragma shader_feature_local EFFECT_EXTRA_TEX

            #define ENABLE_WIND
            #define EFFECT_BACKSIDE_NORMALS
            #define GBUFFER

            #include "Packages/com.unity.render-pipelines.universal/Shaders/Nature/SpeedTree8Input.hlsl"


#define CURVEDWORLD_BEND_TYPE_CLASSICRUNNER_X_POSITIVE
#define CURVEDWORLD_BEND_ID_1
#pragma shader_feature_local CURVEDWORLD_DISABLED_ON
#pragma shader_feature_local CURVEDWORLD_NORMAL_TRANSFORMATION_ON    
#include "../../Core/CurvedWorldTransform.cginc"


            #include "SpeedTree8Passes.hlsl"

            ENDHLSL
        }
        
        Pass
        {
            Name "ShadowCaster"
            Tags{"LightMode" = "ShadowCaster"}

            ColorMask 0

            HLSLPROGRAM

            #pragma vertex SpeedTree8VertDepth
            #pragma fragment SpeedTree8FragDepth

            #pragma multi_compile_vertex LOD_FADE_PERCENTAGE
            #pragma multi_compile __ LOD_FADE_CROSSFADE
            #pragma multi_compile_instancing
            #pragma instancing_options assumeuniformscaling maxcount:50

            #pragma shader_feature_local _WINDQUALITY_NONE _WINDQUALITY_FASTEST _WINDQUALITY_FAST _WINDQUALITY_BETTER _WINDQUALITY_BEST _WINDQUALITY_PALM
            #pragma shader_feature_local EFFECT_BILLBOARD

            #define ENABLE_WIND
            #define DEPTH_ONLY
            #define SHADOW_CASTER

            #include "Packages/com.unity.render-pipelines.universal/Shaders/Nature/SpeedTree8Input.hlsl"


#define CURVEDWORLD_BEND_TYPE_CLASSICRUNNER_X_POSITIVE
#define CURVEDWORLD_BEND_ID_1
#pragma shader_feature_local CURVEDWORLD_DISABLED_ON
#pragma shader_feature_local CURVEDWORLD_NORMAL_TRANSFORMATION_ON    
#include "../../Core/CurvedWorldTransform.cginc"


            #include "SpeedTree8Passes.hlsl"
            ENDHLSL
        }

        Pass
        {
            Name "DepthOnly"
            Tags{"LightMode" = "DepthOnly"}

            ZWrite On
            ColorMask 0

            HLSLPROGRAM

            #pragma vertex SpeedTree8VertDepth
            #pragma fragment SpeedTree8FragDepth

            #pragma multi_compile_vertex LOD_FADE_PERCENTAGE
            #pragma multi_compile __ LOD_FADE_CROSSFADE
            #pragma multi_compile_instancing
            #pragma instancing_options assumeuniformscaling maxcount:50

            #pragma shader_feature_local _WINDQUALITY_NONE _WINDQUALITY_FASTEST _WINDQUALITY_FAST _WINDQUALITY_BETTER _WINDQUALITY_BEST _WINDQUALITY_PALM
            #pragma shader_feature_local EFFECT_BILLBOARD

            #define ENABLE_WIND
            #define DEPTH_ONLY

            #include "Packages/com.unity.render-pipelines.universal/Shaders/Nature/SpeedTree8Input.hlsl"


#define CURVEDWORLD_BEND_TYPE_CLASSICRUNNER_X_POSITIVE
#define CURVEDWORLD_BEND_ID_1
#pragma shader_feature_local CURVEDWORLD_DISABLED_ON
#pragma shader_feature_local CURVEDWORLD_NORMAL_TRANSFORMATION_ON    
#include "../../Core/CurvedWorldTransform.cginc"


            #include "SpeedTree8Passes.hlsl"

            ENDHLSL
        }
		
		// This pass is used when drawing to a _CameraNormalsTexture texture
        Pass
        {
            Name "DepthNormals"
            Tags{"LightMode" = "DepthNormals"}

            ZWrite On

            HLSLPROGRAM
            #pragma vertex SpeedTree8VertDepthNormal
            #pragma fragment SpeedTree8FragDepthNormal

            #pragma shader_feature_local _WINDQUALITY_NONE _WINDQUALITY_FASTEST _WINDQUALITY_FAST _WINDQUALITY_BETTER _WINDQUALITY_BEST _WINDQUALITY_PALM
            #pragma shader_feature_local EFFECT_BUMP

            #pragma multi_compile_instancing
            #pragma multi_compile_vertex LOD_FADE_PERCENTAGE
            #pragma multi_compile __ LOD_FADE_CROSSFADE

            #pragma instancing_options assumeuniformscaling maxcount:50

            #define ENABLE_WIND
            #define EFFECT_BACKSIDE_NORMALS

            #include "Packages/com.unity.render-pipelines.universal/Shaders/Nature/SpeedTree8Input.hlsl"


#define CURVEDWORLD_BEND_TYPE_CLASSICRUNNER_X_POSITIVE
#define CURVEDWORLD_BEND_ID_1
#pragma shader_feature_local CURVEDWORLD_DISABLED_ON
#pragma shader_feature_local CURVEDWORLD_NORMAL_TRANSFORMATION_ON    
#include "../../Core/CurvedWorldTransform.cginc"


            #include "SpeedTree8Passes.hlsl"
            ENDHLSL
        }

        //PassName "ScenePickingPass"
		Pass
        {
            Name "ScenePickingPass"
            Tags { "LightMode" = "Picking" }

            BlendOp Add
            Blend One Zero
            ZWrite On
            Cull Off

            CGPROGRAM
			#include "HLSLSupport.cginc"
			#include "UnityShaderVariables.cginc"
			#include "UnityShaderUtilities.cginc"


            #pragma target 3.0

            #define CUTOUT_0_3
            #pragma multi_compile_instancing

            #pragma vertex vertEditorPass
            #pragma fragment fragScenePickingPass


#define CURVEDWORLD_BEND_TYPE_CLASSICRUNNER_X_POSITIVE
#define CURVEDWORLD_BEND_ID_1
#pragma shader_feature_local CURVEDWORLD_DISABLED_ON


            #include "../../Core/SceneSelection.cginc" 
            ENDCG
        }	//Pass "ScenePickingPass"	
    }

    CustomEditor "AmazingAssets.CurvedWorldEditor.SpeedTree8ShaderGUI"
}
