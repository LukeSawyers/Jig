using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Globalnamesorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"globalnamesorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCowsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cowsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T I3sTileTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"i3s.tile.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Foreach(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"foreach {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LitReact(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lit-react {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Monogameutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monogameutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChloroplastTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chloroplast.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MisterVersionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mister.version.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TolitechLino(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tolitech.lino {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Style(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"style {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetIldasm2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ildasm2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditorComputeLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Make(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"make {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DuotifyEfcoreEntitypartialgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duotify.efcore.entitypartialgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Diffpilot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"diffpilot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rankser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rankser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OskUmlCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"osk.uml.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JwksTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jwks.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Metagen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metagen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Duplicatefilefinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duplicatefilefinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fjj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fjj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TorinoxR4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"torinox.r4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StefandevoGenymanXamarinviewmodel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stefandevo.genyman.xamarinviewmodel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpringcompGplex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"springcomp.gplex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Svgx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svgx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T M2devTymer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"m2dev.tymer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditorCompute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SrihashCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"srihash-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PreviewframeworkDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"previewframework.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OrganizeCsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"organize-csproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hl7CqlPackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hl7.cql.packager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Renamephotos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"renamephotos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LasmeraLsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lasmera.lsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XiliumCrdtpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xilium.crdtp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lastpage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lastpage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hexcalc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hexcalc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TimheuerRepinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timheuer.repinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Subtreeinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"subtreeinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FhirMappingExceptionsWinfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fhir-mapping-exceptions-winfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Powersession(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"powersession {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WinsharpfuzzCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"winsharpfuzz.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WinsharpfuzzInstrument(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"winsharpfuzz.instrument {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CreatioPackagevalidation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"creatio.packagevalidation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gdialog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gdialog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetIldiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ildiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KeycloakMigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"keycloak.migrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Prettytrx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"prettytrx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Retypeappstagingtest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"retypeappstagingtest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Msfslayout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msfslayout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Faultify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faultify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CapnpcCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"capnpc-csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tobase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tobase64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnclassifiedDotnetmakedeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unclassified.dotnetmakedeb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slngenvs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slngenvs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Simmatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simmatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Grazedocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grazedocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpringcompGppg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"springcomp.gppg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fcsbenchmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fcsbenchmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OfcoursedudeTobase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ofcoursedude.tobase64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MsgpackViewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msgpack-viewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webtty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webtty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wttr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wttr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Monopack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monopack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NefariusToolsWdkwhere(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nefarius.tools.wdkwhere {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTestoolGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-testool-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetProcstoclasses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-procstoclasses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Md2word(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"md2word {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Odiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"odiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StefandevoGenymanLoco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stefandevo.genyman.loco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConventionalcommitsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conventionalcommits.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetmanagesecrets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetmanagesecrets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodefocoCmgcb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codefoco.cmgcb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cxxsonarquberunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cxxsonarquberunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NefariusToolsXmldoc2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nefarius.tools.xmldoc2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InedoExtensionpackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"inedo.extensionpackager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Frabcerts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"frabcerts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CdxEnrich(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cdx-enrich {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnvmanagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"envmanager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T P2u(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"p2u {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnitynugetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unitynuget.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Democli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"democli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RpnTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rpn.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeneesChordsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"menees.chords.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbfsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbfsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Proto2csharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proto2csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetStrykerUnofficial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-stryker-unofficial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevteamToolsSwapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devteam.tools.swapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Versionify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versionify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Htmlcopyvscode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"htmlcopyvscode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Temgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"temgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitRocketFilter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-rocket-filter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FmGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fm-generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zxjun2002ConfgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zxjun2002.confgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevrockCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devrock.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Templatevault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"templatevault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docknet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docknet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCoveragexmlConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-coveragexml-converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}