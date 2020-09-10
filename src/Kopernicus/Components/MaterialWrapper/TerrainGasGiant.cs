// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus.Components
{
    namespace MaterialWrapper
    {
        public class TerrainGasGiant : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                private const string shaderName = "Terrain/Gas Giant";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Cloud Pattern Texture, default = "white" {}
                public const string 		CloudPatternTextureKey = "		_CloudPatternTexture";
                public int 		CloudPatternTextureID { get; private set; }

                // Cloud Colour Map, default = "white" {}
                public const string 		CloudColorMapKey = "		_CloudColorMap";
                public int 		CloudColorMapID { get; private set; }

                // Cloud Colour Map 2, default = "white" {}
                public const string 		CloudColorMap2Key = "		_CloudColorMap2";
                public int 		CloudColorMap2ID { get; private set; }

                // Normal Map, default = "bump" {}
                public const string 		NormalMapKey = "		_NormalMap";
                public int 		NormalMapID { get; private set; }

                // Specular Color, default = (0.5,0.5,0.5,1)
                public const string 		SpecularColorKey = "		_SpecularColor";
                public int 		SpecularColorID { get; private set; }

                // Movement Texture, default = "black" {}
                public const string 		MovementTextureKey = "		_MovementTexture";
                public int 		MovementTextureID { get; private set; }

                // Band Movement Speed, default = 0.05
                public const string 		BandMovementSpeedKey = "		_BandMovementSpeed";
                public int 		BandMovementSpeedID { get; private set; }

                // Swirl Rotation Control Texture, default = "black" {}
                public const string 		SwirlRotationControlTextureKey = "		_SwirlRotationControlTexture";
                public int 		SwirlRotationControlTextureID { get; private set; }

                // Swirl Rotation Speed, default = 1
                public const string 		SwirlRotationSpeedKey = "		_SwirlRotationSpeed";
                public int 		SwirlRotationSpeedID { get; private set; }

                // Swirl Rotation Swirliness, default = 1
                public const string 		SwirlRotationSwirlinessKey = "		_SwirlRotationSwirliness";
                public int 		SwirlRotationSwirlinessID { get; private set; }

                // Swirl Pan Speed, default = -0.05
                public const string 		SwirlPanSpeedKey = "		_SwirlPanSpeed";
                public int 		SwirlPanSpeedID { get; private set; }

                // Detail Cloud Pattern Texture, default = "white" {}
                public const string 		DetailCloudPatternTextureKey = "		_DetailCloudPatternTexture";
                public int 		DetailCloudPatternTextureID { get; private set; }

                // Detail Cloud Colour Map, default = "white" {}
                public const string 		DetailCloudColorMapKey = "		_DetailCloudColorMap";
                public int 		DetailCloudColorMapID { get; private set; }

                // Detail Normal Map, default = "bump" {}
                public const string 		DetailNormalMapKey = "		_DetailNormalMap";
                public int 		DetailNormalMapID { get; private set; }

                // Detail Tiling, default = 10
                public const string 		DetailTilingKey = "		_DetailTiling";
                public int 		DetailTilingID { get; private set; }

                // Near Distance For Detail, default = 50
                public const string 		NearDistanceForDetailKey = "		_NearDistanceForDetail";
                public int 		NearDistanceForDetailID { get; private set; }

                // Near Detail, default = 0.8
                public const string 		NearDetailKey = "		_NearDetail";
                public int 		NearDetailID { get; private set; }

                // Far Distance For Detail, default = 200
                public const string 		FarDistanceForDetailKey = "		_FarDistanceForDetail";
                public int 		FarDistanceForDetailID { get; private set; }

                // Far Detail, default = 0
                public const string 		FarDetailKey = "		_FarDetail";
                public int 		FarDetailID { get; private set; }

                // Opacity, default = 1
                public const string 		[PerRendererData] OpacityKey = "		[PerRendererData] _Opacity";
                public int 		[PerRendererData] OpacityID { get; private set; }

                // Surface Into Emissive Multiplier, default = 0.5
                public const string 		SurfaceColourIntoEmissiveMultiplierKey = "		_SurfaceColourIntoEmissiveMultiplier";
                public int 		SurfaceColourIntoEmissiveMultiplierID { get; private set; }

                // Rim Power, default = 3
                public const string 		rimPowerKey = "		_rimPower";
                public int 		rimPowerID { get; private set; }

                // Rim Blend, default = 1
                public const string 		rimBlendKey = "		_rimBlend";
                public int 		rimBlendID { get; private set; }

                // RimColorRamp, default = "white" {}
                public const string 		rimColorRampKey = "		_rimColorRamp";
                public int 		rimColorRampID { get; private set; }

                // LightDirection, default = (1,0,0,0)
                public const string 		[PerRendererData] localLightDirectionKey = "		[PerRendererData] _localLightDirection";
                public int 		[PerRendererData] localLightDirectionID { get; private set; }

                // Singleton instance
                private static Properties singleton = null;
                public static Properties Instance
                {
					get
                    {
                        // Construct the singleton if it does not exist
                        if(singleton == null)
                            singleton = new Properties();
            
                        return singleton;
                    }
                }

                private Properties()
                {
					CloudPatternTextureID = Shader.PropertyToID(		CloudPatternTextureKey);
					CloudColorMapID = Shader.PropertyToID(		CloudColorMapKey);
					CloudColorMap2ID = Shader.PropertyToID(		CloudColorMap2Key);
					NormalMapID = Shader.PropertyToID(		NormalMapKey);
					SpecularColorID = Shader.PropertyToID(		SpecularColorKey);
					MovementTextureID = Shader.PropertyToID(		MovementTextureKey);
					BandMovementSpeedID = Shader.PropertyToID(		BandMovementSpeedKey);
					SwirlRotationControlTextureID = Shader.PropertyToID(		SwirlRotationControlTextureKey);
					SwirlRotationSpeedID = Shader.PropertyToID(		SwirlRotationSpeedKey);
					SwirlRotationSwirlinessID = Shader.PropertyToID(		SwirlRotationSwirlinessKey);
					SwirlPanSpeedID = Shader.PropertyToID(		SwirlPanSpeedKey);
					DetailCloudPatternTextureID = Shader.PropertyToID(		DetailCloudPatternTextureKey);
					DetailCloudColorMapID = Shader.PropertyToID(		DetailCloudColorMapKey);
					DetailNormalMapID = Shader.PropertyToID(		DetailNormalMapKey);
					DetailTilingID = Shader.PropertyToID(		DetailTilingKey);
					NearDistanceForDetailID = Shader.PropertyToID(		NearDistanceForDetailKey);
					NearDetailID = Shader.PropertyToID(		NearDetailKey);
					FarDistanceForDetailID = Shader.PropertyToID(		FarDistanceForDetailKey);
					FarDetailID = Shader.PropertyToID(		FarDetailKey);
					[PerRendererData] OpacityID = Shader.PropertyToID(		[PerRendererData] OpacityKey);
					SurfaceColourIntoEmissiveMultiplierID = Shader.PropertyToID(		SurfaceColourIntoEmissiveMultiplierKey);
					rimPowerID = Shader.PropertyToID(		rimPowerKey);
					rimBlendID = Shader.PropertyToID(		rimBlendKey);
					rimColorRampID = Shader.PropertyToID(		rimColorRampKey);
					[PerRendererData] localLightDirectionID = Shader.PropertyToID(		[PerRendererData] localLightDirectionKey);
                }
            }

            // Is some random material this material
            public static bool UsesSameShader(Material m)
            {
            	return m.shader.name == Properties.shader.name;
            }

            // Cloud Pattern Texture, default = "white" {}
            public Texture2D 		CloudPatternTexture
            {
                get { return GetTexture (Properties.Instance.		CloudPatternTextureID) as Texture2D; }
                set { SetTexture (Properties.Instance.		CloudPatternTextureID, value); }
            }

            public Vector2 		CloudPatternTextureScale
            {
                get { return GetTextureScale (Properties.		CloudPatternTextureKey); }
                set { SetTextureScale (Properties.		CloudPatternTextureKey, value); }
            }

            public Vector2 		CloudPatternTextureOffset
            {
                get { return GetTextureOffset (Properties.		CloudPatternTextureKey); }
                set { SetTextureOffset (Properties.		CloudPatternTextureKey, value); }
            }

            // Cloud Colour Map, default = "white" {}
            public Texture2D 		CloudColorMap
            {
                get { return GetTexture (Properties.Instance.		CloudColorMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.		CloudColorMapID, value); }
            }

            public Vector2 		CloudColorMapScale
            {
                get { return GetTextureScale (Properties.		CloudColorMapKey); }
                set { SetTextureScale (Properties.		CloudColorMapKey, value); }
            }

            public Vector2 		CloudColorMapOffset
            {
                get { return GetTextureOffset (Properties.		CloudColorMapKey); }
                set { SetTextureOffset (Properties.		CloudColorMapKey, value); }
            }

            // Cloud Colour Map 2, default = "white" {}
            public Texture2D 		CloudColorMap2
            {
                get { return GetTexture (Properties.Instance.		CloudColorMap2ID) as Texture2D; }
                set { SetTexture (Properties.Instance.		CloudColorMap2ID, value); }
            }

            public Vector2 		CloudColorMap2Scale
            {
                get { return GetTextureScale (Properties.		CloudColorMap2Key); }
                set { SetTextureScale (Properties.		CloudColorMap2Key, value); }
            }

            public Vector2 		CloudColorMap2Offset
            {
                get { return GetTextureOffset (Properties.		CloudColorMap2Key); }
                set { SetTextureOffset (Properties.		CloudColorMap2Key, value); }
            }

            // Normal Map, default = "bump" {}
            public Texture2D 		NormalMap
            {
                get { return GetTexture (Properties.Instance.		NormalMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.		NormalMapID, value); }
            }

            public Vector2 		NormalMapScale
            {
                get { return GetTextureScale (Properties.		NormalMapKey); }
                set { SetTextureScale (Properties.		NormalMapKey, value); }
            }

            public Vector2 		NormalMapOffset
            {
                get { return GetTextureOffset (Properties.		NormalMapKey); }
                set { SetTextureOffset (Properties.		NormalMapKey, value); }
            }

            // Specular Color, default = (0.5,0.5,0.5,1)
            public Vector4 		SpecularColor
            {
                get { return GetVector (Properties.Instance.		SpecularColorID); }
                set { SetVector (Properties.Instance.		SpecularColorID, value); }
            }

            // Movement Texture, default = "black" {}
            public Texture2D 		MovementTexture
            {
                get { return GetTexture (Properties.Instance.		MovementTextureID) as Texture2D; }
                set { SetTexture (Properties.Instance.		MovementTextureID, value); }
            }

            public Vector2 		MovementTextureScale
            {
                get { return GetTextureScale (Properties.		MovementTextureKey); }
                set { SetTextureScale (Properties.		MovementTextureKey, value); }
            }

            public Vector2 		MovementTextureOffset
            {
                get { return GetTextureOffset (Properties.		MovementTextureKey); }
                set { SetTextureOffset (Properties.		MovementTextureKey, value); }
            }

            // Band Movement Speed, default = 0.05
            public float 		BandMovementSpeed
            {
                get { return GetFloat (Properties.Instance.		BandMovementSpeedID); }
                set { SetFloat (Properties.Instance.		BandMovementSpeedID, Mathf.Clamp(value,-10f, 10f)); }
            }

            // Swirl Rotation Control Texture, default = "black" {}
            public Texture2D 		SwirlRotationControlTexture
            {
                get { return GetTexture (Properties.Instance.		SwirlRotationControlTextureID) as Texture2D; }
                set { SetTexture (Properties.Instance.		SwirlRotationControlTextureID, value); }
            }

            public Vector2 		SwirlRotationControlTextureScale
            {
                get { return GetTextureScale (Properties.		SwirlRotationControlTextureKey); }
                set { SetTextureScale (Properties.		SwirlRotationControlTextureKey, value); }
            }

            public Vector2 		SwirlRotationControlTextureOffset
            {
                get { return GetTextureOffset (Properties.		SwirlRotationControlTextureKey); }
                set { SetTextureOffset (Properties.		SwirlRotationControlTextureKey, value); }
            }

            // Swirl Rotation Speed, default = 1
            public float 		SwirlRotationSpeed
            {
                get { return GetFloat (Properties.Instance.		SwirlRotationSpeedID); }
                set { SetFloat (Properties.Instance.		SwirlRotationSpeedID, Mathf.Clamp(value,0f, 10f)); }
            }

            // Swirl Rotation Swirliness, default = 1
            public float 		SwirlRotationSwirliness
            {
                get { return GetFloat (Properties.Instance.		SwirlRotationSwirlinessID); }
                set { SetFloat (Properties.Instance.		SwirlRotationSwirlinessID, Mathf.Clamp(value,-10f, 10f)); }
            }

            // Swirl Pan Speed, default = -0.05
            public float 		SwirlPanSpeed
            {
                get { return GetFloat (Properties.Instance.		SwirlPanSpeedID); }
                set { SetFloat (Properties.Instance.		SwirlPanSpeedID, Mathf.Clamp(value,-10f, 10f)); }
            }

            // Detail Cloud Pattern Texture, default = "white" {}
            public Texture2D 		DetailCloudPatternTexture
            {
                get { return GetTexture (Properties.Instance.		DetailCloudPatternTextureID) as Texture2D; }
                set { SetTexture (Properties.Instance.		DetailCloudPatternTextureID, value); }
            }

            public Vector2 		DetailCloudPatternTextureScale
            {
                get { return GetTextureScale (Properties.		DetailCloudPatternTextureKey); }
                set { SetTextureScale (Properties.		DetailCloudPatternTextureKey, value); }
            }

            public Vector2 		DetailCloudPatternTextureOffset
            {
                get { return GetTextureOffset (Properties.		DetailCloudPatternTextureKey); }
                set { SetTextureOffset (Properties.		DetailCloudPatternTextureKey, value); }
            }

            // Detail Cloud Colour Map, default = "white" {}
            public Texture2D 		DetailCloudColorMap
            {
                get { return GetTexture (Properties.Instance.		DetailCloudColorMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.		DetailCloudColorMapID, value); }
            }

            public Vector2 		DetailCloudColorMapScale
            {
                get { return GetTextureScale (Properties.		DetailCloudColorMapKey); }
                set { SetTextureScale (Properties.		DetailCloudColorMapKey, value); }
            }

            public Vector2 		DetailCloudColorMapOffset
            {
                get { return GetTextureOffset (Properties.		DetailCloudColorMapKey); }
                set { SetTextureOffset (Properties.		DetailCloudColorMapKey, value); }
            }

            // Detail Normal Map, default = "bump" {}
            public Texture2D 		DetailNormalMap
            {
                get { return GetTexture (Properties.Instance.		DetailNormalMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.		DetailNormalMapID, value); }
            }

            public Vector2 		DetailNormalMapScale
            {
                get { return GetTextureScale (Properties.		DetailNormalMapKey); }
                set { SetTextureScale (Properties.		DetailNormalMapKey, value); }
            }

            public Vector2 		DetailNormalMapOffset
            {
                get { return GetTextureOffset (Properties.		DetailNormalMapKey); }
                set { SetTextureOffset (Properties.		DetailNormalMapKey, value); }
            }

            // Detail Tiling, default = 10
            public float 		DetailTiling
            {
                get { return GetFloat (Properties.Instance.		DetailTilingID); }
                set { SetFloat (Properties.Instance.		DetailTilingID, value); }
            }

            // Near Distance For Detail, default = 50
            public float 		NearDistanceForDetail
            {
                get { return GetFloat (Properties.Instance.		NearDistanceForDetailID); }
                set { SetFloat (Properties.Instance.		NearDistanceForDetailID, value); }
            }

            // Near Detail, default = 0.8
            public float 		NearDetail
            {
                get { return GetFloat (Properties.Instance.		NearDetailID); }
                set { SetFloat (Properties.Instance.		NearDetailID, value); }
            }

            // Far Distance For Detail, default = 200
            public float 		FarDistanceForDetail
            {
                get { return GetFloat (Properties.Instance.		FarDistanceForDetailID); }
                set { SetFloat (Properties.Instance.		FarDistanceForDetailID, value); }
            }

            // Far Detail, default = 0
            public float 		FarDetail
            {
                get { return GetFloat (Properties.Instance.		FarDetailID); }
                set { SetFloat (Properties.Instance.		FarDetailID, value); }
            }

            // Opacity, default = 1
            public float 		[PerRendererData] Opacity
            {
                get { return GetFloat (Properties.Instance.		[PerRendererData] OpacityID); }
                set { SetFloat (Properties.Instance.		[PerRendererData] OpacityID, Mathf.Clamp(value,0f, 1f)); }
            }

            // Surface Into Emissive Multiplier, default = 0.5
            public float 		SurfaceColourIntoEmissiveMultiplier
            {
                get { return GetFloat (Properties.Instance.		SurfaceColourIntoEmissiveMultiplierID); }
                set { SetFloat (Properties.Instance.		SurfaceColourIntoEmissiveMultiplierID, Mathf.Clamp(value,0f, 1f)); }
            }

            // Rim Power, default = 3
            public float 		rimPower
            {
                get { return GetFloat (Properties.Instance.		rimPowerID); }
                set { SetFloat (Properties.Instance.		rimPowerID, value); }
            }

            // Rim Blend, default = 1
            public float 		rimBlend
            {
                get { return GetFloat (Properties.Instance.		rimBlendID); }
                set { SetFloat (Properties.Instance.		rimBlendID, value); }
            }

            // RimColorRamp, default = "white" {}
            public Texture2D 		rimColorRamp
            {
                get { return GetTexture (Properties.Instance.		rimColorRampID) as Texture2D; }
                set { SetTexture (Properties.Instance.		rimColorRampID, value); }
            }

            public Vector2 		rimColorRampScale
            {
                get { return GetTextureScale (Properties.		rimColorRampKey); }
                set { SetTextureScale (Properties.		rimColorRampKey, value); }
            }

            public Vector2 		rimColorRampOffset
            {
                get { return GetTextureOffset (Properties.		rimColorRampKey); }
                set { SetTextureOffset (Properties.		rimColorRampKey, value); }
            }

            // LightDirection, default = (1,0,0,0)
            public Vector4 		[PerRendererData] localLightDirection
            {
                get { return GetVector (Properties.Instance.		[PerRendererData] localLightDirectionID); }
                set { SetVector (Properties.Instance.		[PerRendererData] localLightDirectionID, value); }
            }

            public TerrainGasGiant() : base(Properties.shader)
            {
            }

            public TerrainGasGiant(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public TerrainGasGiant(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/Gas Giant shader required");
            }

        }
    }
}
