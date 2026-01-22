using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command AmazonLambdaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwashbuckleAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swashbuckle.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azuresigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuresigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool60(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool-6.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AwsCodeartifactNugetCredentialprovider(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aws.codeartifact.nuget.credentialprovider {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool31(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool-3.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AwsDeployTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aws.deploy.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool80(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool-8.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool21(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool-2.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftOpenapiKiota(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.openapi.kiota {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CakeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cake.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonElasticbeanstalkTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.elasticbeanstalk.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nbgv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nbgv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpecsyncAzuredevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"specsync.azuredevops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApacheAvroTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apache.avro.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAspnetCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-aspnet-codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetReportgeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-reportgenerator-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VoloAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"volo.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command App(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DdTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dd-trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonEcsTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.ecs.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApimDevopsToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apim.devops.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSonarscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sonarscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAffected(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-affected {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltcoverGlobal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altcover.global {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AwsDeployCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aws.deploy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ari(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ari {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apkdiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apkdiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NswagConsolecore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nswag.consolecore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool50(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool-5.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftOpenapiHidi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.openapi.hidi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UpgradeAssistant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"upgrade-assistant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HopexApplicationserverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hopex.applicationserver.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApprioEnablementInfrastructureServicebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apprio.enablement.infrastructure.servicebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureCostCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-cost-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool70(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool-7.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AndroidsdkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"androidsdk.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AspireCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspire.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAppsettings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-appsettings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NukeGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuke.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCstApplicationinspectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.cst.applicationinspector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftPowerappsCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.powerapps.cli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AhsokaCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ahsoka.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiwinsRocketCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiwins.rocket.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AterDry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ater.dry {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VoloAbpStudioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"volo.abp.studio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChrAvroCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chr.avro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aspirate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspirate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltcoverVisualizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altcover.visualizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutoTester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"auto-tester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PimixAppsFileutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pimix.apps.fileutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssemblyDiffer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assembly-differ {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutosdkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autosdk.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetMsidentity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-msidentity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsharpAnalyzers(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsharp-analyzers {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArgentiniSfumato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"argentini.sfumato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftNugetninjaPrbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.nugetninja.prbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureBicepRegistrymoduletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure.bicep.registrymoduletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftNugetninja(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.nugetninja {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetsparkleupdaterToolsAppcastgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netsparkleupdater.tools.appcastgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command P(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"p {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SecurityScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"security-scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adaptify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adaptify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssemblyRewriter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assembly-rewriter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdlianceQmdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adliance.qmdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azdoi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azdoi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConfluentApacheAvroAvrogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"confluent.apache.avro.avrogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PpyLocalisationanalyserTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ppy.localisationanalyser.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aicommitmessage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aicommitmessage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntuneappbuilderConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intuneappbuilder.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftDotlang(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.dotlang {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AcrSynctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"acr-synctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDataapibuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dataapibuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdrivaDevtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adriva.devtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apiport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apiport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EasyabpAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easyabp.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCstAttacksurfaceanalyzerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.cst.attacksurfaceanalyzer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsDevaccesssetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.devaccesssetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AistantDocimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aistant.docimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtcRestApiGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atc-rest-api-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Checkbinarycompat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"checkbinarycompat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApprioToolsDotnetversionbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apprio.tools.dotnetversionbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmazonLambdaTesttool90(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amazon.lambda.testtool-9.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftAzureSignalrEmulator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.azure.signalr.emulator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"api-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Husky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"husky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aardpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aardpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtechRingDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atech.ring.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SarifMultitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sarif.multitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NservicebusTransportAzureservicebusCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nservicebus.transport.azureservicebus.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AterDropletCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ater.droplet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetApicompatTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet.apicompat.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotswashbuckleAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotswashbuckle.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnduinParser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anduin.parser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}