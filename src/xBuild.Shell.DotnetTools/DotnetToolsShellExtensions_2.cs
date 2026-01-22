using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Azuresign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuresign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppyOp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appy-op {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArqanoreTexgeneratorLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arqanore.texgenerator.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PublicapigeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"publicapigenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftVoyager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.voyager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArqanoreFontgeneratorLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arqanore.fontgenerator.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azcosmoscopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azcosmoscopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Automate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"automate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azuretrustedsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuretrustedsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsosUsersecretsretriever(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asos.usersecretsretriever {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azutilities(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azutilities {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azwikilinkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azwikilinkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Abpdevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"abpdevtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Avnrepository(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avnrepository {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AjunaDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ajuna.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PimixAppsJobutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pimix.apps.jobutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aardwars(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aardwars {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftTemplateengineAuthoringCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.templateengine.authoring.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adxutilities(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adxutilities {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppledevTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appledev.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdeotekDevopstools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adeotek.devopstools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DecsmAtomTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"decsm.atom.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AwsKclBootstrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aws-kcl-bootstrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CratisApplicationsProxygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cratis.applications.proxygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApplicationregistryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"applicationregistry.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnduinHappyrecorder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anduin.happyrecorder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzsUtil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azs-util {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azurepipelinetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azurepipelinetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureStorageCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-storage-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AbfibinCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"abfibin.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureResourcesCleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-resources-cleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ardalis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ardalis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArborNugetGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arbor.nuget.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Avonetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avonetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Blobify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blobify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AyasunaFrostseek(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ayasuna.frostseek {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command H5ElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"h5.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsmVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asm-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XamarinAndroidbinderatorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xamarin.androidbinderator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnkitmehtameRestclientapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ankitmehtame.restclientapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlpheusCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alpheus-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StackageAwsLambdaFakeruntime(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stackage.aws.lambda.fakeruntime {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAwsapigatewayintegrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-awsapigatewayintegrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Semveranalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"semveranalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftAzureKustoLightingest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.azure.kusto.lightingest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenerateaspnetcoreclientRefit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generateaspnetcoreclient.refit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Makegenericagain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"makegenericagain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AspirerunnerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspirerunner.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftHttping(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.httping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposePubConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.pub.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cyclonedx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cyclonedx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Acuwebsitemanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"acuwebsitemanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WivuuAztablecopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wivuu.aztablecopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzSnapshot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"az-snapshot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlmaDebugify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alma.debugify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docfxopenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docfxopenapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusGetassemblyversiontask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.getassemblyversiontask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Allseer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"allseer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdlianceAzuretools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adliance.azuretools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YaosOpenapiDiffAction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yaos.openapi.diff.action {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArborKvconfigurationGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arbor.kvconfiguration.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AirCliTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"air-cli-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnnostractTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"annostract.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AfasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"afas-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Archy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"archy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autorelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autorelease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtcKepwareConfiguration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atc-kepware-configuration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RxbimAcadtestsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rxbim.acadtests.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Armdotconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"armdotconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Avaloniaextensiongenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaextensiongenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AelfCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aelf.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqlserverAdministrativeviews(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlserver.administrativeviews {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autowifilogin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autowifilogin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctopusDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octopus.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetScript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-script {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppcoreSigningtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appcore.signingtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolanaUnityAnchorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solana.unity.anchor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArgentiniSqlpkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"argentini.sqlpkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Atgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Avoneserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avoneserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuestpdfPreviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"questpdf.previewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCognitiveservicesSpeechCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.cognitiveservices.speech.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Abpvue(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"abpvue {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutomaticaPluginStandalone(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"automatica-plugin-standalone {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetcoreforceModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netcoreforce.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LionAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lion.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AndtechRaccoon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"andtech.raccoon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BtTestagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bt.testagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArqanoreFontgeneratorWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arqanore.fontgenerator.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArqanoreTexgeneratorWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arqanore.texgenerator.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Assetbundlemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assetbundlemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusWriteappversiontask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.writeappversiontask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nukeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nukeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsApichangeloggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.apichangeloggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Abptools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"abptools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftGptclientChatconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.gptclient.chatconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AndtechCodecastConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"andtech.codecast.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}