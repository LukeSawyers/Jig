using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Cloudformationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudformationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PsGpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ps.gpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Es365InventoryMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"es365.inventory.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubdonwloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubdonwloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BannerlordSteamworkshop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bannerlord.steamworkshop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wiremockinspector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wiremockinspector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PasswordTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"password.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Custompackagetutorial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"custompackagetutorial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsixCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsix.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoNugetUpdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.nuget.updater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Chatgptroulette(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatgptroulette {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Binlogtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"binlogtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Speccodingmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"speccodingmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JustinlMcpCodevectorsmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"justinl.mcp.codevectorsmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Httplaceholder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"httplaceholder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodecontextCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecontext.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TruthoriginSnapshot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"truthorigin.snapshot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JusteattakeawayQuartermaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"justeattakeaway.quartermaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trunfold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trunfold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsDatautil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.datautil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fakedatasqlsrvmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fakedatasqlsrvmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DuendeDocumentationMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"duende.documentation.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LucamaGcdevtoolmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lucama.gcdevtoolmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trglob(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trglob {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoellerThecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moeller.thecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MypackageTask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mypackage.task {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VersionMaui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"version-maui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nanoclr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nanoclr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GaspraFunctions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gaspra.functions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BenchmarkdotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"benchmarkdotnet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsxc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsxc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NulastudioNbeauty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nulastudio.nbeauty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FlowliteDiag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flowlite.diag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrpcFsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grpc-fsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SytonePersonalMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sytone.personal.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swagger2doc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swagger2doc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hex1bMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hex1b.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B2cconsoleclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b2cconsoleclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RpetrasSpaceweathercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rpetras.spaceweathercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docfxtocgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docfxtocgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitRelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-release {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsixCliWeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsix.cli.web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Omermcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"omermcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UipathCliLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uipath.cli.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpDiscoverDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp-discover-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NachocollCloudformation4dotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nachocoll.cloudformation4dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MkmvcTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mkmvc.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pseudolocalize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pseudolocalize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UmunnaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"umunna.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSqltest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sqltest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetreflectcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetreflectcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KorzhDbtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"korzh.dbtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Web(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PerigonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"perigon.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRoslynMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-roslyn-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelerikMauiMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telerik.maui.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelerikWpfMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telerik.wpf.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pfxtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pfxtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelerikWinformsMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telerik.winforms.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zdm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zdm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KagekirinDotnetNm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kagekirin.dotnet.nm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Promptvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"promptvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProjgraphMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projgraph.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe12netixquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe12netixquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WinshellCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"winshell.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MframeworkServicesFakedataMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mframework.services.fakedata.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LtcElectronnetCliWin7(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ltc.electronnet.cli.win7 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotmortenOmdgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotmorten.omdgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kalk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kalk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SamplemcpserverSilviu20250813(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samplemcpserver-silviu-2025-08-13 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EternalUtf16mustdie(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eternal.utf16mustdie {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RunScript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"run-script {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe12netixslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe12netixslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lazykeyvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lazykeyvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UipathCliMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uipath.cli.macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTinify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tinify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WindowsmcpNetWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"windowsmcp.net.win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CditsCaffoaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cdits.caffoa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devcontainer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devcontainer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Prismatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"prismatic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ralph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ralph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemoBuildstatusmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demo.buildstatusmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ClineUsage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cline-usage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetcobble(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcobble {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSpawn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-spawn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JayshaoGetfilemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jayshao.getfilemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SzlytraceDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"szlytrace.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelerikBlazorMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telerik.blazor.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EinstoolsUtilitiesBuildversionhandler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"einstools.utilities.buildversionhandler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projectdependencydiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectdependencydiagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Loadtesttoolbox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"loadtesttoolbox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dhhieu113Devmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dhhieu113.devmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fakeservernet5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fakeservernet5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IvyExaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ivy.exa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MortisTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mortis.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbsettomodelconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbsettomodelconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xgo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xgo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HouzhenhuangSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"houzhenhuang.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}