using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Globalnamesorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"globalnamesorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCowsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cowsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command I3sTileTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"i3s.tile.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Foreach(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"foreach {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LitReact(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lit-react {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Monogameutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monogameutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChloroplastTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chloroplast.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MisterVersionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mister.version.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TolitechLino(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tolitech.lino {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Style(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"style {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetIldasm2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ildasm2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditorComputeLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Make(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"make {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DuotifyEfcoreEntitypartialgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"duotify.efcore.entitypartialgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Diffpilot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"diffpilot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rankser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rankser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OskUmlCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"osk.uml.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JwksTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jwks.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Metagen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metagen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Duplicatefilefinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"duplicatefilefinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fjj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fjj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TorinoxR4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"torinox.r4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StefandevoGenymanXamarinviewmodel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stefandevo.genyman.xamarinviewmodel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpringcompGplex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"springcomp.gplex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Svgx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svgx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command M2devTymer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"m2dev.tymer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditorCompute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SrihashCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"srihash-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PreviewframeworkDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"previewframework.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OrganizeCsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"organize-csproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hl7CqlPackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hl7.cql.packager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Renamephotos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"renamephotos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LasmeraLsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lasmera.lsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XiliumCrdtpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xilium.crdtp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lastpage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lastpage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hexcalc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hexcalc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TimheuerRepinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timheuer.repinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Subtreeinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"subtreeinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FhirMappingExceptionsWinfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fhir-mapping-exceptions-winfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Powersession(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"powersession {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WinsharpfuzzCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"winsharpfuzz.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WinsharpfuzzInstrument(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"winsharpfuzz.instrument {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CreatioPackagevalidation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"creatio.packagevalidation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gdialog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gdialog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetIldiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ildiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KeycloakMigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"keycloak.migrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Prettytrx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"prettytrx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Retypeappstagingtest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"retypeappstagingtest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Msfslayout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msfslayout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Faultify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faultify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CapnpcCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"capnpc-csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tobase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tobase64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnclassifiedDotnetmakedeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unclassified.dotnetmakedeb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slngenvs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slngenvs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Simmatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simmatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Grazedocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grazedocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpringcompGppg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"springcomp.gppg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fcsbenchmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fcsbenchmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OfcoursedudeTobase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ofcoursedude.tobase64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MsgpackViewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msgpack-viewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webtty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webtty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wttr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wttr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Monopack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monopack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NefariusToolsWdkwhere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nefarius.tools.wdkwhere {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTestoolGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-testool-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetProcstoclasses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-procstoclasses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Md2word(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"md2word {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Odiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"odiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StefandevoGenymanLoco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stefandevo.genyman.loco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConventionalcommitsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conventionalcommits.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetmanagesecrets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetmanagesecrets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodefocoCmgcb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codefoco.cmgcb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cxxsonarquberunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cxxsonarquberunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NefariusToolsXmldoc2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nefarius.tools.xmldoc2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InedoExtensionpackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"inedo.extensionpackager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Frabcerts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"frabcerts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CdxEnrich(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cdx-enrich {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnvmanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"envmanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command P2u(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"p2u {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnitynugetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unitynuget.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Democli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"democli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RpnTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rpn.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeneesChordsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"menees.chords.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbfsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbfsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Proto2csharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proto2csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetStrykerUnofficial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-stryker-unofficial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevteamToolsSwapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devteam.tools.swapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Versionify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"versionify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Htmlcopyvscode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"htmlcopyvscode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Temgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"temgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitRocketFilter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-rocket-filter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FmGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fm-generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zxjun2002ConfgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zxjun2002.confgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevrockCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devrock.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Templatevault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"templatevault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docknet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docknet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCoveragexmlConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-coveragexml-converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}