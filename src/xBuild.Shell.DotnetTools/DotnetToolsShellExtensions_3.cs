using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command AxisnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"axisnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetZip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-zip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Askgpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"askgpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AllagiEndpointCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"allagi.endpoint.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesKnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.knetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AviationexamDependencyupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aviationexam.dependencyupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApizrToolsNswag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apizr.tools.nswag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureBoardsWorkitems(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-boards-workitems {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiDevelopertoolsWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.developertools.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThebytestuffAzuretableutilitiescommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thebytestuff.azuretableutilitiescommandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AgatelibContentassembler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"agatelib.contentassembler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsApitestcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.apitestcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsApisandboxgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.apisandboxgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzmonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azmon-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsApiclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.apiclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtddAcceleratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atdd-accelerator-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsApispecificationrefactorer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.apispecificationrefactorer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AugurkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"augurk.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsApitestgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.apitestgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArchetypicalSoftwareVegaDeployment(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"archetypical.software.vega.deployment {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtcOpcUa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atc-opc-ua {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azdomerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azdomerger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdependsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adepends.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AssecoToolsApifacadegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asseco.tools.apifacadegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApimundoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apimundo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lazystackapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lazystackapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetApimsanitizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-apimsanitizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Architecturedecisionrecords(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"architecturedecisionrecords {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiDevelopertools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.developertools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenapigeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapigenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Appcompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appcompare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AuroraTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aurora_tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloudawesomeDataverseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudawesome.dataverse.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeFontMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.font.merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apilens(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apilens {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsharpasyncgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpasyncgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltcodeVswhat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altcode.vswhat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtcAzureIot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atc-azure-iot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Servicebusadmin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"servicebusadmin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autoversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autoversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposePageConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.page.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AicodereviewTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aicodereview.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeTexConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.tex.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAntlr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-antlr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaxdonApimupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maxdon.apimupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusCopyaftercompiletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.copyaftercompiletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdrtoolCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adrtool.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IoAstrodynamicsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"io.astrodynamics.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvanavoCopilotinstructions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avanavo.copilotinstructions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Arc4uLicmanagerAdmintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arc4u.licmanager.admintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GoodbyeWordpress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"goodbye-wordpress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YsKnifeApiClientGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ys.knife.api.client.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnniumXsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"annium.xs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aptrepobuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aptrepobuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azureutilities(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azureutilities {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDependencyAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dependency-analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LocalstackAwslocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"localstack.awslocal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApplandAppmap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appland.appmap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NmfAnytextgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nmf-anytextgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArgentiniOllamafarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"argentini.ollamafarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureliquidPreview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azureliquid.preview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeFontConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.font.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmitsoNafToolsAppinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smitso.naf.tools.appinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AcuhackElastic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"acuhack-elastic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LambdasharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lambdasharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetScaffoldAspire(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-scaffold-aspire {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChangedbConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"changedb.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetcorextToolsAssemblyinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netcorext.tools.assemblyinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Apimanagementapiimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apimanagementapiimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autosite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autosite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azureeventgridsimulator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azureeventgridsimulator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdlianceToolsLocalize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adliance.tools.localize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnniumDoclint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"annium.doclint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsNugetprebuildapplybranchortag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetprebuildapplybranchortag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnniumXrest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"annium.xrest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAppcat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-appcat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azdevbridgecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azdevbridgecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JhAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jh.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AgibuildModulusCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"agibuild.modulus.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Appvey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appvey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScaleoutAzuredigitaltwinsModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scaleout.azuredigitaltwins.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftGeminibot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.geminibot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Arasmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arasmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTarball(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tarball {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KontentAiModelgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kontent.ai.modelgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltairisTmdCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altairis.tmd.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolnetAnchorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solnet.anchor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Linq2dbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linq2db.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adr-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApacheAvroToolsAvrogenms6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apache.avro.tools.avrogenms.6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftSqlpackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.sqlpackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiParcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.parcel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cosmicworks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cosmicworks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AggregategrootCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aggregategroot.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltairisHarrasCoursewaresync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altairis.harras.coursewaresync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsynkronProfiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asynkron-profiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YoushowAceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"youshow.ace.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}