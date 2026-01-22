using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command JaytechToolsStrykersolution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jaytech.tools.strykersolution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicroRdbms(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"micro.rdbms {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ImplemPleasantersetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"implem.pleasantersetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlstresscmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlstresscmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testprojsraines2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testprojsraines2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaxotekProductivity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maxotek.productivity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XpyNgswagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xpy.ngswagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ophitools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ophitools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JmgParsnip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jmg.parsnip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Iplust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iplust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JrpcmediatorTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jrpcmediator.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Warppackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"warppackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trnullable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trnullable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Smartsftp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartsftp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Resxtojson2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resxtojson2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TwodoSay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"twodo.say {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tasknet2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tasknet2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Json2record(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"json2record {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MystagingGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mystaging.gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mysqlquerydivider(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mysqlquerydivider {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gridscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gridscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tcpmux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tcpmux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShinnySsg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shinny_ssg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VertigisNugetscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vertigis.nugetscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scrub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scrub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkScreen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.screen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkGrep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.grep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JaytechToolsOasIndexgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jaytech.tools.oas.indexgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Typecart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typecart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TideKey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tide-key {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarketToolsStd2np(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"market.tools.std2np {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Weeknumber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"weeknumber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkIssueexporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.issueexporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Performanethelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"performanethelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kubeauth(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kubeauth {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SafeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"safe.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gengurka(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gengurka {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuModbus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.modbus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Voicetrigger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"voicetrigger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GaspraMergesprocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gaspra.mergesprocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Toolui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toolui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LogjointPlugintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"logjoint.plugintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LibRelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lib.release {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gclm3(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gclm3 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Easyfornettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easyfornettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkLogo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.logo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Protoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"protoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KgenRoslynviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kgen.roslynviewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testfiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testfiles {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testfips(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testfips {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Now(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"now {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KinetixToolsSqltestgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kinetix.tools.sqltestgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nuexporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuexporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyrecoilRelay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyrecoil.relay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kodax(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kodax {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReferenceswitcherTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"referenceswitcher.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkSinnn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.sinnn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trpiggy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trpiggy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Linuxtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linuxtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GsuuonToolGrab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gsuuon.tool.grab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeamodPackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meamod.packager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Translate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"translate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tsqllintpatched(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tsqllintpatched {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Touchgrass(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"touchgrass {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MbutilsKafkaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mbutils.kafka.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pulumigraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pulumigraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Snmpsender(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snmpsender {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Filetracker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filetracker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Llhtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"llhtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swaggertotypescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swaggertotypescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SuthepSupermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"suthep.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolFlysql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tool.flysql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ParkitectWorkshopUpload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"parkitect-workshop-upload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vk1Supermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vk1.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gfl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gfl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TocsoftMinikubeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tocsoft.minikube.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThaiNationalIdFormatValidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thai-national-id-format-validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TocsoftKubectlTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tocsoft.kubectl.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FpI18nTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fp-i18n-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Opinionatedusings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opinionatedusings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pulumischemaexplorer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pulumischemaexplorer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fork(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fork {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkFilelength(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.filelength {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EditPlantuml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"edit-plantuml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NatechMasstransitSwagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"natech.masstransit.swagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fzf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fzf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ServeSqlite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"serve-sqlite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TeamsTranscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"teams-transcript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Greeter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"greeter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyrecoilHere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyrecoil.here {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkVideoserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.videoserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EvoscTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"evosc.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitlabreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlabreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyrecoilThere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyrecoil.there {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Json2env(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"json2env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}