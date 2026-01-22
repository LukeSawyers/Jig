using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T DotnetCleanup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cleanup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Certdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"certdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Containertagremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"containertagremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Changelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"changelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MmaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mma-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CourecontentprocessingIcnNigeria(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"courecontentprocessing.icn.nigeria {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHttpie(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-httpie {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ctask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ctask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Commitlint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"commitlint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codecoverageextractor2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecoverageextractor2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Icsharpcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"icsharpcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusRegexreplacetask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.regexreplacetask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RendlelabsUnpkgcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rendlelabs.unpkgcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCrud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-crud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Intunecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intunecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dscom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dscom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuget-license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CommitlintNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"commitlint.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Svgc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svgc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EvaisaNetcodepatcherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"evaisa.netcodepatcher.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusTagtoversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.tagtoversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsGithubtocatalogyaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.githubtocatalogyaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cgitclone(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cgitclone {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MkhToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mkh.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsqlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csqly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cszip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cszip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Checkcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"checkcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OrangDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"orang.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FuseeToolsCmdline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fusee.tools.cmdline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csunzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csunzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CuginitechMarkdowncomments(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cuginitech.markdowncomments {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CuginitechXslViewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cuginitech.xsl-viewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Test262harnessConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"test262harness.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ParlemDotnetCertificateTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"parlem-dotnet-certificate-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowSwaggergencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.swaggergencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpsaCicdDatabasePostgres(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spsa.cicd.database.postgres {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FantasyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fantasy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharporganizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharporganizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JaytwoNugetcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jaytwo.nugetcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Catj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"catj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cryptstr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cryptstr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsfcloudLicensemanagerLicensesigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csfcloud.licensemanager.licensesigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Textcycler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"textcycler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThousandCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thousand.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cito(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cito {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCstomd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cstomd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UstaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"usta-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TdnpglCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tdnpgl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cargowisexubextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cargowisexubextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zen-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CosmosPatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cosmos.patcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChdbTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chdb-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnigmatryEntryCodegenerationTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"enigmatry.entry.codegeneration.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsharpierConfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpier-config {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FacadeToolcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"facade.toolcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ComCrystalgrapeUnityconfigtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"com.crystalgrape.unityconfigtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoWasmVersionchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.wasm.versionchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoffeecupWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coffeecup-windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-setversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EsquioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"esquio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HarpyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"harpy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MartincostelloWaitfornugetpackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"martincostello.waitfornugetpackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoveragecheckerCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coveragechecker.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoverallsNetMachinarius(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coveralls.net.machinarius {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoffeecupLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coffeecup-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Excelcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"excelcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coffeecupcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coffeecupcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRimraf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-rimraf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoverallsNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coveralls.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cosmoscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cosmoscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ros2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ros2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntellegensCornerstoneUtilsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intellegens.cornerstone.utils.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CommitjiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"commitji.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TfwhatsupConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tfwhatsup.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mysqltocsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mysqltocsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemnetElevationapiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demnet-elevationapi-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XerrisOidccli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xerris.oidccli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WhipstaffCmdhelp2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"whipstaff-cmdhelp2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CapRegex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cap.regex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowHologramCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.hologram.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Doccore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doccore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Callmenamestool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"callmenamestool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RobjanMinecraftChunkremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robjan.minecraft.chunkremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChronoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chrono.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sbomlicencecheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sbomlicencecheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatalustCleftool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datalust.cleftool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gpr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gpr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowLighthouseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.lighthouse.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CapitalsoftCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"capitalsoft.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CookmemoryConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cookmemory.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genpg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genpg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetT4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-t4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NxinCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nxin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cpmgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cpmgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cloudinarymigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudinarymigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Letsencryptcert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"letsencryptcert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusEncodingnormalior(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.encodingnormalior {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sa3client(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sa3client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}