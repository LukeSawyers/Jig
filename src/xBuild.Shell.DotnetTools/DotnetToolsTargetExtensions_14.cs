using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T LizardmorphMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lizardmorph.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetalamaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metalama.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Linuxpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linuxpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Contextweaver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"contextweaver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BundlerminifierCoreTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bundlerminifier.core.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpserverOpenxmlStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpserver.openxml.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoedimEdgarMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moedim.edgar.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpserverOpenxmlSse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpserver.openxml.sse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsharptotypescriptClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharptotypescript.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netloy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netloy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TktcoUdonsharplinter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tktco.udonsharplinter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotauthTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotauth.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuartsystemSeqmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quartsystem.seqmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpokesoftLucy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spokesoft.lucy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpsqlserverPreview202507a(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpsqlserver-preview-202507a {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Changedisplaysettings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"changedisplaysettings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GripeMsbuildlogstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gripe-msbuildlogstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nvika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nvika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KsqlLinqCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ksql.linq.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vignaesh01Dataversedevtoolsmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vignaesh01.dataversedevtoolsmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GraphqlclientgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"graphqlclientgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe10net31xslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe10net31xslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RedditradarMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"redditradar.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Settingspaths(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"settingspaths {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Handstack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"handstack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MejramConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mejram.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChickensoftChicken(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chickensoft.chicken {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FastcdcfsNetShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fastcdcfs.net.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MartinduhaldeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"martinduhalde.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codewolfmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codewolfmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Entratokencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entratokencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FirelyTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"firely.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mlnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BigdeliNswagConsolecore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bigdeli.nswag.consolecore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilverflyTreevisualizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"silverfly.treevisualizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nazar322ElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nazar322.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomPowershellgpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.powershellgpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConfiggenerationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"configgeneration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nustore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nustore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DocfxPlus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docfx-plus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XamlplaygroundConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xamlplayground.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Watch2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"watch2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HopperCleannugetpackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hopper.cleannugetpackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolaceCleancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solace.cleancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Naprisecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"naprisecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitversioninfoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitversioninfo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DacpacTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dacpac.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LambdaremotedebugTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lambdaremotedebug.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatabindingLivingdocReportCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"databinding.livingdoc.report.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SerilogSinksFileEncryptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"serilog.sinks.file.encrypt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomWebsearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.websearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BeatwavesResponsiblegherkin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"beatwaves.responsiblegherkin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomPlanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.planner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SecuredconfigCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"securedconfig.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WorkflowgenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"workflowgen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TalxisCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"talxis.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UirealtimecommunicatorTypescriptgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uirealtimecommunicator.typescriptgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnityctlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unityctl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnettoolBuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnettool.builder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnityctlBridge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unityctl.bridge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trcover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trcover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cecrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NulastudioNcbeauty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nulastudio.ncbeauty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetdefenseTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetdefense.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CptmsdugMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cptmsdug.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Climan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"climan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T I18ntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"i18ntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JunitMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"junit.merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RookxxStylecopanalyzersCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rookxx.stylecopanalyzers-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CreedengoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"creedengo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TalxisCliMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"talxis.cli.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BitmonoGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bitmono.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Checktestfiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"checktestfiles {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EndjinCodecoveragesummary(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"endjin.codecoveragesummary {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GripeScanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gripe-scanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yaza(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yaza {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpserverOpenxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpserver.openxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bedtwlserversdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bedtwlserversdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDumpling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dumpling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hercai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hercai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cryptex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cryptex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Libyear(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"libyear {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpokesoftTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spokesoft.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Promotagz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"promotagz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharplensmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharplensmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftArtifactsCredentialproviderNugetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.artifacts.credentialprovider.nuget.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlackholeCoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blackhole.core.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetwhy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetwhy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FabulousCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fabulous-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T C1DataengineToolJa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"c1.dataengine.tool.ja {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uml4netTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uml4net.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Seqmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"seqmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dynsvcdiscovery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dynsvcdiscovery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CogitoSqlserverDeploymentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cogito.sqlserver.deployment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmgToolsEnsureunique(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"emg.tools.ensureunique {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BitbybitSqlsdkprojectReferenceddbdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bitbybit.sqlsdkproject.referenceddbdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}