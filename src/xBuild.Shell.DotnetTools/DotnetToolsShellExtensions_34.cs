using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command R3eCompilerCsharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"r3e.compiler.csharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdgenmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdgenmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Upack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"upack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SvgSkiaConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svg.skia.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFixReferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-fix-references {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Flan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDeps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-deps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TygotechToolLightweightscriptmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tygotech.tool.lightweightscriptmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EirFgraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eir.fgraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OutwitWebGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"outwit.web.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Corral(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"corral {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Torinox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"torinox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command I3dmTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"i3dm.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StudioleExample(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"studiole.example {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Editorconfiggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"editorconfiggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCliZip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cli-zip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gbutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gbutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Facilityconformance(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"facilityconformance {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IcsharpcodeCodeconverterCodeconv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"icsharpcode.codeconverter.codeconv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FbcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fbc-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftPsruleTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.psrule.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetthirdpartynotices(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetthirdpartynotices {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TexttemplatingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"texttemplating.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kvit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kvit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IlledanOpenrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"illedan.openrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gpm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gpm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webvalidate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webvalidate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tur(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tur {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gltfinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gltfinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdgenpython(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdgenpython {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wooly905Prs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wooly905.prs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Recursiverenamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"recursiverenamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solutionfiltergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solutionfiltergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FileSort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"file-sort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StormancerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stormancer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UmbracoToolsPackages(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"umbraco.tools.packages {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tcc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tcc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lffilemapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lffilemapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ForthNetProgram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"forth.net.program {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uploadfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uploadfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IonideProjinfoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ionide.projinfo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JoinCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"join.csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DryGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dry-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGrpcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-grpc-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markdownutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdownutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenerateEventbusCommandProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generate-eventbus-command-proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TranstypeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"transtype.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HotpreviewDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hotpreview.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Imagedeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imagedeployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CslyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csly-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DllpropsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dllprops.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unshort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unshort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Efup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"efup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RobsharperRosMessagecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robsharper.ros.messagecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCodegencs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-codegencs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ExceltosqlscriptsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"exceltosqlscripts.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitConventionalCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git.conventional.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Complog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"complog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sectiongeneratorwebbilir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sectiongeneratorwebbilir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FluentNetSyntaxtest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fluent.net.syntaxtest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csvtrans(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csvtrans {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unbom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unbom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEcho(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-echo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmptyfilesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"emptyfiles.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FpublisherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fpublisher-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDbu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dbu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cronoconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cronoconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MgcbImporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mgcb-importer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mdreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mdreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnitsCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"units.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TablesyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tablesync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-doc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projctl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projctl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EirIgbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eir.igbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Diffexcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"diffexcel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nanovc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nanovc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetdocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetdocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PassingwindGitCiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passingwind.git-ci-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LnwarnCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lnwarn.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntellitectEssentialcsharpListingmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intellitect.essentialcsharp.listingmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devesoltosharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devesoltosharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGtests(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gtests {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbCompute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-compute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Installsdkglobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"installsdkglobaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Upforgrabs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"upforgrabs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GpmUtil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gpm-util {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetStoredprocsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-storedprocsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditorComputeWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute-windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PaketInstall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"paket.install {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCliGhinstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cli-ghinstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgcbEditorComputeMac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute-mac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FpublisherUtilsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fpublisher-utils-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FshCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsh.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Localgitscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"localgitscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqldataextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqldataextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}