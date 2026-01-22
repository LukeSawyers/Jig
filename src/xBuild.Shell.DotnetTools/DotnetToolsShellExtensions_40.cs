using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command DotnetCleanup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cleanup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Certdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"certdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Containertagremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"containertagremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Changelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"changelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MmaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mma-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CourecontentprocessingIcnNigeria(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"courecontentprocessing.icn.nigeria {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHttpie(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-httpie {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ctask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ctask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Commitlint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"commitlint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codecoverageextractor2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecoverageextractor2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Icsharpcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"icsharpcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusRegexreplacetask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.regexreplacetask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RendlelabsUnpkgcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rendlelabs.unpkgcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCrud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-crud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Intunecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intunecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dscom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dscom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuget-license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CommitlintNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"commitlint.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Svgc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svgc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EvaisaNetcodepatcherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"evaisa.netcodepatcher.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusTagtoversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.tagtoversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsGithubtocatalogyaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.githubtocatalogyaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cgitclone(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cgitclone {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MkhToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mkh.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsqlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csqly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cszip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cszip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Checkcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"checkcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OrangDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"orang.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FuseeToolsCmdline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fusee.tools.cmdline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csunzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csunzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CuginitechMarkdowncomments(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cuginitech.markdowncomments {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CuginitechXslViewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cuginitech.xsl-viewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Test262harnessConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"test262harness.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ParlemDotnetCertificateTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"parlem-dotnet-certificate-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowSwaggergencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.swaggergencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpsaCicdDatabasePostgres(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spsa.cicd.database.postgres {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FantasyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fantasy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharporganizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharporganizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JaytwoNugetcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jaytwo.nugetcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Catj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"catj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cryptstr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cryptstr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsfcloudLicensemanagerLicensesigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csfcloud.licensemanager.licensesigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Textcycler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"textcycler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThousandCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thousand.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cito(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cito {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCstomd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cstomd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UstaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"usta-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TdnpglCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tdnpgl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cargowisexubextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cargowisexubextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zen-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CosmosPatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cosmos.patcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChdbTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chdb-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnigmatryEntryCodegenerationTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"enigmatry.entry.codegeneration.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsharpierConfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpier-config {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FacadeToolcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"facade.toolcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ComCrystalgrapeUnityconfigtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"com.crystalgrape.unityconfigtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoWasmVersionchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.wasm.versionchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoffeecupWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coffeecup-windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-setversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EsquioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"esquio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HarpyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"harpy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MartincostelloWaitfornugetpackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"martincostello.waitfornugetpackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoveragecheckerCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coveragechecker.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoverallsNetMachinarius(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coveralls.net.machinarius {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoffeecupLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coffeecup-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Excelcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"excelcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coffeecupcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coffeecupcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRimraf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-rimraf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoverallsNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coveralls.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cosmoscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cosmoscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ros2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ros2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntellegensCornerstoneUtilsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intellegens.cornerstone.utils.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CommitjiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"commitji.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TfwhatsupConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tfwhatsup.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mysqltocsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mysqltocsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemnetElevationapiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demnet-elevationapi-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XerrisOidccli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xerris.oidccli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WhipstaffCmdhelp2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"whipstaff-cmdhelp2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CapRegex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cap.regex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowHologramCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.hologram.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Doccore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doccore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Callmenamestool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"callmenamestool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RobjanMinecraftChunkremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robjan.minecraft.chunkremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChronoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chrono.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sbomlicencecheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sbomlicencecheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatalustCleftool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datalust.cleftool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gpr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gpr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowLighthouseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.lighthouse.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CapitalsoftCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"capitalsoft.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CookmemoryConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cookmemory.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genpg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genpg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetT4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-t4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NxinCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nxin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cpmgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cpmgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cloudinarymigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudinarymigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Letsencryptcert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"letsencryptcert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusEncodingnormalior(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.encodingnormalior {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sa3client(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sa3client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}