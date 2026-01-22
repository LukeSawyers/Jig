using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Cloudformationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudformationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PsGpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ps.gpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Es365InventoryMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"es365.inventory.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubdonwloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubdonwloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BannerlordSteamworkshop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bannerlord.steamworkshop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wiremockinspector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wiremockinspector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PasswordTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"password.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Custompackagetutorial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"custompackagetutorial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsixCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsix.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoNugetUpdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.nuget.updater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Chatgptroulette(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatgptroulette {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Binlogtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"binlogtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Speccodingmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"speccodingmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JustinlMcpCodevectorsmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"justinl.mcp.codevectorsmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Httplaceholder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"httplaceholder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodecontextCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecontext.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TruthoriginSnapshot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"truthorigin.snapshot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JusteattakeawayQuartermaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"justeattakeaway.quartermaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trunfold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trunfold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsDatautil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.datautil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fakedatasqlsrvmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fakedatasqlsrvmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DuendeDocumentationMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duende.documentation.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LucamaGcdevtoolmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lucama.gcdevtoolmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trglob(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trglob {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoellerThecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moeller.thecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MypackageTask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mypackage.task {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VersionMaui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"version-maui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nanoclr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nanoclr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GaspraFunctions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gaspra.functions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BenchmarkdotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"benchmarkdotnet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsxc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsxc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NulastudioNbeauty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nulastudio.nbeauty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FlowliteDiag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flowlite.diag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrpcFsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grpc-fsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SytonePersonalMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sytone.personal.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swagger2doc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swagger2doc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hex1bMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hex1b.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B2cconsoleclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b2cconsoleclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RpetrasSpaceweathercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rpetras.spaceweathercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docfxtocgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docfxtocgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitRelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-release {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsixCliWeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsix.cli.web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Omermcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"omermcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UipathCliLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uipath.cli.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpDiscoverDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp-discover-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NachocollCloudformation4dotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nachocoll.cloudformation4dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MkmvcTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mkmvc.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pseudolocalize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pseudolocalize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UmunnaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"umunna.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSqltest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sqltest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetreflectcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetreflectcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KorzhDbtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"korzh.dbtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Web(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PerigonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"perigon.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRoslynMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-roslyn-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikMauiMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.maui.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikWpfMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.wpf.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pfxtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pfxtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikWinformsMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.winforms.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zdm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zdm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KagekirinDotnetNm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kagekirin.dotnet.nm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Promptvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"promptvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProjgraphMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projgraph.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe12netixquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe12netixquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WinshellCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"winshell.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MframeworkServicesFakedataMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mframework.services.fakedata.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LtcElectronnetCliWin7(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ltc.electronnet.cli.win7 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotmortenOmdgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotmorten.omdgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kalk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kalk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SamplemcpserverSilviu20250813(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samplemcpserver-silviu-2025-08-13 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EternalUtf16mustdie(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eternal.utf16mustdie {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RunScript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"run-script {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe12netixslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe12netixslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lazykeyvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lazykeyvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UipathCliMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uipath.cli.macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTinify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tinify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WindowsmcpNetWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"windowsmcp.net.win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CditsCaffoaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cdits.caffoa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devcontainer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devcontainer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Prismatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"prismatic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ralph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ralph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemoBuildstatusmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demo.buildstatusmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ClineUsage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cline-usage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetcobble(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcobble {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSpawn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-spawn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JayshaoGetfilemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jayshao.getfilemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SzlytraceDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"szlytrace.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikBlazorMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.blazor.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EinstoolsUtilitiesBuildversionhandler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"einstools.utilities.buildversionhandler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projectdependencydiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectdependencydiagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Loadtesttoolbox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"loadtesttoolbox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dhhieu113Devmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dhhieu113.devmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fakeservernet5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fakeservernet5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IvyExaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivy.exa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MortisTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mortis.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbsettomodelconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbsettomodelconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xgo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xgo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HouzhenhuangSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"houzhenhuang.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}