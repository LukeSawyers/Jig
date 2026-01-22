using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Dpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Setblobmimetypes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"setblobmimetypes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UniversaldscResourceWindowsUser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"universaldsc.resource.windows.user {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TemplatemanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"templatemanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LempTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lemp-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TitaniumitGraphqlSdlextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"titaniumit.graphql.sdlextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCharon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-charon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StefandevoGenymanXamarinicons(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stefandevo.genyman.xamarinicons {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BadechoResourcecreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"badecho.resourcecreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Suba(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"suba {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MachinaxxMakercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"machinaxx.makercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChronicleTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chronicle.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsVisualstudioprojectversionupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.visualstudioprojectversionupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoberecCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coberec.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOcremixdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ocremixdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sdn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sdn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BareCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bare-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StaticVoyager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"static.voyager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nomis51Watson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nomis51.watson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Eedatagift(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eedatagift {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vsrenamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vsrenamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Konet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"konet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hashdir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hashdir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FluentmigrationGeneratorPostgresql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fluentmigration.generator.postgresql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeowikiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geowiki.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetImageOptimize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-image-optimize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TemplateversionsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"templateversions.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zipthis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zipthis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FrogvallDotnetbumpversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"frogvall.dotnetbumpversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trainingmoduleconvertor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trainingmoduleconvertor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGrab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-grab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ButrCrashreportTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"butr.crashreport.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SapteamEasysignTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sapteam.easysign.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ResourcetranslatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resourcetranslator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSsllabsCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ssllabs-check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NaoTunnel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nao.tunnel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpiderlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spiderly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftTemplateMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.template.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TheblueskyDotnetToolsSwifthash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thebluesky.dotnet.tools.swifthash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Terramove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"terramove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DependencymanagerFsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependencymanager.fsproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dcmtransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dcmtransform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorsparkConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorspark.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDzripper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dzripper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NyvikenSharptillery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nyviken-sharptillery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MmmScanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mmm.scanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MichaelchecksumConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"michaelchecksum.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bumpversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bumpversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomstoolboxLicensegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomstoolbox.licensegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Run(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csrobot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csrobot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codegenup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codegenup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BonsaiSgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bonsai.sgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsDmupgradestorage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.dmupgradestorage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MjsuPluginMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mjsu.plugin.merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PangouiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pangoui.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Otterkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"otterkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloudflareDdns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudflare-ddns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Newsmake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"newsmake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Thebfg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thebfg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UniversaldscResourceWindowsGroup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"universaldsc.resource.windows.group {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HamsterCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hamster.code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netfetch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netfetch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DomainmodelGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"domainmodel.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Quickup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quickup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetInit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-init {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TextedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"texted-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XxboomMakercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xxboom.makercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nativetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nativetest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftSqlserverKustoservicelayerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.sqlserver.kustoservicelayer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Moderndecompile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moderndecompile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OptiCliClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opti.cli.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T R2rml4netCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"r2rml4net-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tada(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tada {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trextract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trextract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsWinencryptedkeys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.winencryptedkeys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Semanticreleases(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"semanticreleases {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftMlModelbuilderCliWin64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.ml.modelbuilder.cli.win64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetCalculations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"net.calculations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Simpleguidgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simpleguidgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RksoftwareWingetupdateconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rksoftware.wingetupdateconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IronpythonConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ironpython.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Loadit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"loadit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Virtualcentral(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"virtualcentral {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dimmy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dimmy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PixelbadgerToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pixelbadger.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DepmanFsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"depman-fsproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConfigcatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"configcat-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WaDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wa-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlnItemsSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sln-items-sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GoplayTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"goplay.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GithubsyncTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubsync.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOpenai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-openai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CfpOnline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cfp.online {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CinoridCorrupter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cinorid.corrupter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}