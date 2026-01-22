using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Sha(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sha {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RepoVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"repo-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hawks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hawks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trsort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trsort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuIds4server(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.ids4server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WuganhaoGitmirror(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wuganhao.gitmirror {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitlucky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlucky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trungroup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trungroup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trclonereplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trclonereplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SourGherkin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sour.gherkin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XperienceXman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xperience.xman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuExceptions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.exceptions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Leetsharptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"leetsharptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkSnippet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.snippet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trfold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trfold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Paketlocalupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"paketlocalupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Parsisiust(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"parsisiust {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JaytechToolsOasOperationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jaytech.tools.oas.operationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitYamlSkyrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.yaml.skyrim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nibbler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nibbler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Onemastertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"onemastertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitYamlStarfield(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.yaml.starfield {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SingleExe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"single-exe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openjdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openjdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fileopentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fileopentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SiganbergSqlgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"siganberg.sqlgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HandymanOutdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"handyman-outdated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HydeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hyde.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Octonav(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octonav {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitJsonSkyrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.json.skyrim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scaffer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scaffer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qnode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qnode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsonv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsonv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitYamlOblivion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.yaml.oblivion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitJsonOblivion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.json.oblivion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitJsonStarfield(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.json.starfield {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Score(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"score {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trformat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trformat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kronoweave(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kronoweave {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sdashkovskyi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sdashkovskyi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ftpfileupload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ftpfileupload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LivesharpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"livesharp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitYamlFallout4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.yaml.fallout4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsontoenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsontoenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ObsidianMapperTrx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"obsidian-mapper-trx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToPath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"to-path {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Replaceinfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"replaceinfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vali(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vali {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpriggitJsonFallout4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spriggit.json.fallout4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Potion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"potion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Elevationapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elevationapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FhirTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fhir-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaxotekProjectreferenceswitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maxotek.projectreferenceswitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hellotool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hellotool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sdashkovskyi5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sdashkovskyi5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kopi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kopi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lazy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lazy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trgen2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trgen2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElmishLand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elmish-land {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rftool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rftool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetmirror(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetmirror {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WolfFusionSwitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wolf.fusion.switcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pinemigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pinemigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitpullrequest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitpullrequest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Squeal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"squeal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LdfcoreGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ldfcore.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LikvidoKubesec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"likvido.kubesec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ubik(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ubik {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KenticoXperienceManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kentico.xperience.manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PythonnetstubgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pythonnetstubgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Staticpagegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"staticpagegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fasm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fasm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlbrowser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlbrowser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProjectGraphTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"project.graph.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"r-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KebooResxsorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"keboo.resxsorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projectstatus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectstatus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Grepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grepl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trmvsr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trmvsr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitGet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-get {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubselfrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubselfrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkWindowsservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.windowsservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnityproxyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unityproxy.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RefreshTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"refresh.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KrittikornMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"krittikorn.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uplifttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uplifttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Migtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"migtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Infersharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"infersharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaitentoShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maitento.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MbutilsKafkaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mbutils.kafka.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Parkitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"parkitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrpcInit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grpc-init {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Treetype(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"treetype {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xsd2fsharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xsd2fsharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RendlelabsNukefromorbit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rendlelabs.nukefromorbit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}