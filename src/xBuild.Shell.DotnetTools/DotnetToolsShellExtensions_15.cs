using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command FynyddOllamafarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fynydd.ollamafarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCstOssgadgetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.cst.ossgadget.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlitemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlitemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HookreplayCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hookreplay.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RadzenMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"radzen.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChickensoftPalettepainter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chickensoft.palettepainter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BbtPrismCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbt.prism.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RodeldownloaderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rodeldownloader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wyam2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wyam2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rezamcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rezamcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deadsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deadsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OktolWeathermcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oktol.weathermcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markdowncodeembed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdowncodeembed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RunlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TaigaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taiga-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlschemabridgemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlschemabridgemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Monover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mikesmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mikesmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Covenant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"covenant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsixWeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsix.web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UforumMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uforum-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolarwindsChangesets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solarwinds.changesets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ilspymcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ilspymcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RefuelRemimeRefile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"refuel.remime.refile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LukeClickupmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"luke.clickupmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Filesync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filesync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solarscope(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solarscope {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yitpush(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yitpush {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DddadvisorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dddadvisor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GarnetProcessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"garnet.processor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DuseElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"duse.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InfinityflowCsharpEval(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"infinityflow.csharp.eval {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpexConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spex.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Plcrashutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plcrashutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SshpassNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sshpass.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FilerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDotdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dotdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cade(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cade {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MintplayerVidyanoCheckmodelhash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mintplayer.vidyano.checkmodelhash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HyModellerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hy.modeller.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Louvorhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"louvorhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitClean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git.clean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeurofibrominPupnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neurofibromin.pupnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SigilExecutor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sigil.executor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkaarServicebusemulatorclientHttp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skaar.servicebusemulatorclient.http {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Surveyor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"surveyor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gherkinsynctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gherkinsynctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sudokumcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sudokumcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqliteGlobalTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlite-global-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Inheritdoctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"inheritdoctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTarballNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tarball-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelerikDplMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telerik.dpl.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetZipNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-zip-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LofibeatsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lofibeats.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PaketBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"paket.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saamcplocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saamcplocal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ServicebusemulatorconfigCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"servicebusemulatorconfig.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command C1DataengineToolCn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"c1.dataengine.tool.cn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testscaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testscaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharpitect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpitect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MateusTechNugetscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mateus.tech.nugetscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharplspmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharplspmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IvyBreakcoldConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ivy.breakcold.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Psingla1210Firstmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"psingla1210.firstmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetIgnore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrynwaldChangelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grynwald.changelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cnag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cnag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeneratorTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generator.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetIlrepack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ilrepack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Routecheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"routecheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DraindotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"draindotnet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Repointfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"repointfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SvcfabricDevopsToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svcfabric.devops.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UipathCliWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uipath.cli.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DpongraczSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dpongracz.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ultra(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ultra {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ButrCrashreportBannerlordTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"butr.crashreport.bannerlord.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Relationalgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"relationalgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpEvals(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.evals {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Postgretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"postgretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpCnCalendar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.cn.calendar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trsplit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trsplit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NarchitectureGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"narchitecture.gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WordleNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wordle.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMeai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-meai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RustReflectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rust-reflect-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HotchocolatierTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hotchocolatier.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Employeemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"employeemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trcombine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trcombine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEcoji(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ecoji {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LspuseCsharpWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lspuse.csharp.win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Keivicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"keivicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LspuseCsharpLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lspuse.csharp.linux-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MyfirstlibRkClasslibrary1test(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myfirstlib.rk.classlibrary1test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MyBasicCalculator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"my-basic-calculator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Imagegentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imagegentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MchrisTinymemory(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mchris.tinymemory {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WyamTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wyam.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}