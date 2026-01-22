using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command GmanCucumberCannery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gman.cucumber.cannery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SayedhaRouletteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sayedha.roulette.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DocxportnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docxportnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HaiCliProxys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hai.cli.proxys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sumnicli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sumnicli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetToolGist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tool-gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EliassenDocumentconverterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eliassen.documentconverter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pokedexcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pokedexcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Encodingconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"encodingconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swagger60core(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swagger-6.0core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LmondeilCliGremlin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lmondeil.cli.gremlin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command I574nDotnetInteractiveI574n(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"i574n.dotnet-interactive-i574n {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ndjson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ndjson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trwdog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trwdog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TooncoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tooncore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LoanrequestscachingContractsIntegrationevents(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"loanrequestscaching.contracts.integrationevents {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rubikcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rubikcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dnt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Passwordgeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passwordgeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomwareReleasy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomware.releasy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Youtubechannelidextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"youtubechannelidextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MusictopiaCreatewpfblazortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"musictopia.createwpfblazortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LimboCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"limbo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbtoentityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbtoentity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypeId(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"type-id {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Igloo15MqttserverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"igloo15.mqttserver.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Taskflowcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taskflowcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KxCodexConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kx.codex.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemaconsultingVswheretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demaconsulting.vswheretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KxToolxClicky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kx.toolx.clicky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TjololoToolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tjololo.tools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPurge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-purge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Versionincrementertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"versionincrementertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nanodu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nanodu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DihorRepofilesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dihor.repofiles.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SamuelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samuel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeziantouMoneizCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meziantou.moneiz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Majiangcal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"majiangcal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetcorepalCloudCliToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netcorepal.cloud.cli.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PomelocliHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pomelocli.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EarthmlExtensionsMapboxUploadcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"earthml.extensions.mapbox.uploadcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EventrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eventr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JdDomainCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jd.domain.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThiqahSaasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thiqah.saas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zyqcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zyqcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilmoonKeymanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"silmoon.keymanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Msworddiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msworddiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarleneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marlene.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotneterConsolepack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotneter.consolepack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSinglefilecsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-singlefilecsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WindowsCleanFiles(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"windows-clean-files {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command T3mmyvsaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"t3mmyvsa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRetire(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-retire {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LexWpfCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lex.wpf.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimplsharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simplsharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Spotyoink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spotyoink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Threadsposter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"threadsposter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShanescottSqlDataExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shanescott.sql-data-exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsipkaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsipka.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetParseidon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-parseidon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JsoncheckCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsoncheck-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Libcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"libcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Quickdiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quickdiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonPsmstatistics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.psmstatistics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGcstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gcstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wolclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wolclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LmondeilCliGeneratefromopenapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lmondeil.cli.generatefromopenapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dyes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dyes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MateralToolsCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"materal.tools.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitopsUpdaterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitops.updater.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetImgup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-imgup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"db-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LmondeilCliSlndoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lmondeil.cli.slndoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFullgc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-fullgc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FymCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fym.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Modshardpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modshardpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WatchsassTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"watchsass.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TRex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"t-rex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetJwk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-jwk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Treegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"treegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharplings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharplings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetResources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-resources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoDevserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.devserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Protoflex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"protoflex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSimpleSln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-simple-sln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNewProject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-new-project {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Efcoretsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"efcoretsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KagekirinXmlformatTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kagekirin.xmlformat.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GgcEndecrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ggc_endecrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TessesTimelapsepack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tesses.timelapsepack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EntitydbNpgsqlProvisioner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entitydb.npgsql.provisioner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonPeptidespectrummatching(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.peptidespectrummatching {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qacoverreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qacoverreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReleaseNotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"release-notes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatatablesGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datatables.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDebNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-deb-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}