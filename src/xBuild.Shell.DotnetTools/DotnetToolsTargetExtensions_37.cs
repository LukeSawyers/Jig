using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T PouroverGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pourover.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConsoleJwtparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"console.jwtparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GelbermMagicwindball(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gelberm-magicwindball {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EternalTheswizzler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eternal.theswizzler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GiixooTossacoin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"giixoo.tossacoin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SharptypesGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharptypes.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JourneyNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"journey.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitsith(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitsith {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGcforce(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gcforce {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SharptypesSignalrGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharptypes.signalr.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MrhihiHishell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mrhihi.hishell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cfbshelper20(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cfbshelper2.0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FennekitSpringcloudconfigEncrypttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fennekit.springcloudconfig.encrypttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Json2fs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"json2fs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PulumiYoyo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pulumi-yoyo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fgraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fgraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NotedownCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"notedown.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fdbshell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fdbshell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitlabtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlabtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Youtubemp3downloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"youtubemp3downloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetpadCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netpad.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShubhamSharma12345(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shubham_sharma12345 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Museplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"museplayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TwCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tw-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dofusdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dofusdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Operasihitungprojectmesinkasir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"operasihitungprojectmesinkasir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testfilegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testfilegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fdbtop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fdbtop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetdocumentationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetdocumentationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JustinlMcpRoslynmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"justinl.mcp.roslynmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testwebgl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testwebgl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Exceptionalstatistics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"exceptionalstatistics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hashidhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hashidhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T S2cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"s2cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Microserveicesrabbitmq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microserveicesrabbitmq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tsexportcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tsexportcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TmpltCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tmplt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WizardworldCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wizardworld.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Squeeze(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"squeeze {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SeesharprunImageoptimizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"seesharprun.imageoptimizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCertificatesInstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-certificates-installer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DpupekCodeNavMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dpupek.code.nav.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solanavanity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solanavanity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T G0t(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"g0t {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PodXledgerSqlServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pod.xledger.sql_server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hookspy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hookspy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetData(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-data {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DimonsmartNotebookmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dimonsmart.notebookmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YosrimlikFilewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yosrimlik.filewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpsqlserverPreview202508d(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpsqlserver-preview-202508d {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeniuslociEmissarytool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geniusloci.emissarytool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HiraMathOperations(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hira.math.operations {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vscleanertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vscleanertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HomebookSdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"homebook-sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoderoomZenitsuCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coderoom.zenitsu.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlvscanDevcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlvscan.devcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solutioncleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solutioncleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolsCodeflowiommd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tools-codeflowiommd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcpsqlserverteste0(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpsqlserverteste0 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IndirectxHlslcodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"indirectx.hlslcodegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Requesty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"requesty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lab4veronika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lab4veronika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RoslynDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"roslyn-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpecworksJsondiffCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"specworks.jsondiff.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Runic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Releasator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"releasator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-coverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCounters(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-counters {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoChangelogCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.changelog.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetInteractive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-interactive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoverallsNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coveralls.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ExcuboWebcompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"excubo.webcompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCertificateTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-certificate-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsharpLs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharp-ls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Minicover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minicover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoPackageUpdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.package.update {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trx2junit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trx2junit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoDotnetRepoToolsCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.dotnet.repo.tools.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RoslynatorDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"roslynator.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoPackagePush(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.package.push {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codequalitytogitlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codequalitytogitlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FluentmigratorDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fluentmigrator.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ErikejEfcorepowertoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"erikej.efcorepowertools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevprimeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devprime.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KubernetescrdmodelgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kubernetescrdmodelgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codefilesanity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codefilesanity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChecknugetpackagesDotnetclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"checknugetpackages.dotnetclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetctrfjsonreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetctrfjsonreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharprepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharprepl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CorvusJsonJsonschemaTypegeneratortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corvus.json.jsonschema.typegeneratortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmiteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smite-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ResharperToCodeclimate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resharper-to-codeclimate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WolvenkitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wolvenkit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Confix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"confix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Signclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"signclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChillicreamNitroCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chillicream.nitro.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coda-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetLinuxCert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-linux-cert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}