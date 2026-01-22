using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Project2015to2017Migrate2019Tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"project2015to2017.migrate2019.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UndertestFeaturetransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"undertest.featuretransform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KafkaContextCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kafka.context.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetJdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-jdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DankuCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"danku.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dcmfind(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dcmfind {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JoysoftwareNetdaemonHassmodelCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"joysoftware.netdaemon.hassmodel.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ButrNexusuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"butr.nexusuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codebleach(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codebleach {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trperf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trperf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XunitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xunit-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hawaii(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hawaii {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zipsrc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zipsrc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe12netxslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe12netxslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConanyaoSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conanyao.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MermaidGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mermaid-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TaigaMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taiga-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SundewPackagingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sundew.packaging.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dcmorganize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dcmorganize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Keypressprocesstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"keypressprocesstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EirMfsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eir.mfsh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DolittleElog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dolittle.elog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PengChengSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"peng-cheng.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GroupdocsConversionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"groupdocs.conversion-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NunitRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nunit.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Oraclecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oraclecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Speedgrapher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"speedgrapher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmithyCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smithy-csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mockaco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mockaco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CeleritasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"celeritas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DurabletaskMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"durabletask.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypedsignalrClientTypescriptGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typedsignalr.client.typescript.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codegentools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codegentools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nexusuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nexusuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Samplemcpserver1275706970(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samplemcpserver1275706970 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lgn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lgn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Meissaserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meissaserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nvmfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nvmfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcpproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhotoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"photo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mazweathermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mazweathermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Todo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"todo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilIdlimporterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sil.idlimporter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitFlowVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-flow-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ExceldnaUnpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"exceldna-unpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YardarmCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yardarm.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trinsert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trinsert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vcdg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vcdg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsBiliutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.biliutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IvyConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ivy.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cryptofuturesmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cryptofuturesmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsPackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.packager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MonkeyloaderReferencepackagegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monkeyloader.referencepackagegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Odataexamplegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"odataexamplegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NallHangfiremcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nall.hangfiremcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NerdbankDotnetrepotools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nerdbank.dotnetrepotools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCcvarn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ccvarn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Podcastmetadatagenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"podcastmetadatagenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githublabelsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githublabelsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GetweatherinsightsTalatiMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"getweatherinsights.talati.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Compatibilitychecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"compatibilitychecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StudioleOrbit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"studiole.orbit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codewenmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codewenmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nppe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nppe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetTry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet-try {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MirangoLicensetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mirango.licensetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilNugetcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sil.nugetcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lunet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lunet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SharpupdaterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpupdater.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gamebundle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gamebundle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlnetWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet-win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Casidotestmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"casidotestmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trstrip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trstrip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YuniqlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yuniql.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RappajiSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rappaji.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KafkaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kafka-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NethereumGeneratorConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nethereum.generator.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FarkleTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"farkle.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe11netxslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe11netxslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BannerlordChangelogparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bannerlord.changelogparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElectronsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"electronsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saxonhe12netxquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saxonhe12netxquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlserverlocalmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlserverlocalmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Weathermcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"weathermcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Net2typescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"net2typescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Perla(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"perla {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nupkgversionextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nupkgversionextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CynosuraStudioClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cynosura.studio.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ExperimentalFakeserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"experimental.fakeserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NexusTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nexus-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Terminalguidesigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"terminalguidesigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSlnmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-slnmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElastacloudTwinmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elastacloud.twinmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugone(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugone {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pgsql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pgsql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}