using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Githubmilestonecleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubmilestonecleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Upgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"upgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MorganstanleyDotnetplease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"morganstanley.dotnetplease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NunitConsolerunnerNet80(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nunit.consolerunner.net80 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NutstoneReadmeGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nutstone.readme.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Runfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Quickergitversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quickergitversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCmder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cmder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PublishIis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"publish-iis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SourcelinkMilestonereleasenotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sourcelink.milestonereleasenotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trxuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Redisdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"redisdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FileprepperCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fileprepper-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GapotchenkoTurboCocor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gapotchenko.turbo.cocor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeocraMarkgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neocra.markgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LosettaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"losetta.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftMlModelbuilderCliLinux64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.ml.modelbuilder.cli.linux64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVersionPatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-version-patch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNamechk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-namechk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DamengObfuscarGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dameng.obfuscar.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UbietyVersionit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ubiety.versionit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LightbddScenariosyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lightbdd.scenariosync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-venv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Crudgeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"crudgeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ftpdeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ftpdeployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nhkeasy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nhkeasy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDocumentCustomfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-document-customfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Beep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"beep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RichasyRodelcommit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"richasy.rodelcommit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devmark(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devmark {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Calaf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"calaf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Transooner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"transooner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GemojisharpDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gemojisharp.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GapotchenkoGnutk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gapotchenko.gnutk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packageusage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packageusage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IlasmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ilasm-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GodeltechCodereviewEsdataimporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"godeltech.codereview.esdataimporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FrankSimpleinstallerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"frank.simpleinstaller.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trfirst(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trfirst {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TsqlMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tsql-mcp-server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChooseLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"choose-license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packagereferencenormalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packagereferencenormalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RosserSatisfactoryextractorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rosser.satisfactoryextractor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoowareShowassemblyinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mooware.showassemblyinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jacksondr5Sqlgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jacksondr5.sqlgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SigningserverStandaloneclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"signingserver.standaloneclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xnetwork(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xnetwork {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LocaldbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"localdb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trojansourcedetector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trojansourcedetector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lz4cmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lz4cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PiratelangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"piratelang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Refriender(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"refriender {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kizuna(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kizuna {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coffeecup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coffeecup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BuildversionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"buildversion.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CorgibytesFreshliCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"corgibytes.freshli.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mdtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mdtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenboxFastdataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genbox.fastdata.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDrama(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-drama {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uptoyou(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uptoyou {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vaughancli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vaughancli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CnmlBotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cnml.botsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Weathercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"weathercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tye2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tye2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InfiniteCipher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"infinite.cipher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CxuesongThemiddle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cxuesong.themiddle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CxuesongCommandlinetester(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cxuesong.commandlinetester {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DimonsmartNugetmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dimonsmart.nugetmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Diceware(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"diceware {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cspmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cspmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Noted(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"noted {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlnTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sln-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CocoarConfigurationSecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cocoar.configuration.secrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Microservicekit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microservicekit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webformconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webformconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CamusdbSqlsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"camusdb.sqlsh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetversioningTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetversioning.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CascodeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cascode.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mangoseed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mangoseed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBoard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-board {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Familiar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"familiar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTinypng(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tinypng {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Chihiro(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chihiro {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuepasaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quepasa.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotfastlzPackagingTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotfastlz.packaging.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Versionbumper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"versionbumper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RunExe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"run-exe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dngrep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dngrep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JinagaTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jinaga.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Toshowdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toshowdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Folderzipper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"folderzipper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SaastackInstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saastack-installer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YaeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yae.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xnuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xnuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zaunic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zaunic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}