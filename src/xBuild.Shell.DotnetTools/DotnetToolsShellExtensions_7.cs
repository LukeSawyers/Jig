using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command AiursoftNugetninjaGeminibot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.nugetninja.geminibot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adfsauthtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adfsauthtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevatticConfigcrypterConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devattic.configcrypter.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Audiosync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"audiosync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSqlCache(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sql-cache {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlbatrossCodegenCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"albatross.codegen.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdpCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adp.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Assemblyversionincrementer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assemblyversionincrementer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FlynkAutogenCs2ts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flynk.autogen.cs2ts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autogenerationmodels(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autogenerationmodels {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppsettingsReader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appsettings_reader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlbatrossMessagingUtility(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"albatross.messaging.utility {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtlasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atlas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnyjobCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anyjob.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BorsuksoftwareToolsAwsdevicefarmRunwaiter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borsuksoftware.tools.awsdevicefarm.runwaiter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Asmdefdefinesymbols(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asmdefdefinesymbols {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomstoolboxNugetaudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomstoolbox.nugetaudit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RegulusApplicationServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regulus.application.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppsettingsOverrideTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appsettings.override.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SapteamKryptorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sapteam.kryptor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PrivateApiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"private-api-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bionic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bionic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TransistorAzuresqlExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"transistor.azuresql.exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Encapsulationanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"encapsulationanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azdevopspool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azdevopspool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VentureaxisCrudCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ventureaxis.crud.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Accelerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"accelerate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiruditMdbook(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"airudit.mdbook {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BjornkpuAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bjornkpu.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApploggertestTk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apploggertest.tk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AefinderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aefinder.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkAssetdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.assetdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkAlfrescoquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.alfrescoquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MrkwatkinsOakasmTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mrkwatkins.oakasm.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDynamicsBusinesscentralDevelopmentTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dynamics.businesscentral.development.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Approvaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"approvaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltemiqDocfxOpenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altemiq.docfx.openapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B2aGatekeeperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b2a.gatekeeper.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzattekcetestCoreApplications(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azattekcetest.core.applications {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RevoToolsDatabasemigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"revo.tools.databasemigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Elmanalysetojunit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elmanalysetojunit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftWebLibrarymanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.web.librarymanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChickensoftGodotenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chickensoft.godotenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yamlizr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yamlizr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Eunice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eunice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FaithlifeApidifftoolTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faithlife.apidifftool.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeSlidesSplitter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.slides.splitter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AffirmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"affirm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DossedoAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dossedo.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xgitalarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xgitalarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeSlidesMerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.slides.merger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RicaunAppbundletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ricaun.appbundletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeZipPasswordrecovery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.zip.passwordrecovery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThreaxAzurevmprovisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"threax.azurevmprovisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCleanArtifacts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-clean-artifacts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AaakunCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aaakun.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Perfx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"perfx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Prejitall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"prejitall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AshirafumiiroSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ashirafumiiro.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aspnetcoresseserver1275706970(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspnetcoresseserver1275706970 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Agriffard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"agriffard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetpublishaction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetpublishaction {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAutogit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-autogit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AkpalHashing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"akpal_hashing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ParticularAspExport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"particular.asp.export {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PipelinesagentmanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pipelinesagentmanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PimixAppsBookutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pimix.apps.bookutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureDriftDetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-drift-detector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAddcasa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-addcasa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LindexiToolCheckblogurlavailable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lindexi.tool.checkblogurlavailable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RegulusApplicationProtocolCodebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regulus.application.protocol.codebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApptoCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appto.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BmconsultingOpenapiGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bmconsulting.openapi.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetpackagingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetpackaging.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtomatiqSchemamigrationsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atomatiq.schemamigrations.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlbinberishaBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"albinberisha.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adoauditlog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adoauditlog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NiceAndBeautiful(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nice.and.beautiful {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MonoAddinsUtiltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mono.addins.utiltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autoconst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autoconst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RuichenAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ruichen.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpserverAzuredevopsStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpserver.azuredevops.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SigmaorigoPublishagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sigmaorigo.publishagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AliceprojectAliceconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aliceproject.aliceconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmwdMakedeb10(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amwd.makedeb10 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-audit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BorsuksoftwareToolsAwsdevicefarmLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borsuksoftware.tools.awsdevicefarm.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapimediatrresponsematcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapimediatrresponsematcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsautocomplete(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsautocomplete {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevopsimplementAdoguardCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devopsimplement.adoguard.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GroupdocsViewerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"groupdocs.viewer-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UniversoidSpatialEsriArcpycliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"universoid.spatial.esri.arcpycli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniasyncerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniasyncer.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartbitToolsApigen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartbit.tools.apigen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SbroenneExcelmcpMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sbroenne.excelmcp.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CleanarchGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cleanarch.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FynyddSfumato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fynydd.sfumato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Abpcmds(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"abpcmds {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CaligoSqltoopenapi3schemas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"caligo.sqltoopenapi3schemas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Archiforge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"archiforge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}