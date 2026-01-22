using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Xsetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xsetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DsianTcpnscannerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dsian.tcpnscanner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Changey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"changey {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Windowsterminalshadertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"windowsterminalshadertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MorganstanleyCrossroads(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"morganstanley.crossroads {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Launchsettingsconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"launchsettingsconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command R0b0t(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"r0b0t {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Magicef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"magicef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Giteztag(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"giteztag {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MomentumExtensionsEventmarkdowngenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"momentum.extensions.eventmarkdowngenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitstub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitstub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Resumaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resumaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetclearidentity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetclearidentity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PackagescriptwriterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packagescriptwriter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nxjestmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nxjestmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DiffstoreDbms(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"diffstore.dbms {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PrmergerGithub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"prmerger.github {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSetVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-set-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BorsuksoftwareConicalToolsEvidencesetcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.evidencesetcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWhatsapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-whatsapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoreeDotnettoolToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coree.dotnettool.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KrypteraTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kryptera.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kubedmc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kubedmc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetUz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-uz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GltfTooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gltf.tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOverview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-overview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mklinker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mklinker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwitchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"switch-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftPowerplatformDataverseMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.powerplatform.dataverse.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitsourcesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitsources.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOdata4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-odata4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Findref(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"findref {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitclearbranches(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitclearbranches {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Javaversionswitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"javaversionswitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThanksNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thanks.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Refitgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"refitgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VizgqlConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vizgql.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimpleTemplateRenderer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simple-template-renderer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gunslingercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gunslingercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Centralnugetupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"centralnugetupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHisar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-hisar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwallowRefactor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swallow.refactor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jreplacenet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jreplacenet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NrgCalendarfinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nrg.calendarfinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Macospublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"macospublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetYdktesterGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ydktester-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Randomisa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"randomisa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Versa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"versa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuickmcpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quickmcp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharpico(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpico {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Moq2nsubstitute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moq2nsubstitute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EcorenettoTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ecorenetto.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hotspot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hotspot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stringconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stringconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Typescriptclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typescriptclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetamorphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metamorph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dothttptestcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dothttptestcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IfersCoalesceMySourceCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ifers.coalesce-my-source-code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EditorconfigTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"editorconfig-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clonegithuborg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clonegithuborg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsPackagesign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.packagesign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoNugetHierarchyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.nuget.hierarchy.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Goldsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"goldsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HrTemplategenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hr.templategenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Odatatoclass(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"odatatoclass {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xdev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xdev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ColotilineGitDatetimeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"colotiline.git.datetime.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xflow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xflow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Getdatafromfer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"getdatafromfer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PowerutilsBenchmarkdotnetReporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"powerutils.benchmarkdotnet.reporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaverickPackTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maverick.pack.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genmac(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genmac {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RagcapCliTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ragcap.cli.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoNugetDownloaderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.nuget.downloader.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Splitfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"splitfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FloeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"floe.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatajugglerDatatierNet7ItemtemplatesBlazordataservices(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datajuggler.datatier.net7.itemtemplates.blazordataservices {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetnewtemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetnewtemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetChangeLog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-change-log {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mainway(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mainway {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ForgeOdataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"forge.odata.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WaEdit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wa-edit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChellRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chell.run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FloeCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"floe.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSnippetconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-snippetconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BaronfelBinlogMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"baronfel.binlog.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomstoolboxJsontoresx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomstoolbox.jsontoresx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftMlModelbuilderCliOsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.ml.modelbuilder.cli.osx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSemver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-semver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeocraGitmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neocra.gitmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CinoridDbml2ef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cinorid.dbml2ef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BorsuksoftwareConicalToolsTrxuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.trxuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stewardef(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stewardef {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PicklesCommandlineOsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pickles.commandline.osx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitreposync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitreposync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCodemetric(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-codemetric {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Llpods(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"llpods {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitlabreviewbot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlabreviewbot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}