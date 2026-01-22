using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Cdp4CometBe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cdp4-comet-be {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tring(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tring {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RazorconsoleGallery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"razorconsole.gallery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Motif(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"motif {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloudflareDnsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudflare-dnsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Huaweistoragemanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"huaweistoragemanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElskomNetCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elskom.net.check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoscineRepositorymanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coscine.repositorymanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVersioninfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-versioninfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NewUi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"new-ui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CorenotifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corenotify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GodeltechCodereviewOrchestrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"godeltech.codereview.orchestrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOpenapiMerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-openapi-merger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShannonFano(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shannon-fano {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloudburstBuildtoolsDotnettools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudburst.buildtools.dotnettools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Peer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"peer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LizTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"liz.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PackscanTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packscan.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Phonecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phonecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packageguard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packageguard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetsdkhelpers(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetsdkhelpers {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Moscownight(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moscownight {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Resxscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resxscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcdg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcdg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testeroid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testeroid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Logiplugintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"logiplugintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSlugci(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-slugci {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PandaIl2cppinteropCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"panda.il2cppinterop.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Doclanguagetranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doclanguagetranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCnblog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cnblog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsliveCliTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fslive-cli-test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XslTransformer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xsl.transformer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qleatherman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qleatherman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetefmigrationssquash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetefmigrationssquash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsNugetchangeversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetchangeversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KgenControlcatalogstandaloneDesktop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kgen.controlcatalogstandalone.desktop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Schema2code(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"schema2code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Marain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PergerchFocusinittest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pergerch.focusinittest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DjohnnieCustomCoverageReportgeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"djohnnie-custom-coverage-reportgenerator-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSprite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sprite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gsg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gsg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Contractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"contractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HeleonixBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"heleonix.build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WaInfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wa-info {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Boguscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"boguscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zipextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zipextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codelines(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codelines {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetLabodotnettestresultsparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-labodotnettestresultsparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GbaseDotnetDevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gbase.dotnet-devops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sdkgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sdkgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unlockfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unlockfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sofiawl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sofiawl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Configfern(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"configfern {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Butlerdotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"butlerdotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Installutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"installutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rpcnetgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rpcnetgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PrinciplestudiosCodefixes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"principlestudios.codefixes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetaphorStrawberryshakeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metaphor.strawberryshake.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KewebBatiscafo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"keweb.batiscafo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PromoteNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"promote.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Il2cppinteropCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"il2cppinterop.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RadishtoolsGitfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"radishtools.gitfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SuperjmnDotnetSsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"superjmn.dotnet.ssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCcc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ccc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetpackagewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetpackagewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypescriptdeclarationsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typescriptdeclarations.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wordypkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wordypkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MermaidGraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mermaid-graph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqldatabaseGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqldatabase.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsValidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VstsPrTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vsts-pr-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnbreakableToolsPolicyreportNet5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unbreakable.tools.policyreport.net5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Starrysky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"starrysky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetutilsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetutils.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SamhammerTrxtohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samhammer.trxtohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trunfoldlit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trunfoldlit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesNavencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.navencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Salesforcecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"salesforcecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FormatLines(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"format-lines {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SchematypistCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"schematypist.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trbankdata(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trbankdata {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hasso(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hasso {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DubniumCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dubnium-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sizoscope(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sizoscope {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BootstrapblazorCssbundler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bootstrapblazor.cssbundler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xtraq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xtraq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NtersolScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ntersol.scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DamikunElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"damikun.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetpushtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetpushtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DataflowkitDbmigratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dataflowkit.dbmigrator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openvsixsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openvsixsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}