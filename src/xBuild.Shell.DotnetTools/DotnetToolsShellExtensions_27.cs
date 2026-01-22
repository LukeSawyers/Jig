using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Traefikpreconfiguratorwindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"traefikpreconfiguratorwindows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BaldsolutionsElasticsearcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"baldsolutions.elasticsearcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cli4fody(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cli4fody {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Foreachshell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"foreachshell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitworkingtime(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitworkingtime {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Net2puml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"net2puml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Eticat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eticat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mkncomprobar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mkncomprobar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Piholecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"piholecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Guidgeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"guidgeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomstoolboxNugetdefrog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomstoolbox.nugetdefrog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NbomberConverterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nbomber.converter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CtyarEfContrib(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ctyar.ef-contrib {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VerticalCsdependencies(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vertical-csdependencies {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RoomsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"roomsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YdkFscat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ydk.fscat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBookmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-bookmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetxslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetxslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlunderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blunder.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsGithubsecretupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.githubsecretupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsJenkinsmaintenance(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.jenkinsmaintenance {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Razorscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"razorscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Centralconfiggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"centralconfiggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MinimaGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minima.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotmortenNullabilitystats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotmorten.nullabilitystats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mycalendar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mycalendar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Split2folders(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"split2folders {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Checklogsin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"checklogsin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SableCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sable.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xnugetuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xnugetuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Obfy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"obfy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsequal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsequal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Exportkindleclippingstonotion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"exportkindleclippingstonotion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FynyddSqlpkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fynydd.sqlpkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsUncfilecopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.uncfilecopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command U(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"u {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testdashboard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testdashboard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Springscrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"springscrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EfMigrationRuntimeSchema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ef-migration-runtime-schema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xrunwait(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xrunwait {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solutionsetuptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solutionsetuptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sendemailcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sendemailcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Contentsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"contentsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Papa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"papa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sometypesconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sometypesconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DanskeCurrencyExchangePovilas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"danske_currency_exchange_povilas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CognitoOidc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cognito-oidc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetLocbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-locbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoaidhathotTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moaidhathot.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bookmarkr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bookmarkr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetInitadamtki(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-initadamtki {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deepuriderlib(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deepuriderlib {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lang(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lang {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Moaidhathot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moaidhathot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Firetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"firetest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Crono32(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"crono32 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xuser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xuser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JajvDotnetWaffle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jajv_dotnet_waffle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Servicegeneratorwebbilir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"servicegeneratorwebbilir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Redline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"redline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharpoogle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpoogle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trbutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trbutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StaticImport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"static-import {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Readmesync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"readmesync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Commitsense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"commitsense {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetpackagesmigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetpackagesmigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docx2oc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docx2oc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GoblinfactoryJsonquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"goblinfactory.jsonquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Etwforcegc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"etwforcegc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xmlcommentchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xmlcommentchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShanescottSqlExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shanescott.sql-exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Itauofxcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"itauofxcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IsaachealthStrawberryshakeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"isaachealth.strawberryshake.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevPassword(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dev-password {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BetalgoBlueflowChopper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"betalgo.blueflow.chopper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodexTokens(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codex-tokens {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SquaduckCsharpmatrix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"squaduck.csharpmatrix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fmname(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fmname {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IpsloggerV1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ipslogger.v1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Extlauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"extlauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DercodeottoCslspmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dercodeotto.cslspmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EzdbschemaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ezdbschema.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyfsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyfs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mapperdm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mapperdm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetD1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-d1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ViscachaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"viscacha.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OmniaDockerfilegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"omnia.dockerfilegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TimestamperTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timestamper.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LinktspCoremoduleCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linktsp.coremodule.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Commandgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"commandgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetsparkToolsDumpconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netspark.tools.dumpconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IvyToolsCapturewindow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ivy.tools.capturewindow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cnblog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cnblog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FranktoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"franktools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CiciCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cici.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsBookutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.bookutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Illinois(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"illinois {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HolisticwareSlnTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"holisticware.sln-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EricDotnetClassConstructor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eric.dotnet.class.constructor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}