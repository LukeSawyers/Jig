using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Githubmilestonecleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubmilestonecleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Upgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"upgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MorganstanleyDotnetplease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"morganstanley.dotnetplease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NunitConsolerunnerNet80(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nunit.consolerunner.net80 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NutstoneReadmeGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nutstone.readme.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Runfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Quickergitversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quickergitversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCmder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cmder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PublishIis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"publish-iis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SourcelinkMilestonereleasenotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sourcelink.milestonereleasenotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trxuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Redisdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"redisdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FileprepperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fileprepper-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GapotchenkoTurboCocor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gapotchenko.turbo.cocor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeocraMarkgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neocra.markgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LosettaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"losetta.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftMlModelbuilderCliLinux64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.ml.modelbuilder.cli.linux64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVersionPatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-version-patch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNamechk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-namechk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DamengObfuscarGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dameng.obfuscar.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UbietyVersionit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ubiety.versionit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LightbddScenariosyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lightbdd.scenariosync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-venv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Crudgeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"crudgeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ftpdeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ftpdeployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nhkeasy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nhkeasy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDocumentCustomfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-document-customfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Beep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"beep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RichasyRodelcommit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"richasy.rodelcommit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Calaf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"calaf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Transooner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"transooner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GemojisharpDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gemojisharp.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GapotchenkoGnutk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gapotchenko.gnutk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packageusage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packageusage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IlasmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ilasm-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GodeltechCodereviewEsdataimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"godeltech.codereview.esdataimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FrankSimpleinstallerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"frank.simpleinstaller.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trfirst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trfirst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TsqlMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tsql-mcp-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChooseLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"choose-license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packagereferencenormalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packagereferencenormalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RosserSatisfactoryextractorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rosser.satisfactoryextractor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoowareShowassemblyinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mooware.showassemblyinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jacksondr5Sqlgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jacksondr5.sqlgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SigningserverStandaloneclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"signingserver.standaloneclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xnetwork(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xnetwork {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LocaldbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"localdb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trojansourcedetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trojansourcedetector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lz4cmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lz4cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PiratelangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"piratelang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Refriender(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"refriender {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kizuna(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kizuna {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coffeecup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coffeecup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BuildversionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"buildversion.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CorgibytesFreshliCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corgibytes.freshli.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mdtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mdtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenboxFastdataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genbox.fastdata.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDrama(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-drama {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uptoyou(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uptoyou {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vaughancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vaughancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CnmlBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cnml.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Weathercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"weathercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tye2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tye2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InfiniteCipher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"infinite.cipher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CxuesongThemiddle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cxuesong.themiddle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CxuesongCommandlinetester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cxuesong.commandlinetester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DimonsmartNugetmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dimonsmart.nugetmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Diceware(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"diceware {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cspmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cspmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Noted(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"noted {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlnTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sln-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CocoarConfigurationSecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cocoar.configuration.secrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Microservicekit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microservicekit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webformconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webformconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CamusdbSqlsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"camusdb.sqlsh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetversioningTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetversioning.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CascodeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cascode.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mangoseed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mangoseed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBoard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-board {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Familiar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"familiar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTinypng(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tinypng {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Chihiro(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chihiro {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuepasaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quepasa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotfastlzPackagingTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotfastlz.packaging.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Versionbumper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versionbumper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RunExe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"run-exe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dngrep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dngrep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JinagaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jinaga.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Toshowdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toshowdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Folderzipper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"folderzipper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SaastackInstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saastack-installer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YaeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yae.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xnuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xnuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zaunic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zaunic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}