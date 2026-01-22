using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Factoriotel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"factoriotel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Directorypropswitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"directorypropswitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Logenvtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"logenvtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Simplemsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simplemsi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCross(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cross {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Formatconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"formatconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WatchTemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"watch-template {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command M3u8Downloader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"m3u8-downloader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Urlencoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"urlencoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Usingusings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"usingusings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DuotifyEfcoreEfrepositorygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"duotify.efcore.efrepositorygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaggsoftCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maggsoft.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotgraphee(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotgraphee {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Depguard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"depguard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UuidnextCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uuidnext.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cygnus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cygnus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimpleserverTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simpleserver-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IgnixaValidationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ignixa.validation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IgnixaSqlonfhirCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ignixa.sqlonfhir.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IgnixaFhirfakesCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ignixa.fhirfakes.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitlabSecurityReportConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlab_security_report_converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Quoll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quoll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LuciferCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lucifer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotumlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotuml.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpotlightExtractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spotlight-extractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGuit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-guit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Natcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"natcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChibildCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chibild-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSqliteCache(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sqlite-cache {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FaultifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faultify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMakeGlobalTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-make-global-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xtr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xtr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CukeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cuke.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TanukisharpOnetimepassword(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tanukisharp.onetimepassword {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Splendr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"splendr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScgWin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scg-win {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ViscachaTestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"viscacha.testrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Esclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"esclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ippool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ippool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CosmosTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cosmos.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TimesheetfillerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timesheetfiller.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MchrisDotnetcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mchris.dotnetcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VsmacCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vsmac-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NefariusToolsVpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nefarius.tools.vpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MawosoftMissingcoverage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mawosoft.missingcoverage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XposureLeanLauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xposure.lean.launcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SshCp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ssh-cp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zudesigncontrol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zudesigncontrol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Esh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"esh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcoreGitignore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcore-gitignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SxServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sx.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sp-docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EzplatformEzonboarding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ezplatform.ezonboarding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetWarden(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuget-warden {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChibiarCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chibiar-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Telegramsessionkeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telegramsessionkeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetsdependencygraphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetsdependencygraph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VecerdiIgnore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vecerdi.ignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nbundle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nbundle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeltaqCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deltaq.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tfscollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tfscollector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SxClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sx.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Entitydtohelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entitydtohelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dewordle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dewordle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCldrResx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cldr-resx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Froxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"froxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nukit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nukit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xmldocmdsymbols(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xmldocmdsymbols {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Circularlabels(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"circularlabels {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Image64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"image64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LrRenameReplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lr-rename-replace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markdown2toc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdown2toc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Modsharddiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modsharddiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HayaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"haya.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StaticsphereCliGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"staticsphere.cli.guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuinntyneEndpointCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quinntyne.endpoint.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Multiframeworktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"multiframeworktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jestgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jestgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TaskitDotnetVersions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taskit.dotnet.versions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MsmdotnetCleanprojects(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msmdotnet.cleanprojects {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevPomo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dev-pomo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sop4csDemo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sop4cs.demo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VbLs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vb-ls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stringextensionpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stringextensionpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NrgMatrix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nrg.matrix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mfu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mfu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Strfind(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"strfind {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Temple(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"temple {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Queryfirst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"queryfirst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LucaslgtDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lucaslgt.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nukex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nukex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LibTransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lib.transform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slnc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slnc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unityxrefmaps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unityxrefmaps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMagicwindballEcarney(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-magicwindball-ecarney {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SturmovikmissionCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sturmovikmission.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlncsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slncs.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}