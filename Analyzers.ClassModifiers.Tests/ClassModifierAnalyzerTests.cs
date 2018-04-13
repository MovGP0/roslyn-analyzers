using System;
using System.Threading.Tasks;
using NUnit.Framework;
using static Analyzers.ClassModifiers.Tests.TestHelpers;

namespace Analyzers.ClassModifiers.Tests
{
    [TestFixture]
    public sealed class ClassModifierAnalyzerTests
    {
        private static readonly string BasePath =
            $@"{TestContext.CurrentContext.TestDirectory}\Targets\ClassModifier\";

        [Test]
        public async Task AnalyzeWhenClassHasNoInheritanceModifiers()
        {
            await RunAnalysisAsync<ClassModifierAnalyzer>(
                $"{BasePath}{nameof(AnalyzeWhenClassHasNoInheritanceModifiers)}.cs",
                new []{ "CS0000" }).ConfigureAwait(false);
        }

        [Test]
        public async Task AnalyzeWhenClassIsStatic()
        {
            await RunAnalysisAsync<ClassModifierAnalyzer>(
                $"{BasePath}{nameof(AnalyzeWhenClassIsStatic)}.cs", Array.Empty<string>()).ConfigureAwait(false);
        }

        [Test]
        public async Task AnalyzeWhenClassIsSealed()
        {
            await RunAnalysisAsync<ClassModifierAnalyzer>(
                $"{BasePath}{nameof(AnalyzeWhenClassIsSealed)}.cs", Array.Empty<string>()).ConfigureAwait(false);
        }

        [Test]
        public async Task AnalyzeWhenClassIsAbstract()
        {
            await RunAnalysisAsync<ClassModifierAnalyzer>(
                $"{BasePath}{nameof(AnalyzeWhenClassIsAbstract)}.cs", Array.Empty<string>()).ConfigureAwait(false);
        }
    }
}
