using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command GitLfsAudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-lfs-audit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSortRefs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sort-refs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomwareTestr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomware.testr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNewrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-newrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConfEncrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conf-encrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MrkwatkinsRemovejetbrainsannotations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mrkwatkins.removejetbrainsannotations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetReadbin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-readbin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Documenttestapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"documenttestapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hemnatapplogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hemnatapplogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependencypath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependencypath {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FfmpegBatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ffmpeg-batch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MachyOpenapiToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"machy.openapi.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EncryptedconfigvalueNetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"encryptedconfigvalue.net.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B2r2RearendLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b2r2.rearend.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Reordenarasignaciones(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reordenarasignaciones {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Servicebusspy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"servicebusspy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FengAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"feng.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CenttrAutoversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"centtr.autoversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmmAppsettingstoenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"emm.appsettingstoenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntegrationApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"integration.api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unpackdacpac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unpackdacpac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HttpServerSim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"http-server-sim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LmbAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lmb.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomRoom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.room {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MvcfrontendkitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mvcfrontendkit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IfyArchimedes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ify.archimedes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Containerupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"containerupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Crono(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"crono {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Skonsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skonsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ComporiMagentoapiSoapsvcutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"compori.magentoapi.soapsvcutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CuriosityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"curiosity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OriginframeworkApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"originframework.api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dpi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dpi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetaeropuertosmpb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetaeropuertosmpb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FynyddFdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fynydd.fdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTerraform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-terraform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BunUnofficialToolOsxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bun.unofficial.tool.osx-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElteFiArchitecturalanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elte.fi.architecturalanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EkranosFactorioApiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ekranos.factorio.api.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Troodon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"troodon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorbindingsavaloniaComponentgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorbindingsavalonia.componentgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Imgbin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imgbin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Smartagents(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartagents {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SherlockMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sherlock.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGrpc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-grpc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webapplab51(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webapplab5-1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FuseopenapiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fuseopenapi.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BeamableTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"beamable.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetYlt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ylt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saasmtplocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saasmtplocal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpiderlyAppinitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spiderly.appinitializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trexascii(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trexascii {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Beeching(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"beeching {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScriptUtilidadesDiaadia(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"script.utilidades.diaadia {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Performancetestapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"performancetestapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CommunityMcpDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"community.mcp.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bionicmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bionicmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetabrainzMusicbrainzDotnetMbdiscid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metabrainz.musicbrainz.dotnet-mbdiscid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PeakswcRemotewebviewservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"peakswc.remotewebviewservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TeapieTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"teapie.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpserverEverythingStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpserver.everything.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProyectoSi8811a2024IiU1ApisYFuncionesJarroYValle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proyecto-si8811a-2024-ii-u1-apis-y-funciones-jarro-y-valle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFiglet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-figlet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZorgozPrecompress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zorgoz.precompress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZenCanonicalibPackagecomparer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zen.canonicalib.packagecomparer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RustBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rust-build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Databasemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"databasemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bibtoarc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bibtoarc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetutilsToolExec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetutils.tool.exec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsnakesStage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csnakes.stage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelerikReportingMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telerik.reporting.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command N3rgyApiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"n3rgy.api.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EcocodeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ecocode.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MusementLambdaexec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"musement.lambdaexec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetutilsToolDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetutils.tool.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSeedBeanstalk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-seed-beanstalk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Undertaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"undertaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rxwebcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rxwebcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GraphqlToKarate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"graphql-to-karate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Programmerall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"programmerall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwashbuckleAspnetcoreCliGpn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swashbuckle.aspnetcore.cli.gpn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlopwatchCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slopwatch.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MyappCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myapp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartstackAdmintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartstack.admintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LintellectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lintellect.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CustomTranslatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"custom-translator-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VcelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vcel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapirefmerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapirefmerger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WindowsmcpNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"windowsmcp.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EventhorizonBlazorTypescriptInteropTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eventhorizon.blazor.typescript.interop.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-do {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubworkflow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubworkflow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JonpsmithMultiprojpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jonpsmith.multiprojpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DddStudio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ddd.studio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpextractTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpextract.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}