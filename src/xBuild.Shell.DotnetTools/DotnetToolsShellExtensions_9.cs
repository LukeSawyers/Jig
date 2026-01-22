using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Githubassetsdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubassetsdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fs.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DtAireviewTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dt.aireview.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LifaAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lifa.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RestapigeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"restapigenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RafaelldiDiagnosticsagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rafaelldi.diagnosticsagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IsopAutoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"isop.auto.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NoxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nox.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GunslingerOpenapiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gunslinger.openapi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LspuseCsharpOsxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lspuse.csharp.osx-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetblazorproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetblazorproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command D7Artisan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"d7.artisan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowReactorAgent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.reactor.agent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AudaciaAuthOpeniddictSeedingEntityframeworkcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"audacia.auth.openiddict.seeding.entityframeworkcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AudaciaAuthOpeniddictSeedingEntityframework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"audacia.auth.openiddict.seeding.entityframework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CrosstechXblocksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"crosstech.xblocks-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autoangularformgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autoangularformgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApprovaltestsTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"approvaltests.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PackagereferenceversiontoattributeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packagereferenceversiontoattribute.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsharpCodeAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharp.code.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetcorepalExtensionsCodeanalysisTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netcorepal.extensions.codeanalysis.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JonasmhSwashbuckleAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jonasmh.swashbuckle.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DvoituronFindandreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dvoituron.findandreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitCredentialManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-credential-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LomtecIdentityproviderAccesstoken(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lomtec.identityprovider.accesstoken {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CzfAppBackgroundKeepsysteminuse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"czf.app.background.keepsysteminuse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ErikliebenFaEsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eriklieben.fa.es.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAppsettingsOverride(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-appsettings-override {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypepackCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typepack.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Odata2pocoDotnetO2pgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"odata2poco.dotnet.o2pgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ResolverathenaCliclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resolverathena.cliclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltimeshProcesstestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altimesh.processtestrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TerevintosoftwareStaticsitegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"terevintosoftware.staticsitegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAzureNaming(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-azure-naming {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Promfilesdconfigappender(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"promfilesdconfigappender {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ObfuscarGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"obfuscar.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ResourceAllocator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resource.allocator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ErikejDacfxTsqlanalyzerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"erikej.dacfx.tsqlanalyzer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LombiqHostingMediathemeDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lombiq.hosting.mediatheme.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkActionbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.actionbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KnightsofthearkXmlconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"knightsoftheark.xmlconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Taskr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taskr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GetinstalledaddonsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"getinstalledaddons.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkIlasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.ilasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BokameraConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bokamera.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mck9595Apimocker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mck9595.apimocker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PullrequestreleasenotesDotnetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pullrequestreleasenotes.dotnetcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RxbimRevittestsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rxbim.revittests.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsRunautomationscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.runautomationscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Soundstretch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"soundstretch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mirucli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mirucli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Svgxaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svgxaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpAggregatorsStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.aggregators.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubdigestbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubdigestbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mycliapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mycliapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KarkasCodegenerationConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"karkas.codegeneration.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetConsolidate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-consolidate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SjpAvrotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sjp.avrotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EonacatHttpclientOpenapiGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eonacat.httpclient.openapi.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAutocommit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-autocommit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZastaiBuildApireferenceTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zastai.build.apireference.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProgrammeralToolsCodeupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"programmeral.tools.codeupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OsimAwsTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"osim.aws.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fluentassertionsmigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fluentassertionsmigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkIpaddress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.ipaddress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TerevintosoftwareStaticsitegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"terevintosoftware.staticsitegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IlnumericsLicenseActivation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ilnumerics.license.activation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CanpolatTalo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"canpolat.talo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xdefaultapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xdefaultapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VsSecrets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vs-secrets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFileAssociatorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-file-associator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapispectomodelconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapispectomodelconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SblueminAiWorks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sbluemin.ai-works {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilentToolHexagonalCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"silent.tool.hexagonal.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAutograph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-autograph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VulnerabilitytosonarissueconverterApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vulnerabilitytosonarissueconverter.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MsiAllocator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msi.allocator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CleanarchitecturebootstrapperConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cleanarchitecturebootstrapper.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetsshApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetssh.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReactorMauiHotreload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reactor.maui.hotreload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppreviewfetchMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appreviewfetch.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppreviewfetchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appreviewfetch.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VuisisFormulaArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vuisis.formula.arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Myconsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myconsoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ccpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ccpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbupAddmigrations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbup.addmigrations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonAlignmentbasedquantstatistics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.alignmentbasedquantstatistics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HigrowAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"higrow.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapitransfer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapitransfer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Arbor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arbor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gameassetarchive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gameassetarchive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EaaAiReview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eaa.ai.review {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CalebsWebapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"calebs.webapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command C1DataengineTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"c1.dataengine.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Entraauthcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entraauthcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VishelAwsS3Tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vishel.aws.s3.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lottiegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lottiegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cotopaxi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cotopaxi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}