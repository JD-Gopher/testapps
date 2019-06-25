﻿using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Console;

namespace versioninfo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**.NET Core info**");
            WriteLine($"Environment.Version: {Environment.Version}");
            WriteLine($"RuntimeInformation.FrameworkDescription: {RuntimeInformation.FrameworkDescription}");
            WriteLine($"CoreCLR Build: {((AssemblyInformationalVersionAttribute[])typeof(object).Assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute),false))[0].InformationalVersion.Split('+')[0]}");
            WriteLine($"CoreCLR Hash: {((AssemblyInformationalVersionAttribute[])typeof(object).Assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false))[0].InformationalVersion.Split('+')[1]}");
            WriteLine($"CoreFX Build: {((AssemblyInformationalVersionAttribute[])typeof(Uri).Assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute),false))[0].InformationalVersion.Split('+')[0]}");
            WriteLine($"CoreFX Hash: {((AssemblyInformationalVersionAttribute[])typeof(Uri).Assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false))[0].InformationalVersion.Split('+')[1]}");
            WriteLine();
            WriteLine("**Environment info**");
            WriteLine($"Environment.OSVersion: {Environment.OSVersion}");
            WriteLine($"RuntimeInformation.OSDescription: {RuntimeInformation.OSDescription}");
            WriteLine($"RuntimeInformation.OSArchitecture: {RuntimeInformation.OSArchitecture}");
            WriteLine($"Environment.ProcessorCount: {Environment.ProcessorCount}");
            WriteLine();
        }
    }
}
