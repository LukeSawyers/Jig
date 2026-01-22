using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Dnspod(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnspod {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Objmapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"objmapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsimagetosixelTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsimagetosixel.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slnsort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slnsort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lewissayhello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lewissayhello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SemgusParserTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"semgus.parser.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReactivememoryGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reactivememory.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-hash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FaithlifePackagedifftoolTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faithlife.packagedifftool.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Linx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ykmc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ykmc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsharpsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsharpsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMongo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mongo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sassysharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sassysharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetForeman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-foreman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWaffleSerg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-waffle-serg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GodotHub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"godot-hub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Opslevelvalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opslevelvalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Otterkeys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"otterkeys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetwaffleJcampra(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetwaffle.jcampra {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Orphancsfilesfinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"orphancsfilesfinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NitoProjprops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nito.projprops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NovonordiskSpectrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"novonordisk.spectrace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TriaxisToolsXelive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"triaxis.tools.xelive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TrapLabelingui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trap.labelingui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FaithlifeFacadegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faithlife.facadegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VzGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vz-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonMzlitetomzml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.mzlitetomzml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDarwoft(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-darwoft {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPfx2pem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pfx2pem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OnestrataSwaggertots(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"onestrata.swaggertots {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PackagingDebuosTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packaging.debuos.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeziantouFrameworkHtmlTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meziantou.framework.html.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IvysoftGitlabTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ivysoft.gitlab.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nupkgversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nupkgversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nocurly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nocurly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNugetGc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nuget-gc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RjcpVssolutionsort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rjcp.vssolutionsort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Objectidgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"objectidgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MsbuildOtelHarness(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msbuild.otel.harness {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GmanSiren(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gman.siren {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IgnisResharperReporterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ignis.resharper.reporter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KafkaInvestigator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kafka.investigator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DirSize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dir-size {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGittemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gittemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Schemazenplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"schemazenplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ImgGo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"img-go {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TailwindcssDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tailwindcss-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XrmmockupMetadatagenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xrmmockup.metadatagenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fasmi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fasmi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XenialPretzel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xenial.pretzel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Heic2jpg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"heic2jpg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kryptos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kryptos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command X2netXpilerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"x2net.xpiler.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scribancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scribancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PapaltineFluxsdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"papaltine.fluxsdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nukepayload2ToolsDocfx2vb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nukepayload2.tools.docfx2vb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PxlSimulator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pxl.simulator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sowa705DotnetOutdatedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sowa705.dotnet-outdated-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StructDesign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"struct.design {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Reloadify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reloadify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Powerpointtemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"powerpointtemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWhich(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-which {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerSdkDownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.sdk.download {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Forceops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"forceops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EllemapperTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ellemapper.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Farcaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"farcaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SoftwarepioniereToolsEventstorepassword(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"softwarepioniere.tools.eventstorepassword {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EdiMidiplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"edi.midiplayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Releasedb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"releasedb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nitec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nitec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IncatechnologiesLocalizationframeworkTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"incatechnologies.localizationframework.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mfp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mfp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VtLoadtest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vt-loadtest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependencygraphdrawer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependencygraphdrawer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShakermakerSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shakermaker.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Elitetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elitetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dumpdiag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dumpdiag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KyrtGitignore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kyrt.gitignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMoGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mo-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dmd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dmd5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Watch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"watch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zipgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zipgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SonicgdPackagestoprojectstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sonicgd.packagestoprojectstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpiderxTemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spiderx.template {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsimagetotic80Tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsimagetotic80.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kronoweavetemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kronoweavetemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fileoptics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fileoptics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHotrewatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-hotrewatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFciv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-fciv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsharppacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsharppacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuget-sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Httprequestinspector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"httprequestinspector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}