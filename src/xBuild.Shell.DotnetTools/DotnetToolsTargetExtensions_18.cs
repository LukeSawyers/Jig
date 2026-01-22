using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Srcset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"srcset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharpermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CarnaRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"carna-runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHtml2md(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-html2md {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsversionmaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsversionmaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clr2ts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clr2ts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitProfileManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-profile-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tod(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tod {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Konfigmap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"konfigmap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tranalyze(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tranalyze {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TrifenixVersionsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trifenix.versions.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PythonToolUvUnofficialDotnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"python.tool.uv.unofficial.dotnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Project2015to2017Migrate2017Tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"project2015to2017.migrate2017.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IrilCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iril-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThinkinghomeNooliteConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thinkinghome.noolite.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCstRecursiveextractorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.cst.recursiveextractor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bruce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bruce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Entityframeworkruler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entityframeworkruler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yapg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yapg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSshdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sshdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NodsoftMoltenobsidianTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nodsoft.moltenobsidian.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlnetLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet-linux-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Releasedownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"releasedownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodersCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coders.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDnbDatamigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dnb-datamigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cksetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cksetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NethereumgeneratorExtendedconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nethereumgenerator.extendedconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bingimagedownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bingimagedownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProjectversioningDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectversioning.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctopusprojectbuilderConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octopusprojectbuilder.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnbreakableToolsPolicyreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unbreakable.tools.policyreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VrchatVpmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vrchat.vpm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DaterpillarTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"daterpillar.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VersioningNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versioning.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftSqlserverSqltoolsservicelayerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.sqlserver.sqltoolsservicelayer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DactoolsDeploymentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dactools.deployment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qrcodecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qrcodecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LaobianJarvis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"laobian.jarvis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Braillify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"braillify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nusight(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nusight {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmoogipooNvika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smoogipoo.nvika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ikon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ikon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TntCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tnt-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Project2015to2017Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"project2015to2017.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pgutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pgutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeohashGeoraptorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geohash.georaptor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGitcoauth(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gitcoauth {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlnetOsxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet-osx-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JiraOauthCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jira-oauth-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnettestsplit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnettestsplit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DocgenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docgen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe10net31xquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe10net31xquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Updateglobaltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"updateglobaltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConverterMarkdowntobbcodenmTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"converter.markdowntobbcodenm.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fastpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fastpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GreensupergreenBenchmarkingLauncherNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greensupergreen.benchmarking.launcher.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trgroup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trgroup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetToolExec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tool-exec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KenticoKontentModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kentico.kontent.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cronorsd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cronorsd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FantomlessTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fantomless-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Linqtoxsdcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linqtoxsdcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tsclientgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tsclientgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsNugetvalidateskylinespecifications(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetvalidateskylinespecifications {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe11netxquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe11netxquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElmahIoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elmah.io.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WcomPrValidation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wcom-pr-validation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rainlispconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rainlispconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OkCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ok-cli-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetgtt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetgtt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ibancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ibancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Burner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"burner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SharpilmixinsProcessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpilmixins.processor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MonikerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moniker.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetUtils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-utils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mwcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mwcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConverterMarkdowntobbcodesteamTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"converter.markdowntobbcodesteam.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WebRepositorylayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"web.repositorylayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MotherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mother.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNswagen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nswagen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CqrsandmediatorScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cqrsandmediator.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Termix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"termix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KrosDummydataInitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kros.dummydata.initializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTestx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-testx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitIstage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-istage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Domaintcc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"domaintcc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trdelabel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trdelabel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JetbrainsRefasmerClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jetbrains.refasmer.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DidIdefix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"did.idefix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TopmodelModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topmodel.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cut(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cut {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsMemriseutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.memriseutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SleepPc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sleep-pc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TrimbleXchangeConnectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trimble.xchange.connector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Overcrowdin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"overcrowdin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}