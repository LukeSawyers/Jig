using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command HyaKadasterBagTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hya.kadaster.bag.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BalsamLicensingtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"balsam.licensingtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BbcodersCommonsSourcegeneratortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbcoders.commons.sourcegeneratortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BeiyuanWebsystemCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"beiyuan.websystem.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bingogen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bingogen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitBrowse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-browse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBusly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-busly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BluegoatMongoutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bluegoat.mongoutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Verbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"verbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BwbotCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bwbot-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBuildcharts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-buildcharts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BicepLocalDocgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bicep-local-docgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ironbeard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ironbeard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bborodiy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bborodiy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BanianForkElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"banian.fork.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PiralBlazorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"piral.blazor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Blprnt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blprnt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Blazora(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazora {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BasicTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"basic-trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BasetestpackageDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"basetestpackage.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bacon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bacon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Burgr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"burgr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BasesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bases.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Burrich(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"burrich {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorloreScaffoldCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorlore.scaffold.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bborodiy6rest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bborodiy6rest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BorsuksoftwareConicalToolsPytestresultsuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.pytestresultsuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBuildImage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-build-image {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bborodiy5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bborodiy5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetadslxBuildtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metadslx.buildtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bitbucketcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bitbucketcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EasybuildCommitlinter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easybuild.commitlinter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deveweb3cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deveweb3cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Blobcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blobcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CavebirdlabsGenymanIosdeviceidentifiers(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cavebirdlabs.genyman.iosdeviceidentifiers {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ncompilebench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ncompilebench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BannerlordcoopCliScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bannerlordcoop.cli.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B3dmExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b3dm.exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BushmanSecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bushman.secrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetSignalrBenchmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-signalr-benchmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solutionfilterbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solutionfilterbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Btcpaytool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"btcpaytool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NukedbitNrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nukedbit.nrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bitdao(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bitdao {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Borkscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borkscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SamhowesBzl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samhowes.bzl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleCentrallogtester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.centrallogtester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TrelloBackuperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trello-backuper.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloudwiseBuildProcessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudwise.build.processor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BestShellCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"best.shell.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rimraf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rimraf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TesselateBuilding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tesselate_building {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BenbenWechat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"benben.wechat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TelegramBotUpdatesforwarder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telegram.bot.updatesforwarder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ByzLogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"byz.logger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BenbenGarnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"benben.garnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BrainfuckNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brainfuck.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeoExpress(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neo.express {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BilaQWeatherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bila.q.weather.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pha3lDotbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pha3l.dotbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bulkreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bulkreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BrendanlynnBackuphash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brendanlynn.backuphash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Banjotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"banjotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolidopsSubzeroBuildtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solidops.subzero.buildtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorjsCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorjs.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Recreatesolutionstructure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"recreatesolutionstructure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bit76FluentmigratorToolUpdatedatabase(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bit76.fluentmigrator.tool.updatedatabase {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OhioboxTestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ohiobox.testrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazekitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazekit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BundotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bundotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bravectl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bravectl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BanjoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"banjo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorcliServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorcli.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BenbenLiveTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"benben.live.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BotsayTest1234(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"botsay-test1234 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bborodiy6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bborodiy6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GxbyBycoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gxby.bycore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Go2freeComponentbootstrapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"go2free.componentbootstrapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BenbenDotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"benben.dotnet-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetlicencebuddy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetlicencebuddy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XenialBranchy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xenial.branchy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EdjcaseIcpClientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"edjcase.icp.clientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbconfirmTemplategeneration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbconfirm.templategeneration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BryjenMonkey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bryjen.monkey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BrendanlynnBrandom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brendanlynn.brandom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GraphqlBreakingSchemaChangeDetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"graphql-breaking-schema-change-detector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bbmdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbmdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Brot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Base64topdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"base64topdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BurnerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"burner-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlbench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlbench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OfcoursedudeBomcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ofcoursedude.bomcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkNugetbadge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.nugetbadge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodeButler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"code-butler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LindexiToolCheckoutgitrandomnamebranch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lindexi.tool.checkoutgitrandomnamebranch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetL10nBuildtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-l10n-buildtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GazelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gazel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}