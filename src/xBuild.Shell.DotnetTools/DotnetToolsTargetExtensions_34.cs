using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T R3eCompilerCsharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"r3e.compiler.csharp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdgenmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdgenmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Upack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"upack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SvgSkiaConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svg.skia.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFixReferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-fix-references {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Flan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDeps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-deps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TygotechToolLightweightscriptmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tygotech.tool.lightweightscriptmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EirFgraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eir.fgraph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OutwitWebGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"outwit.web.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Corral(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corral {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Torinox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"torinox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T I3dmTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"i3dm.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StudioleExample(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"studiole.example {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Editorconfiggenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"editorconfiggenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCliZip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cli-zip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gbutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gbutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Facilityconformance(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"facilityconformance {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IcsharpcodeCodeconverterCodeconv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"icsharpcode.codeconverter.codeconv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FbcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fbc-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftPsruleTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.psrule.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetthirdpartynotices(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetthirdpartynotices {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TexttemplatingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"texttemplating.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kvit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kvit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IlledanOpenrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"illedan.openrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gpm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gpm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webvalidate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webvalidate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tur(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tur {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gltfinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gltfinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdgenpython(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdgenpython {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wooly905Prs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wooly905.prs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Recursiverenamer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"recursiverenamer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solutionfiltergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solutionfiltergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FileSort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"file-sort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StormancerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stormancer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UmbracoToolsPackages(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"umbraco.tools.packages {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tcc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tcc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lffilemapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lffilemapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ForthNetProgram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"forth.net.program {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uploadfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uploadfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IonideProjinfoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ionide.projinfo.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JoinCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"join.csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DryGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dry-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGrpcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-grpc-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markdownutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdownutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenerateEventbusCommandProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generate-eventbus-command-proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TranstypeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"transtype.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HotpreviewDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hotpreview.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Imagedeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imagedeployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CslyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csly-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DllpropsTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dllprops.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unshort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unshort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Efup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"efup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RobsharperRosMessagecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robsharper.ros.messagecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCodegencs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-codegencs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ExceltosqlscriptsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"exceltosqlscripts.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitConventionalCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git.conventional.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Complog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"complog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sectiongeneratorwebbilir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sectiongeneratorwebbilir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FluentNetSyntaxtest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fluent.net.syntaxtest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csvtrans(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csvtrans {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unbom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unbom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEcho(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-echo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmptyfilesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"emptyfiles.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FpublisherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fpublisher-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDbu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dbu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cronoconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cronoconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MgcbImporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mgcb-importer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mdreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mdreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnitsCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"units.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TablesyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tablesync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-doc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projctl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projctl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EirIgbuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eir.igbuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Diffexcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"diffexcel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nanovc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nanovc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetdocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetdocs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PassingwindGitCiTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passingwind.git-ci-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LnwarnCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lnwarn.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntellitectEssentialcsharpListingmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intellitect.essentialcsharp.listingmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devesoltosharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devesoltosharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGtests(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gtests {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbCompute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-compute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Installsdkglobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"installsdkglobaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Upforgrabs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"upforgrabs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GpmUtil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gpm-util {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetStoredprocsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-storedprocsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditorComputeWindows(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute-windows {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PaketInstall(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"paket.install {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCliGhinstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cli-ghinstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgcbEditorComputeMac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgcb-editor-compute-mac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FpublisherUtilsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fpublisher-utils-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FshCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsh.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Localgitscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"localgitscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqldataextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqldataextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}