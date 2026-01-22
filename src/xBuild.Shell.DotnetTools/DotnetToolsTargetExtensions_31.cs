using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T HyaKadasterBagTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hya.kadaster.bag.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BalsamLicensingtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"balsam.licensingtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BbcodersCommonsSourcegeneratortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbcoders.commons.sourcegeneratortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BeiyuanWebsystemCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"beiyuan.websystem.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bingogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bingogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitBrowse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-browse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBusly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-busly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BluegoatMongoutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bluegoat.mongoutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Verbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"verbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BwbotCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bwbot-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBuildcharts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-buildcharts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BicepLocalDocgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bicep-local-docgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ironbeard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ironbeard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bborodiy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bborodiy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BanianForkElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"banian.fork.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PiralBlazorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"piral.blazor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Blprnt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blprnt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Blazora(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazora {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BasicTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"basic-trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BasetestpackageDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"basetestpackage.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bacon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bacon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Burgr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"burgr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BasesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bases.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Burrich(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"burrich {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorloreScaffoldCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorlore.scaffold.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bborodiy6rest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bborodiy6rest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BorsuksoftwareConicalToolsPytestresultsuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.pytestresultsuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBuildImage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-build-image {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bborodiy5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bborodiy5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetadslxBuildtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metadslx.buildtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bitbucketcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bitbucketcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EasybuildCommitlinter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easybuild.commitlinter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deveweb3cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deveweb3cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Blobcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blobcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CavebirdlabsGenymanIosdeviceidentifiers(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cavebirdlabs.genyman.iosdeviceidentifiers {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ncompilebench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ncompilebench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BannerlordcoopCliScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bannerlordcoop.cli.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B3dmExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b3dm.exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BushmanSecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bushman.secrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetSignalrBenchmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-signalr-benchmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solutionfilterbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solutionfilterbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Btcpaytool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"btcpaytool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NukedbitNrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nukedbit.nrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bitdao(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bitdao {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Borkscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borkscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SamhowesBzl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samhowes.bzl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleCentrallogtester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.centrallogtester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TrelloBackuperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trello-backuper.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloudwiseBuildProcessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudwise.build.processor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BestShellCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"best.shell.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rimraf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rimraf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TesselateBuilding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tesselate_building {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BenbenWechat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"benben.wechat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelegramBotUpdatesforwarder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telegram.bot.updatesforwarder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ByzLogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"byz.logger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BenbenGarnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"benben.garnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BrainfuckNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brainfuck.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeoExpress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neo.express {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BilaQWeatherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bila.q.weather.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pha3lDotbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pha3l.dotbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bulkreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bulkreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BrendanlynnBackuphash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brendanlynn.backuphash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Banjotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"banjotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolidopsSubzeroBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solidops.subzero.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorjsCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorjs.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Recreatesolutionstructure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"recreatesolutionstructure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bit76FluentmigratorToolUpdatedatabase(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bit76.fluentmigrator.tool.updatedatabase {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OhioboxTestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ohiobox.testrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazekitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazekit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BundotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bundotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bravectl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bravectl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BanjoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"banjo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorcliServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorcli.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BenbenLiveTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"benben.live.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BotsayTest1234(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"botsay-test1234 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bborodiy6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bborodiy6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GxbyBycoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gxby.bycore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Go2freeComponentbootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"go2free.componentbootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BenbenDotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"benben.dotnet-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetlicencebuddy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetlicencebuddy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XenialBranchy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xenial.branchy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EdjcaseIcpClientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"edjcase.icp.clientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbconfirmTemplategeneration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbconfirm.templategeneration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BryjenMonkey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bryjen.monkey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BrendanlynnBrandom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brendanlynn.brandom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GraphqlBreakingSchemaChangeDetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"graphql-breaking-schema-change-detector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bbmdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbmdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Brot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Base64topdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"base64topdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BurnerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"burner-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlbench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlbench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OfcoursedudeBomcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ofcoursedude.bomcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkNugetbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.nugetbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodeButler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"code-butler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LindexiToolCheckoutgitrandomnamebranch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lindexi.tool.checkoutgitrandomnamebranch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetL10nBuildtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-l10n-buildtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GazelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gazel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}