using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T GitLfsAudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-lfs-audit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSortRefs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sort-refs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomwareTestr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomware.testr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNewrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-newrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConfEncrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conf-encrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MrkwatkinsRemovejetbrainsannotations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mrkwatkins.removejetbrainsannotations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetReadbin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-readbin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Documenttestapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"documenttestapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hemnatapplogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hemnatapplogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependencypath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependencypath {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FfmpegBatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ffmpeg-batch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MachyOpenapiToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"machy.openapi.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EncryptedconfigvalueNetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"encryptedconfigvalue.net.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B2r2RearendLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b2r2.rearend.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Reordenarasignaciones(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reordenarasignaciones {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Servicebusspy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"servicebusspy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FengAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"feng.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CenttrAutoversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"centtr.autoversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmmAppsettingstoenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"emm.appsettingstoenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntegrationApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"integration.api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unpackdacpac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unpackdacpac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HttpServerSim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"http-server-sim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LmbAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lmb.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomRoom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.room {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MvcfrontendkitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mvcfrontendkit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IfyArchimedes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ify.archimedes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Containerupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"containerupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Crono(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"crono {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Skonsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skonsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ComporiMagentoapiSoapsvcutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"compori.magentoapi.soapsvcutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CuriosityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"curiosity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OriginframeworkApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"originframework.api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dpi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dpi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetaeropuertosmpb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetaeropuertosmpb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FynyddFdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fynydd.fdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTerraform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-terraform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BunUnofficialToolOsxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bun.unofficial.tool.osx-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElteFiArchitecturalanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elte.fi.architecturalanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EkranosFactorioApiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ekranos.factorio.api.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Troodon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"troodon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorbindingsavaloniaComponentgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorbindingsavalonia.componentgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Imgbin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imgbin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Smartagents(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartagents {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SherlockMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sherlock.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGrpc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-grpc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webapplab51(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webapplab5-1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FuseopenapiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fuseopenapi.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BeamableTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"beamable.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetYlt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ylt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saasmtplocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saasmtplocal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpiderlyAppinitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spiderly.appinitializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trexascii(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trexascii {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Beeching(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"beeching {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScriptUtilidadesDiaadia(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"script.utilidades.diaadia {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Performancetestapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"performancetestapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CommunityMcpDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"community.mcp.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bionicmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bionicmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetabrainzMusicbrainzDotnetMbdiscid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metabrainz.musicbrainz.dotnet-mbdiscid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PeakswcRemotewebviewservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"peakswc.remotewebviewservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TeapieTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"teapie.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpserverEverythingStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpserver.everything.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProyectoSi8811a2024IiU1ApisYFuncionesJarroYValle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proyecto-si8811a-2024-ii-u1-apis-y-funciones-jarro-y-valle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFiglet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-figlet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZorgozPrecompress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zorgoz.precompress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZenCanonicalibPackagecomparer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zen.canonicalib.packagecomparer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RustBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rust-build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Databasemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"databasemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bibtoarc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bibtoarc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetutilsToolExec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetutils.tool.exec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsnakesStage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csnakes.stage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikReportingMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.reporting.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T N3rgyApiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"n3rgy.api.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EcocodeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ecocode.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MusementLambdaexec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"musement.lambdaexec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetutilsToolDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetutils.tool.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSeedBeanstalk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-seed-beanstalk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Undertaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"undertaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rxwebcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rxwebcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GraphqlToKarate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"graphql-to-karate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Programmerall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"programmerall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwashbuckleAspnetcoreCliGpn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swashbuckle.aspnetcore.cli.gpn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlopwatchCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slopwatch.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MyappCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myapp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartstackAdmintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartstack.admintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LintellectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lintellect.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CustomTranslatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"custom-translator-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VcelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vcel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapirefmerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapirefmerger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WindowsmcpNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"windowsmcp.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EventhorizonBlazorTypescriptInteropTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eventhorizon.blazor.typescript.interop.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-do {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubworkflow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubworkflow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JonpsmithMultiprojpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jonpsmith.multiprojpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DddStudio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ddd.studio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpextractTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpextract.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}