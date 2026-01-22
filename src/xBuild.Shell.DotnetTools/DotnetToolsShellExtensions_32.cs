using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command OresoftBlazoredxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oresoft.blazoredx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkGithubbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.githubbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EvdbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"evdb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HattrickCrockfordbase32Tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hattrick.crockfordbase32.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Specbridge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"specbridge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codebinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codebinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBuildFile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-build-file {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CorvusDeploymentPowerbiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"corvus.deployment.powerbi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Browserbookmarkstomd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"browserbookmarkstomd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BorgTransporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borg.transporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SayedhaBlackjackCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sayedha.blackjack.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetReferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-references {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tool.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InhaquitesSendmessagetotelegrambot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"inhaquites.sendmessagetotelegrambot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FssLibBuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fss-lib.builder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LeprechaunCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"leprechaun.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deletebinobj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deletebinobj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RuikuanBindingredirectrewriter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ruikuan.bindingredirectrewriter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TestgeneratorPluginbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testgenerator.pluginbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FunBuildCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fun.build.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BestedoMindvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bestedo.mindvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FivefortySqlbackupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fiveforty.sqlbackup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EasybuildChangeloggen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easybuild.changeloggen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KempdecBadynetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kempdec.badynet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Iotbytefont(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iotbytefont {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTypegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-typegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnumgeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"enumgenerator.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TurnersoftwareBuildversioningTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"turnersoftware.buildversioning.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KswareBuildtoolsIncrementversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ksware.buildtools.incrementversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SoloxBlazorjsonlocalizationToolsCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solox.blazorjsonlocalization.tools.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkTeambadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.teambadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StartupProjects(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"startup-projects {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloudtekBuildTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudtek.build.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jackywang118Botsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jackywang118.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DvwaBruteforceHighsecurity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dvwa_bruteforce_highsecurity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MilouDeployerBootstrapperGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"milou.deployer.bootstrapper.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YadayadasoftwareBuildtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yadayadasoftware.buildtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Monobuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monobuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MobroPluginCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mobro.plugin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ironbeardcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ironbeardcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Indexbundler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"indexbundler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Easybuildtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easybuildtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wasp3dSportsCricket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wasp3d.sports.cricket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Neelbook(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neelbook {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CommonBasichelperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"common.basichelper.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clibackuptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clibackuptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeoTestRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neo.test.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KarlsBettersecretstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"karls.bettersecretstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MintplayerRemoveobjbin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mintplayer.removeobjbin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditorWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditorLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Flxble(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flxble {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkSonarbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.sonarbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SbsharpLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sbsharp.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBingchat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-bingchat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesJcoreflectorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.jcoreflectorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LoremfoobarSolutionfiltergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"loremfoobar.solutionfiltergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QaBoomos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qa_boomos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Grate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditorMac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-mac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CastleblackNugetsources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"castleblack.nugetsources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cilbrowser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cilbrowser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkDebbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.debbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clientsideblazordeployhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clientsideblazordeployhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkVsmarketbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.vsmarketbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeoCompilerCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neo.compiler.csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FalanxTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"falanx.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SourcegearLlamaBc2cil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sourcegear.llama.bc2cil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicroserviceBlueprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microservice.blueprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xbehavereportgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xbehavereportgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DmWebBuildstatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dm.web.buildstatic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetbuf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetbuf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpecsyncJira(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"specsync.jira {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TastyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tasty-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MorleyDotnetBugreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"morley.dotnet.bugreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IronbadMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ironbad.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StormancerCppBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stormancer.cpp.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetIldasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ildasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CadpieBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cadpie.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeoskyeBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neoskye.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EsheepdevBloggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"esheepdev.bloggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TzfinderBuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tzfinder.builder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsefBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsef-base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkBase64url(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.base64url {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Runbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasaCompetitionBootsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"masa.competition.bootsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBuildapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-buildapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCoverageconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-coverageconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Staticsitebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"staticsitebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command W3tiOpenbasenetsqlserverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"w3ti.openbasenetsqlserver.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XyBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xy.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Flappybird(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flappybird {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotinstallBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotinstall.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Iconbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iconbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clibright(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clibright {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KornelijepetakBranchkill(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kornelijepetak.branchkill {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DzBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dz.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TeamcityCsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"teamcity.csi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}