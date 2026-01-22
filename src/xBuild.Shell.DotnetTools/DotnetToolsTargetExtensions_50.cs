using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Dnspod(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnspod {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Objmapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"objmapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsimagetosixelTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsimagetosixel.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slnsort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slnsort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lewissayhello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lewissayhello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SemgusParserTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"semgus.parser.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReactivememoryGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reactivememory.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-hash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FaithlifePackagedifftoolTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faithlife.packagedifftool.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Linx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ykmc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ykmc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsharpsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsharpsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMongo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mongo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sassysharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sassysharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetForeman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-foreman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWaffleSerg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-waffle-serg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GodotHub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"godot-hub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Opslevelvalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opslevelvalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Otterkeys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"otterkeys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetwaffleJcampra(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetwaffle.jcampra {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Orphancsfilesfinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"orphancsfilesfinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NitoProjprops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nito.projprops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NovonordiskSpectrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"novonordisk.spectrace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TriaxisToolsXelive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"triaxis.tools.xelive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TrapLabelingui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trap.labelingui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FaithlifeFacadegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faithlife.facadegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VzGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vz-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonMzlitetomzml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.mzlitetomzml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDarwoft(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-darwoft {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPfx2pem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pfx2pem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OnestrataSwaggertots(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"onestrata.swaggertots {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PackagingDebuosTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packaging.debuos.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeziantouFrameworkHtmlTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meziantou.framework.html.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IvysoftGitlabTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivysoft.gitlab.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nupkgversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nupkgversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nocurly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nocurly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNugetGc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nuget-gc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RjcpVssolutionsort(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rjcp.vssolutionsort {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Objectidgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"objectidgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MsbuildOtelHarness(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msbuild.otel.harness {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GmanSiren(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gman.siren {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IgnisResharperReporterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ignis.resharper.reporter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KafkaInvestigator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kafka.investigator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DirSize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dir-size {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGittemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gittemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Schemazenplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"schemazenplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ImgGo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"img-go {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TailwindcssDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tailwindcss-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XrmmockupMetadatagenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xrmmockup.metadatagenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fasmi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fasmi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XenialPretzel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xenial.pretzel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Heic2jpg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"heic2jpg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kryptos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kryptos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T X2netXpilerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"x2net.xpiler.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scribancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scribancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PapaltineFluxsdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"papaltine.fluxsdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nukepayload2ToolsDocfx2vb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nukepayload2.tools.docfx2vb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PxlSimulator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pxl.simulator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sowa705DotnetOutdatedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sowa705.dotnet-outdated-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StructDesign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"struct.design {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Reloadify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reloadify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Powerpointtemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"powerpointtemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWhich(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-which {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerSdkDownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.sdk.download {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Forceops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"forceops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EllemapperTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ellemapper.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Farcaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"farcaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SoftwarepioniereToolsEventstorepassword(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"softwarepioniere.tools.eventstorepassword {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EdiMidiplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"edi.midiplayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Releasedb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"releasedb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nitec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nitec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IncatechnologiesLocalizationframeworkTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"incatechnologies.localizationframework.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mfp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mfp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VtLoadtest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vt-loadtest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependencygraphdrawer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependencygraphdrawer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShakermakerSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shakermaker.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Elitetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elitetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dumpdiag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dumpdiag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KyrtGitignore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kyrt.gitignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMoGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mo-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dmd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dmd5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Watch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"watch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zipgit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zipgit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SonicgdPackagestoprojectstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sonicgd.packagestoprojectstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpiderxTemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spiderx.template {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsimagetotic80Tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsimagetotic80.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kronoweavetemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kronoweavetemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fileoptics(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fileoptics {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHotrewatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-hotrewatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFciv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-fciv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsharppacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsharppacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuget-sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Httprequestinspector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"httprequestinspector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}