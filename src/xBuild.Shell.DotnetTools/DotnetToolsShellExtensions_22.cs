using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Dpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Setblobmimetypes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"setblobmimetypes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UniversaldscResourceWindowsUser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"universaldsc.resource.windows.user {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TemplatemanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"templatemanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LempTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lemp-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TitaniumitGraphqlSdlextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"titaniumit.graphql.sdlextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCharon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-charon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StefandevoGenymanXamarinicons(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stefandevo.genyman.xamarinicons {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BadechoResourcecreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"badecho.resourcecreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Suba(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"suba {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MachinaxxMakercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"machinaxx.makercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChronicleTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chronicle.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsVisualstudioprojectversionupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.visualstudioprojectversionupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoberecCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coberec.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOcremixdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ocremixdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sdn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sdn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BareCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bare-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StaticVoyager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"static.voyager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nomis51Watson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nomis51.watson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Eedatagift(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eedatagift {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vsrenamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vsrenamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Konet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"konet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hashdir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hashdir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FluentmigrationGeneratorPostgresql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fluentmigration.generator.postgresql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeowikiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geowiki.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetImageOptimize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-image-optimize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TemplateversionsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"templateversions.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zipthis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zipthis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FrogvallDotnetbumpversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"frogvall.dotnetbumpversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trainingmoduleconvertor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trainingmoduleconvertor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGrab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-grab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ButrCrashreportTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"butr.crashreport.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SapteamEasysignTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sapteam.easysign.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ResourcetranslatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resourcetranslator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSsllabsCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ssllabs-check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NaoTunnel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nao.tunnel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpiderlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spiderly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftTemplateMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.template.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TheblueskyDotnetToolsSwifthash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thebluesky.dotnet.tools.swifthash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Terramove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"terramove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DependencymanagerFsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependencymanager.fsproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dcmtransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dcmtransform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorsparkConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorspark.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDzripper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dzripper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NyvikenSharptillery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nyviken-sharptillery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MmmScanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mmm.scanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MichaelchecksumConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"michaelchecksum.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bumpversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bumpversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomstoolboxLicensegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomstoolbox.licensegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Run(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csrobot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csrobot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codegenup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codegenup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BonsaiSgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bonsai.sgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsDmupgradestorage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.dmupgradestorage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MjsuPluginMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mjsu.plugin.merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PangouiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pangoui.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Otterkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"otterkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloudflareDdns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudflare-ddns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Newsmake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"newsmake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Thebfg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thebfg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UniversaldscResourceWindowsGroup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"universaldsc.resource.windows.group {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HamsterCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hamster.code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netfetch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netfetch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DomainmodelGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"domainmodel.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Quickup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quickup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetInit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-init {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TextedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"texted-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XxboomMakercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xxboom.makercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nativetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nativetest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftSqlserverKustoservicelayerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.sqlserver.kustoservicelayer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Moderndecompile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moderndecompile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OptiCliClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opti.cli.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command R2rml4netCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"r2rml4net-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tada(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tada {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trextract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trextract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsWinencryptedkeys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.winencryptedkeys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Semanticreleases(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"semanticreleases {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftMlModelbuilderCliWin64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.ml.modelbuilder.cli.win64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetCalculations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"net.calculations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Simpleguidgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simpleguidgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RksoftwareWingetupdateconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rksoftware.wingetupdateconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IronpythonConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ironpython.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Loadit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"loadit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Virtualcentral(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"virtualcentral {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dimmy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dimmy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PixelbadgerToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pixelbadger.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DepmanFsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"depman-fsproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConfigcatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"configcat-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WaDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wa-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlnItemsSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sln-items-sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GoplayTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"goplay.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GithubsyncTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubsync.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOpenai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-openai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CfpOnline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cfp.online {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CinoridCorrupter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cinorid.corrupter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}