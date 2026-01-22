using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T DotnetCompressor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-compressor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DummyBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dummy.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetcompress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcompress {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevJoshbruntonWatchfileCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dev.joshbrunton.watchfile.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GmodnetVersiontool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gmodnet.versiontool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RksoftwareImageborderconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rksoftware.imageborderconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnettipsSpargineDevTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnettips.spargine.dev.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Whitespacewarrior(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"whitespacewarrior {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Marktheripper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marktheripper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LyainbotPluginpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lyainbot.pluginpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Paketchain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"paketchain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ps2vb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ps2vb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MdGist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"md-gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Logicblocksgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"logicblocksgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GherkinLinter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gherkin-linter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T W3tiOpenbaseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"w3ti.openbase.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EquinoxTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"equinox.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SalehalbalkhiBotsay082822001(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"salehalbalkhi.botsay.08.28.22.001 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Heroesdecode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"heroesdecode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeshmakersOctoBlueprintmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meshmakers.octo.blueprintmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevhawkDumpnef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devhawk.dumpnef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZeroqlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zeroql.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PageflowBlazorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pageflow.blazor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftOdataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.odata.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPgroutiner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pgroutiner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Retypeapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"retypeapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Utools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"utools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PropulsionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"propulsion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DuotifyReplacetext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duotify.replacetext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NivobiGitbuddy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nivobi.gitbuddy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clockifycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clockifycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChaoticonyxTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chaoticonyx.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolurumStaeltradebot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solurum.staeltradebot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PliskyVersonify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plisky.versonify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeziantouFrameworkNugetpackagevalidationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meziantou.framework.nugetpackagevalidation.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dirsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dirsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T W3tiOpenbasenetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"w3ti.openbasenet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Imlp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imlp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hydrascript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hydrascript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesNureflectorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.nureflectorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypedtreeGeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typedtree.generator.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-search {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Eber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tsukuru(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tsukuru {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Viking(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"viking {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TchaxxSnappyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tchaxx.snappy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShelluiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shellui.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGitchanges(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gitchanges {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VioletWorkitemsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"violet.workitems.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hydedotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hydedotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clangsharppinvokegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clangsharppinvokegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdgencsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdgencsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnsureGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ensure.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NickoglWebsocketsRpcClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nickogl.websockets.rpc.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LivingdocgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"livingdocgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeoWorknet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neo.worknet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Semtex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"semtex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tkt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tkt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tuesdayclass(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tuesdayclass {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Modernuoschemagenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modernuoschemagenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NfirestoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nfirestore-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Windowex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"windowex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kylemcmaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kylemcmaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Protokeep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"protokeep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SvrooijPowershellDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svrooij.powershell.docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MobileinspectorToolsRemovemodel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobileinspector.tools.removemodel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xmldocmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xmldocmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Doser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MgcbCrunch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mgcb-crunch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KubeopsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kubeops.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MobileinspectorToolsRemoveview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobileinspector.tools.removeview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PliskyMollycoddle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plisky.mollycoddle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WyeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wye.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenpixCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openpix.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnsconceDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ensconce.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T I3dmExport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"i3dm.export {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChibiasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chibias-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoGalleryDeletecorruptimage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.gallery.deletecorruptimage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotmrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotmr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SamayasToolsProjectsnugetupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samayas.tools.projectsnugetupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdgenfsd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdgenfsd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TktStats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tkt.stats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdgenjs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdgenjs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SvgSprite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svg-sprite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypegenDotnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typegen.dotnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Outputtestcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"outputtestcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T File2utf8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"file2utf8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slnutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slnutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDepends(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-depends {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Snowflaqe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snowflaqe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deepclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deepclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MgcbFfmpeg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mgcb-ffmpeg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FaceoffxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faceoffx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MgcbFfprobe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mgcb-ffprobe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lbt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lbt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Illuminate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"illuminate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HaveibeenpwnedDownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"haveibeenpwned-downloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swimburger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swimburger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VostokLaunchpad(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vostok.launchpad {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}