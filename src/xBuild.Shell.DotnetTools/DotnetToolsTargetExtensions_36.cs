using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Factoriotel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"factoriotel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Directorypropswitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"directorypropswitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Logenvtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"logenvtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Simplemsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simplemsi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCross(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cross {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Formatconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"formatconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WatchTemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"watch-template {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T M3u8Downloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"m3u8-downloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Urlencoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"urlencoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Usingusings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"usingusings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DuotifyEfcoreEfrepositorygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duotify.efcore.efrepositorygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaggsoftCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maggsoft.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotgraphee(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotgraphee {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Depguard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"depguard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UuidnextCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uuidnext.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cygnus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cygnus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimpleserverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simpleserver-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IgnixaValidationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ignixa.validation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IgnixaSqlonfhirCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ignixa.sqlonfhir.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IgnixaFhirfakesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ignixa.fhirfakes.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitlabSecurityReportConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlab_security_report_converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Quoll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quoll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LuciferCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lucifer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotumlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotuml.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpotlightExtractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spotlight-extractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGuit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-guit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Natcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"natcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChibildCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chibild-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSqliteCache(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sqlite-cache {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FaultifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faultify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMakeGlobalTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-make-global-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xtr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xtr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CukeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cuke.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TanukisharpOnetimepassword(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tanukisharp.onetimepassword {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Splendr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"splendr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScgWin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scg-win {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ViscachaTestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"viscacha.testrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Esclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"esclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ippool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ippool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CosmosTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cosmos.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TimesheetfillerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timesheetfiller.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MchrisDotnetcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mchris.dotnetcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VsmacCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vsmac-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NefariusToolsVpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nefarius.tools.vpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MawosoftMissingcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mawosoft.missingcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XposureLeanLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xposure.lean.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SshCp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ssh-cp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zudesigncontrol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zudesigncontrol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Esh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"esh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcoreGitignore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcore-gitignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SxServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sx.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sp-docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EzplatformEzonboarding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ezplatform.ezonboarding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetWarden(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuget-warden {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChibiarCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chibiar-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Telegramsessionkeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telegramsessionkeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetsdependencygraphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetsdependencygraph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VecerdiIgnore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vecerdi.ignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nbundle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nbundle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeltaqCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deltaq.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tfscollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tfscollector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SxClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sx.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Entitydtohelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"entitydtohelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dewordle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dewordle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCldrResx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cldr-resx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Froxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"froxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nukit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nukit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xmldocmdsymbols(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xmldocmdsymbols {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Circularlabels(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"circularlabels {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Image64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"image64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LrRenameReplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lr-rename-replace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markdown2toc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdown2toc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Modsharddiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modsharddiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HayaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"haya.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StaticsphereCliGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"staticsphere.cli.guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuinntyneEndpointCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quinntyne.endpoint.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Multiframeworktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"multiframeworktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jestgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jestgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TaskitDotnetVersions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taskit.dotnet.versions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MsmdotnetCleanprojects(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msmdotnet.cleanprojects {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevPomo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dev-pomo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sop4csDemo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sop4cs.demo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VbLs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vb-ls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stringextensionpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stringextensionpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NrgMatrix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nrg.matrix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mfu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mfu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Strfind(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"strfind {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Temple(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"temple {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Queryfirst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"queryfirst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LucaslgtDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lucaslgt.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nukex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nukex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LibTransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lib.transform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slnc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slnc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unityxrefmaps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unityxrefmaps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMagicwindballEcarney(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-magicwindball-ecarney {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SturmovikmissionCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sturmovikmission.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlncsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slncs.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}