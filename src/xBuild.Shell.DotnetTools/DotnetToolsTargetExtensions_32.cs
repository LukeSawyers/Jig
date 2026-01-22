using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T OresoftBlazoredxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oresoft.blazoredx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkGithubbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.githubbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EvdbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"evdb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HattrickCrockfordbase32Tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hattrick.crockfordbase32.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Specbridge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"specbridge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codebinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codebinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBuildFile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-build-file {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CorvusDeploymentPowerbiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corvus.deployment.powerbi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Browserbookmarkstomd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"browserbookmarkstomd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BorgTransporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borg.transporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SayedhaBlackjackCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sayedha.blackjack.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetReferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-references {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tool.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InhaquitesSendmessagetotelegrambot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"inhaquites.sendmessagetotelegrambot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FssLibBuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fss-lib.builder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LeprechaunCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"leprechaun.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deletebinobj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deletebinobj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RuikuanBindingredirectrewriter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ruikuan.bindingredirectrewriter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TestgeneratorPluginbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testgenerator.pluginbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FunBuildCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fun.build.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BestedoMindvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bestedo.mindvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FivefortySqlbackupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fiveforty.sqlbackup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EasybuildChangeloggen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easybuild.changeloggen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KempdecBadynetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kempdec.badynet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Iotbytefont(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iotbytefont {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTypegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-typegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnumgeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"enumgenerator.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TurnersoftwareBuildversioningTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"turnersoftware.buildversioning.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KswareBuildtoolsIncrementversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ksware.buildtools.incrementversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SoloxBlazorjsonlocalizationToolsCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solox.blazorjsonlocalization.tools.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkTeambadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.teambadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StartupProjects(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"startup-projects {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloudtekBuildTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudtek.build.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jackywang118Botsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jackywang118.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DvwaBruteforceHighsecurity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dvwa_bruteforce_highsecurity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MilouDeployerBootstrapperGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"milou.deployer.bootstrapper.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YadayadasoftwareBuildtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yadayadasoftware.buildtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Monobuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monobuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MobroPluginCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobro.plugin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ironbeardcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ironbeardcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Indexbundler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"indexbundler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Easybuildtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easybuildtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wasp3dSportsCricket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wasp3d.sports.cricket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Neelbook(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neelbook {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CommonBasichelperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"common.basichelper.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clibackuptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clibackuptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeoTestRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neo.test.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KarlsBettersecretstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"karls.bettersecretstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MintplayerRemoveobjbin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mintplayer.removeobjbin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditorWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditorLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Flxble(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flxble {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkSonarbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.sonarbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SbsharpLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sbsharp.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBingchat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-bingchat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesJcoreflectorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.jcoreflectorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LoremfoobarSolutionfiltergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"loremfoobar.solutionfiltergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QaBoomos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qa_boomos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Grate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditorMac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-mac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CastleblackNugetsources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"castleblack.nugetsources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cilbrowser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cilbrowser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkDebbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.debbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clientsideblazordeployhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clientsideblazordeployhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkVsmarketbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.vsmarketbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeoCompilerCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neo.compiler.csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FalanxTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"falanx.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SourcegearLlamaBc2cil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sourcegear.llama.bc2cil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicroserviceBlueprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microservice.blueprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xbehavereportgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xbehavereportgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DmWebBuildstatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dm.web.buildstatic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetbuf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetbuf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpecsyncJira(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"specsync.jira {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TastyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tasty-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MorleyDotnetBugreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"morley.dotnet.bugreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IronbadMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ironbad.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StormancerCppBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stormancer.cpp.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetIldasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ildasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CadpieBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cadpie.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeoskyeBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neoskye.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EsheepdevBloggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"esheepdev.bloggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TzfinderBuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tzfinder.builder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsefBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsef-base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkBase64url(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.base64url {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Runbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasaCompetitionBootsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"masa.competition.bootsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBuildapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-buildapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCoverageconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-coverageconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Staticsitebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"staticsitebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T W3tiOpenbasenetsqlserverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"w3ti.openbasenetsqlserver.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XyBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xy.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Flappybird(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flappybird {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotinstallBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotinstall.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Iconbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iconbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clibright(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clibright {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KornelijepetakBranchkill(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kornelijepetak.branchkill {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DzBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dz.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TeamcityCsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"teamcity.csi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}