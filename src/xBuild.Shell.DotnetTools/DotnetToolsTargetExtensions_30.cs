using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T BackenderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"backender.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FunBlazorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fun.blazor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFormat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-format {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bbob(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbob {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LibsassbuilderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"libsassbuilder-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BtrfsRsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"btrfs-rsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BearboneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bearbone.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NewbeBuildPsake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"newbe.build.psake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bomcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bomcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusBuildkittool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.buildkittool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetbackground(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetbackground {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZebbleBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zebble-build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BasicCompilerlog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"basic.compilerlog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Beacon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"beacon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleKserviceimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.kserviceimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BottlenoselabsC2ffiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bottlenoselabs.c2ffi.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmoerfuglBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smoerfugl._build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Base64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleInflexmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.inflexmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDecodeBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-decode-base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorloreFormatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorlore.format.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BbcodersCommonsTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbcoders.commons.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Biblemarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"biblemarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BnjsoftwareDocumentationtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bnjsoftware.documentationtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazor.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Eros404Bandcampsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eros404.bandcampsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bitesized(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bitesized {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bring2mindCodegenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bring2mind.codegen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DartsassbuilderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dartsassbuilder-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetStryker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-stryker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlakeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blake.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusBuildmd5task(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.buildmd5task {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevbricksClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devbricks.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleCentrallogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.centrallogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Boomos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"boomos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BomsweeperGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bomsweeper.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Timeitsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timeitsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Buildversionmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"buildversionmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BriandrellingHarmony(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"briandrelling.harmony {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorbindingsMauiComponentgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorbindings.maui.componentgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NservicebusPersistenceSqlCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nservicebus.persistence.sql.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BusytagCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"busytag.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowBlaze(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.blaze {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dartsassbuildwatchertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dartsassbuildwatchertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MartincostelloDotnetbumper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"martincostello.dotnetbumper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Benchmarkcmp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"benchmarkcmp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BravellianWorkbench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bravellian.workbench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MgcbBasisu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mgcb-basisu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BsoaGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bsoa.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SharpbrickPoweredupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpbrick.poweredup.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NservicebusTransportRabbitmqCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nservicebus.transport.rabbitmq.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BunUnofficialTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bun.unofficial.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Breakdance(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"breakdance {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProtobufNetProtogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"protobuf-net.protogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BsoaFromjschema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bsoa.fromjschema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bbap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BinarydatadecodersNetServicehostCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"binarydatadecoders.net.servicehost.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BulkimagedownloaderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bulkimagedownloader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unitybuildrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unitybuildrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RxbimMsibuilderGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rxbim.msibuilder.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BbcodersCommonsQuerygeneratortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbcoders.commons.querygeneratortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatavisionBeeyardCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datavision.beeyard.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinybiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinybi.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BoleroLive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bolero-live {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webben(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webben {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Breacher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"breacher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusGitlabcodeformatbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.gitlabcodeformatbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kraft(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kraft {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetProperty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-property {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BitmagicTemplateengineRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bitmagic.templateengine.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B2r2Fslint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b2r2.fslint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimcubeBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simcube.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BinarydatadecodersPackmanCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"binarydatadecoders.packman.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RosieVersionbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rosie.versionbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BeyondLsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"beyond.ls.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UndertestFeaturelint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"undertest.featurelint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BreweryProjecttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brewery.projecttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleImporttester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.importtester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BunUnofficialToolWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bun.unofficial.tool.win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BunUnofficialToolLinuxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bun.unofficial.tool.linux-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cicee(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cicee {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleCmmdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.cmmdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BulldetektorWatchify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bulldetektor.watchify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Terrabuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"terrabuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StormancerServerBootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stormancer.server.bootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MddBooster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mdd-booster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BerttHello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bertt.hello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitlabcodequalitybuildloggerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlabcodequalitybuildlogger.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSubset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-subset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Botsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BunUnofficialToolOsxX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bun.unofficial.tool.osx-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Baseconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"baseconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RsmasstransitTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rsmasstransit.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XtcBaasoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xtc.baaso.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlackbytesboxDistributedBbdist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blackbytesbox.distributed.bbdist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Brackettextremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brackettextremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BotsayTestLust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"botsay_test_lust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Breach(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"breach {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BosonWebkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"boson.webkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}