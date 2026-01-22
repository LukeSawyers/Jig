using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Clidictionaryhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clidictionaryhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DocueyeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docueye.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TbssCommonsToolsResxgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tbss.commons.tools.resxgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xliffcommandtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xliffcommandtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FaithlifeFindreplacecodeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faithlife.findreplacecode.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CieloGrpcProtoTranspiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cielo.grpc.proto.transpiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotcopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotcopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MbwToolsGhstandardcontent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mbw.tools.ghstandardcontent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cleanoldnuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cleanoldnuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetClear(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-clear {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesPlc4netcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.plc4netcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartprofilerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartprofiler.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarymoorstudiosCoreRpcTracecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marymoorstudios.core.rpc.tracecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeneblabStashlockCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deneblab.stashlock.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SicoJobPgsql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sico.job.pgsql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DokiCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doki.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codecoverageextractor3(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecoverageextractor3 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YoyobootCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yoyoboot-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Identityservercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"identityservercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetToast(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-toast {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MinfoldCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minfold.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FennecNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fennec.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyfxToolsLinuxcmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyfx.tools.linuxcmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkRuncode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.runcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PerfyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"perfy-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPstacks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pstacks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NamecheckCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"namecheck.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vinylcutter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vinylcutter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DirectoryDeduplicateCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"directory.deduplicate.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoryxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moryx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EunetCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eunet.codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkSecretsconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.secretsconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JaytwoNugetcheckGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jaytwo.nugetcheck.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZayniRedisCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zayni-redis-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FshOrchardcorePoextractor2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsh.orchardcore.poextractor2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hellodotnetcoretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hellodotnetcoretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HasteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"haste.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HitsmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hitsm-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YukimiscriptCommandlinetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yukimiscript.commandlinetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LeancodeGlobalcontractsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"leancode.globalcontractsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EpubcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"epubcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netcdgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netcdgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReigniteProfilerCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reignite.profiler.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EntitygenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entitygen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stidgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stidgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusYmltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.ymltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ModernroninProjectrenamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modernronin.projectrenamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemaconsultingVhdltest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demaconsulting.vhdltest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Extcopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"extcopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LmondeilCliRedis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lmondeil.cli.redis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HolyesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"holyes.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Passgencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passgencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetUpdatr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-updatr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sftpcopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sftpcopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaplargeincChromedevtoolsProtocolgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maplargeinc.chromedevtools.protocolgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemaconsultingWeasyprinttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demaconsulting.weasyprinttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RestafarianCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"restafarian-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SeesharprunFilecounter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"seesharprun.filecounter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SyncCentralVersions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sync-central-versions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DehiveCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dehive.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MagiconionGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"magiconion.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SoftbandExtractorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"softband.extractor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jiragitcommiter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jiragitcommiter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GratisdnsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gratisdns-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MinecraftmodupdaterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minecraftmodupdater.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GiteeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitee-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetXscgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-xscgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OrchestrateitDxfgeometrycompareTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"orchestrateit.dxfgeometrycompare.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeosenseplusCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geosenseplus.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZiocampoSmollprox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ziocampo.smollprox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MilkywareSarifConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"milkyware-sarif-converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Toyrobotchallenge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toyrobotchallenge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FflowCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fflow.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-trx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EonacatLicenserNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eonacat.licenser.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WizcoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wizco.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProjgraphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projgraph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-monitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devcachecleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devcachecleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpecworksMarkmywordCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"specworks.markmyword.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Seeder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"seeder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimcubeDappergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simcube.dappergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KamisamaMicroservicesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kamisama.microservices.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PassingwindMakecerts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passingwind.makecerts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZerozerooneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zerozeroone.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkNulllockconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.nulllockconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TorqueCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"torque-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwagabondCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swagabond.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DazzleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dazzle.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatagapJellogCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datagap.jellog.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HowldevCliTextdto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"howldev.cli.textdto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FleeceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fleece.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genms(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genms {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCdp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cdp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmallsoftCalculator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smallsoft.calculator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KodifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kodify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WolfiredU3dotConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wolfired.u3dot_converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KopfrechnerChurnr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kopfrechner.churnr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MigratorDatabaseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"migrator.database.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}