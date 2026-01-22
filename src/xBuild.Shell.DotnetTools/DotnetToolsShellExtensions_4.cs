using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command AigeeksquadImagegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aigeeksquad.imagegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThreaxProvisionCheapazure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"threax.provision.cheapazure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlnetOsxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet-osx-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Assemblyxml2doc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assemblyxml2doc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SemantickernelAgentsDatabaseagentMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"semantickernel.agents.databaseagent.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtcRestApiGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atc-rest-api-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetScaffoldAspnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-scaffold-aspnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AustinsTailwindcsstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"austins.tailwindcsstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsharpAvroApacheTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsharp.avro.apache.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AgilecodingExtentionsAttributes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"agilecoding.extentions.attributes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Asalkhanovtesttask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asalkhanovtesttask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CriteoOpenapiComparatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"criteo.openapi.comparator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArborNugetconfigGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arbor.nugetconfig.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutomatoTasks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"automato.tasks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeImagingImageConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.imaging.image-convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rapicgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rapicgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AllowedPublisherWindowsservices(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"allowed.publisher.windowsservices {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azqmon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azqmon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDelice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-delice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureAppRolesAssigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-app-roles-assigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EirAutomate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eir.automate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coalesce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coalesce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FlubucoreGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flubucore.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Asciiart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asciiart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AterEasydocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ater.easydocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvrogenNetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avrogen.net.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiDevelopertoolsMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.developertools.macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtlasEf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atlas-ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FredoqwAlfaProterminalMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fredoqw.alfa.proterminal.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArasCodeAuditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aras-code-auditor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ib(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ib {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AworkBackendCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"awork-backend-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MiruCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"miru.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BuildersoftAndyXCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"buildersoft.andy.x.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureDailyCostCompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-daily-cost-compare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlexaNetSkillflowTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alexa.net.skillflow.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AitsysChangeloggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aitsys.changeloggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiDevelopertoolsLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.developertools.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzOpsSb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"az-ops-sb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devacceleratetools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devacceleratetools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azurevsixsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azurevsixsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Altseed2Tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altseed2.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Antdesignhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"antdesignhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ahqstorecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ahqstorecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnniumVersioning(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"annium.versioning {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LingyunAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lingyun.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AjaveNetCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ajave.net.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dcmanonymize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dcmanonymize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmbaRabbitmqtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amba.rabbitmqtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeImagingImageMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.imaging.image-merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArtemisrgbToolsPluginuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"artemisrgb.tools.pluginuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAzdoArtifactsMultidownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-azdo-artifacts-multidownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiParcelWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.parcel.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autolocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autolocalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ahmadcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ahmadcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureAccessTokenGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-access-token-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlgelImagetopdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"algel.imagetopdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartcodeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartcode.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzappconfigtousersecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azappconfigtousersecrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltairisXml4webAzuresync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altairis.xml4web.azuresync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PassingwindAbpprojecttools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passingwind.abpprojecttools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RxbimAutocadtestsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rxbim.autocadtests.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Localappveyor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"localappveyor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeImagingImageResize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.imaging.image-resize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AcuitMarkdowntohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"acuit.markdowntohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltinnStudioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altinn.studio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Craftsman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"craftsman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Averestexe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"averestexe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtddAccelerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atdd-accelerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctonotesGithubupdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octonotes.githubupdater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Albionprofit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"albionprofit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command D2lAmazonLambdaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"d2l.amazon.lambda.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdzupPlayerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adzup.player.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Appsettingsdocgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appsettingsdocgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Args2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"args2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DependencyAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependency-analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtomicCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atomic.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzuretablestorageseederTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuretablestorageseeder.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AthyGeneratorConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"athy.generator.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Doaudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doaudit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Arcisaprocessmermaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arcisaprocessmermaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Appimager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appimager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docassembler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docassembler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IconresizeutilityApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iconresizeutility.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeCellsConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.cells.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftExtensionsAiEvaluationConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.extensions.ai.evaluation.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnqaRead(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anqa.read {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Assemblyrefscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assemblyrefscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BinkylabsOpenapiOverlaysTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"binkylabs.openapi.overlays.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusUpdatealldotnettools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.updatealldotnettools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeBarcodeGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.barcode.generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PullrequestreleasenotesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pullrequestreleasenotes.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KingsAbpvnextproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kings.abpvnextpro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aglet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aglet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HalaDatabaseagentOraclemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hala.databaseagent.oraclemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeBarcodeRecognize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.barcode.recognize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenapitorefitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapitorefit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azddns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azddns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Snapx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snapx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Youtubearchiver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"youtubearchiver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}