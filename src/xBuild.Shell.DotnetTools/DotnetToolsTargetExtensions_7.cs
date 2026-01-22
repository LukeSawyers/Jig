using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T AiursoftNugetninjaGeminibot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.nugetninja.geminibot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adfsauthtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adfsauthtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevatticConfigcrypterConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devattic.configcrypter.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Audiosync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"audiosync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSqlCache(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sql-cache {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlbatrossCodegenCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"albatross.codegen.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdpCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adp.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Assemblyversionincrementer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assemblyversionincrementer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FlynkAutogenCs2ts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flynk.autogen.cs2ts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autogenerationmodels(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autogenerationmodels {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppsettingsReader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appsettings_reader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlbatrossMessagingUtility(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"albatross.messaging.utility {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtlasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atlas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnyjobCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anyjob.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BorsuksoftwareToolsAwsdevicefarmRunwaiter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borsuksoftware.tools.awsdevicefarm.runwaiter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Asmdefdefinesymbols(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asmdefdefinesymbols {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomstoolboxNugetaudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomstoolbox.nugetaudit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RegulusApplicationServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regulus.application.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppsettingsOverrideTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appsettings.override.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SapteamKryptorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sapteam.kryptor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PrivateApiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"private-api-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bionic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bionic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TransistorAzuresqlExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"transistor.azuresql.exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Encapsulationanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"encapsulationanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azdevopspool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azdevopspool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VentureaxisCrudCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ventureaxis.crud.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Accelerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"accelerate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiruditMdbook(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"airudit.mdbook {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BjornkpuAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bjornkpu.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApploggertestTk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apploggertest.tk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AefinderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aefinder.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAssetdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.assetdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAlfrescoquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.alfrescoquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MrkwatkinsOakasmTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mrkwatkins.oakasm.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDynamicsBusinesscentralDevelopmentTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dynamics.businesscentral.development.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Approvaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"approvaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltemiqDocfxOpenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altemiq.docfx.openapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B2aGatekeeperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b2a.gatekeeper.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzattekcetestCoreApplications(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azattekcetest.core.applications {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RevoToolsDatabasemigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"revo.tools.databasemigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Elmanalysetojunit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elmanalysetojunit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftWebLibrarymanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.web.librarymanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChickensoftGodotenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chickensoft.godotenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yamlizr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yamlizr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Eunice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eunice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FaithlifeApidifftoolTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faithlife.apidifftool.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeSlidesSplitter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.slides.splitter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AffirmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"affirm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DossedoAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dossedo.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xgitalarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xgitalarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeSlidesMerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.slides.merger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RicaunAppbundletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ricaun.appbundletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeZipPasswordrecovery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.zip.passwordrecovery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThreaxAzurevmprovisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"threax.azurevmprovisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCleanArtifacts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-clean-artifacts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AaakunCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aaakun.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Perfx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"perfx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Prejitall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"prejitall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AshirafumiiroSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ashirafumiiro.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aspnetcoresseserver1275706970(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspnetcoresseserver1275706970 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Agriffard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"agriffard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetpublishaction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetpublishaction {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAutogit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-autogit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AkpalHashing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"akpal_hashing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ParticularAspExport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"particular.asp.export {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PipelinesagentmanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pipelinesagentmanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PimixAppsBookutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pimix.apps.bookutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureDriftDetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-drift-detector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAddcasa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-addcasa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LindexiToolCheckblogurlavailable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lindexi.tool.checkblogurlavailable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RegulusApplicationProtocolCodebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regulus.application.protocol.codebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApptoCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appto.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BmconsultingOpenapiGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bmconsulting.openapi.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetpackagingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetpackaging.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtomatiqSchemamigrationsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atomatiq.schemamigrations.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlbinberishaBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"albinberisha.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adoauditlog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adoauditlog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NiceAndBeautiful(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nice.and.beautiful {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MonoAddinsUtiltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mono.addins.utiltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autoconst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autoconst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RuichenAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ruichen.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpserverAzuredevopsStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpserver.azuredevops.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SigmaorigoPublishagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sigmaorigo.publishagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AliceprojectAliceconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aliceproject.aliceconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmwdMakedeb10(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amwd.makedeb10 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-audit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BorsuksoftwareToolsAwsdevicefarmLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borsuksoftware.tools.awsdevicefarm.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapimediatrresponsematcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapimediatrresponsematcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsautocomplete(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsautocomplete {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevopsimplementAdoguardCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devopsimplement.adoguard.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GroupdocsViewerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"groupdocs.viewer-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UniversoidSpatialEsriArcpycliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"universoid.spatial.esri.arcpycli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniasyncerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniasyncer.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartbitToolsApigen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartbit.tools.apigen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SbroenneExcelmcpMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sbroenne.excelmcp.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CleanarchGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cleanarch.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FynyddSfumato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fynydd.sfumato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Abpcmds(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"abpcmds {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CaligoSqltoopenapi3schemas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"caligo.sqltoopenapi3schemas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Archiforge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"archiforge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}