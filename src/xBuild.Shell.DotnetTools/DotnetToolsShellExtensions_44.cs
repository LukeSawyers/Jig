using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Clidictionaryhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clidictionaryhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DocueyeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docueye.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TbssCommonsToolsResxgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tbss.commons.tools.resxgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xliffcommandtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xliffcommandtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FaithlifeFindreplacecodeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faithlife.findreplacecode.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CieloGrpcProtoTranspiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cielo.grpc.proto.transpiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotcopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotcopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MbwToolsGhstandardcontent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mbw.tools.ghstandardcontent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cleanoldnuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cleanoldnuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetClear(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-clear {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesPlc4netcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.plc4netcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartprofilerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartprofiler.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarymoorstudiosCoreRpcTracecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marymoorstudios.core.rpc.tracecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeneblabStashlockCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deneblab.stashlock.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SicoJobPgsql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sico.job.pgsql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DokiCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doki.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codecoverageextractor3(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecoverageextractor3 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YoyobootCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yoyoboot-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Identityservercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"identityservercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetToast(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-toast {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MinfoldCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minfold.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FennecNetcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fennec.netcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyfxToolsLinuxcmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyfx.tools.linuxcmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkRuncode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.runcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PerfyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"perfy-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPstacks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pstacks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NamecheckCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"namecheck.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vinylcutter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vinylcutter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DirectoryDeduplicateCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"directory.deduplicate.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoryxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moryx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EunetCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eunet.codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkSecretsconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.secretsconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JaytwoNugetcheckGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jaytwo.nugetcheck.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZayniRedisCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zayni-redis-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FshOrchardcorePoextractor2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsh.orchardcore.poextractor2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hellodotnetcoretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hellodotnetcoretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HasteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"haste.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HitsmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hitsm-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YukimiscriptCommandlinetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yukimiscript.commandlinetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LeancodeGlobalcontractsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"leancode.globalcontractsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EpubcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"epubcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netcdgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netcdgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReigniteProfilerCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reignite.profiler.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EntitygenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entitygen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stidgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stidgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusYmltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.ymltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ModernroninProjectrenamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modernronin.projectrenamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemaconsultingVhdltest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demaconsulting.vhdltest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Extcopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"extcopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LmondeilCliRedis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lmondeil.cli.redis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HolyesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"holyes.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Passgencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passgencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetUpdatr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-updatr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sftpcopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sftpcopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaplargeincChromedevtoolsProtocolgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maplargeinc.chromedevtools.protocolgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemaconsultingWeasyprinttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demaconsulting.weasyprinttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RestafarianCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"restafarian-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SeesharprunFilecounter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"seesharprun.filecounter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SyncCentralVersions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sync-central-versions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DehiveCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dehive.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MagiconionGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"magiconion.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SoftbandExtractorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"softband.extractor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jiragitcommiter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jiragitcommiter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GratisdnsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gratisdns-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MinecraftmodupdaterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minecraftmodupdater.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GiteeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitee-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetXscgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-xscgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OrchestrateitDxfgeometrycompareTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"orchestrateit.dxfgeometrycompare.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeosenseplusCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geosenseplus.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZiocampoSmollprox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ziocampo.smollprox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MilkywareSarifConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"milkyware-sarif-converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Toyrobotchallenge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toyrobotchallenge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FflowCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fflow.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTrx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-trx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EonacatLicenserNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eonacat.licenser.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WizcoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wizco.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProjgraphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projgraph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-monitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devcachecleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devcachecleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpecworksMarkmywordCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"specworks.markmyword.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Seeder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"seeder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimcubeDappergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simcube.dappergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KamisamaMicroservicesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kamisama.microservices.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PassingwindMakecerts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passingwind.makecerts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZerozerooneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zerozeroone.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkNulllockconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.nulllockconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TorqueCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"torque-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwagabondCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swagabond.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DazzleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dazzle.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatagapJellogCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datagap.jellog.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HowldevCliTextdto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"howldev.cli.textdto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FleeceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fleece.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genms(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genms {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCdp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cdp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmallsoftCalculator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smallsoft.calculator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KodifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kodify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WolfiredU3dotConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wolfired.u3dot_converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KopfrechnerChurnr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kopfrechner.churnr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MigratorDatabaseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"migrator.database.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}