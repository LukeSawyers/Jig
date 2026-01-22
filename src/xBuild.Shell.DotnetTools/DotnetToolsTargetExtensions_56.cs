using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T JaytechToolsStrykersolution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jaytech.tools.strykersolution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicroRdbms(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"micro.rdbms {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ImplemPleasantersetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"implem.pleasantersetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlstresscmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlstresscmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testprojsraines2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testprojsraines2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaxotekProductivity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maxotek.productivity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XpyNgswagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xpy.ngswagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ophitools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ophitools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JmgParsnip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jmg.parsnip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Iplust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iplust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JrpcmediatorTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jrpcmediator.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Warppackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"warppackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trnullable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trnullable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Smartsftp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartsftp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Resxtojson2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resxtojson2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TwodoSay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"twodo.say {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tasknet2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tasknet2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Json2record(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"json2record {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MystagingGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mystaging.gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mysqlquerydivider(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mysqlquerydivider {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gridscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gridscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tcpmux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tcpmux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShinnySsg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shinny_ssg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VertigisNugetscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vertigis.nugetscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scrub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scrub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkScreen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.screen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkGrep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.grep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JaytechToolsOasIndexgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jaytech.tools.oas.indexgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Typecart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typecart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TideKey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tide-key {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarketToolsStd2np(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"market.tools.std2np {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Weeknumber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"weeknumber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkIssueexporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.issueexporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Performanethelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"performanethelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kubeauth(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kubeauth {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SafeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"safe.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gengurka(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gengurka {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuModbus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.modbus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Voicetrigger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"voicetrigger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GaspraMergesprocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gaspra.mergesprocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Toolui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toolui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LogjointPlugintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"logjoint.plugintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LibRelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lib.release {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gclm3(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gclm3 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Easyfornettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easyfornettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkLogo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.logo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Protoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"protoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KgenRoslynviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kgen.roslynviewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testfiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testfiles {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testfips(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testfips {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Now(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"now {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KinetixToolsSqltestgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kinetix.tools.sqltestgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nuexporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuexporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyrecoilRelay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyrecoil.relay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kodax(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kodax {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReferenceswitcherTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"referenceswitcher.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkSinnn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.sinnn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trpiggy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trpiggy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Linuxtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linuxtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GsuuonToolGrab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gsuuon.tool.grab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeamodPackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meamod.packager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Translate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"translate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tsqllintpatched(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tsqllintpatched {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Touchgrass(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"touchgrass {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MbutilsKafkaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mbutils.kafka.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pulumigraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pulumigraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Snmpsender(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snmpsender {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Filetracker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filetracker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Llhtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"llhtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swaggertotypescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swaggertotypescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SuthepSupermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"suthep.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolFlysql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tool.flysql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ParkitectWorkshopUpload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"parkitect-workshop-upload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vk1Supermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vk1.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gfl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gfl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TocsoftMinikubeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tocsoft.minikube.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThaiNationalIdFormatValidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thai-national-id-format-validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TocsoftKubectlTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tocsoft.kubectl.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FpI18nTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fp-i18n-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Opinionatedusings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opinionatedusings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pulumischemaexplorer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pulumischemaexplorer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fork(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fork {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkFilelength(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.filelength {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EditPlantuml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"edit-plantuml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NatechMasstransitSwagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"natech.masstransit.swagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fzf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fzf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ServeSqlite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"serve-sqlite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TeamsTranscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"teams-transcript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Greeter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greeter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyrecoilHere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyrecoil.here {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkVideoserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.videoserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EvoscTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"evosc.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitlabreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlabreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyrecoilThere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyrecoil.there {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Json2env(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"json2env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}