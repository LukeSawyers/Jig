using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Cdp4CometBe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cdp4-comet-be {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tring(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tring {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RazorconsoleGallery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"razorconsole.gallery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Motif(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"motif {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloudflareDnsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudflare-dnsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Huaweistoragemanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"huaweistoragemanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElskomNetCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elskom.net.check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoscineRepositorymanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coscine.repositorymanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVersioninfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-versioninfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NewUi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"new-ui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CorenotifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"corenotify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GodeltechCodereviewOrchestrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"godeltech.codereview.orchestrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sema(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sema {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOpenapiMerger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-openapi-merger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShannonFano(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shannon-fano {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloudburstBuildtoolsDotnettools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudburst.buildtools.dotnettools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Peer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"peer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LizTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"liz.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PackscanTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packscan.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Phonecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phonecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packageguard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packageguard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetsdkhelpers(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetsdkhelpers {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Moscownight(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moscownight {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Resxscanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resxscanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcdg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcdg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testeroid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testeroid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Logiplugintool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"logiplugintool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSlugci(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-slugci {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PandaIl2cppinteropCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"panda.il2cppinterop.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Doclanguagetranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doclanguagetranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCnblog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cnblog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsliveCliTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fslive-cli-test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XslTransformer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xsl.transformer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qleatherman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qleatherman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetefmigrationssquash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetefmigrationssquash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsNugetchangeversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.nugetchangeversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KgenControlcatalogstandaloneDesktop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kgen.controlcatalogstandalone.desktop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Schema2code(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"schema2code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Marain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PergerchFocusinittest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pergerch.focusinittest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DjohnnieCustomCoverageReportgeneratorGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"djohnnie-custom-coverage-reportgenerator-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSprite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sprite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gsg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gsg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Contractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"contractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HeleonixBuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"heleonix.build {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WaInfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wa-info {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Boguscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"boguscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zipextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zipextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codelines(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codelines {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetLabodotnettestresultsparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-labodotnettestresultsparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GbaseDotnetDevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gbase.dotnet-devops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sdkgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sdkgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unlockfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unlockfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sofiawl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sofiawl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Configfern(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"configfern {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Butlerdotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"butlerdotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Installutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"installutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rpcnetgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rpcnetgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PrinciplestudiosCodefixes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"principlestudios.codefixes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetaphorStrawberryshakeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metaphor.strawberryshake.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KewebBatiscafo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"keweb.batiscafo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PromoteNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"promote.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Il2cppinteropCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"il2cppinterop.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RadishtoolsGitfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"radishtools.gitfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SuperjmnDotnetSsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"superjmn.dotnet.ssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCcc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ccc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetpackagewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetpackagewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypescriptdeclarationsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typescriptdeclarations.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wordypkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wordypkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MermaidGraph(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mermaid-graph {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqldatabaseGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqldatabase.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsValidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VstsPrTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vsts-pr-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnbreakableToolsPolicyreportNet5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unbreakable.tools.policyreport.net5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Starrysky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"starrysky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetutilsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetutils.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SamhammerTrxtohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samhammer.trxtohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trunfoldlit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trunfoldlit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesNavencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.navencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Salesforcecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"salesforcecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FormatLines(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"format-lines {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SchematypistCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"schematypist.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trbankdata(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trbankdata {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hasso(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hasso {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DubniumCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dubnium-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sizoscope(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sizoscope {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BootstrapblazorCssbundler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bootstrapblazor.cssbundler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xtraq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xtraq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NtersolScaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ntersol.scaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DamikunElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"damikun.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetpushtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetpushtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DataflowkitDbmigratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dataflowkit.dbmigrator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openvsixsigntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openvsixsigntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}