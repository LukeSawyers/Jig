using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T SuiClientWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sui.client.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Recastcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"recastcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TddxtNhotspotConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tddxt.nhotspot.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarketToolsChartpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"market.tools.chartpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypescriptclassgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typescriptclassgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoDspCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.dsp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XkpasswdCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xkpasswd.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Consolpunke(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"consolpunke {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetorbIdlcompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetorb.idlcompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XenialCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xenial.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkConsoleservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.consoleservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SnowflakeToolingCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snowflake.tooling.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoresuitCrudgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coresuit-crudgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodeminicUuidgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codeminic.uuidgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlainsqlMigrationsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plainsql.migrations.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Customvisiondevopscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"customvisiondevopscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GithubexplorerCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubexplorer.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EpochCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"epoch-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Processnswagclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"processnswagclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GhulTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ghul.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tmcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tmcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cliguidgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cliguidgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Opinionatedcsharptodos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opinionatedcsharptodos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConfigComparer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"config-comparer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MongochainsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mongochains.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xlsx2csv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xlsx2csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChecknpmpackagesDotnetclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"checknpmpackages.dotnetclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarkdownsnippetsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdownsnippets.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codedocumentation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codedocumentation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slackwebhookcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slackwebhookcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cqrscligenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cqrscligenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FrcDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"frc.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xmldoc2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xmldoc2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csgettext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csgettext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EntityframeworkcoreSqlserverSeedingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entityframeworkcore.sqlserver.seeding.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqltocsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqltocsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WbrezaCertificateTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wbreza-certificate-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ResumeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resume-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetacontextTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metacontext.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LibraryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"library.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Raztrackerclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"raztrackerclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SayedhaCommands(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sayedha.commands {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cscompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cscompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SaburaiisCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saburaiis.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkClipboard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.clipboard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Serialportcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"serialportcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCertificateTool21(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-certificate-tool-2.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwitchCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"switch-cli-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HexagramsOidccli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hexagrams.oidccli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DitheryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dithery-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hammer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hammer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clilinq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clilinq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CesiumCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cesium.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cmsnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cmsnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rw7DotnetsecuritytoolsClientcredentialscreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rw7.dotnetsecuritytools.clientcredentialscreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMarkdownSampleCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-markdown-sample-code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csvcodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csvcodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DaxOptimizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dax.optimizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ClockTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clock_test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CdcsharpToolsXmldoctomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cdcsharp.tools.xmldoctomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetjsoncheckTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetjsoncheck.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftVisualstudioSlngenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.visualstudio.slngen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TiveriadStudioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tiveriad.studio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkRestclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.restclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Carp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"carp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGcmon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gcmon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QiyqiriqCrud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qiyqiriq-crud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ObfustarConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"obfustar.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rw7DotnetsecuritytoolsJsonwebkeycreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rw7.dotnetsecuritytools.jsonwebkeycreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UescriptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uescript.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TopswagcodeCliPodcastplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topswagcode.cli.podcastplayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionDevjwtCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.devjwt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ItnDotnetNewclassgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"itn.dotnet.newclassgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coakeygen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coakeygen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EntitydbMongodbProvisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entitydb.mongodb.provisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markdown2pdfConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdown2pdf.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CilverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cilver-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GarnetServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"garnet-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cargowisereporttemplatecreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cargowisereporttemplatecreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GiraffeHotreloadCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"giraffe.hotreload.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlugfyCoreExtensionLibraryRunnerDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plugfy.core.extension.library.runner.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CreateFeature(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"create-feature {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Changeset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"changeset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TiliedCstojsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tilied.cstojs_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Createcommandhandler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"createcommandhandler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SurityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"surity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HellopackCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hellopack.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zgencodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zgencodegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCalcengine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-calcengine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FevalCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"feval.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuget.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CdcsharpToolsGeneratorsrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cdcsharp.tools.generatorsrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ContosoSpacesConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"contoso.spaces.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScaleoutInvocationgridCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scaleout.invocationgrid.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GoogleCloudToolsReleaseprogressreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"google.cloud.tools.releaseprogressreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FshOrchardcorePoextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsh.orchardcore.poextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesJnetreflector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.jnetreflector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Octonautscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octonautscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HadesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hades-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Envconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"envconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}