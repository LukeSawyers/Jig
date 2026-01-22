using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Shipyard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shipyard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Makewebrequest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"makewebrequest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pad(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pad {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packageshadertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packageshadertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MemoniaNugletTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"memonia.nuglet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartlightMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartlight.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Huddly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"huddly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Httpmeter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"httpmeter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HelloworldMv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"helloworld.mv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Httptostdout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"httptostdout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Htetodotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"htetodotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hackingstudio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hackingstudio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Helloxingya(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"helloxingya {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hellotoolsdandan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hellotoolsdandan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hexrr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hexrr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HellonugetSimediaRead(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hellonuget.simedia.read {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Photohack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"photohack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Simplestatichttpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simplestatichttpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SodaSvghelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"soda.svghelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShohabbyImagestitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shohabby.imagestitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PxlSimulatorHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pxl.simulator.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TransSignaturehelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trans.signaturehelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Turingsmartscreentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"turingsmartscreentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZkeacmsPublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zkeacms.publisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VancheercmsPublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vancheercms.publisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kirinsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kirinsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VgyMe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vgy.me {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NexusModsUploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nexus-mods-uploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mytools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mytools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Memleak(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"memleak {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftQuantumIqsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.quantum.iqsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Id7(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"id7 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Iceboxnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iceboxnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InnosetupTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"innosetup-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Iitog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iitog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Imgtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imgtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Versioninfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versioninfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PicoMcpPdf2img(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pico.mcp.pdf2img {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkMysqlimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.mysqlimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SysMediaInfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sys-media-info {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Releaseit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"releaseit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlnetPredict(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet-predict {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trippinmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trippinmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Windowssandboxmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"windowssandboxmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Shpytchuk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shpytchuk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sayconf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sayconf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Listdepasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"listdepasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JaneTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jane.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JaparsonPackage_1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"japarson_package_1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JoexgSaychina(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"joexg.saychina {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsakamoto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsakamoto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JayshaoTestmcp2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jayshao.testmcp2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsonsizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsonsizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jorn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jorn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yuanjietesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yuanjietesttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkJsonschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.jsonschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkJsonpath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.jsonpath {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RcaronShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rcaron.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RcaronLanguageserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rcaron.languageserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mtc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mtc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yaztest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yaztest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Logsearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"logsearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scmpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scmpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pepin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pepin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Udic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"udic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StockMartPg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stock.mart.pg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KepungTooltest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kepung-tooltest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kosh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kosh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KestrelMonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kestrel-monitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lab4kosenko1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lab4kosenko1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lab4kosenko2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lab4kosenko2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lab4kosenkor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lab4kosenkor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Osscore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"osscore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vault102525(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vault.10.25.25 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LrNugetUpdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lr-nuget-update {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LemonPackagetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lemon_packagetest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Listenup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"listenup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Localcart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"localcart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LiScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"li.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ObsidianMapperLocust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"obsidian-mapper-locust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pavlolr4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pavlolr4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkWholock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.wholock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Timelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkLayout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.layout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OoLab4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oo_lab4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yankivlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yankivlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MateralLoggerLoggertrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"materal.logger.loggertrace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vyevseichyklab4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vyevseichyklab4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Octostachetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octostachetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MondRepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mond.repl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McreatorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcreator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToptenTranslatetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topten.translatetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Runscripts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runscripts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wybetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wybetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packagetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packagetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Printador(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"printador {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Totpa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"totpa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mybotty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mybotty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeziantouMsbuildTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meziantou.msbuild.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}