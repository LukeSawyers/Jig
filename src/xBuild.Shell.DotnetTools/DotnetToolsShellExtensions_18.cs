using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Srcset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"srcset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharpermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CarnaRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"carna-runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHtml2md(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-html2md {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsversionmaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsversionmaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clr2ts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clr2ts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitProfileManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-profile-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tod(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tod {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Konfigmap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"konfigmap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tranalyze(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tranalyze {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TrifenixVersionsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trifenix.versions.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PythonToolUvUnofficialDotnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"python.tool.uv.unofficial.dotnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Project2015to2017Migrate2017Tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"project2015to2017.migrate2017.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IrilCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iril-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThinkinghomeNooliteConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thinkinghome.noolite.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCstRecursiveextractorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.cst.recursiveextractor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bruce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bruce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Entityframeworkruler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entityframeworkruler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yapg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yapg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSshdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sshdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NodsoftMoltenobsidianTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nodsoft.moltenobsidian.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlnetLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet-linux-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Releasedownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"releasedownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodersCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coders.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDnbDatamigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dnb-datamigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cksetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cksetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NethereumgeneratorExtendedconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nethereumgenerator.extendedconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bingimagedownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bingimagedownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProjectversioningDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectversioning.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctopusprojectbuilderConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octopusprojectbuilder.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnbreakableToolsPolicyreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unbreakable.tools.policyreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VrchatVpmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vrchat.vpm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DaterpillarTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"daterpillar.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VersioningNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"versioning.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftSqlserverSqltoolsservicelayerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.sqlserver.sqltoolsservicelayer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DactoolsDeploymentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dactools.deployment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qrcodecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qrcodecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LaobianJarvis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"laobian.jarvis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Braillify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"braillify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nusight(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nusight {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmoogipooNvika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smoogipoo.nvika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ikon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ikon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TntCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tnt-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Project2015to2017Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"project2015to2017.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pgutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pgutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeohashGeoraptorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geohash.georaptor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGitcoauth(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gitcoauth {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlnetOsxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet-osx-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JiraOauthCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jira-oauth-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnettestsplit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnettestsplit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DocgenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docgen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe10net31xquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe10net31xquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Updateglobaltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"updateglobaltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConverterMarkdowntobbcodenmTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"converter.markdowntobbcodenm.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fastpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fastpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GreensupergreenBenchmarkingLauncherNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"greensupergreen.benchmarking.launcher.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trgroup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trgroup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetToolExec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tool-exec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KenticoKontentModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kentico.kontent.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cronorsd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cronorsd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FantomlessTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fantomless-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Linqtoxsdcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linqtoxsdcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tsclientgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tsclientgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsNugetvalidateskylinespecifications(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetvalidateskylinespecifications {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe11netxquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe11netxquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElmahIoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elmah.io.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WcomPrValidation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wcom-pr-validation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rainlispconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rainlispconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OkCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ok-cli-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetgtt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetgtt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ibancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ibancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Burner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"burner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SharpilmixinsProcessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpilmixins.processor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MonikerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moniker.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetUtils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-utils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mwcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mwcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConverterMarkdowntobbcodesteamTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"converter.markdowntobbcodesteam.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WebRepositorylayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"web.repositorylayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MotherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mother.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNswagen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nswagen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CqrsandmediatorScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cqrsandmediator.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Termix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"termix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KrosDummydataInitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kros.dummydata.initializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTestx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-testx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitIstage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-istage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Domaintcc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"domaintcc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trdelabel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trdelabel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JetbrainsRefasmerClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jetbrains.refasmer.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DidIdefix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"did.idefix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TopmodelModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topmodel.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cut(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cut {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsMemriseutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.memriseutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SleepPc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sleep-pc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TrimbleXchangeConnectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trimble.xchange.connector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Overcrowdin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"overcrowdin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}