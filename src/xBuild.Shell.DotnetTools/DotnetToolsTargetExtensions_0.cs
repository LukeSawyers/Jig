using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T AmazonLambdaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwashbuckleAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swashbuckle.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azuresigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuresigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool60(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool-6.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AwsCodeartifactNugetCredentialprovider(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aws.codeartifact.nuget.credentialprovider {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool31(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool-3.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AwsDeployTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aws.deploy.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool80(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool-8.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool21(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool-2.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftOpenapiKiota(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.openapi.kiota {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CakeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cake.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonElasticbeanstalkTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.elasticbeanstalk.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nbgv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nbgv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpecsyncAzuredevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"specsync.azuredevops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApacheAvroTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apache.avro.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAspnetCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-aspnet-codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetReportgeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-reportgenerator-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VoloAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"volo.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T App(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DdTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dd-trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonEcsTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.ecs.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApimDevopsToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apim.devops.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSonarscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sonarscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAffected(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-affected {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltcoverGlobal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altcover.global {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AwsDeployCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aws.deploy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ari(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ari {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apkdiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apkdiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NswagConsolecore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nswag.consolecore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool50(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool-5.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftOpenapiHidi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.openapi.hidi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UpgradeAssistant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"upgrade-assistant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HopexApplicationserverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hopex.applicationserver.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApprioEnablementInfrastructureServicebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apprio.enablement.infrastructure.servicebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureCostCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-cost-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool70(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool-7.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AndroidsdkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"androidsdk.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AspireCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspire.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAppsettings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-appsettings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NukeGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuke.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCstApplicationinspectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.cst.applicationinspector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftPowerappsCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.powerapps.cli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AhsokaCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ahsoka.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiwinsRocketCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiwins.rocket.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AterDry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ater.dry {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VoloAbpStudioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"volo.abp.studio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChrAvroCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chr.avro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aspirate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspirate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltcoverVisualizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altcover.visualizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutoTester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"auto-tester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PimixAppsFileutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pimix.apps.fileutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssemblyDiffer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assembly-differ {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutosdkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autosdk.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetMsidentity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-msidentity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsharpAnalyzers(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsharp-analyzers {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArgentiniSfumato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"argentini.sfumato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftNugetninjaPrbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.nugetninja.prbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureBicepRegistrymoduletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure.bicep.registrymoduletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftNugetninja(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.nugetninja {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetsparkleupdaterToolsAppcastgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netsparkleupdater.tools.appcastgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T P(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"p {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SecurityScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"security-scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adaptify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adaptify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssemblyRewriter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assembly-rewriter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdlianceQmdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adliance.qmdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azdoi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azdoi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConfluentApacheAvroAvrogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"confluent.apache.avro.avrogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PpyLocalisationanalyserTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ppy.localisationanalyser.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aicommitmessage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aicommitmessage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntuneappbuilderConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intuneappbuilder.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftDotlang(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.dotlang {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AcrSynctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"acr-synctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDataapibuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dataapibuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdrivaDevtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adriva.devtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apiport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apiport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EasyabpAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easyabp.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCstAttacksurfaceanalyzerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.cst.attacksurfaceanalyzer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsDevaccesssetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.devaccesssetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AistantDocimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aistant.docimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtcRestApiGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atc-rest-api-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Checkbinarycompat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"checkbinarycompat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApprioToolsDotnetversionbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apprio.tools.dotnetversionbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmazonLambdaTesttool90(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amazon.lambda.testtool-9.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftAzureSignalrEmulator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.azure.signalr.emulator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"api-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Husky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"husky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aardpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aardpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtechRingDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atech.ring.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SarifMultitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sarif.multitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NservicebusTransportAzureservicebusCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nservicebus.transport.azureservicebus.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AterDropletCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ater.droplet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetApicompatTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet.apicompat.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotswashbuckleAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotswashbuckle.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnduinParser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anduin.parser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}