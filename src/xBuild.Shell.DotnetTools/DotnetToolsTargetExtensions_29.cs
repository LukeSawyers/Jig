using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T StrawberryshakeToolsFixed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"strawberryshake.tools.fixed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PushmonolithCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pushmonolith.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MypackageTest253623(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mypackage.test.253623 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KavicsGittools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kavics.gittools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HelperPerfornanceGenericboxing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"helper.perfornance.genericboxing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kona(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kona {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MabPipelineframeworkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mab.pipelineframework.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MageesoftStellarissaveparserCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mageesoft.stellarissaveparser.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Createsekibantemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"createsekibantemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Grepapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grepapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsQahelperconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.qahelperconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Databasevisualizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"databasevisualizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TradingviewScreenerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tradingview.screener.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slyricf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slyricf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WavesentSshdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wavesent.sshdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ppct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ppct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazormicrofrontendsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazormicrofrontends.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FradavDepmanProj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fradav.depman-proj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RobertsirreChangelogConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robertsirre.changelog.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pattool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pattool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InterblazeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"interblaze.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EdgelordkiritoMp3filecut(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"edgelordkirito.mp3filecut {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatovyEdamDataCatalogdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datovy.edam.data.catalogdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VuforiawebserviceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vuforiawebservice.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ExceedsystemNugetlicensecollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"exceedsystem.nugetlicensecollector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NinjamooseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ninjamoose.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TemplateCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"template.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DmarranconeNovidisCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dmarrancone-novidis.codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DlabsDotnetProjectTemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dlabs-dotnet-project-template {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YarnspinnerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yarnspinner.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SsfOnionSln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ssf.onion.sln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CopltCom2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coplt.com2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetpackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetpackager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TavisM365copilotchat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tavis.m365copilotchat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LtbDotnetGuidDemo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ltb-dotnet-guid-demo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SubashTorontoWeather(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"subash_toronto_weather {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharkyparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharkyparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Venumerables(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"venumerables {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetS2f(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-s2f {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DataversetablemanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dataversetablemanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IlabIo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ilab-io {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Efbootstrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"efbootstrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cnct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cnct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwallowTaskrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swallow.taskrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sparkql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sparkql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FvneverNightwatchTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fvnever.nightwatch.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SannrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sannr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vaultpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vaultpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetJsome(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-jsome {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fcu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fcu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FynyddSfumatoScss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fynydd.sfumato-scss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CcPlugins(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cc-plugins {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TiaccCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tiacc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UapsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uaps.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IpsloggerV11(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ipslogger.v1.1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Notmdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"notmdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LambtonClgClasslibrary11Testlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lambton.clg.classlibrary11.testlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Top2000Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"top2000.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodetorchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codetorch.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GemojisharpMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gemojisharp.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Viperscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"viperscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Razorformatter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"razorformatter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReporeadmerewriterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reporeadmerewriter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DhCsDllanalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dh.cs.dllanalyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HaruCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"haru.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JetbrainsDotcoverCommandlinetools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jetbrains.dotcover.commandlinetools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JetbrainsResharperGlobaltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jetbrains.resharper.globaltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FunfairBuildversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"funfair.buildversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Boogie(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"boogie {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BrowserstackSdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"browserstack-sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Barista(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"barista {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BottlenoselabsC2csTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bottlenoselabs.c2cs.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BreakdanceTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"breakdance.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetServe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-serve {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BonsaiPlayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bonsai.player {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BitResxtranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bit.resxtranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bbdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bbdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Databoss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"databoss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Commandlinebatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"commandlinebatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BinarydatadecodersXsltCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"binarydatadecoders.xslt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleConfigeditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.configeditor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoGalleryOutputbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.gallery.outputbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MsharpBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msharp-build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BacklangManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"backlang-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XamlstylerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xamlstyler.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoverletConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coverlet.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CredfetoGallerySiteindexbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"credfeto.gallery.siteindexbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FlowerbiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flowerbi.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcircleKservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bcircle.kservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bitbucketcodecoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bitbucketcodecoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pg2b3dm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pg2b3dm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BottlecapNetGraphqlGenerationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bottlecap.net.graphql.generation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharpier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BrighidCommandsSdkPackagetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"brighid.commands.sdk.packagetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T B3dmTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"b3dm.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UploadBitbucketCoverageTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"upload-bitbucket-coverage-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Berp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"berp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}