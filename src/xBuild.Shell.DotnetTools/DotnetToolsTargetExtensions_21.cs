using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T GooiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gooi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEvergreen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-evergreen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SummerdawnMcpifierServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"summerdawn.mcpifier.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazorpathhelperMigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorpathhelper.migration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PgNetGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pg-net-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GtCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharpsyntaxvalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpsyntaxvalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DwcaCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dwca-codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharpminifierconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpminifierconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThinkinghomeMigratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thinkinghome.migrator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StleganographerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stleganographer.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Copyconf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"copyconf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sizoscopex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sizoscopex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GoogleCloudToolsSbomgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"google.cloud.tools.sbomgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Typecontractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typecontractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PipeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pipe-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnbreakableToolsPolicyreportNetcore31(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unbreakable.tools.policyreport.netcore31 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Domino(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"domino {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Passwordgencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passwordgencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tdlive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tdlive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatawfWebserviceGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datawf.webservice.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SelfdeployCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"selfdeploy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KuinoxCsharpscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kuinox.csharpscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xnotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xnotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Flashplanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flashplanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dynamodbtolitedb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dynamodbtolitedb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wrm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wrm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zdm3(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zdm3 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHtmlpackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-htmlpackager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-eg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SayedhaTemplateCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sayedha.template.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CassandraMigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cassandra-migrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetwhere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetwhere {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webconnectionwebserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webconnectionwebserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPfpak(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pfpak {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOpenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-openapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsoncsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsoncsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrpcCurl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grpc-curl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Linq2graphqlGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linq2graphql.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsSkychdownloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.skychdownloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevdeerToolsTocpm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devdeer.tools.tocpm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WalgelijkFontgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"walgelijk.fontgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SparkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spark.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetExtract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-extract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mysocials(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mysocials {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NovaloopUpdatetag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"novaloop.updatetag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnclassifiedDotnetsshdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unclassified.dotnetsshdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GodeltechCodereviewDataimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"godeltech.codereview.dataimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeoTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neo.trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swagger2jsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swagger2js_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPackLocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pack-local {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Efmigrationssquash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"efmigrationssquash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Barber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"barber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SecurestoreClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"securestore.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConvertjsontogherkinexampletableCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"convertjsontogherkinexampletable.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetthx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetthx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BackupMaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"backup_maker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IcSched(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ic.sched {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Registerbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"registerbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ValleysoftDredge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"valleysoft.dredge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sidecarcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sidecarcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VisorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"visor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jerry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jerry {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DirectoryWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"directory.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mdbatlas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mdbatlas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Toolupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toolupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netproxycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netproxycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pywinrt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pywinrt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IronschemeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ironscheme.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevtoDotnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devto-dotnetcore-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Js2il(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"js2il {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DockerWatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docker-watch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEventgrid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-eventgrid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VitorioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vitorio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PdftocextractorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pdftocextractor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DnfIis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnf-iis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Undercutf1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"undercutf1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Djamalnew(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"djamalnew {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlscripter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlscripter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MitoToolsJavutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mito.tools.javutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeohashPolyhasherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geohash.polyhasher.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tailwind(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tailwind {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T What3passwords(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"what3passwords {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RnCrontool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rn.crontool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FinlegalLibsassbuilderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"finlegal.libsassbuilder-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Base64urls(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"base64urls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoxposerRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moxposer.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StrangesoftDotnetinstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"strangesoft.dotnetinstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatalinqCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datalinq.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cqrstemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cqrstemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimilaritycsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"similaritycsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Whereintheworld(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"whereintheworld {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WebConfigTransformTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"web.config.transform.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctopusConfigExporterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octopus.config.exporter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatleCryptographyTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatle.cryptography.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ssinmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ssinmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Feersum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"feersum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}