using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Packagevulnerabilitychecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packagevulnerabilitychecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Decode2020Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"decode2020.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbcontextsplitter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbcontextsplitter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MiniengineToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"miniengine.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UthavuCrud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uthavu.crud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WordpuzzleConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wordpuzzle.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sop4csCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sop4cs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VioletCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"violet.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetcorewithvue(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcorewithvue {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetsyncerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetsyncer.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThreaxGitserverCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"threax.gitserver.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpecialExampleNickCharniakId(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"special_example_nick_charniak_id {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JustCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"just-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IplanDesktoptoolsCommon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iplan.desktoptools.common {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qunatclikit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qunatclikit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ilspycmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ilspycmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NinechroniclesHeadlessExecutor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ninechronicles.headless.executor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WeavlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"weavly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RapidfireCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rapidfire-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MemoryleakdetectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"memoryleakdetector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThiqahCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thiqah.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KillportCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"killport.cli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DyabpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dyabp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HybridclrQuickrunCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hybridclr.quickrun.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Robocopyconfigmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robocopyconfigmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Imagecompressionconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imagecompressionconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Luycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"luycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GmYlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gm.yl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Regi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XmldocformatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xmldocformat.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JsonmergeCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsonmerge.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Https(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"https {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SsmexporterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ssmexporter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RksoftwareImageresizeconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rksoftware.imageresizeconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jonturkcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jonturkcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SearchpioneerRankingCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"searchpioneer.ranking.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OnesMediatesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ones.mediates.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rumrunner0CowsayTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rumrunner0.cowsay.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharp-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FluxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flux.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MygenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mygen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnigmaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"enigma.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sftpcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sftpcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkSheetstocsv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.sheetstocsv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesNetpdfcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.netpdfcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WauxLangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"waux.lang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDbkeepernet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dbkeepernet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KorzhEasyqueryDatamodeltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"korzh.easyquery.datamodeltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZCodeSqlsugar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"z.code.sqlsugar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DrewcOctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"drewc.octool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemaconsultingReqstream(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demaconsulting.reqstream {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetExecute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-execute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MyormCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myorm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mlocombiner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlocombiner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EliassenTemplateengineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eliassen.templateengine.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeutrinoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neutrino.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JeftdotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jeftdotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Positionmakercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"positionmakercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WakeonlanConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wakeonlan.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RasoulianCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rasoulian.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EprCliConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"epr.cli.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mecabconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mecabconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DmarcreaderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dmarcreader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hello1dotnetcoretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hello1dotnetcoretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EliassenFixsourcelinksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eliassen.fixsourcelinks.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaomiCurl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maomi.curl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RacoonTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"racoon.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolCocor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tool.cocor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Semver2Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"semver2.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZCodeEf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"z.code.ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scaffnetconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scaffnetconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GillesduifCrypto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gillesduif.crypto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wordscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wordscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NobisoftCoreCrudgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nobisoft.core.crudgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Schemacreation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"schemacreation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilmoonScriptengineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"silmoon.scriptengine.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sergen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sergen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Followingchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"followingchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDbMigrate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-db-migrate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetpackageupgraderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetpackageupgrader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GranuletCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"granulet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HopdeployCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hopdeploy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WslrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wslr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Htmlc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"htmlc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MagicodesIeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"magicodes.ie.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lizziecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lizziecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlaceCounterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"place-counter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EndowdlyCercis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"endowdly.cercis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuberCoreCmdtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quber.core.cmdtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DtoqlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dtoql.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MhDbtoentityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mh.dbtoentity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuberCoreNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quber.core.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EntitydbProvisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entitydb.provisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SubdotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"subdotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Haydara1MathCnums(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"haydara1.math.cnums {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MyclasslibFfffffffffffff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myclasslib_ffffffffffffff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MdrivesyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mdrivesync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VerticalTemplatecopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vertical-templatecopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}