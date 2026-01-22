using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Livefile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"livefile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VssolutionsToolsSolforge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vssolutions.tools.solforge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoedimMcpFabric(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moedim.mcp.fabric {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Niceson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"niceson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnlimitedinfTom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unlimitedinf.tom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KnapcodeTnetstringstojson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"knapcode.tnetstringstojson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Winsocat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"winsocat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wtc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wtc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Islocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"islocalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YoutubeGet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"youtube.get {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vdenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vdenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gti(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gti {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ksnitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ksnitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mssql2mysql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mssql2mysql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ParticularTimeoutmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"particular.timeoutmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NootScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"noot-scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UthavuTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uthavu.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubreleasenotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubreleasenotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lockdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lockdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Locomat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"locomat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VersiongeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versiongenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sourcesymbolmapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sourcesymbolmapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Np(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"np {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZpdfgeneratorTemplatepreview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zpdfgenerator.templatepreview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Strings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"strings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LockdownTutorial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lockdown.tutorial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaowohlRenovateversionlimit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maowohl.renovateversionlimit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trxtohtmlconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxtohtmlconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OreofoxTodo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oreofox-todo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testreportgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testreportgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HeleonixTestingReporting(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"heleonix.testing.reporting {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NtwSqlhydraSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ntw.sqlhydra.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Taskmonster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taskmonster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SiganbergMapsterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"siganberg.mapster.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VitaVitadbtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vita.vitadbtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markocoa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markocoa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NickmkkSnitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nickmkk.snitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpiderlyProjectinitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spiderly.projectinitializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xls2sql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xls2sql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScenegateHinoxUtils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scenegate.hinox.utils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JguzdvJsonmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jguzdv.jsonmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WolfMetalworkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wolf.metalwork.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SecurelinkShortener(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"securelink.shortener {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuget-merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmusdiGherkintomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smusdi.gherkintomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JoerageNulink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"joerage.nulink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Send2watched(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"_send2watched {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NventiveNugetUpdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nventive.nuget.updater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gactool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gactool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitsmimesign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitsmimesign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Powershell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"powershell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubtesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubtesttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githours(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githours {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowHologramViewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.hologram.viewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitKey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-key {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitKeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-keeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitImport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-import {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GreenheckSn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greenheck.sn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubverify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubverify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GunchartedPackageupdaterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"guncharted.packageupdater.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Giteenote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"giteenote {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MediatorregistrationsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mediatorregistrations.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GfMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gf.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GelbermLoadelastic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gelberm-loadelastic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetutilsToolRestore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetutils.tool.restore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PockProgrammingGuidMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pock-programming.guid-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenerateNewGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generate-new-guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SemanticreleaseGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"semanticrelease.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GsuuonToolGpt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gsuuon.tool.gpt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MacrosourceGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"macrosource.guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitloom(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitloom {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitignorerer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitignorerer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Randomguid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"randomguid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MercanPassgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mercan.passgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SaigonmioGenerata(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saigonmio.generata {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Youtubesubtitlesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"youtubesubtitlesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mygitnugget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mygitnugget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Miguan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"miguan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Showgroffename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"showgroffename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZebbleSchema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zebble-schema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZebbleImage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zebble-image {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PsimsaGitrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"psimsa.gitrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zdjgeneraltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zdjgeneraltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XdkGenerators(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xdk.generators {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SnappytoolPwdgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snappytool.pwdgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Robotraconteurwebgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robotraconteurwebgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToyStoresystemGeneric(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toy_storesystem.generic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Retro(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"retro {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VsMsbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vs-msbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetrepackTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetrepack.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stein(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stein {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MmlibToolsTranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mmlib.tools.translator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Toitnups(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toitnups {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qcg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qcg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vsmachelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vsmachelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}