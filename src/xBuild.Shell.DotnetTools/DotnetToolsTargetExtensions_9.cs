using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Githubassetsdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubassetsdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fs.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DtAireviewTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dt.aireview.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LifaAbpproCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lifa.abppro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RestapigeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"restapigenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RafaelldiDiagnosticsagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rafaelldi.diagnosticsagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IsopAutoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"isop.auto.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NoxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nox.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GunslingerOpenapiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gunslinger.openapi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LspuseCsharpOsxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lspuse.csharp.osx-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetblazorproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetblazorproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T D7Artisan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"d7.artisan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowReactorAgent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.reactor.agent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AudaciaAuthOpeniddictSeedingEntityframeworkcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"audacia.auth.openiddict.seeding.entityframeworkcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AudaciaAuthOpeniddictSeedingEntityframework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"audacia.auth.openiddict.seeding.entityframework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CrosstechXblocksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"crosstech.xblocks-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autoangularformgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autoangularformgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApprovaltestsTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"approvaltests.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PackagereferenceversiontoattributeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packagereferenceversiontoattribute.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsharpCodeAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharp.code.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetcorepalExtensionsCodeanalysisTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netcorepal.extensions.codeanalysis.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JonasmhSwashbuckleAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jonasmh.swashbuckle.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DvoituronFindandreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dvoituron.findandreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitCredentialManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-credential-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LomtecIdentityproviderAccesstoken(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lomtec.identityprovider.accesstoken {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CzfAppBackgroundKeepsysteminuse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"czf.app.background.keepsysteminuse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ErikliebenFaEsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eriklieben.fa.es.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAppsettingsOverride(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-appsettings-override {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypepackCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typepack.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Odata2pocoDotnetO2pgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"odata2poco.dotnet.o2pgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ResolverathenaCliclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resolverathena.cliclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltimeshProcesstestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altimesh.processtestrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TerevintosoftwareStaticsitegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"terevintosoftware.staticsitegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAzureNaming(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-azure-naming {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Promfilesdconfigappender(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"promfilesdconfigappender {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ObfuscarGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"obfuscar.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ResourceAllocator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resource.allocator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ErikejDacfxTsqlanalyzerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"erikej.dacfx.tsqlanalyzer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LombiqHostingMediathemeDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lombiq.hosting.mediatheme.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkActionbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.actionbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KnightsofthearkXmlconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"knightsoftheark.xmlconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Taskr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taskr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GetinstalledaddonsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"getinstalledaddons.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkIlasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.ilasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BokameraConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bokamera.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mck9595Apimocker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mck9595.apimocker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PullrequestreleasenotesDotnetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pullrequestreleasenotes.dotnetcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RxbimRevittestsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rxbim.revittests.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsRunautomationscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.runautomationscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Soundstretch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"soundstretch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mirucli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mirucli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Svgxaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svgxaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpAggregatorsStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.aggregators.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubdigestbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubdigestbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mycliapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mycliapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KarkasCodegenerationConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"karkas.codegeneration.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetConsolidate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-consolidate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SjpAvrotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sjp.avrotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EonacatHttpclientOpenapiGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eonacat.httpclient.openapi.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAutocommit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-autocommit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZastaiBuildApireferenceTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zastai.build.apireference.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProgrammeralToolsCodeupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"programmeral.tools.codeupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OsimAwsTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"osim.aws.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fluentassertionsmigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fluentassertionsmigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkIpaddress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.ipaddress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TerevintosoftwareStaticsitegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"terevintosoftware.staticsitegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IlnumericsLicenseActivation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ilnumerics.license.activation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CanpolatTalo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"canpolat.talo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xdefaultapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xdefaultapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VsSecrets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vs-secrets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFileAssociatorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-file-associator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapispectomodelconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapispectomodelconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SblueminAiWorks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sbluemin.ai-works {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilentToolHexagonalCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"silent.tool.hexagonal.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAutograph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-autograph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VulnerabilitytosonarissueconverterApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vulnerabilitytosonarissueconverter.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MsiAllocator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msi.allocator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CleanarchitecturebootstrapperConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cleanarchitecturebootstrapper.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetsshApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetssh.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReactorMauiHotreload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reactor.maui.hotreload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppreviewfetchMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appreviewfetch.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppreviewfetchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appreviewfetch.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VuisisFormulaArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vuisis.formula.arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Myconsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myconsoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ccpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ccpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbupAddmigrations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbup.addmigrations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonAlignmentbasedquantstatistics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.alignmentbasedquantstatistics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HigrowAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"higrow.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapitransfer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapitransfer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Arbor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arbor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gameassetarchive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gameassetarchive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EaaAiReview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eaa.ai.review {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CalebsWebapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"calebs.webapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T C1DataengineTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"c1.dataengine.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Entraauthcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entraauthcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VishelAwsS3Tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vishel.aws.s3.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lottiegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lottiegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cotopaxi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cotopaxi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}