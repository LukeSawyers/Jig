using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Packagevulnerabilitychecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packagevulnerabilitychecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Decode2020Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"decode2020.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbcontextsplitter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbcontextsplitter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MiniengineToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"miniengine.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UthavuCrud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uthavu.crud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WordpuzzleConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wordpuzzle.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sop4csCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sop4cs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VioletCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"violet.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetcorewithvue(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcorewithvue {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetsyncerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetsyncer.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThreaxGitserverCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"threax.gitserver.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpecialExampleNickCharniakId(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"special_example_nick_charniak_id {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JustCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"just-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IplanDesktoptoolsCommon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iplan.desktoptools.common {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qunatclikit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qunatclikit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ilspycmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ilspycmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NinechroniclesHeadlessExecutor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ninechronicles.headless.executor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WeavlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"weavly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RapidfireCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rapidfire-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MemoryleakdetectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"memoryleakdetector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThiqahCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thiqah.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KillportCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"killport.cli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DyabpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dyabp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HybridclrQuickrunCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hybridclr.quickrun.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Robocopyconfigmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robocopyconfigmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Imagecompressionconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imagecompressionconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Luycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"luycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GmYlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gm.yl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Regi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XmldocformatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xmldocformat.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JsonmergeCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsonmerge.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Https(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"https {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SsmexporterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ssmexporter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RksoftwareImageresizeconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rksoftware.imageresizeconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jonturkcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jonturkcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SearchpioneerRankingCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"searchpioneer.ranking.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OnesMediatesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ones.mediates.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rumrunner0CowsayTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rumrunner0.cowsay.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharp-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FluxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flux.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MygenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mygen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnigmaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"enigma.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sftpcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sftpcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkSheetstocsv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.sheetstocsv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesNetpdfcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.netpdfcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WauxLangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"waux.lang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDbkeepernet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dbkeepernet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KorzhEasyqueryDatamodeltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"korzh.easyquery.datamodeltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZCodeSqlsugar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"z.code.sqlsugar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DrewcOctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"drewc.octool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemaconsultingReqstream(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demaconsulting.reqstream {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetExecute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-execute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MyormCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myorm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mlocombiner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlocombiner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EliassenTemplateengineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eliassen.templateengine.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeutrinoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neutrino.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JeftdotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jeftdotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Positionmakercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"positionmakercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WakeonlanConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wakeonlan.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RasoulianCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rasoulian.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EprCliConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"epr.cli.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mecabconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mecabconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DmarcreaderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dmarcreader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hello1dotnetcoretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hello1dotnetcoretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EliassenFixsourcelinksCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eliassen.fixsourcelinks.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaomiCurl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maomi.curl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RacoonTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"racoon.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolCocor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tool.cocor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Semver2Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"semver2.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZCodeEf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"z.code.ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scaffnetconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scaffnetconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GillesduifCrypto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gillesduif.crypto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wordscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wordscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NobisoftCoreCrudgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nobisoft.core.crudgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Schemacreation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"schemacreation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilmoonScriptengineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"silmoon.scriptengine.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sergen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sergen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Followingchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"followingchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDbMigrate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-db-migrate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetpackageupgraderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetpackageupgrader.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GranuletCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"granulet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HopdeployCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hopdeploy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WslrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wslr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Htmlc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"htmlc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MagicodesIeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"magicodes.ie.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lizziecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lizziecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlaceCounterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"place-counter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EndowdlyCercis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"endowdly.cercis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuberCoreCmdtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quber.core.cmdtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DtoqlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dtoql.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MhDbtoentityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mh.dbtoentity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuberCoreNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quber.core.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EntitydbProvisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entitydb.provisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SubdotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"subdotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Haydara1MathCnums(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"haydara1.math.cnums {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MyclasslibFfffffffffffff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myclasslib_ffffffffffffff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MdrivesyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mdrivesync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VerticalTemplatecopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vertical-templatecopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}