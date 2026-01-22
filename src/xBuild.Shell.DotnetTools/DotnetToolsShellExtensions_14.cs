using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command LizardmorphMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lizardmorph.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetalamaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metalama.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Linuxpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linuxpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Contextweaver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"contextweaver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BundlerminifierCoreTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bundlerminifier.core.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpserverOpenxmlStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpserver.openxml.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoedimEdgarMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moedim.edgar.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpserverOpenxmlSse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpserver.openxml.sse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsharptotypescriptClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharptotypescript.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netloy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netloy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TktcoUdonsharplinter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tktco.udonsharplinter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotauthTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotauth.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuartsystemSeqmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quartsystem.seqmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpokesoftLucy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spokesoft.lucy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpsqlserverPreview202507a(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpsqlserver-preview-202507a {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Changedisplaysettings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"changedisplaysettings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GripeMsbuildlogstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gripe-msbuildlogstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nvika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nvika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KsqlLinqCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ksql.linq.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vignaesh01Dataversedevtoolsmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vignaesh01.dataversedevtoolsmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GraphqlclientgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"graphqlclientgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe10net31xslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe10net31xslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RedditradarMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"redditradar.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Settingspaths(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"settingspaths {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Handstack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"handstack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MejramConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mejram.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChickensoftChicken(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chickensoft.chicken {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FastcdcfsNetShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fastcdcfs.net.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MartinduhaldeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"martinduhalde.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codewolfmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codewolfmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Entratokencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entratokencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FirelyTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"firely.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mlnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BigdeliNswagConsolecore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bigdeli.nswag.consolecore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilverflyTreevisualizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"silverfly.treevisualizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nazar322ElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nazar322.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomPowershellgpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.powershellgpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConfiggenerationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"configgeneration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nustore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nustore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DocfxPlus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docfx-plus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XamlplaygroundConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xamlplayground.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Watch2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"watch2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HopperCleannugetpackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hopper.cleannugetpackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolaceCleancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solace.cleancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Naprisecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"naprisecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitversioninfoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitversioninfo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DacpacTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dacpac.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LambdaremotedebugTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lambdaremotedebug.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatabindingLivingdocReportCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"databinding.livingdoc.report.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SerilogSinksFileEncryptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"serilog.sinks.file.encrypt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomWebsearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.websearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BeatwavesResponsiblegherkin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"beatwaves.responsiblegherkin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomPlanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.planner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SecuredconfigCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"securedconfig.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WorkflowgenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"workflowgen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TalxisCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"talxis.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UirealtimecommunicatorTypescriptgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uirealtimecommunicator.typescriptgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnityctlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unityctl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnettoolBuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnettool.builder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnityctlBridge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unityctl.bridge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trcover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trcover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cecrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NulastudioNcbeauty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nulastudio.ncbeauty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetdefenseTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetdefense.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CptmsdugMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cptmsdug.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Climan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"climan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command I18ntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"i18ntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JunitMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"junit.merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RookxxStylecopanalyzersCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rookxx.stylecopanalyzers-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CreedengoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"creedengo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TalxisCliMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"talxis.cli.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BitmonoGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bitmono.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Checktestfiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"checktestfiles {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EndjinCodecoveragesummary(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"endjin.codecoveragesummary {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GripeScanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gripe-scanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yaza(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yaza {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpserverOpenxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpserver.openxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bedtwlserversdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bedtwlserversdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDumpling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dumpling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hercai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hercai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cryptex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cryptex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Libyear(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"libyear {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpokesoftTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spokesoft.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Promotagz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"promotagz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharplensmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharplensmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftArtifactsCredentialproviderNugetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.artifacts.credentialprovider.nuget.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlackholeCoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blackhole.core.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetwhy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetwhy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FabulousCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fabulous-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command C1DataengineToolJa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"c1.dataengine.tool.ja {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uml4netTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uml4net.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Seqmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"seqmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dynsvcdiscovery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dynsvcdiscovery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CogitoSqlserverDeploymentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cogito.sqlserver.deployment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmgToolsEnsureunique(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"emg.tools.ensureunique {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BitbybitSqlsdkprojectReferenceddbdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bitbybit.sqlsdkproject.referenceddbdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}