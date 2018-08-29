Shader "Unlit/Rainbow"
{
	Properties
	{
		_MainTex ("Color (RGB) Alpha (A)", 2D) = "white" {}
	    _WaveSpeed ("WaveSpeed", Range(-1000, 1000)) = 20
		_Frequency ("Frequency", Range(0, 100)) = 10
		_Amplitude ("Amplitude", Range(0, 3)) = 0.02
		_RedScale ("RedScale", Range(0, 3)) = 1
		_GreenScale ("GreenScale", Range(0, 3)) = 0
		_BlueScale ("BlueScale", range(0, 3)) = 1

	}
	SubShader
	{
		Tags {"Queue" = "Transparent" "RenderType" = "Transparent" }
		Blend SrcAlpha OneMinusSrcAlpha
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			fixed _Frequency;
			fixed _WaveSpeed;
			fixed _Amplitude;
			fixed _RedScale;
			fixed _GreenScale;
			fixed _BlueScale;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed2 uvs = i.uv;
				fixed4 col = tex2D(_MainTex, uvs);
				fixed d = sin(uvs.y * _Frequency + _Time * _WaveSpeed) * _Amplitude;
				col.r += d * _RedScale; 
				col.g += d * _GreenScale;
				col.b += d * _BlueScale;
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG
		}
	}
}
