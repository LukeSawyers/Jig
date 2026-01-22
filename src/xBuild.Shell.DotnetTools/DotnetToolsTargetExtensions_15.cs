using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T FynyddOllamafarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fynydd.ollamafarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCstOssgadgetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.cst.ossgadget.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlitemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlitemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HookreplayCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hookreplay.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RadzenMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"radzen.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChickensoftPalettepainter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chickensoft.palettepainter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BbtPrismCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbt.prism.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RodeldownloaderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rodeldownloader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wyam2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wyam2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rezamcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rezamcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deadsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deadsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OktolWeathermcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oktol.weathermcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markdowncodeembed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdowncodeembed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RunlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TaigaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taiga-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlschemabridgemcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlschemabridgemcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Monover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mikesmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mikesmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Covenant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"covenant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsixWeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsix.web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UforumMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uforum-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolarwindsChangesets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solarwinds.changesets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ilspymcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ilspymcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RefuelRemimeRefile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"refuel.remime.refile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LukeClickupmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"luke.clickupmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Filesync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filesync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solarscope(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solarscope {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yitpush(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yitpush {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DddadvisorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dddadvisor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GarnetProcessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"garnet.processor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DuseElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duse.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InfinityflowCsharpEval(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"infinityflow.csharp.eval {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpexConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spex.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Plcrashutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plcrashutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SshpassNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sshpass.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FilerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDotdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dotdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cade(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cade {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MintplayerVidyanoCheckmodelhash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mintplayer.vidyano.checkmodelhash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HyModellerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hy.modeller.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Louvorhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"louvorhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitClean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git.clean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeurofibrominPupnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neurofibromin.pupnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SigilExecutor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sigil.executor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkaarServicebusemulatorclientHttp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skaar.servicebusemulatorclient.http {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Surveyor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"surveyor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gherkinsynctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gherkinsynctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sudokumcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sudokumcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqliteGlobalTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlite-global-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Inheritdoctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"inheritdoctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTarballNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tarball-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikDplMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.dpl.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetZipNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-zip-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LofibeatsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lofibeats.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PaketBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"paket.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saamcplocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saamcplocal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ServicebusemulatorconfigCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"servicebusemulatorconfig.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T C1DataengineToolCn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"c1.dataengine.tool.cn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testscaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testscaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharpitect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpitect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MateusTechNugetscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mateus.tech.nugetscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharplspmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharplspmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IvyBreakcoldConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivy.breakcold.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Psingla1210Firstmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"psingla1210.firstmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetIgnore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrynwaldChangelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grynwald.changelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cnag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cnag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeneratorTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generator.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetIlrepack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ilrepack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Routecheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"routecheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DraindotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"draindotnet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Repointfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"repointfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SvcfabricDevopsToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svcfabric.devops.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UipathCliWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uipath.cli.windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DpongraczSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dpongracz.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ultra(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ultra {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ButrCrashreportBannerlordTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"butr.crashreport.bannerlord.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Relationalgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"relationalgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpEvals(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.evals {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Postgretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"postgretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpCnCalendar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.cn.calendar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trsplit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trsplit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NarchitectureGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"narchitecture.gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WordleNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wordle.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMeai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-meai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RustReflectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rust-reflect-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HotchocolatierTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hotchocolatier.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Employeemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"employeemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trcombine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trcombine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEcoji(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ecoji {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LspuseCsharpWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lspuse.csharp.win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Keivicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"keivicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LspuseCsharpLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lspuse.csharp.linux-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MyfirstlibRkClasslibrary1test(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myfirstlib.rk.classlibrary1test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MyBasicCalculator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"my-basic-calculator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Imagegentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imagegentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MchrisTinymemory(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mchris.tinymemory {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WyamTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wyam.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}