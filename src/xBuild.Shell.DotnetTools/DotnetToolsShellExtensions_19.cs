using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command FskaggleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fskaggle.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetmddocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetmddocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsSbom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.sbom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatamoleCommonsEventhubexplorer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datamole.commons.eventhubexplorer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YatterNetToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yatter.net.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Helveg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"helveg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testwatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testwatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Meissa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meissa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDartlicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dartlicense {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trgenvsc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trgenvsc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdgenswagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdgenswagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThirdpartylibrariesGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thirdpartylibraries.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe11netixquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe11netixquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsTestprojectdetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.testprojectdetector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Heartbeat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"heartbeat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsCatalogupload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.catalogupload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCliJdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cli-jdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTrx2sonarUpdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-trx2sonar-updated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cosmic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cosmic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsNugettoggleonbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugettoggleonbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LangchainCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"langchain.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctopusOctonotesGithubupdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octopus.octonotes.githubupdater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kapitan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kapitan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsNugetpackageconfigdetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetpackageconfigdetector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trrup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trrup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusOfficedocumentzipper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.officedocumentzipper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bdna(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bdna {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Weta(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"weta {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDbinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dbinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitSyncCreationDate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-sync-creation-date {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dnf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pm1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pm1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Crudify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"crudify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packageupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packageupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command C4scli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"c4scli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EfseedCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"efseed.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kanyon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kanyon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VaerktojerProjectpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vaerktojer.projectpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InterceptionGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"interception.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWikiexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-wikiexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KahunaControl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kahuna.control {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe11netixslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe11netixslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Greet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"greet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDlla(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dlla {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lazorm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lazorm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsSubutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.subutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Steamfetch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"steamfetch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Taloscore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taloscore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PsdoframeworkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"psdoframework.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NoetictoolsGit2semverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"noetictools.git2semver.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Djamal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"djamal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbupCli2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbup-cli-2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Godottool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"godottool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGcr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gcr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kamino(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kamino {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cogs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cogs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Migrondi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"migrondi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TmreflexionmodelerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tmreflexionmodeler.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsont(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsont {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetChromium(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-chromium {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jwtcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jwtcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotbook(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotbook {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mason(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mason {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nyancat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nyancat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KapitanResourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kapitan.resourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CwlGalaxyParser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cwl-galaxy-parser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlopsNetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlops.net.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Varsub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"varsub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ImportToolIngestion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"import.tool.ingestion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saileshpfxtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saileshpfxtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dgraph4netTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dgraph4net.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trmove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trmove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dockercaptain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dockercaptain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Healthnerd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"healthnerd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nupu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nupu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KonfidenceProjectReferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"konfidence.project-references {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VostokSnoopdog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vostok.snoopdog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitversioningGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitversioning-github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MstestxConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mstestx.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsMediautil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.mediautil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pwshext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pwshext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devbuddy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devbuddy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbmtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbmtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetmetricsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetmetrics.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ipcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ipcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Removeobj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"removeobj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"line.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KanyonResourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kanyon.resourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsSyntaxer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cs-syntaxer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dtree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dtree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xroot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xroot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cqsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cqsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openf1Console(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openf1-console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trull(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trull {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsDataminerdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.dataminerdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Runfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TrxToVsplaylist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trx-to-vsplaylist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlinthScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plinth.scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}