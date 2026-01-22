using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Darlek(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"darlek {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devopsai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devopsai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevicetoolWfwattch2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devicetool.wfwattch2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsefTouch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsef-touch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetprojectstarter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetprojectstarter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetwhois(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetwhois {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetLink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-link {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetsetupprojectstructure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetsetupprojectstructure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Diskusage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"diskusage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeltanullsMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deltanulls.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeveloperToolsMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"developer-tools-mcp-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotviz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotviz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependenciesscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependenciesscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetShift(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-shift {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Refdocgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"refdocgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Databrute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"databrute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dongsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dongsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWikitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-wikitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemoSs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demo_ss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevimplementsSlnxgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devimplements.slnxgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetExtractunitypackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-extractunitypackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOpen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-open {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HardwareinfoDiskTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hardwareinfo.disk.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DibrunnerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dibrunner.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dib2html(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dib2html {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevicetoolSensoromron(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devicetool.sensoromron {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nanoff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nanoff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetLicensesReporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-licenses-reporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetExcelFlow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-excel-flow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependencyupdatedtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependencyupdatedtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Finddupes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"finddupes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSemanticRelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-semantic-release {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dyshowdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dyshowdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeadowDebugsolsources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meadow.debugsolsources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetnugetdevstarter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetnugetdevstarter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SuiDbsResponseLoggerWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sui.dbs.response.logger.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkIssuedownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.issuedownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ddk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ddk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotlocz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotlocz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LoxsmokeMddox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"loxsmoke.mddox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XdxdDotnetPostgresPocoGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xdxd-dotnet-postgres-poco-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jdshowdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jdshowdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Minimig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minimig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFsns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-fsns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkDotnetupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.dotnetupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSetSemverVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-set-semver-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWaffleSevann(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-waffle-sevann {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Warpdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"warpdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dirtree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dirtree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Databaseshrinker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"databaseshrinker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWaffleRaulmor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-waffle-raulmor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsefHosts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsef-hosts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DiscorcaPythonPackageMaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"discorca-python-package-maker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRpmPack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-rpm-pack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlyngMonorepoDependencymanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slyng.monorepo.dependencymanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMultirepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-multirepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dongpu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dongpu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HandymanDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"handyman-docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dnp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetZx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-zx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTimestamp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-timestamp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WoodmanDkgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"woodman.dkgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTrimerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-trimerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkDotnetformat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.dotnetformat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependamaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependamaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MbwToolsRabbitdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mbw.tools.rabbitdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevelopertoolsMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"developertools.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMagic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-magic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkFolderdownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.folderdownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetweathertopjsonreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetweathertopjsonreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkDotnetproject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.dotnetproject {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkDecompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.decompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetsparkToolsDeepreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netspark.tools.deepreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LsifDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lsif-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FusedigitalPdfsnip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fusedigital.pdfsnip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JaytechToolsDotnetOperationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jaytech.tools.dotnet.operationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DspEnv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dsp-env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XdxdDotnetPocoGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xdxd-dotnet-poco-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetdocgenRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netdocgen.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SparkdevnetworkRockDevtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sparkdevnetwork.rock.devtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpDataverseStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.dataverse.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SoloDacpactool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solo.dacpactool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mapdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mapdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TenogyToolsFluentmigratorUpdatedatabase(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tenogy.tools.fluentmigrator.updatedatabase {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetconf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetconf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LogicsoftwareEasyprojectsDatabasemanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"logicsoftware.easyprojects.databasemanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Daffect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"daffect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkMysqldump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.mysqldump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HwDotnettools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hw.dotnettools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkDotspace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.dotspace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Flightdeck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flightdeck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KuinoxNupkgdeterministicator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kuinox.nupkgdeterministicator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IsnesDynamicsIntegrationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"isnes.dynamics.integration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Meg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ErikejDacfxDacdeployskip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"erikej.dacfx.dacdeployskip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KronoweaveDatabase(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kronoweave.database {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}