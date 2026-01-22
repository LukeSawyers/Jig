using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T GhulCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ghul.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetConfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-config {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevratingConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devrating.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCoyoteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.coyote.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EntityframeworkcoreGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entityframeworkcore.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codecoverageextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecoverageextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoTsqlFormatterCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.tsql.formatter.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsScriptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cs-script.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrapecityLicensemanagertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grapecity.licensemanagertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T H5Compiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"h5-compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WildernesslabsMeadowCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wildernesslabs.meadow.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KubernetescrdmodelgenSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kubernetescrdmodelgen.sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetacodeTemplatesuite2Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metacode.templatesuite2.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeshmakersOctoConstructionkitCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meshmakers.octo.constructionkit.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RedthNetMauiCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"redth.net.maui.check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodeworxRestToolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codeworx.rest.tool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CwtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cwtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqlhydraCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlhydra.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TddxtTrxconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tddxt.trxconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetacodeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metacode.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PkgchkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pkgchk-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Doclinkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doclinkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Centralisedpackageconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"centralisedpackageconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ckli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ckli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Competitiveverifiercsresolver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"competitiveverifiercsresolver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Configvalidate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"configvalidate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HoustonCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"houston.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Plantumlclassdiagramgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plantumlclassdiagramgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOutdatedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-outdated-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetContractsGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-contracts-generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetacodeTs3Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metacode.ts3.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FixieConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fixie.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotvvmCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotvvm.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaplargeincCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maplargeinc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TryConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"try-convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clickhousemigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clickhousemigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-deb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docfx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docfx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ContentfulModelscreatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"contentful.modelscreator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsSdkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.sdkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Claimssetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"claimssetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoffeecupMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coffeecup-macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConjureEfxDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conjure.efx.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntentSoftwarefactoryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intent.softwarefactory.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodegeneratorCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codegenerator.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TailwindcssCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tailwindcss.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OrchardcorecontribPoextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"orchardcorecontrib.poextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoravelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coravel-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRpm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-rpm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RocketmakersEnvironmentGenerationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rocketmakers.environment.generation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DolittleRuntimeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dolittle.runtime.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ClojureMain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clojure.main {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodificMvc567Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codific.mvc567.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetafacCg4Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metafac.cg4.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCensus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-census {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElviaEdnaEventsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elvia.edna.events.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCodecoverageConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.codecoverage.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkbkonturTypescriptContractgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skbkontur.typescript.contractgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftQuantumChemistryTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.quantum.chemistry.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-repl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenocsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genocs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetProjectLicenses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-project-licenses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntentPackagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intent.packager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codegeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codegeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pauldeen79TemplateframeworkConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pauldeen79.templateframework.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZhiletimeHopeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zhiletime.hope.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UlidCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ulid-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xrmdocumentationgeneratorcorecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xrmdocumentationgeneratorcorecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SquidexCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"squidex.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolhigsonFrameworkEfcoretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solhigson.framework.efcoretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WaiinRaaghuCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"waiin.raaghu.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csprojcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csprojcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Congelato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"congelato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ContentstackModelGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"contentstack.model.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusGitrevisiontask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.gitrevisiontask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusNugettask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.nugettask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetafacCg3Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metafac.cg3.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusDotnettask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.dotnettask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeadowCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meadow.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pauldeen79TexttemplatetransformationframeworkT4PlusCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pauldeen79.texttemplatetransformationframework.t4.plus.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusNugetpublishtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.nugetpublishtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CuidgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cuidgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusMsbuildtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.msbuildtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CreatedecisionsmoduleGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"createdecisionsmodule-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RecompiledminifierCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"recompiledminifier.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EzdbcodegenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ezdbcodegen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FcswatchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fcswatch-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HolionTranslationsyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"holion.translationsync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetafacCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metafac.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GivenspecsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"givenspecs.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetXunitToJunit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-xunit-to-junit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SvrooijWingetIntuneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svrooij.winget-intune.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusPicktextvaluetask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.picktextvaluetask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGcm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gcm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharpzxscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpzxscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CreateGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"create-guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}