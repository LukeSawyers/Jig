using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command StrawberryshakeToolsFixed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"strawberryshake.tools.fixed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PushmonolithCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pushmonolith.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MypackageTest253623(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mypackage.test.253623 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KavicsGittools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kavics.gittools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HelperPerfornanceGenericboxing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"helper.perfornance.genericboxing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kona(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kona {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MabPipelineframeworkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mab.pipelineframework.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MageesoftStellarissaveparserCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mageesoft.stellarissaveparser.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Createsekibantemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"createsekibantemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Grepapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grepapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsQahelperconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.qahelperconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Databasevisualizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"databasevisualizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TradingviewScreenerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tradingview.screener.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slyricf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slyricf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WavesentSshdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wavesent.sshdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ppct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ppct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazormicrofrontendsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazormicrofrontends.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FradavDepmanProj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fradav.depman-proj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RobertsirreChangelogConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robertsirre.changelog.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pattool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pattool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InterblazeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"interblaze.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EdgelordkiritoMp3filecut(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"edgelordkirito.mp3filecut {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatovyEdamDataCatalogdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datovy.edam.data.catalogdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VuforiawebserviceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vuforiawebservice.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ExceedsystemNugetlicensecollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"exceedsystem.nugetlicensecollector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NinjamooseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ninjamoose.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TemplateCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"template.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DmarranconeNovidisCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dmarrancone-novidis.codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DlabsDotnetProjectTemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dlabs-dotnet-project-template {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YarnspinnerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yarnspinner.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SsfOnionSln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ssf.onion.sln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CopltCom2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coplt.com2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetpackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetpackager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TavisM365copilotchat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tavis.m365copilotchat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LtbDotnetGuidDemo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ltb-dotnet-guid-demo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SubashTorontoWeather(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"subash_toronto_weather {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharkyparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharkyparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Venumerables(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"venumerables {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetS2f(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-s2f {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DataversetablemanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dataversetablemanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IlabIo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ilab-io {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Efbootstrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"efbootstrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cnct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cnct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwallowTaskrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swallow.taskrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sparkql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sparkql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FvneverNightwatchTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fvnever.nightwatch.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SannrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sannr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vaultpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vaultpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetJsome(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-jsome {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fcu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fcu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FynyddSfumatoScss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fynydd.sfumato-scss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CcPlugins(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cc-plugins {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TiaccCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tiacc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UapsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uaps.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IpsloggerV11(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ipslogger.v1.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Notmdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"notmdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LambtonClgClasslibrary11Testlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lambton.clg.classlibrary11.testlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Top2000Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"top2000.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodetorchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codetorch.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GemojisharpMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gemojisharp.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Viperscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"viperscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Razorformatter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"razorformatter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReporeadmerewriterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reporeadmerewriter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DhCsDllanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dh.cs.dllanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HaruCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"haru.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JetbrainsDotcoverCommandlinetools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jetbrains.dotcover.commandlinetools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JetbrainsResharperGlobaltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jetbrains.resharper.globaltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FunfairBuildversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"funfair.buildversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Boogie(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"boogie {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BrowserstackSdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"browserstack-sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Barista(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"barista {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BottlenoselabsC2csTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bottlenoselabs.c2cs.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BreakdanceTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"breakdance.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetServe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-serve {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BonsaiPlayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bonsai.player {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BitResxtranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bit.resxtranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bbdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bbdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Databoss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"databoss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Commandlinebatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"commandlinebatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BinarydatadecodersXsltCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"binarydatadecoders.xslt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleConfigeditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.configeditor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoGalleryOutputbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.gallery.outputbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MsharpBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msharp-build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BacklangManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"backlang-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XamlstylerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xamlstyler.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoverletConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coverlet.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoGallerySiteindexbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.gallery.siteindexbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FlowerbiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flowerbi.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcircleKservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bcircle.kservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bitbucketcodecoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bitbucketcodecoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pg2b3dm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pg2b3dm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BottlecapNetGraphqlGenerationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bottlecap.net.graphql.generation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharpier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BrighidCommandsSdkPackagetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"brighid.commands.sdk.packagetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command B3dmTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"b3dm.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UploadBitbucketCoverageTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"upload-bitbucket-coverage-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Berp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"berp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}