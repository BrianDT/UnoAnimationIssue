// <copyright file="SmokeViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2016-2024 All rights reserved</copyright>

namespace UnoAnimationIssue;

using System;
using System.Collections.Generic;
using System.Text;
using Vssl.Samples.ViewModels;

/// <summary>
/// The view model for a single smoke circle
/// </summary>
public class SmokeViewModel : BaseViewModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmokeViewModel"/> class
    /// </summary>
    public SmokeViewModel()
    {
        this.Diameter = 10.0D;
    }

    /// <summary>
    /// Gets the diameter of the smoke ring
    /// </summary>
    public double Diameter { get; private set; }
}
