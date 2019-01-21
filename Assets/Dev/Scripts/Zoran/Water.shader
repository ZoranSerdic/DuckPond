//Gemaakt met behulp van https://www.youtube.com/watch?v=lWCPFwxZpVg
//Gemaakt door Ayoub Lamdaghri

Shader "Custom/Water" 
{
	Properties
	{
		m_MainTex("Albedo Texture", 2D) = "White"{}
		m_Color("Color", Color) = (0,0,0,1)
		m_Strength("Strength", Range(0, 2)) = 1.0
		m_Speed("Speed", Range(-200, 200)) = 100
		m_Transparency("Transparency", Range(0.0, 5)) = 0.25
	}
		SubShader
		{
			Tags{"Queue" = "Transparent" "Rendertype" = "Transparent"}

			Pass{

				Cull Off

				CGPROGRAM

				#pragma vertex vertexFunc

				#pragma fragment fragmentFunc

				float4 m_MainTex;
				float4 m_Color;
				float m_Strength;
				float m_Speed;
				float m_Transparency;

				struct vertexInput
				{
					float4 vertex : POSITION;
				};

				struct vertexOutput
				{
					float4 pos : SV_POSITION;
				};

				struct v2f 
				{
					float2 uv : TEXTCOORD0;
					float4 vertex : SV_POSITION;
				};

				vertexOutput vertexFunc(vertexInput IN)
				{
					vertexOutput o;

					float4 worldpos = mul(unity_ObjectToWorld, IN.vertex);

					float displacement = (cos(worldpos.y) + cos(worldpos.x + (m_Speed * _Time)));

					worldpos.y = worldpos.y + (displacement * m_Strength);

					o.pos = mul(UNITY_MATRIX_VP, worldpos);

					return o;
				};

				float4 fragmentFunc(vertexOutput IN) : COLOR
				{
					return m_Color;
				}

				fixed4 frag(v2f i) : SV_Target
				{
					fixed4 color = /*tex2D(m_MainTex, i.uv) +*/ m_Color;
					color.a = m_Transparency;
					return color;
				}


				ENDCG
			}
		}
	FallBack "Diffuse"
}
