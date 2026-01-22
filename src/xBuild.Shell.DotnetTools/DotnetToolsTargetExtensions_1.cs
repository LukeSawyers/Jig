using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Appauthentication(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appauthentication {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetOpenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-openapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzuredevopsDataingestor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuredevops.dataingestor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Almops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"almops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FunfairBuildcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"funfair.buildcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SteffbeckersAbpGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"steffbeckers.abp.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutoguruKeyvaluepushRedis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autoguru.keyvaluepush.redis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Alias(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alias {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AntIpcServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ant-ipc-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutomaticaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"automatica-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Automatize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"automatize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzLazy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"az-lazy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmorrisonMutant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amorrison.mutant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vpk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vpk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpecflowPlusLivingdocCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"specflow.plus.livingdoc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsosServicebusMessagesiphon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asos.servicebus.messagesiphon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtcCodingRulesUpdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atc-coding-rules-updater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AntyramaToolsScribeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"antyrama.tools.scribe.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdlianceTogglr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adliance.togglr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Amsmigrate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amsmigrate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PimixAppsBiliutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pimix.apps.biliutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApplicationregistryCollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"applicationregistry.collector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apps72DevDataGeneratorTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apps72.dev.data.generator.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aidocument(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aidocument {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AndtechGooball(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"andtech.gooball {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azzipgo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azzipgo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Atconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Animdl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"animdl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AireviewTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aireview.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftNugetninjaMergebot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.nugetninja.mergebot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmusoftVisualstudioTemplategeneratorCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amusoft.visualstudio.templategenerator.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftStathubClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.stathub.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Paket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"paket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArborToolerGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arbor.tooler.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MinverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minver-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdlianceToolsLingohub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adliance.tools.lingohub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LocaleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"locale.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netpackageanalyzerconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netpackageanalyzerconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LogicflowAstraCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"logicflow.astra.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XamarinAndroidxMigrationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xamarin.androidx.migration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JusteattakeawayWatchman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"justeattakeaway.watchman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetkeyvaultsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetkeyvaultsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PimixAppsSubutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pimix.apps.subutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WinAcme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"win-acme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftDotdownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.dotdownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGcdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gcdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutosystemDevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autosystem.devops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApiverseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apiverse.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureAuditCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-audit-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolidrpcOpenapiDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solidrpc.openapi.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AllintraDevAuthenticator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"allintra.dev.authenticator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Authenticodelint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"authenticodelint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PiralBlazorAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"piral.blazor.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lbi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lbi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltcodeGendarmeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altcode.gendarme-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AcceleratePackageRestore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"accelerate-package-restore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodecovTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecov.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkyapmDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyapm.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azurediagramgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azurediagramgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArborBuildBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arbor.build.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetsparkCleanarchitectureScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netspark.cleanarchitecture.scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Antlr4codegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"antlr4codegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FurionTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"furion.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeCellsUnlock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.cells.unlock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Appinsightstestpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appinsightstestpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenerateApiProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generate-api-proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azdoutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azdoutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SoftmakeallCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"softmakeall.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azurespeechcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azurespeechcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoDotnetCodeAnalysisOverridesCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.dotnet.code.analysis.overrides.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azres(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azres {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeCellsMerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.cells.merger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArfwareArfblocksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arfware.arfblocks-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HyparCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hypar.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApstoryScaffoldApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apstory.scaffold.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Amgbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amgbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AwslambdaAspnetcoreappmeshCatalog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"awslambda.aspnetcoreappmesh.catalog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bri(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bri {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftIpmicontroller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.ipmicontroller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LimeflightOpenapiDiffAction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"limeflight.openapi.diff.action {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Refitter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"refitter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlethicSqlserverDeploymentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alethic.sqlserver.deployment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KumuluzApipublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kumuluz.apipublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KmdLogicGatewayAutomationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kmd.logic.gateway.automation.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aspnetcoresharedserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspnetcoresharedserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-aop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArmonikUtilsDocextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"armonik.utils.docextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Boots(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"boots {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArgentiniFdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"argentini.fdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftNibot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.nibot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MsidentityAppSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msidentity-app-sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T A19029ServicesFrameworkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"a19029.services.framework.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EdiAzureblobsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"edi.azureblobsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzuxirenAionianTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuxiren.aionian.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftStatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.static {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FreesqlAdminlteTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"freesql.adminlte.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TerevintosoftwareAadappregistryTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"terevintosoftware.aadappregistry.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}