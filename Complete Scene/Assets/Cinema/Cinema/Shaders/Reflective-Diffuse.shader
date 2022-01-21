Shader "Rflective_Lightmapped_Diffuse" {

   Properties {

    _Color ("Main Color", Color) = (1,1,1,1)

    _ReflectColor ("Reflection Color", Color) = (1,1,1,0.5)

    _MainTex ("Texture", 2D) = "white" {} 

    _Cube ("Reflection Cubemap", Cube) = "_Skybox" { TexGen CubeReflect }

    

    _Illum ("Lightmap", 2D) = "white" { LightmapMode }

}

SubShader {

 

Pass {

 

 

   

    

        BindChannels {

                    Bind "Vertex", vertex

                    Bind "texcoord", texcoord0

                    Bind "texcoord1", texcoord1

                        } 

    

    SetTexture [_MainTex] {

        constantColor [_Color]

        Combine texture * constant

        

    }

    SetTexture [_Illum] {

    

         Combine texture * previous

    }

}

 

Pass {

Blend One One

  

 

    SetTexture [_Cube] {

    

        constantColor [_ReflectColor] 

        Combine  texture * constant

    

                

                

        

    

                                }

 

 

    } 

 

 

}

}