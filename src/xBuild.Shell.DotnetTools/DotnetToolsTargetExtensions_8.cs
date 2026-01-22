using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T DotnetAwsKclBootstrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-aws-kcl-bootstrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aylin05(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aylin05 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apiposture(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apiposture {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Powerautomateflowstringreplacercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"powerautomateflowstringreplacercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Makeac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"makeac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Awsat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"awsat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArchetypicalSoftwareFluxUpdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"archetypical.software.flux.updater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LegerityPageobjectgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"legerity.pageobjectgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kongverge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kongverge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlbertCommons(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"albert.commons {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RosieFindandreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rosie.findandreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NanoApiScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nano-api-scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsynkronMcpdebugger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asynkron.mcpdebugger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SiaconsultingAppstoreconnectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"siaconsulting.appstoreconnect.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DnvSecretsmanagerConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnv.secretsmanager.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apibuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apibuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AntigravityCsharpBackendkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"antigravity.csharp.backendkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AelfDev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aelf.dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetapiversioningtemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetapiversioningtemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JetbrainsDottraceGlobaltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jetbrains.dottrace.globaltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Staragent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"staragent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ezpipeline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ezpipeline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdlianceResxr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adliance.resxr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AchinaSay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"achina.say {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AjstarterapiDotnet9(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ajstarterapi_dotnet9 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FantomasTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fantomas-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlbatrossExpressionUtility(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"albatross.expression.utility {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WiremockOpenapivalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wiremock.openapivalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UmbracoDocsPreviewApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"umbraco.docs.preview.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azdbdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azdbdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRunas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-runas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EaglerepairCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eaglerepair.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapi2http(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapi2http {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeneblabAbcversioncmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deneblab.abcversioncmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"x.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltemiqNugetPromote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altemiq.nuget.promote {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArgentiniSfumatoScss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"argentini.sfumato-scss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AicommitsummarizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aicommitsummarizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wpaicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wpaicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aibotcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aibotcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Huiyuanai709Aim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"huiyuanai709.aim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apploggerrt1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apploggerrt1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsprojtoasmdefCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csprojtoasmdef.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ashokcalculatorlibrary(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ashokcalculatorlibrary {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YoyobootCliApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yoyoboot.cli.api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlbatrossDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"albatross.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DefinuxEmeraudeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"definux.emeraude.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DockerAffected(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docker-affected {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAdtx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-adtx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BfAbp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bf-abp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T A5C0837278Sumfunction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"a5_c0837278_sumfunction {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Neukeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neukeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApilCalc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apil.calc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csavrogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csavrogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SignalrEventaggregatorproxyAspnetcoreGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"signalr.eventaggregatorproxy.aspnetcore.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcpdatabaseanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpdatabaseanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlnAddcsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sln.addcsproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AardvarkPaket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aardvark.paket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testanicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testanicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cleanall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cleanall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pveautoconnectvm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pveautoconnectvm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PowerflyAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"powerfly.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtriusDigitaltwinsApiClientExample(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atrius.digitaltwins.api.client.example {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RocketSurgeryBlazorFontawesomeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rocket.surgery.blazor.fontawesome.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Salesforce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"salesforce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetpackageanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetpackageanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetHttprepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-httprepl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swaddinmanagercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swaddinmanagercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AardvarkPaketBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aardvark.paket.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetdaemonHassmodelCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netdaemon.hassmodel.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SaigkillAdrToolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saigkill.adr-tool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApproveitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"approveit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Assemblyname251(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assemblyname251 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonQuantbasedalignmentLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.quantbasedalignment_linux_x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wiremockadminui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wiremockadminui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpTaskandresearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.taskandresearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitreleasemanagerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitreleasemanager.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrynwaldMddocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grynwald.mddocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YaosOpenapiDiffCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yaos.openapi.diff.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZureAzdoScanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zure-azdo-scanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Httpgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"httpgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SbroenneExcelmcpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sbroenne.excelmcp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JmeloseguiDevopscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jmelosegui.devopscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HotchocolateFusionCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hotchocolate.fusion.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NscanConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nscan.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MobileactGithublabelsetupper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobileact.githublabelsetupper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Curlgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"curlgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AuroraLabsHelperToolSet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aurora.labs.helper.tool.set {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kickflip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kickflip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PimixAppsDatautil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pimix.apps.datautil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LibplanetTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"libplanet.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HandymanAdo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"handyman-ado {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WiredviewsXperienceFontawesomeintegrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wiredviews.xperience.fontawesomeintegrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeoSmartcontractAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neo.smartcontract.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTestRerun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-test-rerun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetUpdateAllTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-update-all-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAnsibleVaultDecoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ansible-vault-decoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftAgentsA365DevtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.agents.a365.devtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeuromcpAzuredevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neuromcp.azuredevops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsdocsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdocs-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}