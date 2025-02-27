#ifndef CUSTOM_LIGHTING_INCLUDED
#define CUSTOM_LIGHTING_INCLUDED

// Obtiene una posicion en el mundo y nos regresa una direccion y color de la luz de unity
void CalculateLight_float(float3 WorldPos, out float3 Direction, out float3 Color)
{
    #if SHADERGRAPH_PREVIEW
    Direction = float3(0.5f,0.5f,0);
    Color = 1;
    #else
    Light mainLight = GetMainLight(0);
    Direction = mainLight.direction;
    Color = mainLight.color;
    #endif
}
#endif