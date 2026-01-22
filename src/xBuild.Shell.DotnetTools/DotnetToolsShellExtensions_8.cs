using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command DotnetAwsKclBootstrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-aws-kcl-bootstrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aylin05(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aylin05 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apiposture(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apiposture {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Powerautomateflowstringreplacercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"powerautomateflowstringreplacercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Makeac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"makeac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Awsat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"awsat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArchetypicalSoftwareFluxUpdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"archetypical.software.flux.updater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LegerityPageobjectgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"legerity.pageobjectgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kongverge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kongverge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlbertCommons(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"albert.commons {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RosieFindandreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rosie.findandreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NanoApiScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nano-api-scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsynkronMcpdebugger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asynkron.mcpdebugger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SiaconsultingAppstoreconnectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"siaconsulting.appstoreconnect.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DnvSecretsmanagerConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnv.secretsmanager.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apibuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apibuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AntigravityCsharpBackendkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"antigravity.csharp.backendkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AelfDev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aelf.dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetapiversioningtemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetapiversioningtemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JetbrainsDottraceGlobaltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jetbrains.dottrace.globaltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Staragent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"staragent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ezpipeline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ezpipeline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdlianceResxr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adliance.resxr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AchinaSay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"achina.say {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AjstarterapiDotnet9(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ajstarterapi_dotnet9 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FantomasTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fantomas-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlbatrossExpressionUtility(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"albatross.expression.utility {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WiremockOpenapivalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wiremock.openapivalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UmbracoDocsPreviewApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"umbraco.docs.preview.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azdbdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azdbdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRunas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-runas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EaglerepairCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eaglerepair.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapi2http(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapi2http {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeneblabAbcversioncmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deneblab.abcversioncmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"x.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltemiqNugetPromote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altemiq.nuget.promote {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArgentiniSfumatoScss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"argentini.sfumato-scss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AicommitsummarizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aicommitsummarizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wpaicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wpaicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aibotcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aibotcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Huiyuanai709Aim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"huiyuanai709.aim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apploggerrt1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apploggerrt1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsprojtoasmdefCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csprojtoasmdef.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ashokcalculatorlibrary(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ashokcalculatorlibrary {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YoyobootCliApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yoyoboot.cli.api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlbatrossDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"albatross.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DefinuxEmeraudeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"definux.emeraude.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DockerAffected(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docker-affected {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAdtx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-adtx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BfAbp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bf-abp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command A5C0837278Sumfunction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"a5_c0837278_sumfunction {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Neukeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neukeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApilCalc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apil.calc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csavrogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csavrogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SignalrEventaggregatorproxyAspnetcoreGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"signalr.eventaggregatorproxy.aspnetcore.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcpdatabaseanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpdatabaseanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlnAddcsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sln.addcsproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AardvarkPaket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aardvark.paket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testanicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testanicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cleanall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cleanall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pveautoconnectvm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pveautoconnectvm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PowerflyAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"powerfly.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtriusDigitaltwinsApiClientExample(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atrius.digitaltwins.api.client.example {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RocketSurgeryBlazorFontawesomeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rocket.surgery.blazor.fontawesome.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Salesforce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"salesforce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetpackageanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetpackageanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetHttprepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-httprepl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swaddinmanagercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swaddinmanagercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AardvarkPaketBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aardvark.paket.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetdaemonHassmodelCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netdaemon.hassmodel.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SaigkillAdrToolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saigkill.adr-tool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApproveitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"approveit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Assemblyname251(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assemblyname251 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonQuantbasedalignmentLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.quantbasedalignment_linux_x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wiremockadminui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wiremockadminui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpTaskandresearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.taskandresearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitreleasemanagerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitreleasemanager.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrynwaldMddocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grynwald.mddocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YaosOpenapiDiffCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yaos.openapi.diff.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZureAzdoScanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zure-azdo-scanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Httpgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"httpgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SbroenneExcelmcpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sbroenne.excelmcp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JmeloseguiDevopscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jmelosegui.devopscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HotchocolateFusionCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hotchocolate.fusion.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NscanConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nscan.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MobileactGithublabelsetupper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mobileact.githublabelsetupper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Curlgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"curlgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AuroraLabsHelperToolSet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aurora.labs.helper.tool.set {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kickflip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kickflip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PimixAppsDatautil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pimix.apps.datautil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LibplanetTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"libplanet.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HandymanAdo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"handyman-ado {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WiredviewsXperienceFontawesomeintegrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wiredviews.xperience.fontawesomeintegrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeoSmartcontractAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neo.smartcontract.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTestRerun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-test-rerun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetUpdateAllTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-update-all-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAnsibleVaultDecoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ansible-vault-decoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftAgentsA365DevtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.agents.a365.devtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeuromcpAzuredevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neuromcp.azuredevops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsdocsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdocs-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}