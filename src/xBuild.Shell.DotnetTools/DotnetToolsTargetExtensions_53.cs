using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Darlek(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"darlek {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devopsai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devopsai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevicetoolWfwattch2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devicetool.wfwattch2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsefTouch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsef-touch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetprojectstarter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetprojectstarter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetwhois(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetwhois {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetLink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-link {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetsetupprojectstructure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetsetupprojectstructure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Diskusage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"diskusage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeltanullsMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deltanulls.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeveloperToolsMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"developer-tools-mcp-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotviz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotviz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependenciesscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependenciesscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetShift(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-shift {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Refdocgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"refdocgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Databrute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"databrute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dongsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dongsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWikitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-wikitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemoSs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demo_ss {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevimplementsSlnxgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devimplements.slnxgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetExtractunitypackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-extractunitypackage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOpen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-open {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HardwareinfoDiskTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hardwareinfo.disk.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DibrunnerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dibrunner.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dib2html(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dib2html {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevicetoolSensoromron(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devicetool.sensoromron {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nanoff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nanoff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetLicensesReporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-licenses-reporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetExcelFlow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-excel-flow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependencyupdatedtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependencyupdatedtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Finddupes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"finddupes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSemanticRelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-semantic-release {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dyshowdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dyshowdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeadowDebugsolsources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meadow.debugsolsources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetnugetdevstarter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetnugetdevstarter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SuiDbsResponseLoggerWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sui.dbs.response.logger.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkIssuedownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.issuedownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ddk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ddk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotlocz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotlocz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LoxsmokeMddox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"loxsmoke.mddox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XdxdDotnetPostgresPocoGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xdxd-dotnet-postgres-poco-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jdshowdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jdshowdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Minimig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minimig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFsns(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-fsns {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkDotnetupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.dotnetupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSetSemverVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-set-semver-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWaffleSevann(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-waffle-sevann {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Warpdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"warpdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dirtree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dirtree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Databaseshrinker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"databaseshrinker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWaffleRaulmor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-waffle-raulmor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsefHosts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsef-hosts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DiscorcaPythonPackageMaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"discorca-python-package-maker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRpmPack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-rpm-pack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlyngMonorepoDependencymanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slyng.monorepo.dependencymanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMultirepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-multirepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dongpu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dongpu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HandymanDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"handyman-docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dnp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetZx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-zx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTimestamp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-timestamp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WoodmanDkgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"woodman.dkgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrimerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-trimerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkDotnetformat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.dotnetformat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependamaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependamaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MbwToolsRabbitdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mbw.tools.rabbitdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevelopertoolsMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"developertools.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMagic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-magic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkFolderdownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.folderdownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetweathertopjsonreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetweathertopjsonreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkDotnetproject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.dotnetproject {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkDecompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.decompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetsparkToolsDeepreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netspark.tools.deepreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LsifDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lsif-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FusedigitalPdfsnip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fusedigital.pdfsnip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JaytechToolsDotnetOperationgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jaytech.tools.dotnet.operationgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DspEnv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dsp-env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XdxdDotnetPocoGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xdxd-dotnet-poco-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetdocgenRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netdocgen.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SparkdevnetworkRockDevtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sparkdevnetwork.rock.devtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpDataverseStdio(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.dataverse.stdio {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SoloDacpactool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solo.dacpactool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mapdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mapdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TenogyToolsFluentmigratorUpdatedatabase(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tenogy.tools.fluentmigrator.updatedatabase {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetconf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetconf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LogicsoftwareEasyprojectsDatabasemanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"logicsoftware.easyprojects.databasemanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Daffect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"daffect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkMysqldump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.mysqldump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HwDotnettools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hw.dotnettools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkDotspace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.dotspace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Flightdeck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flightdeck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KuinoxNupkgdeterministicator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kuinox.nupkgdeterministicator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IsnesDynamicsIntegrationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"isnes.dynamics.integration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Meg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ErikejDacfxDacdeployskip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"erikej.dacfx.dacdeployskip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KronoweaveDatabase(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kronoweave.database {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}