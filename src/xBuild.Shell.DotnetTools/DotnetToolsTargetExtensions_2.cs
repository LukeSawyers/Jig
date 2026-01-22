using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Azuresign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuresign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppyOp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appy-op {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArqanoreTexgeneratorLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arqanore.texgenerator.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PublicapigeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"publicapigenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftVoyager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.voyager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArqanoreFontgeneratorLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arqanore.fontgenerator.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azcosmoscopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azcosmoscopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Automate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"automate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azuretrustedsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuretrustedsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsosUsersecretsretriever(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asos.usersecretsretriever {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azutilities(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azutilities {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azwikilinkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azwikilinkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Abpdevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"abpdevtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Avnrepository(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avnrepository {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AjunaDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ajuna.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PimixAppsJobutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pimix.apps.jobutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aardwars(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aardwars {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftTemplateengineAuthoringCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.templateengine.authoring.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adxutilities(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adxutilities {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppledevTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appledev.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdeotekDevopstools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adeotek.devopstools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DecsmAtomTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"decsm.atom.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AwsKclBootstrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aws-kcl-bootstrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CratisApplicationsProxygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cratis.applications.proxygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApplicationregistryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"applicationregistry.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnduinHappyrecorder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anduin.happyrecorder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzsUtil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azs-util {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azurepipelinetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azurepipelinetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureStorageCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-storage-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AbfibinCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"abfibin.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureResourcesCleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-resources-cleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ardalis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ardalis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArborNugetGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arbor.nuget.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Avonetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avonetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Blobify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blobify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AyasunaFrostseek(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ayasuna.frostseek {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T H5ElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"h5.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsmVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asm-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XamarinAndroidbinderatorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xamarin.androidbinderator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnkitmehtameRestclientapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ankitmehtame.restclientapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlpheusCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alpheus-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StackageAwsLambdaFakeruntime(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stackage.aws.lambda.fakeruntime {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAwsapigatewayintegrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-awsapigatewayintegrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Semveranalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"semveranalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftAzureKustoLightingest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.azure.kusto.lightingest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenerateaspnetcoreclientRefit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generateaspnetcoreclient.refit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Makegenericagain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"makegenericagain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AspirerunnerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspirerunner.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftHttping(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.httping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposePubConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.pub.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cyclonedx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cyclonedx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Acuwebsitemanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"acuwebsitemanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WivuuAztablecopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wivuu.aztablecopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzSnapshot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"az-snapshot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlmaDebugify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alma.debugify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docfxopenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docfxopenapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusGetassemblyversiontask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.getassemblyversiontask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Allseer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"allseer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdlianceAzuretools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adliance.azuretools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YaosOpenapiDiffAction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yaos.openapi.diff.action {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArborKvconfigurationGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arbor.kvconfiguration.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AirCliTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"air-cli-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnnostractTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"annostract.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AfasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"afas-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Archy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"archy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autorelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autorelease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtcKepwareConfiguration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atc-kepware-configuration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RxbimAcadtestsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rxbim.acadtests.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Armdotconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"armdotconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Avaloniaextensiongenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaextensiongenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AelfCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aelf.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqlserverAdministrativeviews(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlserver.administrativeviews {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autowifilogin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autowifilogin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctopusDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octopus.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetScript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-script {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppcoreSigningtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appcore.signingtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolanaUnityAnchorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solana.unity.anchor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArgentiniSqlpkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"argentini.sqlpkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Atgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Avoneserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avoneserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuestpdfPreviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"questpdf.previewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCognitiveservicesSpeechCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.cognitiveservices.speech.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Abpvue(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"abpvue {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutomaticaPluginStandalone(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"automatica-plugin-standalone {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetcoreforceModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netcoreforce.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LionAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lion.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AndtechRaccoon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"andtech.raccoon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BtTestagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bt.testagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArqanoreFontgeneratorWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arqanore.fontgenerator.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArqanoreTexgeneratorWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arqanore.texgenerator.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Assetbundlemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assetbundlemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusWriteappversiontask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.writeappversiontask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nukeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nukeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsApichangeloggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.apichangeloggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Abptools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"abptools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftGptclientChatconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.gptclient.chatconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AndtechCodecastConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"andtech.codecast.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}