using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T AxisnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"axisnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetZip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-zip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Askgpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"askgpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AllagiEndpointCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"allagi.endpoint.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesKnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.knetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AviationexamDependencyupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aviationexam.dependencyupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApizrToolsNswag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apizr.tools.nswag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureBoardsWorkitems(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-boards-workitems {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiDevelopertoolsWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.developertools.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThebytestuffAzuretableutilitiescommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thebytestuff.azuretableutilitiescommandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AgatelibContentassembler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"agatelib.contentassembler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsApitestcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.apitestcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsApisandboxgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.apisandboxgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzmonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azmon-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsApiclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.apiclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtddAcceleratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atdd-accelerator-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsApispecificationrefactorer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.apispecificationrefactorer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AugurkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"augurk.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsApitestgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.apitestgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArchetypicalSoftwareVegaDeployment(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"archetypical.software.vega.deployment {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtcOpcUa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atc-opc-ua {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azdomerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azdomerger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdependsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adepends.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AssecoToolsApifacadegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asseco.tools.apifacadegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApimundoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apimundo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lazystackapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lazystackapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetApimsanitizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-apimsanitizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Architecturedecisionrecords(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"architecturedecisionrecords {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiDevelopertools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.developertools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenapigeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapigenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Appcompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appcompare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AuroraTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aurora_tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloudawesomeDataverseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudawesome.dataverse.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeFontMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.font.merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apilens(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apilens {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsharpasyncgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpasyncgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltcodeVswhat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altcode.vswhat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtcAzureIot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atc-azure-iot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Servicebusadmin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"servicebusadmin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autoversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autoversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposePageConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.page.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AicodereviewTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aicodereview.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeTexConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.tex.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAntlr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-antlr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaxdonApimupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maxdon.apimupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusCopyaftercompiletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.copyaftercompiletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdrtoolCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adrtool.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IoAstrodynamicsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"io.astrodynamics.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvanavoCopilotinstructions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avanavo.copilotinstructions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Arc4uLicmanagerAdmintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arc4u.licmanager.admintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GoodbyeWordpress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"goodbye-wordpress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YsKnifeApiClientGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ys.knife.api.client.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnniumXsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"annium.xs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aptrepobuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aptrepobuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azureutilities(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azureutilities {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDependencyAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dependency-analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LocalstackAwslocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"localstack.awslocal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApplandAppmap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appland.appmap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NmfAnytextgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nmf-anytextgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArgentiniOllamafarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"argentini.ollamafarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureliquidPreview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azureliquid.preview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeFontConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.font.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmitsoNafToolsAppinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smitso.naf.tools.appinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AcuhackElastic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"acuhack-elastic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LambdasharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lambdasharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetScaffoldAspire(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-scaffold-aspire {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChangedbConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"changedb.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetcorextToolsAssemblyinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netcorext.tools.assemblyinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Apimanagementapiimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apimanagementapiimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autosite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autosite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azureeventgridsimulator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azureeventgridsimulator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdlianceToolsLocalize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adliance.tools.localize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnniumDoclint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"annium.doclint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsNugetprebuildapplybranchortag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetprebuildapplybranchortag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnniumXrest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"annium.xrest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAppcat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-appcat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azdevbridgecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azdevbridgecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JhAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jh.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AgibuildModulusCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"agibuild.modulus.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Appvey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appvey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScaleoutAzuredigitaltwinsModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scaleout.azuredigitaltwins.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftGeminibot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.geminibot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Arasmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arasmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTarball(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tarball {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KontentAiModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kontent.ai.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltairisTmdCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altairis.tmd.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolnetAnchorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solnet.anchor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Linq2dbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linq2db.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adr-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApacheAvroToolsAvrogenms6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apache.avro.tools.avrogenms.6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftSqlpackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.sqlpackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiParcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.parcel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cosmicworks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cosmicworks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AggregategrootCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aggregategroot.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltairisHarrasCoursewaresync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altairis.harras.coursewaresync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsynkronProfiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asynkron-profiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YoushowAceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"youshow.ace.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}