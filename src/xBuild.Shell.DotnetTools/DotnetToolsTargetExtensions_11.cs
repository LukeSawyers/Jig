using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T GportUpgradeallprojects(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gport.upgradeallprojects {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitopsautomation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitopsautomation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MobileactGitlablabelsetupper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobileact.gitlablabelsetupper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PerfolizerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"perfolizer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikAspnetmvcMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.aspnetmvc.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitcommitanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitcommitanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VaettirnetPixelsdiceAnimationimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vaettirnet.pixelsdice.animationimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HertzoleDocfx2astro(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hertzole.docfx2astro {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XperiencecommunityDatabaseanonymizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xperiencecommunity.databaseanonymizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HonaCodereviewai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hona.codereviewai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XseineDotbond(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xseine.dotbond {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PowerprepareApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"powerprepare.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-watch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlanarCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"planar-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pks-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetaudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetaudit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VirtocommerceGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"virtocommerce.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EvanAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"evan.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctonotesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octonotes.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ImagegliderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imageglider.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WebPing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"web.ping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Orcaanalysiscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"orcaanalysiscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Purgh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"purgh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cmdconsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cmdconsoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PolyapiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"polyapi.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Camerasyncapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"camerasyncapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IndStudioScada(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ind-studio-scada {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cranky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cranky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenmudMudpilerCompilerProjectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openmud.mudpiler.compiler.project.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAlfrescoadduser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.alfrescoadduser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NikiforovallCopypaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nikiforovall.copypaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FirecrawlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"firecrawl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartcardAppledevTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartcard.appledev.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeimdalExtractopenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deimdal.extractopenapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Currentweatherapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"currentweatherapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DecsmToolsArtifactclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"decsm.tools.artifactclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OneAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"one.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SurveilyHydraTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"surveily.hydra.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testconsoleapp2021(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testconsoleapp2021 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FunitRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"funit.run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IsIotIpcServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"is-iot-ipc-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWorkflowGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-workflow-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PerfyApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"perfy-app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BanjoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"banjo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IncrementalistCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"incrementalist.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredentialswriterAws(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credentialswriter.aws {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TimheuerDumpall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timheuer.dumpall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSnow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-snow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDynamicsBusinesscentralDevelopmentToolsOsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dynamics.businesscentral.development.tools.osx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FlcdrgAu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flcdrg.au {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetPackagesourcemapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuget.packagesourcemapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Npgsqlsm3authbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"npgsqlsm3authbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubapicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubapicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PromptstreamAiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"promptstream.ai.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vcr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vcr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Whatarch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"whatarch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Componentschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"componentschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Typorauploaderazure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typorauploaderazure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Epicdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"epicdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TogglNormalizebomandeol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toggl.normalizebomandeol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MagicsuiteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"magicsuite.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetcoreDocpal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netcore-docpal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SigmaorigoSwdl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sigmaorigo.swdl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChangelogautomationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"changelogautomation.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapimodelcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapimodelcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlnLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sln.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Internalaccessiblecsctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"internalaccessiblecsctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NunitConsolerunnerNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nunit.consolerunner.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenapiToTerraformRevisioncli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapi-to-terraform.revisioncli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deepstrip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deepstrip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B2aDbtulaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b2a.dbtula.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Brewupapitemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brewupapitemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BacklangDebugadapter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"backlang.debugadapter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ghx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ghx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mergejsonapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mergejsonapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UirealtimecommunicatorTypescriptgeneratorDevelop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uirealtimecommunicator.typescriptgenerator-develop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RunnerClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runner.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KullDbaccesscodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kull.dbaccesscodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CreateKenticoAppConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"create-kentico-app.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotadr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotadr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TiveriadStudioConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tiveriad.studio.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scorecardgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scorecardgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mytoolapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mytoolapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapicodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapicodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VijayanandSlnx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vijayanand.slnx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MyfreesqlGeneratorAws(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myfreesql.generator.aws {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenerateverticalslicearchitectureFluentresults(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generateverticalslicearchitecture.fluentresults {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomBingsearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.bingsearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MessageManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"message-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsonconfigflatter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsonconfigflatter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JibanMultiprojpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jiban.multiprojpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BannerlordLocalizationparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bannerlord.localizationparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MyanimelistCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myanimelist.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftAgentsCopilotstudioMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.agents.copilotstudio.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GhusncloudservicesAspnetcorePublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ghusncloudservices.aspnetcore.publisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MythTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myth.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pbm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pbm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nameoftheapplication(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nameoftheapplication {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}