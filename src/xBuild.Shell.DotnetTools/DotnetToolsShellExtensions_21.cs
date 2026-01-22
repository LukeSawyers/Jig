using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command GooiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gooi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEvergreen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-evergreen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SummerdawnMcpifierServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"summerdawn.mcpifier.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazorpathhelperMigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorpathhelper.migration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PgNetGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pg-net-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GtCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharpsyntaxvalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpsyntaxvalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DwcaCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dwca-codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharpminifierconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpminifierconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThinkinghomeMigratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thinkinghome.migrator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StleganographerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stleganographer.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Copyconf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"copyconf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sizoscopex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sizoscopex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GoogleCloudToolsSbomgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"google.cloud.tools.sbomgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Typecontractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typecontractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PipeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pipe-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnbreakableToolsPolicyreportNetcore31(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unbreakable.tools.policyreport.netcore31 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Domino(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"domino {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Passwordgencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passwordgencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tdlive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tdlive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatawfWebserviceGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datawf.webservice.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SelfdeployCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"selfdeploy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KuinoxCsharpscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kuinox.csharpscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xnotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xnotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Flashplanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flashplanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dynamodbtolitedb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dynamodbtolitedb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wrm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wrm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zdm3(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zdm3 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHtmlpackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-htmlpackager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-eg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SayedhaTemplateCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sayedha.template.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CassandraMigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cassandra-migrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetwhere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetwhere {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webconnectionwebserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webconnectionwebserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPfpak(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pfpak {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOpenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-openapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsoncsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsoncsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrpcCurl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grpc-curl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Linq2graphqlGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linq2graphql.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsSkychdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.skychdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevdeerToolsTocpm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devdeer.tools.tocpm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WalgelijkFontgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"walgelijk.fontgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SparkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spark.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetExtract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-extract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mysocials(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mysocials {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NovaloopUpdatetag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"novaloop.updatetag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnclassifiedDotnetsshdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unclassified.dotnetsshdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GodeltechCodereviewDataimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"godeltech.codereview.dataimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeoTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neo.trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swagger2jsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swagger2js_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPackLocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pack-local {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Efmigrationssquash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"efmigrationssquash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Barber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"barber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SecurestoreClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"securestore.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConvertjsontogherkinexampletableCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"convertjsontogherkinexampletable.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetthx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetthx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BackupMaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"backup_maker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IcSched(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ic.sched {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Registerbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"registerbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ValleysoftDredge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"valleysoft.dredge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sidecarcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sidecarcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VisorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"visor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jerry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jerry {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DirectoryWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"directory.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mdbatlas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mdbatlas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Toolupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toolupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netproxycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netproxycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pywinrt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pywinrt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IronschemeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ironscheme.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevtoDotnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devto-dotnetcore-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Js2il(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"js2il {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DockerWatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docker-watch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEventgrid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-eventgrid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VitorioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vitorio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PdftocextractorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pdftocextractor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DnfIis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnf-iis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Undercutf1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"undercutf1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Djamalnew(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"djamalnew {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlscripter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlscripter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MitoToolsJavutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mito.tools.javutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeohashPolyhasherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geohash.polyhasher.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tailwind(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tailwind {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command What3passwords(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"what3passwords {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RnCrontool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rn.crontool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FinlegalLibsassbuilderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"finlegal.libsassbuilder-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Base64urls(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"base64urls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoxposerRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moxposer.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StrangesoftDotnetinstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"strangesoft.dotnetinstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatalinqCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datalinq.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cqrstemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cqrstemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimilaritycsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"similaritycsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Whereintheworld(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"whereintheworld {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WebConfigTransformTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"web.config.transform.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctopusConfigExporterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octopus.config.exporter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatleCryptographyTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatle.cryptography.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ssinmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ssinmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Feersum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"feersum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}