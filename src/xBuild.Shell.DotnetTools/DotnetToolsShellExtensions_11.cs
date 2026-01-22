using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command GportUpgradeallprojects(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gport.upgradeallprojects {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitopsautomation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitopsautomation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MobileactGitlablabelsetupper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mobileact.gitlablabelsetupper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PerfolizerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"perfolizer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelerikAspnetmvcMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telerik.aspnetmvc.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitcommitanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitcommitanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VaettirnetPixelsdiceAnimationimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vaettirnet.pixelsdice.animationimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HertzoleDocfx2astro(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hertzole.docfx2astro {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XperiencecommunityDatabaseanonymizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xperiencecommunity.databaseanonymizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HonaCodereviewai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hona.codereviewai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XseineDotbond(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xseine.dotbond {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PowerprepareApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"powerprepare.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-watch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlanarCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"planar-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pks-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetaudit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetaudit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VirtocommerceGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"virtocommerce.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EvanAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"evan.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctonotesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octonotes.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ImagegliderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imageglider.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WebPing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"web.ping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Orcaanalysiscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"orcaanalysiscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Purgh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"purgh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cmdconsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cmdconsoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PolyapiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"polyapi.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Camerasyncapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"camerasyncapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IndStudioScada(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ind-studio-scada {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cranky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cranky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenmudMudpilerCompilerProjectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openmud.mudpiler.compiler.project.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkAlfrescoadduser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.alfrescoadduser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NikiforovallCopypaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nikiforovall.copypaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FirecrawlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"firecrawl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartcardAppledevTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartcard.appledev.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeimdalExtractopenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deimdal.extractopenapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Currentweatherapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"currentweatherapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DecsmToolsArtifactclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"decsm.tools.artifactclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OneAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"one.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SurveilyHydraTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"surveily.hydra.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testconsoleapp2021(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testconsoleapp2021 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FunitRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"funit.run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IsIotIpcServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"is-iot-ipc-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWorkflowGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-workflow-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PerfyApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"perfy-app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BanjoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"banjo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IncrementalistCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"incrementalist.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredentialswriterAws(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credentialswriter.aws {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TimheuerDumpall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timheuer.dumpall {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSnow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-snow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDynamicsBusinesscentralDevelopmentToolsOsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dynamics.businesscentral.development.tools.osx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FlcdrgAu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flcdrg.au {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetPackagesourcemapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuget.packagesourcemapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Npgsqlsm3authbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"npgsqlsm3authbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubapicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubapicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PromptstreamAiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"promptstream.ai.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vcr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vcr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Whatarch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"whatarch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Componentschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"componentschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Typorauploaderazure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typorauploaderazure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Epicdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"epicdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TogglNormalizebomandeol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toggl.normalizebomandeol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MagicsuiteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"magicsuite.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetcoreDocpal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netcore-docpal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SigmaorigoSwdl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sigmaorigo.swdl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChangelogautomationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"changelogautomation.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapimodelcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapimodelcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlnLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sln.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Internalaccessiblecsctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"internalaccessiblecsctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NunitConsolerunnerNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nunit.consolerunner.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenapiToTerraformRevisioncli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapi-to-terraform.revisioncli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deepstrip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deepstrip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B2aDbtulaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b2a.dbtula.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Brewupapitemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brewupapitemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BacklangDebugadapter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"backlang.debugadapter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ghx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ghx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mergejsonapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mergejsonapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UirealtimecommunicatorTypescriptgeneratorDevelop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uirealtimecommunicator.typescriptgenerator-develop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RunnerClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runner.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KullDbaccesscodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kull.dbaccesscodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CreateKenticoAppConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"create-kentico-app.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotadr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotadr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TiveriadStudioConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tiveriad.studio.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scorecardgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scorecardgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mytoolapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mytoolapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapicodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapicodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VijayanandSlnx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vijayanand.slnx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MyfreesqlGeneratorAws(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myfreesql.generator.aws {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenerateverticalslicearchitectureFluentresults(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generateverticalslicearchitecture.fluentresults {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomBingsearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.bingsearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MessageManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"message-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsonconfigflatter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsonconfigflatter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JibanMultiprojpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jiban.multiprojpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BannerlordLocalizationparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bannerlord.localizationparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MyanimelistCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myanimelist.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftAgentsCopilotstudioMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.agents.copilotstudio.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GhusncloudservicesAspnetcorePublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ghusncloudservices.aspnetcore.publisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MythTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myth.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pbm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pbm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nameoftheapplication(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nameoftheapplication {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}