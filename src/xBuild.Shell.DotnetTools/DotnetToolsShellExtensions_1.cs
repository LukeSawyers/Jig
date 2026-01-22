using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Appauthentication(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appauthentication {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetOpenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-openapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzuredevopsDataingestor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuredevops.dataingestor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Almops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"almops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FunfairBuildcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"funfair.buildcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SteffbeckersAbpGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"steffbeckers.abp.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutoguruKeyvaluepushRedis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autoguru.keyvaluepush.redis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Alias(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alias {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AntIpcServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ant-ipc-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutomaticaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"automatica-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Automatize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"automatize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzLazy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"az-lazy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmorrisonMutant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amorrison.mutant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vpk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vpk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpecflowPlusLivingdocCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"specflow.plus.livingdoc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsosServicebusMessagesiphon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asos.servicebus.messagesiphon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtcCodingRulesUpdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atc-coding-rules-updater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AntyramaToolsScribeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"antyrama.tools.scribe.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdlianceTogglr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adliance.togglr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Amsmigrate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amsmigrate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PimixAppsBiliutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pimix.apps.biliutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApplicationregistryCollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"applicationregistry.collector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apps72DevDataGeneratorTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apps72.dev.data.generator.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aidocument(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aidocument {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AndtechGooball(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"andtech.gooball {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azzipgo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azzipgo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Atconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Animdl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"animdl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AireviewTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aireview.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftNugetninjaMergebot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.nugetninja.mergebot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmusoftVisualstudioTemplategeneratorCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amusoft.visualstudio.templategenerator.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftStathubClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.stathub.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Paket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"paket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArborToolerGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arbor.tooler.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MinverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minver-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdlianceToolsLingohub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adliance.tools.lingohub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LocaleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"locale.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netpackageanalyzerconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netpackageanalyzerconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LogicflowAstraCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"logicflow.astra.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XamarinAndroidxMigrationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xamarin.androidx.migration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JusteattakeawayWatchman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"justeattakeaway.watchman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetkeyvaultsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetkeyvaultsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PimixAppsSubutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pimix.apps.subutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WinAcme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"win-acme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftDotdownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.dotdownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGcdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gcdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutosystemDevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autosystem.devops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApiverseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apiverse.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureAuditCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-audit-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolidrpcOpenapiDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solidrpc.openapi.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AllintraDevAuthenticator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"allintra.dev.authenticator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Authenticodelint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"authenticodelint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PiralBlazorAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"piral.blazor.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lbi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lbi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltcodeGendarmeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altcode.gendarme-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AcceleratePackageRestore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"accelerate-package-restore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodecovTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecov.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkyapmDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyapm.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azurediagramgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azurediagramgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArborBuildBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arbor.build.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetsparkCleanarchitectureScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netspark.cleanarchitecture.scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Antlr4codegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"antlr4codegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FurionTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"furion.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeCellsUnlock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.cells.unlock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Appinsightstestpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appinsightstestpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenerateApiProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generate-api-proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azdoutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azdoutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SoftmakeallCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"softmakeall.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azurespeechcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azurespeechcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoDotnetCodeAnalysisOverridesCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.dotnet.code.analysis.overrides.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azres(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azres {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeCellsMerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.cells.merger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArfwareArfblocksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arfware.arfblocks-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HyparCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hypar.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApstoryScaffoldApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apstory.scaffold.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Amgbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amgbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AwslambdaAspnetcoreappmeshCatalog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"awslambda.aspnetcoreappmesh.catalog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bri(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bri {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftIpmicontroller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.ipmicontroller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LimeflightOpenapiDiffAction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"limeflight.openapi.diff.action {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Refitter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"refitter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlethicSqlserverDeploymentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alethic.sqlserver.deployment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KumuluzApipublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kumuluz.apipublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KmdLogicGatewayAutomationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kmd.logic.gateway.automation.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aspnetcoresharedserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspnetcoresharedserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-aop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArmonikUtilsDocextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"armonik.utils.docextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Boots(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"boots {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArgentiniFdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"argentini.fdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftNibot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.nibot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MsidentityAppSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msidentity-app-sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command A19029ServicesFrameworkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"a19029.services.framework.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EdiAzureblobsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"edi.azureblobsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzuxirenAionianTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuxiren.aionian.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftStatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.static {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FreesqlAdminlteTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"freesql.adminlte.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TerevintosoftwareAadappregistryTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"terevintosoftware.aadappregistry.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}