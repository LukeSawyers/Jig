using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T SolaceScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solace.scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CyivalBuildCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cyival.build.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TsgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tsgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Diskor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"diskor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xsometool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xsometool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DendrodocsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dendrodocs.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Distancebetweencoordonates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"distancebetweencoordonates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FilesummaryTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filesummary.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Retest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"retest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsrun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsrun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Httphammer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"httphammer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LinkedinMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linkedin.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RetrosharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"retrosharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docx2html(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docx2html {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NrsGltf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nrs-gltf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SputterConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sputter.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetpurge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetpurge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaheshkshirsagarTestingConcurrencytester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maheshkshirsagar.testing.concurrencytester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deadcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deadcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrokCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grok-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KonetExt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"konet-ext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SyntheaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"synthea-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Roslynrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"roslynrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharpts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Graphconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"graphconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mediasorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mediasorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetbulkdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetbulkdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wellknowns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wellknowns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NrsEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nrs-editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fluentcodegentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fluentcodegentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dnsswitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnsswitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Defaultcorspolicies(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"defaultcorspolicies {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SptbridgeuiTypegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sptbridgeui.typegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CzemilogicmethodsNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"czemilogicmethods.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NrsMv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nrs-mv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tskm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tskm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DecovaGotcha(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"decova.gotcha {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LadeakPenit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ladeak.penit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MultitypeNetSourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"multitype.net.sourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DragonhillCmakefilewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dragonhill.cmakefilewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Igbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"igbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sourceexplorermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sourceexplorermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PixelbadgerToolkitRag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pixelbadger.toolkit.rag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ioncli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ioncli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KiwisoftMailjet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kiwisoft.mailjet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorforkidsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorforkids.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tiny.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MindscopeMigrationtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mindscope.migrationtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qsai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qsai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Behero(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"behero {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PackagescannerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packagescanner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deloutdatedfiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deloutdatedfiles {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RobodDecoderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robod.decoder.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MybatisNetSqlmapperTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mybatis.net.sqlmapper.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NusaveCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nusave.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KorzhTextfilesconcatenator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"korzh.textfilesconcatenator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ListpagerPagination(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"listpager.pagination {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clauder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clauder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McmhamHarmockserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcmham.harmockserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeshweaverThumbnailgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meshweaver.thumbnailgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fslint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fslint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dicecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dicecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Soddi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"soddi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Modelprocessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modelprocessor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kizuna7(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kizuna7 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DockernamesgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dockernamesgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NikoPackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"niko_package {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Commandscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"commandscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GpHurl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gp-hurl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scpsltemplategenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scpsltemplategenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Flexnamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flexnamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EcmsUpdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ecms.updater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dottimework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dottimework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CadmeanRpcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cadmean.rpc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JerryNetconf2025Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jerry-netconf2025-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codecolor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecolor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IvysoftMegasolution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivysoft.megasolution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Godotconstantsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"godotconstantsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TzionetRamon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tzionet-ramon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BootstrapblazorLlmsdocsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bootstrapblazor.llmsdocsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HonaNugethelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hona.nugethelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YgJenkins(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yg-jenkins {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Shuaige(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shuaige {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Init2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"init2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GwvGotchaGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gwv.gotcha.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GwvXwinpick(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gwv.xwinpick {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CamusdbDump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"camusdb.dump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sudokusolver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sudokusolver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RorokaiiPoGpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rorokaii.po.gpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T C2paremoverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"c2paremover.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gshell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gshell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FluentmigratorcommunityMigrationtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fluentmigratorcommunity.migrationtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Poke(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"poke {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Libtools4djs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"libtools4djs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Handkey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"handkey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GreaterthantechTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greaterthantech.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Plantumldotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plantumldotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Transformconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"transformconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenericDummygeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generic.dummygenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetcleanerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetcleaner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}