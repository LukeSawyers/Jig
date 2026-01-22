using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Traefikpreconfiguratorwindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"traefikpreconfiguratorwindows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BaldsolutionsElasticsearcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"baldsolutions.elasticsearcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cli4fody(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cli4fody {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Foreachshell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"foreachshell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitworkingtime(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitworkingtime {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Net2puml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"net2puml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Eticat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eticat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mkncomprobar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mkncomprobar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Piholecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"piholecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Guidgeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"guidgeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomstoolboxNugetdefrog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomstoolbox.nugetdefrog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NbomberConverterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nbomber.converter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CtyarEfContrib(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ctyar.ef-contrib {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VerticalCsdependencies(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vertical-csdependencies {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RoomsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"roomsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YdkFscat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ydk.fscat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBookmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-bookmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetxslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetxslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlunderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blunder.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsGithubsecretupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.githubsecretupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsJenkinsmaintenance(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.jenkinsmaintenance {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Razorscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"razorscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Centralconfiggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"centralconfiggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MinimaGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minima.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotmortenNullabilitystats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotmorten.nullabilitystats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mycalendar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mycalendar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Split2folders(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"split2folders {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Checklogsin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"checklogsin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SableCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sable.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xnugetuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xnugetuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Obfy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"obfy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsequal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsequal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Exportkindleclippingstonotion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"exportkindleclippingstonotion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FynyddSqlpkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fynydd.sqlpkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsUncfilecopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.uncfilecopy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T U(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"u {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testdashboard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testdashboard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Springscrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"springscrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EfMigrationRuntimeSchema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ef-migration-runtime-schema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xrunwait(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xrunwait {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solutionsetuptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solutionsetuptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sendemailcore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sendemailcore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Contentsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"contentsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Papa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"papa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sometypesconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sometypesconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DanskeCurrencyExchangePovilas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"danske_currency_exchange_povilas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CognitoOidc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cognito-oidc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetLocbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-locbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoaidhathotTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moaidhathot.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bookmarkr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bookmarkr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetInitadamtki(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-initadamtki {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deepuriderlib(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deepuriderlib {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lang(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lang {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Moaidhathot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moaidhathot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Firetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"firetest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Crono32(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"crono32 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xuser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xuser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JajvDotnetWaffle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jajv_dotnet_waffle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Servicegeneratorwebbilir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"servicegeneratorwebbilir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Redline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"redline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharpoogle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpoogle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trbutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trbutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StaticImport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"static-import {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Readmesync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"readmesync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Commitsense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"commitsense {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetpackagesmigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetpackagesmigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docx2oc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docx2oc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GoblinfactoryJsonquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"goblinfactory.jsonquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Etwforcegc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"etwforcegc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xmlcommentchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xmlcommentchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShanescottSqlExporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shanescott.sql-exporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Itauofxcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"itauofxcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IsaachealthStrawberryshakeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"isaachealth.strawberryshake.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevPassword(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dev-password {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BetalgoBlueflowChopper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"betalgo.blueflow.chopper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodexTokens(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codex-tokens {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SquaduckCsharpmatrix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"squaduck.csharpmatrix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fmname(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fmname {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IpsloggerV1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ipslogger.v1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Extlauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"extlauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DercodeottoCslspmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dercodeotto.cslspmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EzdbschemaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ezdbschema.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyfsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyfs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mapperdm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mapperdm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetD1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-d1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ViscachaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"viscacha.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OmniaDockerfilegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"omnia.dockerfilegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TimestamperTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timestamper.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LinktspCoremoduleCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linktsp.coremodule.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Commandgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"commandgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetsparkToolsDumpconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netspark.tools.dumpconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IvyToolsCapturewindow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivy.tools.capturewindow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cnblog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cnblog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FranktoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"franktools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CiciCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cici.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsBookutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.bookutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Illinois(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"illinois {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HolisticwareSlnTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"holisticware.sln-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EricDotnetClassConstructor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eric.dotnet.class.constructor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}