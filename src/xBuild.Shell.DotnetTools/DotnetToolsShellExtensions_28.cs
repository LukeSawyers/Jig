using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command SolaceScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solace.scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CyivalBuildCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cyival.build.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TsgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tsgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Diskor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"diskor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xsometool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xsometool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DendrodocsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dendrodocs.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Distancebetweencoordonates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"distancebetweencoordonates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FilesummaryTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filesummary.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Retest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"retest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsrun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsrun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Httphammer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"httphammer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LinkedinMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linkedin.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RetrosharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"retrosharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docx2html(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docx2html {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NrsGltf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nrs-gltf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SputterConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sputter.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetpurge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetpurge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaheshkshirsagarTestingConcurrencytester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maheshkshirsagar.testing.concurrencytester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deadcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deadcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrokCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grok-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KonetExt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"konet-ext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SyntheaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"synthea-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Roslynrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"roslynrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharpts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Graphconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"graphconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mediasorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mediasorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetbulkdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetbulkdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wellknowns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wellknowns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NrsEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nrs-editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fluentcodegentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fluentcodegentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dnsswitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnsswitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Defaultcorspolicies(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"defaultcorspolicies {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SptbridgeuiTypegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sptbridgeui.typegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CzemilogicmethodsNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"czemilogicmethods.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NrsMv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nrs-mv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tskm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tskm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DecovaGotcha(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"decova.gotcha {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LadeakPenit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ladeak.penit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MultitypeNetSourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"multitype.net.sourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DragonhillCmakefilewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dragonhill.cmakefilewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Igbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"igbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sourceexplorermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sourceexplorermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PixelbadgerToolkitRag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pixelbadger.toolkit.rag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ioncli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ioncli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KiwisoftMailjet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kiwisoft.mailjet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorforkidsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorforkids.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tiny.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MindscopeMigrationtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mindscope.migrationtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qsai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qsai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Behero(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"behero {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PackagescannerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packagescanner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deloutdatedfiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deloutdatedfiles {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RobodDecoderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robod.decoder.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MybatisNetSqlmapperTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mybatis.net.sqlmapper.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NusaveCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nusave.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KorzhTextfilesconcatenator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"korzh.textfilesconcatenator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ListpagerPagination(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"listpager.pagination {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clauder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clauder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McmhamHarmockserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcmham.harmockserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeshweaverThumbnailgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meshweaver.thumbnailgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fslint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fslint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dicecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dicecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Soddi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"soddi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Modelprocessor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modelprocessor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kizuna7(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kizuna7 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DockernamesgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dockernamesgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NikoPackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"niko_package {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Commandscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"commandscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GpHurl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gp-hurl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scpsltemplategenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scpsltemplategenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Flexnamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flexnamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EcmsUpdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ecms.updater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dottimework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dottimework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CadmeanRpcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cadmean.rpc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JerryNetconf2025Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jerry-netconf2025-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codecolor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecolor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IvysoftMegasolution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ivysoft.megasolution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Godotconstantsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"godotconstantsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TzionetRamon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tzionet-ramon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BootstrapblazorLlmsdocsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bootstrapblazor.llmsdocsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HonaNugethelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hona.nugethelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YgJenkins(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yg-jenkins {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Shuaige(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shuaige {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Init2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"init2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GwvGotchaGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gwv.gotcha.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GwvXwinpick(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gwv.xwinpick {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CamusdbDump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"camusdb.dump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sudokusolver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sudokusolver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RorokaiiPoGpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rorokaii.po.gpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command C2paremoverCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"c2paremover.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gshell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gshell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FluentmigratorcommunityMigrationtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fluentmigratorcommunity.migrationtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Poke(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"poke {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Libtools4djs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"libtools4djs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Handkey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"handkey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GreaterthantechTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"greaterthantech.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Plantumldotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plantumldotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Transformconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"transformconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenericDummygeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generic.dummygenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetcleanerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetcleaner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}