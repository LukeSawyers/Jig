using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command PouroverGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pourover.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConsoleJwtparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"console.jwtparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GelbermMagicwindball(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gelberm-magicwindball {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EternalTheswizzler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eternal.theswizzler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GiixooTossacoin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"giixoo.tossacoin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SharptypesGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharptypes.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JourneyNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"journey.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitsith(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitsith {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGcforce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gcforce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SharptypesSignalrGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharptypes.signalr.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MrhihiHishell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mrhihi.hishell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cfbshelper20(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cfbshelper2.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FennekitSpringcloudconfigEncrypttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fennekit.springcloudconfig.encrypttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Json2fs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"json2fs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PulumiYoyo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pulumi-yoyo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fgraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fgraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NotedownCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"notedown.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fdbshell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fdbshell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitlabtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlabtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Youtubemp3downloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"youtubemp3downloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetpadCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netpad.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShubhamSharma12345(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shubham_sharma12345 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Museplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"museplayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TwCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tw-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dofusdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dofusdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Operasihitungprojectmesinkasir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"operasihitungprojectmesinkasir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testfilegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testfilegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fdbtop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fdbtop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetdocumentationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetdocumentationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JustinlMcpRoslynmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"justinl.mcp.roslynmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testwebgl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testwebgl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Exceptionalstatistics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"exceptionalstatistics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hashidhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hashidhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command S2cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"s2cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Microserveicesrabbitmq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microserveicesrabbitmq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tsexportcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tsexportcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TmpltCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tmplt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WizardworldCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wizardworld.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Squeeze(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"squeeze {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SeesharprunImageoptimizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"seesharprun.imageoptimizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCertificatesInstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-certificates-installer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DpupekCodeNavMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dpupek.code.nav.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solanavanity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solanavanity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command G0t(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"g0t {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PodXledgerSqlServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pod.xledger.sql_server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hookspy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hookspy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetData(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-data {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DimonsmartNotebookmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dimonsmart.notebookmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YosrimlikFilewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yosrimlik.filewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpsqlserverPreview202508d(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpsqlserver-preview-202508d {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeniuslociEmissarytool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geniusloci.emissarytool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HiraMathOperations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hira.math.operations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vscleanertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vscleanertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HomebookSdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"homebook-sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoderoomZenitsuCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coderoom.zenitsu.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlvscanDevcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlvscan.devcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solutioncleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solutioncleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolsCodeflowiommd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tools-codeflowiommd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcpsqlserverteste0(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpsqlserverteste0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IndirectxHlslcodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"indirectx.hlslcodegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Requesty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"requesty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lab4veronika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lab4veronika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RoslynDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"roslyn-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpecworksJsondiffCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"specworks.jsondiff.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Runic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Releasator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"releasator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-coverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCounters(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-counters {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoChangelogCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.changelog.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetInteractive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-interactive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoverallsNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coveralls.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ExcuboWebcompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"excubo.webcompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCertificateTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-certificate-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsharpLs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharp-ls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Minicover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minicover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoPackageUpdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.package.update {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trx2junit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trx2junit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoDotnetRepoToolsCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.dotnet.repo.tools.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RoslynatorDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"roslynator.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoPackagePush(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.package.push {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codequalitytogitlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codequalitytogitlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FluentmigratorDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fluentmigrator.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ErikejEfcorepowertoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"erikej.efcorepowertools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevprimeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devprime.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KubernetescrdmodelgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kubernetescrdmodelgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codefilesanity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codefilesanity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChecknugetpackagesDotnetclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"checknugetpackages.dotnetclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetctrfjsonreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetctrfjsonreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharprepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharprepl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CorvusJsonJsonschemaTypegeneratortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"corvus.json.jsonschema.typegeneratortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmiteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smite-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ResharperToCodeclimate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resharper-to-codeclimate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WolvenkitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wolvenkit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Confix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"confix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Signclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"signclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChillicreamNitroCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chillicream.nitro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coda-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetLinuxCert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-linux-cert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}