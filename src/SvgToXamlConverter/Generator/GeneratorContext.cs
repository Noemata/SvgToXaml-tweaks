﻿using SvgToXamlConverter.Model.Resources;

namespace SvgToXamlConverter.Generator;

public record GeneratorContext
{
    public string NewLine { get; init; } = "\r\n";

    public bool UseCompatMode { get; init; } = false;

    public bool AddTransparentBackground { get; init; } = false;

    public bool ReuseExistingResources { get; init; } = false;

    public  bool TransformGeometry { get; init; } = true;

    public  bool WriteResources { get; init; } = false;

    public ResourceDictionary? Resources { get; init; }
}
