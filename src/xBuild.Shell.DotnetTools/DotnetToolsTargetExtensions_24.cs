using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Xsetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xsetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DsianTcpnscannerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dsian.tcpnscanner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Changey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"changey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Windowsterminalshadertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"windowsterminalshadertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MorganstanleyCrossroads(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"morganstanley.crossroads {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Launchsettingsconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"launchsettingsconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T R0b0t(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"r0b0t {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Magicef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"magicef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Giteztag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"giteztag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MomentumExtensionsEventmarkdowngenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"momentum.extensions.eventmarkdowngenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitstub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitstub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Resumaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resumaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetclearidentity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetclearidentity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PackagescriptwriterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packagescriptwriter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nxjestmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nxjestmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DiffstoreDbms(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"diffstore.dbms {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PrmergerGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"prmerger.github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSetVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-set-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BorsuksoftwareConicalToolsEvidencesetcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.evidencesetcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWhatsapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-whatsapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoreeDotnettoolToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coree.dotnettool.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KrypteraTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kryptera.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kubedmc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kubedmc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetUz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-uz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GltfTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gltf.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOverview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-overview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mklinker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mklinker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwitchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"switch-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftPowerplatformDataverseMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.powerplatform.dataverse.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitsourcesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitsources.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOdata4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-odata4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Findref(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"findref {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitclearbranches(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitclearbranches {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Javaversionswitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"javaversionswitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThanksNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thanks.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Refitgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"refitgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VizgqlConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vizgql.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimpleTemplateRenderer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simple-template-renderer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gunslingercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gunslingercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Centralnugetupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"centralnugetupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHisar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-hisar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwallowRefactor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swallow.refactor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jreplacenet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jreplacenet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NrgCalendarfinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nrg.calendarfinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Macospublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"macospublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetYdktesterGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ydktester-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Randomisa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"randomisa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Versa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuickmcpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quickmcp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharpico(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpico {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Moq2nsubstitute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moq2nsubstitute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EcorenettoTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ecorenetto.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hotspot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hotspot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stringconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stringconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Typescriptclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typescriptclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetamorphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metamorph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dothttptestcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dothttptestcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IfersCoalesceMySourceCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ifers.coalesce-my-source-code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EditorconfigTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"editorconfig-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Clonegithuborg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clonegithuborg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsPackagesign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.packagesign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoNugetHierarchyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.nuget.hierarchy.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Goldsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"goldsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HrTemplategenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hr.templategenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Odatatoclass(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"odatatoclass {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xdev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xdev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ColotilineGitDatetimeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"colotiline.git.datetime.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xflow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xflow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Getdatafromfer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"getdatafromfer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PowerutilsBenchmarkdotnetReporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"powerutils.benchmarkdotnet.reporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaverickPackTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maverick.pack.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genmac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genmac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RagcapCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ragcap.cli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoNugetDownloaderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.nuget.downloader.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Splitfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"splitfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FloeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"floe.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatajugglerDatatierNet7ItemtemplatesBlazordataservices(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datajuggler.datatier.net7.itemtemplates.blazordataservices {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetnewtemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetnewtemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetChangeLog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-change-log {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mainway(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mainway {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ForgeOdataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"forge.odata.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WaEdit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wa-edit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChellRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chell.run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FloeCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"floe.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSnippetconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-snippetconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BaronfelBinlogMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"baronfel.binlog.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomstoolboxJsontoresx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomstoolbox.jsontoresx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftMlModelbuilderCliOsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.ml.modelbuilder.cli.osx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSemver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-semver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeocraGitmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neocra.gitmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CinoridDbml2ef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cinorid.dbml2ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BorsuksoftwareConicalToolsTrxuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.trxuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stewardef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stewardef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PicklesCommandlineOsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pickles.commandline.osx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitreposync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitreposync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCodemetric(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-codemetric {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Llpods(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"llpods {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitlabreviewbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlabreviewbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}