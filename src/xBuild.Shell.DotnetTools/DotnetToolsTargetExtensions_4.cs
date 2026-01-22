using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T AigeeksquadImagegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aigeeksquad.imagegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThreaxProvisionCheapazure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"threax.provision.cheapazure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlnetOsxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet-osx-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Assemblyxml2doc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assemblyxml2doc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SemantickernelAgentsDatabaseagentMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"semantickernel.agents.databaseagent.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtcRestApiGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atc-rest-api-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetScaffoldAspnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-scaffold-aspnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AustinsTailwindcsstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"austins.tailwindcsstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsharpAvroApacheTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsharp.avro.apache.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AgilecodingExtentionsAttributes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"agilecoding.extentions.attributes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Asalkhanovtesttask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asalkhanovtesttask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CriteoOpenapiComparatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"criteo.openapi.comparator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArborNugetconfigGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arbor.nugetconfig.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutomatoTasks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"automato.tasks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeImagingImageConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.imaging.image-convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rapicgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rapicgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AllowedPublisherWindowsservices(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"allowed.publisher.windowsservices {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azqmon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azqmon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDelice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-delice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureAppRolesAssigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-app-roles-assigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EirAutomate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eir.automate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coalesce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coalesce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FlubucoreGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flubucore.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Asciiart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asciiart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AterEasydocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ater.easydocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvrogenNetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avrogen.net.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiDevelopertoolsMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.developertools.macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtlasEf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atlas-ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FredoqwAlfaProterminalMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fredoqw.alfa.proterminal.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArasCodeAuditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aras-code-auditor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ib(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ib {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AworkBackendCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"awork-backend-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MiruCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"miru.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BuildersoftAndyXCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"buildersoft.andy.x.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureDailyCostCompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-daily-cost-compare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlexaNetSkillflowTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alexa.net.skillflow.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AitsysChangeloggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aitsys.changeloggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiDevelopertoolsLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.developertools.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzOpsSb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"az-ops-sb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devacceleratetools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devacceleratetools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azurevsixsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azurevsixsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Altseed2Tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altseed2.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Antdesignhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"antdesignhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ahqstorecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ahqstorecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnniumVersioning(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"annium.versioning {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LingyunAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lingyun.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AjaveNetCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ajave.net.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dcmanonymize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dcmanonymize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmbaRabbitmqtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amba.rabbitmqtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeImagingImageMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.imaging.image-merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArtemisrgbToolsPluginuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"artemisrgb.tools.pluginuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAzdoArtifactsMultidownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-azdo-artifacts-multidownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiParcelWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.parcel.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autolocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autolocalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ahmadcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ahmadcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureAccessTokenGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-access-token-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlgelImagetopdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"algel.imagetopdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartcodeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartcode.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzappconfigtousersecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azappconfigtousersecrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltairisXml4webAzuresync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altairis.xml4web.azuresync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PassingwindAbpprojecttools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passingwind.abpprojecttools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RxbimAutocadtestsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rxbim.autocadtests.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Localappveyor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"localappveyor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeImagingImageResize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.imaging.image-resize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AcuitMarkdowntohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"acuit.markdowntohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltinnStudioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altinn.studio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Craftsman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"craftsman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Averestexe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"averestexe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtddAccelerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atdd-accelerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctonotesGithubupdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octonotes.githubupdater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Albionprofit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"albionprofit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T D2lAmazonLambdaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"d2l.amazon.lambda.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdzupPlayerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adzup.player.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Appsettingsdocgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appsettingsdocgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Args2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"args2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DependencyAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependency-analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtomicCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atomic.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzuretablestorageseederTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuretablestorageseeder.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AthyGeneratorConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"athy.generator.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Doaudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doaudit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Arcisaprocessmermaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arcisaprocessmermaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Appimager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appimager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docassembler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docassembler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IconresizeutilityApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iconresizeutility.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeCellsConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.cells.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftExtensionsAiEvaluationConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.extensions.ai.evaluation.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnqaRead(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anqa.read {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Assemblyrefscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assemblyrefscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BinkylabsOpenapiOverlaysTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"binkylabs.openapi.overlays.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusUpdatealldotnettools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.updatealldotnettools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeBarcodeGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.barcode.generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PullrequestreleasenotesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pullrequestreleasenotes.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KingsAbpvnextproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kings.abpvnextpro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aglet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aglet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HalaDatabaseagentOraclemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hala.databaseagent.oraclemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeBarcodeRecognize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.barcode.recognize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenapitorefitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapitorefit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azddns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azddns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Snapx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snapx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Youtubearchiver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"youtubearchiver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}