using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command BackenderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"backender.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FunBlazorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fun.blazor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFormat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-format {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bbob(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbob {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LibsassbuilderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"libsassbuilder-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BtrfsRsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"btrfs-rsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BearboneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bearbone.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NewbeBuildPsake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"newbe.build.psake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bomcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bomcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusBuildkittool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.buildkittool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetbackground(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetbackground {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZebbleBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zebble-build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BasicCompilerlog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"basic.compilerlog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Beacon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"beacon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleKserviceimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.kserviceimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BottlenoselabsC2ffiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bottlenoselabs.c2ffi.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmoerfuglBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smoerfugl._build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Base64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleInflexmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.inflexmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDecodeBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-decode-base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorloreFormatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorlore.format.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BbcodersCommonsTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbcoders.commons.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Biblemarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"biblemarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BnjsoftwareDocumentationtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bnjsoftware.documentationtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazor.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Eros404Bandcampsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eros404.bandcampsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bitesized(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bitesized {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bring2mindCodegenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bring2mind.codegen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DartsassbuilderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dartsassbuilder-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetStryker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-stryker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlakeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blake.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusBuildmd5task(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.buildmd5task {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevbricksClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devbricks.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleCentrallogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.centrallogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Boomos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"boomos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BomsweeperGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bomsweeper.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Timeitsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timeitsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Buildversionmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"buildversionmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BriandrellingHarmony(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"briandrelling.harmony {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorbindingsMauiComponentgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorbindings.maui.componentgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NservicebusPersistenceSqlCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nservicebus.persistence.sql.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BusytagCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"busytag.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowBlaze(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.blaze {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dartsassbuildwatchertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dartsassbuildwatchertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MartincostelloDotnetbumper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"martincostello.dotnetbumper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Benchmarkcmp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"benchmarkcmp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BravellianWorkbench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bravellian.workbench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MgcbBasisu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mgcb-basisu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BsoaGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bsoa.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SharpbrickPoweredupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpbrick.poweredup.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NservicebusTransportRabbitmqCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nservicebus.transport.rabbitmq.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BunUnofficialTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bun.unofficial.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Breakdance(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"breakdance {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProtobufNetProtogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"protobuf-net.protogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BsoaFromjschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bsoa.fromjschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bbap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BinarydatadecodersNetServicehostCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"binarydatadecoders.net.servicehost.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BulkimagedownloaderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bulkimagedownloader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unitybuildrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unitybuildrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RxbimMsibuilderGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rxbim.msibuilder.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BbcodersCommonsQuerygeneratortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbcoders.commons.querygeneratortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatavisionBeeyardCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datavision.beeyard.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinybiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinybi.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BoleroLive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bolero-live {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webben(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webben {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Breacher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"breacher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusGitlabcodeformatbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.gitlabcodeformatbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kraft(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kraft {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetProperty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-property {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BitmagicTemplateengineRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bitmagic.templateengine.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B2r2Fslint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b2r2.fslint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimcubeBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simcube.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BinarydatadecodersPackmanCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"binarydatadecoders.packman.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RosieVersionbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rosie.versionbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BeyondLsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"beyond.ls.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UndertestFeaturelint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"undertest.featurelint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BreweryProjecttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brewery.projecttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleImporttester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.importtester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BunUnofficialToolWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bun.unofficial.tool.win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BunUnofficialToolLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bun.unofficial.tool.linux-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cicee(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cicee {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleCmmdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.cmmdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BulldetektorWatchify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bulldetektor.watchify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Terrabuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"terrabuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StormancerServerBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stormancer.server.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MddBooster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mdd-booster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BerttHello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bertt.hello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitlabcodequalitybuildloggerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlabcodequalitybuildlogger.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSubset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-subset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Botsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BunUnofficialToolOsxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bun.unofficial.tool.osx-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Baseconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"baseconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RsmasstransitTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rsmasstransit.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XtcBaasoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xtc.baaso.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlackbytesboxDistributedBbdist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blackbytesbox.distributed.bbdist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Brackettextremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brackettextremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BotsayTestLust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"botsay_test_lust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Breach(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"breach {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BosonWebkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"boson.webkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}