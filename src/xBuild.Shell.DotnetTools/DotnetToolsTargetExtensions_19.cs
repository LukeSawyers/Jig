using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T FskaggleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fskaggle.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetmddocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetmddocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsSbom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.sbom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatamoleCommonsEventhubexplorer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datamole.commons.eventhubexplorer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YatterNetToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yatter.net.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Helveg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"helveg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testwatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testwatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Meissa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meissa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDartlicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dartlicense {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trgenvsc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trgenvsc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdgenswagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdgenswagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThirdpartylibrariesGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thirdpartylibraries.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe11netixquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe11netixquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsTestprojectdetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.testprojectdetector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Heartbeat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"heartbeat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsCatalogupload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.catalogupload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCliJdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cli-jdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrx2sonarUpdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-trx2sonar-updated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cosmic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cosmic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsNugettoggleonbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugettoggleonbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LangchainCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"langchain.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctopusOctonotesGithubupdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octopus.octonotes.githubupdater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kapitan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kapitan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsNugetpackageconfigdetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetpackageconfigdetector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trrup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trrup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusOfficedocumentzipper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.officedocumentzipper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bdna(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bdna {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Weta(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"weta {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDbinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dbinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitSyncCreationDate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-sync-creation-date {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dnf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pm1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pm1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Crudify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"crudify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packageupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packageupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T C4scli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"c4scli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EfseedCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"efseed.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kanyon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kanyon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VaerktojerProjectpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vaerktojer.projectpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InterceptionGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"interception.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWikiexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-wikiexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KahunaControl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kahuna.control {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe11netixslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe11netixslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Greet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDlla(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dlla {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lazorm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lazorm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsSubutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.subutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Steamfetch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"steamfetch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Taloscore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taloscore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PsdoframeworkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"psdoframework.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NoetictoolsGit2semverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"noetictools.git2semver.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Djamal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"djamal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbupCli2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbup-cli-2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Godottool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"godottool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGcr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gcr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kamino(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kamino {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cogs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cogs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Migrondi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"migrondi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TmreflexionmodelerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tmreflexionmodeler.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsont(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsont {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetChromium(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-chromium {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jwtcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jwtcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotbook(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotbook {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mason(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mason {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nyancat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nyancat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KapitanResourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kapitan.resourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CwlGalaxyParser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cwl-galaxy-parser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlopsNetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlops.net.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Varsub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"varsub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ImportToolIngestion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"import.tool.ingestion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saileshpfxtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saileshpfxtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dgraph4netTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dgraph4net.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trmove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trmove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dockercaptain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dockercaptain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Healthnerd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"healthnerd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nupu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nupu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KonfidenceProjectReferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"konfidence.project-references {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VostokSnoopdog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vostok.snoopdog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitversioningGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitversioning-github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MstestxConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mstestx.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsMediautil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.mediautil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pwshext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pwshext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devbuddy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devbuddy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbmtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbmtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetmetricsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetmetrics.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ipcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ipcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Removeobj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"removeobj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"line.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KanyonResourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kanyon.resourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsSyntaxer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cs-syntaxer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dtree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dtree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xroot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xroot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cqsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cqsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openf1Console(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openf1-console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trull(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trull {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsDataminerdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.dataminerdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Runfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TrxToVsplaylist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trx-to-vsplaylist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlinthScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plinth.scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}