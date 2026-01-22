using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Sha(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sha {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RepoVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"repo-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hawks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hawks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trsort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trsort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuIds4server(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.ids4server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WuganhaoGitmirror(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wuganhao.gitmirror {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitlucky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlucky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trungroup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trungroup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trclonereplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trclonereplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SourGherkin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sour.gherkin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XperienceXman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xperience.xman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuExceptions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.exceptions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Leetsharptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"leetsharptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkSnippet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.snippet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trfold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trfold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Paketlocalupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"paketlocalupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Parsisiust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"parsisiust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JaytechToolsOasOperationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jaytech.tools.oas.operationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitYamlSkyrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.yaml.skyrim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nibbler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nibbler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Onemastertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"onemastertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitYamlStarfield(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.yaml.starfield {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SingleExe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"single-exe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openjdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openjdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fileopentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fileopentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SiganbergSqlgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"siganberg.sqlgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HandymanOutdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"handyman-outdated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HydeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hyde.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Octonav(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octonav {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitJsonSkyrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.json.skyrim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scaffer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scaffer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qnode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qnode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsonv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsonv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitYamlOblivion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.yaml.oblivion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitJsonOblivion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.json.oblivion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitJsonStarfield(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.json.starfield {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Score(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"score {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trformat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trformat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kronoweave(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kronoweave {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sdashkovskyi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sdashkovskyi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ftpfileupload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ftpfileupload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LivesharpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"livesharp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitYamlFallout4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.yaml.fallout4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsontoenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsontoenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ObsidianMapperTrx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"obsidian-mapper-trx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToPath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"to-path {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Replaceinfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"replaceinfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vali(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vali {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpriggitJsonFallout4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spriggit.json.fallout4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Potion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"potion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Elevationapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elevationapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FhirTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fhir-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaxotekProjectreferenceswitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maxotek.projectreferenceswitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hellotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hellotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sdashkovskyi5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sdashkovskyi5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kopi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kopi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lazy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lazy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trgen2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trgen2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElmishLand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elmish-land {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rftool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rftool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetmirror(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetmirror {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WolfFusionSwitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wolf.fusion.switcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pinemigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pinemigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitpullrequest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitpullrequest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Squeal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"squeal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LdfcoreGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ldfcore.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LikvidoKubesec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"likvido.kubesec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ubik(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ubik {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KenticoXperienceManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kentico.xperience.manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PythonnetstubgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pythonnetstubgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Staticpagegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"staticpagegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlbrowser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlbrowser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProjectGraphTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"project.graph.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"r-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KebooResxsorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"keboo.resxsorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projectstatus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectstatus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Grepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grepl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trmvsr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trmvsr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitGet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-get {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubselfrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubselfrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkWindowsservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.windowsservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnityproxyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unityproxy.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RefreshTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"refresh.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KrittikornMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"krittikorn.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uplifttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uplifttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Migtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"migtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Infersharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"infersharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaitentoShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maitento.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MbutilsKafkaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mbutils.kafka.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Parkitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"parkitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrpcInit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grpc-init {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Treetype(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"treetype {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xsd2fsharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xsd2fsharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RendlelabsNukefromorbit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rendlelabs.nukefromorbit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}