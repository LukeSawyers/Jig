using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Livefile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"livefile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VssolutionsToolsSolforge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vssolutions.tools.solforge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoedimMcpFabric(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moedim.mcp.fabric {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Niceson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"niceson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnlimitedinfTom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unlimitedinf.tom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KnapcodeTnetstringstojson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"knapcode.tnetstringstojson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Winsocat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"winsocat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wtc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wtc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Islocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"islocalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YoutubeGet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"youtube.get {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vdenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vdenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gti(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gti {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ksnitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ksnitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mssql2mysql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mssql2mysql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ParticularTimeoutmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"particular.timeoutmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NootScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"noot-scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UthavuTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uthavu.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubreleasenotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubreleasenotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lockdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lockdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Locomat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"locomat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VersiongeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"versiongenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sourcesymbolmapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sourcesymbolmapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Np(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"np {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZpdfgeneratorTemplatepreview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zpdfgenerator.templatepreview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Strings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"strings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LockdownTutorial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lockdown.tutorial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaowohlRenovateversionlimit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maowohl.renovateversionlimit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trxtohtmlconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxtohtmlconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OreofoxTodo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oreofox-todo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testreportgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testreportgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HeleonixTestingReporting(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"heleonix.testing.reporting {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NtwSqlhydraSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ntw.sqlhydra.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Taskmonster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taskmonster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SiganbergMapsterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"siganberg.mapster.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VitaVitadbtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vita.vitadbtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markocoa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markocoa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NickmkkSnitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nickmkk.snitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpiderlyProjectinitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spiderly.projectinitializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xls2sql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xls2sql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScenegateHinoxUtils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scenegate.hinox.utils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JguzdvJsonmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jguzdv.jsonmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WolfMetalworkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wolf.metalwork.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SecurelinkShortener(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"securelink.shortener {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuget-merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmusdiGherkintomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smusdi.gherkintomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JoerageNulink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"joerage.nulink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Send2watched(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"_send2watched {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NventiveNugetUpdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nventive.nuget.updater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gactool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gactool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitsmimesign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitsmimesign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Powershell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"powershell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubtesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubtesttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githours(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githours {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowHologramViewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.hologram.viewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitKey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-key {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitKeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-keeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitImport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-import {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GreenheckSn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"greenheck.sn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubverify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubverify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GunchartedPackageupdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"guncharted.packageupdater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Giteenote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"giteenote {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MediatorregistrationsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mediatorregistrations.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GfMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gf.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GelbermLoadelastic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gelberm-loadelastic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetutilsToolRestore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetutils.tool.restore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PockProgrammingGuidMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pock-programming.guid-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenerateNewGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generate-new-guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SemanticreleaseGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"semanticrelease.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GsuuonToolGpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gsuuon.tool.gpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MacrosourceGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"macrosource.guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitloom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitloom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitignorerer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitignorerer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Randomguid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"randomguid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MercanPassgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mercan.passgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SaigonmioGenerata(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saigonmio.generata {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Youtubesubtitlesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"youtubesubtitlesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mygitnugget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mygitnugget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Miguan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"miguan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Showgroffename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"showgroffename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZebbleSchema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zebble-schema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZebbleImage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zebble-image {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PsimsaGitrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"psimsa.gitrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zdjgeneraltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zdjgeneraltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XdkGenerators(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xdk.generators {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SnappytoolPwdgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snappytool.pwdgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Robotraconteurwebgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robotraconteurwebgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToyStoresystemGeneric(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toy_storesystem.generic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Retro(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"retro {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VsMsbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vs-msbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetrepackTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetrepack.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stein(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stein {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MmlibToolsTranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mmlib.tools.translator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Toitnups(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toitnups {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qcg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qcg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vsmachelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vsmachelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}