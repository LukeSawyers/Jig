using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Enumpractice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"enumpractice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jsongigo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsongigo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stamp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stamp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GobiInsyncService(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gobi.insync.service {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Helloworldtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"helloworldtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QuantHub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quant_hub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gamemaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gamemaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Passwordlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passwordlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KatostoelenGithubreleaseTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"katostoelen.githubrelease.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EpsitecZouflow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"epsitec.zouflow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EavfwExtensionsManifestManifestenrichertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eavfw.extensions.manifest.manifestenrichertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuExtentions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.extentions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqliteExec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlite-exec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowProjectEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.project.editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sleet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sleet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EaltoolsTui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ealtools.tui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Escritor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"escritor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PoeReplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"poe.replayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EcotemplategenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ecotemplategen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Epiclash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"epiclash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Easyfileops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easyfileops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Easymathhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easymathhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EndowdlyFitz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"endowdly.fitz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnvironmentmanagerEx1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"environmentmanager-ex-1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Editenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"editenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TestnugetedgarwwwwTestWwwTestTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testnugetedgarwwww.test.www.test.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LeftyEmail(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lefty.email {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WordextractorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wordextractor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HazeMcpserverEcho(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"haze.mcpserver.echo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XsenseExtractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xsense-extractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FindEnv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"find-env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MusictopiaSvgpngembedtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"musictopia.svgpngembedtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MslQuickencrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msl.quickencrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoEtltranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.etltranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Propertyextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"propertyextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Godotnodeextensioninstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"godotnodeextensioninstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TranslatableExportTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"translatable.export.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MbwToolsElephantproject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mbw.tools.elephantproject {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GaryngSqleditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"garyng.sqleditor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VirabshetkarXmledit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"virabshetkar.xmledit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HlcTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hlc-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MinioUploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minio-uploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IykResultpattern(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iyk.resultpattern {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tyrannoport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tyrannoport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Snake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xelk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xelk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnityPacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unity-packer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LockdownNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lockdown.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sql2yaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sql2yaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Printfolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"printfolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetgrpcgenGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netgrpcgen.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SsgTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ssg.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openhosts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openhosts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StormancerUdpecho(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stormancer.udpecho {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Teetoys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"teetoys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Path(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"path {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Toolget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toolget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PkgTrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pkg-trim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KarlsGitflowTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"karls.gitflow.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PublishPackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"publish-package {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nipahfirebaserules(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nipahfirebaserules {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Viteration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"viteration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Robogate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robogate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MacomiSiren(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"macomi.siren {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PujLibrariesLogin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"puj.libraries.login {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZebbleFormatZbl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zebble-format-zbl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LrFrameworkTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lr-framework-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Telplin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"telplin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReplaceInFile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"replace-in-file {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsxwatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsxwatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FakhravariIr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fakhravari.ir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FrontmatecToolsFpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"frontmatec.tools.fpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Framascli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"framascli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitFilestage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-filestage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fakeget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fakeget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Furhellotools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"furhellotools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FreesqlGeneratorRjgf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"freesql.generator.rjgf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Findproject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"findproject {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FluentMigratorGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fluent.migrator.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Functionsettingsmaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"functionsettingsmaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Freegrok(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"freegrok {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Filemd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filemd5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NickvisionFlatpakgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nickvision.flatpakgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NbraceitFakemessagegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nbraceit.fakemessagegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LesvegodFsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lesvegod.fsx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NewbieFornax(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"newbie.fornax {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Snitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZkeasoftTofolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zkeasoft.tofolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GetTheForkOut(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"get-the-fork-out {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TulesiFramework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tulesi.framework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SylvanToolsFilesysteminfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sylvan.tools.filesysteminfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkFilelength31(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.filelength31 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IndfusionMcpWeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"indfusion.mcp.web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetfetcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetfetcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jyunrcaeaframework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jyunrcaeaframework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}