using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T GmanCucumberCannery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gman.cucumber.cannery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SayedhaRouletteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sayedha.roulette.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DocxportnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docxportnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HaiCliProxys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hai.cli.proxys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sumnicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sumnicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetToolGist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tool-gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EliassenDocumentconverterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eliassen.documentconverter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pokedexcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pokedexcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Encodingconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"encodingconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swagger60core(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swagger-6.0core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LmondeilCliGremlin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lmondeil.cli.gremlin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T I574nDotnetInteractiveI574n(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"i574n.dotnet-interactive-i574n {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ndjson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ndjson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trwdog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trwdog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TooncoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tooncore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LoanrequestscachingContractsIntegrationevents(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"loanrequestscaching.contracts.integrationevents {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rubikcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rubikcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dnt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Passwordgeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passwordgeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomwareReleasy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomware.releasy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Youtubechannelidextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"youtubechannelidextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MusictopiaCreatewpfblazortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"musictopia.createwpfblazortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LimboCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"limbo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbtoentityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbtoentity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypeId(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"type-id {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Igloo15MqttserverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"igloo15.mqttserver.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Taskflowcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taskflowcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KxCodexConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kx.codex.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemaconsultingVswheretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demaconsulting.vswheretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KxToolxClicky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kx.toolx.clicky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TjololoToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tjololo.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPurge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-purge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Versionincrementertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versionincrementertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nanodu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nanodu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DihorRepofilesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dihor.repofiles.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SamuelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samuel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeziantouMoneizCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meziantou.moneiz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Majiangcal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"majiangcal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetcorepalCloudCliToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netcorepal.cloud.cli.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PomelocliHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pomelocli.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EarthmlExtensionsMapboxUploadcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"earthml.extensions.mapbox.uploadcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EventrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eventr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JdDomainCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jd.domain.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThiqahSaasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thiqah.saas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zyqcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zyqcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilmoonKeymanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"silmoon.keymanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Msworddiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msworddiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarleneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marlene.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotneterConsolepack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotneter.consolepack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSinglefilecsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-singlefilecsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WindowsCleanFiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"windows-clean-files {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T T3mmyvsaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"t3mmyvsa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRetire(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-retire {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LexWpfCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lex.wpf.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimplsharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simplsharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Spotyoink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spotyoink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Threadsposter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"threadsposter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShanescottSqlDataExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shanescott.sql-data-exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsipkaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsipka.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetParseidon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-parseidon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JsoncheckCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsoncheck-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Libcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"libcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Quickdiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quickdiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonPsmstatistics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.psmstatistics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGcstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gcstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wolclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wolclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LmondeilCliGeneratefromopenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lmondeil.cli.generatefromopenapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dyes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dyes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MateralToolsCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"materal.tools.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitopsUpdaterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitops.updater.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetImgup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-imgup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"db-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LmondeilCliSlndoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lmondeil.cli.slndoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFullgc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-fullgc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FymCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fym.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Modshardpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modshardpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WatchsassTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"watchsass.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TRex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"t-rex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetJwk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-jwk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Treegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"treegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharplings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharplings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetResources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-resources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoDevserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.devserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Protoflex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"protoflex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSimpleSln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-simple-sln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNewProject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-new-project {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Efcoretsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"efcoretsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KagekirinXmlformatTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kagekirin.xmlformat.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GgcEndecrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ggc_endecrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TessesTimelapsepack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tesses.timelapsepack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EntitydbNpgsqlProvisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entitydb.npgsql.provisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonPeptidespectrummatching(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.peptidespectrummatching {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qacoverreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qacoverreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReleaseNotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"release-notes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatatablesGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datatables.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDebNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-deb-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}