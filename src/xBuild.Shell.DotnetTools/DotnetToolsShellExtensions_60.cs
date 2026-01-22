using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Shipyard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shipyard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Makewebrequest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"makewebrequest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pad(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pad {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packageshadertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packageshadertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MemoniaNugletTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"memonia.nuglet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartlightMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartlight.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Huddly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"huddly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Httpmeter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"httpmeter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HelloworldMv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"helloworld.mv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Httptostdout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"httptostdout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Htetodotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"htetodotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hackingstudio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hackingstudio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Helloxingya(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"helloxingya {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hellotoolsdandan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hellotoolsdandan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hexrr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hexrr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HellonugetSimediaRead(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hellonuget.simedia.read {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Photohack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"photohack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Simplestatichttpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simplestatichttpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SodaSvghelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"soda.svghelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShohabbyImagestitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shohabby.imagestitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PxlSimulatorHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pxl.simulator.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TransSignaturehelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trans.signaturehelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Turingsmartscreentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"turingsmartscreentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZkeacmsPublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zkeacms.publisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VancheercmsPublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vancheercms.publisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kirinsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kirinsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VgyMe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vgy.me {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NexusModsUploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nexus-mods-uploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mytools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mytools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Memleak(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"memleak {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftQuantumIqsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.quantum.iqsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Id7(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"id7 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Iceboxnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iceboxnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InnosetupTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"innosetup-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Iitog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iitog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Imgtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imgtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Versioninfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"versioninfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PicoMcpPdf2img(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pico.mcp.pdf2img {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkMysqlimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.mysqlimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SysMediaInfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sys-media-info {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Releaseit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"releaseit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlnetPredict(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet-predict {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trippinmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trippinmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Windowssandboxmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"windowssandboxmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Shpytchuk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shpytchuk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sayconf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sayconf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Listdepasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"listdepasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JaneTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jane.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JaparsonPackage_1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"japarson_package_1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JoexgSaychina(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"joexg.saychina {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsakamoto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsakamoto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JayshaoTestmcp2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jayshao.testmcp2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsonsizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsonsizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jorn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jorn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yuanjietesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yuanjietesttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkJsonschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.jsonschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkJsonpath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.jsonpath {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RcaronShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rcaron.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RcaronLanguageserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rcaron.languageserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mtc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mtc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yaztest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yaztest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Logsearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"logsearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scmpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scmpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pepin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pepin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Udic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"udic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StockMartPg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stock.mart.pg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KepungTooltest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kepung-tooltest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kosh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kosh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KestrelMonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kestrel-monitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lab4kosenko1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lab4kosenko1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lab4kosenko2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lab4kosenko2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lab4kosenkor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lab4kosenkor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Osscore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"osscore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vault102525(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vault.10.25.25 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LrNugetUpdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lr-nuget-update {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LemonPackagetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lemon_packagetest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Listenup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"listenup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Localcart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"localcart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LiScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"li.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ObsidianMapperLocust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"obsidian-mapper-locust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pavlolr4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pavlolr4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkWholock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.wholock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Timelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkLayout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.layout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OoLab4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oo_lab4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yankivlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yankivlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MateralLoggerLoggertrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"materal.logger.loggertrace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vyevseichyklab4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vyevseichyklab4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Octostachetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octostachetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MondRepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mond.repl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McreatorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcreator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToptenTranslatetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topten.translatetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Runscripts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runscripts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wybetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wybetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packagetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packagetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Printador(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"printador {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Totpa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"totpa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mybotty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mybotty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeziantouMsbuildTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meziantou.msbuild.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}