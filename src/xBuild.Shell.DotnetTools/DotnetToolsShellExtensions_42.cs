using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command SuiClientWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sui.client.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Recastcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"recastcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TddxtNhotspotConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tddxt.nhotspot.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarketToolsChartpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"market.tools.chartpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypescriptclassgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typescriptclassgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoDspCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.dsp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XkpasswdCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xkpasswd.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Consolpunke(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"consolpunke {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetorbIdlcompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetorb.idlcompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XenialCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xenial.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkConsoleservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.consoleservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SnowflakeToolingCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snowflake.tooling.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoresuitCrudgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coresuit-crudgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodeminicUuidgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codeminic.uuidgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlainsqlMigrationsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plainsql.migrations.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Customvisiondevopscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"customvisiondevopscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GithubexplorerCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubexplorer.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EpochCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"epoch-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Processnswagclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"processnswagclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GhulTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ghul.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tmcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tmcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cliguidgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cliguidgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Opinionatedcsharptodos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opinionatedcsharptodos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConfigComparer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"config-comparer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MongochainsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mongochains.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xlsx2csv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xlsx2csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChecknpmpackagesDotnetclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"checknpmpackages.dotnetclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarkdownsnippetsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdownsnippets.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codedocumentation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codedocumentation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slackwebhookcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slackwebhookcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cqrscligenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cqrscligenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FrcDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"frc.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xmldoc2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xmldoc2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csgettext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csgettext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EntityframeworkcoreSqlserverSeedingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entityframeworkcore.sqlserver.seeding.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqltocsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqltocsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WbrezaCertificateTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wbreza-certificate-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ResumeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resume-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetacontextTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metacontext.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LibraryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"library.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Raztrackerclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"raztrackerclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SayedhaCommands(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sayedha.commands {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cscompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cscompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SaburaiisCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saburaiis.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkClipboard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.clipboard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Serialportcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"serialportcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCertificateTool21(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-certificate-tool-2.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwitchCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"switch-cli-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HexagramsOidccli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hexagrams.oidccli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DitheryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dithery-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hammer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hammer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clilinq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clilinq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CesiumCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cesium.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cmsnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cmsnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rw7DotnetsecuritytoolsClientcredentialscreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rw7.dotnetsecuritytools.clientcredentialscreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMarkdownSampleCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-markdown-sample-code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csvcodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csvcodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DaxOptimizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dax.optimizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ClockTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clock_test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CdcsharpToolsXmldoctomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cdcsharp.tools.xmldoctomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetjsoncheckTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetjsoncheck.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftVisualstudioSlngenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.visualstudio.slngen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TiveriadStudioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tiveriad.studio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkRestclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.restclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Carp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"carp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGcmon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gcmon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QiyqiriqCrud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qiyqiriq-crud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ObfustarConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"obfustar.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rw7DotnetsecuritytoolsJsonwebkeycreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rw7.dotnetsecuritytools.jsonwebkeycreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UescriptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uescript.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TopswagcodeCliPodcastplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topswagcode.cli.podcastplayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionDevjwtCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.devjwt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ItnDotnetNewclassgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"itn.dotnet.newclassgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coakeygen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coakeygen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EntitydbMongodbProvisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entitydb.mongodb.provisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markdown2pdfConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdown2pdf.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CilverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cilver-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GarnetServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"garnet-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cargowisereporttemplatecreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cargowisereporttemplatecreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GiraffeHotreloadCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"giraffe.hotreload.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlugfyCoreExtensionLibraryRunnerDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plugfy.core.extension.library.runner.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CreateFeature(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"create-feature {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Changeset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"changeset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TiliedCstojsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tilied.cstojs_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Createcommandhandler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"createcommandhandler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SurityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"surity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HellopackCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hellopack.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zgencodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zgencodegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCalcengine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-calcengine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FevalCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"feval.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuget.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CdcsharpToolsGeneratorsrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cdcsharp.tools.generatorsrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ContosoSpacesConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"contoso.spaces.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScaleoutInvocationgridCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scaleout.invocationgrid.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GoogleCloudToolsReleaseprogressreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"google.cloud.tools.releaseprogressreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FshOrchardcorePoextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsh.orchardcore.poextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesJnetreflector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.jnetreflector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Octonautscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octonautscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HadesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hades-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Envconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"envconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}