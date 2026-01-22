using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Enumpractice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"enumpractice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jsongigo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsongigo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stamp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stamp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GobiInsyncService(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gobi.insync.service {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Helloworldtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"helloworldtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QuantHub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quant_hub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gamemaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gamemaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Passwordlab(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passwordlab {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KatostoelenGithubreleaseTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"katostoelen.githubrelease.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EpsitecZouflow(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"epsitec.zouflow {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EavfwExtensionsManifestManifestenrichertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eavfw.extensions.manifest.manifestenrichertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuExtentions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.extentions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqliteExec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlite-exec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowProjectEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.project.editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sleet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sleet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EaltoolsTui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ealtools.tui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Escritor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"escritor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PoeReplayer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"poe.replayer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EcotemplategenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ecotemplategen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Epiclash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"epiclash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Easyfileops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easyfileops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Easymathhelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easymathhelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EndowdlyFitz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"endowdly.fitz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnvironmentmanagerEx1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"environmentmanager-ex-1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Editenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"editenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TestnugetedgarwwwwTestWwwTestTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testnugetedgarwwww.test.www.test.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LeftyEmail(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lefty.email {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WordextractorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wordextractor.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HazeMcpserverEcho(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"haze.mcpserver.echo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XsenseExtractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xsense-extractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FindEnv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"find-env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MusictopiaSvgpngembedtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"musictopia.svgpngembedtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MslQuickencrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msl.quickencrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoEtltranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.etltranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Propertyextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"propertyextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Godotnodeextensioninstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"godotnodeextensioninstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TranslatableExportTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"translatable.export.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MbwToolsElephantproject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mbw.tools.elephantproject {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GaryngSqleditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"garyng.sqleditor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VirabshetkarXmledit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"virabshetkar.xmledit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HlcTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hlc-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MinioUploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minio-uploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IykResultpattern(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iyk.resultpattern {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tyrannoport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tyrannoport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Snake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xelk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xelk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnityPacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unity-packer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LockdownNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lockdown.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sql2yaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sql2yaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Printfolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"printfolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetgrpcgenGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netgrpcgen.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SsgTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ssg.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openhosts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openhosts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StormancerUdpecho(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stormancer.udpecho {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Teetoys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"teetoys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Path(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"path {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Toolget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toolget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PkgTrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pkg-trim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KarlsGitflowTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"karls.gitflow.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PublishPackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"publish-package {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nipahfirebaserules(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nipahfirebaserules {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Viteration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"viteration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Robogate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robogate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MacomiSiren(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"macomi.siren {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PujLibrariesLogin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"puj.libraries.login {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZebbleFormatZbl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zebble-format-zbl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LrFrameworkTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lr-framework-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Telplin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telplin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReplaceInFile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"replace-in-file {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsxwatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsxwatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FakhravariIr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fakhravari.ir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FrontmatecToolsFpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"frontmatec.tools.fpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Framascli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"framascli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitFilestage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-filestage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fakeget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fakeget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Furhellotools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"furhellotools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FreesqlGeneratorRjgf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"freesql.generator.rjgf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Findproject(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"findproject {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FluentMigratorGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fluent.migrator.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Functionsettingsmaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"functionsettingsmaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Freegrok(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"freegrok {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Filemd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filemd5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NickvisionFlatpakgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nickvision.flatpakgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NbraceitFakemessagegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nbraceit.fakemessagegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LesvegodFsx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lesvegod.fsx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NewbieFornax(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"newbie.fornax {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Snitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZkeasoftTofolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zkeasoft.tofolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GetTheForkOut(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"get-the-fork-out {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TulesiFramework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tulesi.framework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SylvanToolsFilesysteminfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sylvan.tools.filesysteminfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkFilelength31(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.filelength31 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IndfusionMcpWeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"indfusion.mcp.web {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetfetcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetfetcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jyunrcaeaframework(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jyunrcaeaframework {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}