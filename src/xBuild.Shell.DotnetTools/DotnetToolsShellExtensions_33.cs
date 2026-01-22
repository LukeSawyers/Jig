using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command DotnetCompressor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-compressor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DummyBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dummy.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetcompress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcompress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevJoshbruntonWatchfileCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dev.joshbrunton.watchfile.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GmodnetVersiontool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gmodnet.versiontool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RksoftwareImageborderconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rksoftware.imageborderconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnettipsSpargineDevTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnettips.spargine.dev.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Whitespacewarrior(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"whitespacewarrior {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Marktheripper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marktheripper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LyainbotPluginpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lyainbot.pluginpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Paketchain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"paketchain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ps2vb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ps2vb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MdGist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"md-gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Logicblocksgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"logicblocksgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GherkinLinter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gherkin-linter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command W3tiOpenbaseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"w3ti.openbase.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EquinoxTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"equinox.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SalehalbalkhiBotsay082822001(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"salehalbalkhi.botsay.08.28.22.001 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Heroesdecode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"heroesdecode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeshmakersOctoBlueprintmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meshmakers.octo.blueprintmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevhawkDumpnef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devhawk.dumpnef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZeroqlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zeroql.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PageflowBlazorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pageflow.blazor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftOdataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.odata.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPgroutiner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pgroutiner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Retypeapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"retypeapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Utools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"utools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PropulsionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"propulsion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DuotifyReplacetext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"duotify.replacetext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NivobiGitbuddy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nivobi.gitbuddy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clockifycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clockifycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChaoticonyxTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chaoticonyx.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolurumStaeltradebot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solurum.staeltradebot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PliskyVersonify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plisky.versonify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeziantouFrameworkNugetpackagevalidationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meziantou.framework.nugetpackagevalidation.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dirsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dirsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command W3tiOpenbasenetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"w3ti.openbasenet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Imlp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imlp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hydrascript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hydrascript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesNureflectorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.nureflectorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypedtreeGeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typedtree.generator.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-search {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Eber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tsukuru(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tsukuru {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Viking(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"viking {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TchaxxSnappyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tchaxx.snappy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShelluiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shellui.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGitchanges(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gitchanges {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VioletWorkitemsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"violet.workitems.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hydedotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hydedotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clangsharppinvokegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clangsharppinvokegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdgencsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdgencsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnsureGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ensure.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NickoglWebsocketsRpcClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nickogl.websockets.rpc.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LivingdocgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"livingdocgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeoWorknet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neo.worknet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Semtex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"semtex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tkt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tkt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tuesdayclass(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tuesdayclass {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Modernuoschemagenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modernuoschemagenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NfirestoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nfirestore-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Windowex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"windowex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kylemcmaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kylemcmaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Protokeep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"protokeep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SvrooijPowershellDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svrooij.powershell.docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MobileinspectorToolsRemovemodel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mobileinspector.tools.removemodel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xmldocmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xmldocmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Doser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MgcbCrunch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mgcb-crunch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KubeopsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kubeops.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MobileinspectorToolsRemoveview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mobileinspector.tools.removeview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PliskyMollycoddle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plisky.mollycoddle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WyeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wye.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenpixCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openpix.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnsconceDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ensconce.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command I3dmExport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"i3dm.export {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChibiasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chibias-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoGalleryDeletecorruptimage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.gallery.deletecorruptimage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotmrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotmr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SamayasToolsProjectsnugetupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samayas.tools.projectsnugetupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdgenfsd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdgenfsd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TktStats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tkt.stats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdgenjs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdgenjs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SvgSprite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svg-sprite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypegenDotnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typegen.dotnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Outputtestcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"outputtestcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command File2utf8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"file2utf8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slnutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slnutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDepends(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-depends {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Snowflaqe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snowflaqe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deepclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deepclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MgcbFfmpeg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mgcb-ffmpeg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FaceoffxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faceoffx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MgcbFfprobe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mgcb-ffprobe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lbt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lbt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Illuminate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"illuminate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HaveibeenpwnedDownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"haveibeenpwned-downloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swimburger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swimburger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VostokLaunchpad(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vostok.launchpad {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}