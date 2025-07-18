﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[CreateAssetMenu(menuName = "Rendering/Universal Render Pipeline/Curved World RP (Pipeline Asset)")]
public class CurvedWorldRenderPipeline : UniversalRenderPipelineAsset
{

    public Shader detailLitShader;
    public Shader wavingGrassShader;
    public Shader wavingGrassBillboardShader;


    public override Shader terrainDetailLitShader => detailLitShader;
    public override Shader terrainDetailGrassShader => wavingGrassShader;
    public override Shader terrainDetailGrassBillboardShader => wavingGrassBillboardShader;
}

