using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Project2015to2017Migrate2019Tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"project2015to2017.migrate2019.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UndertestFeaturetransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"undertest.featuretransform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KafkaContextCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kafka.context.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetJdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-jdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DankuCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"danku.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dcmfind(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dcmfind {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JoysoftwareNetdaemonHassmodelCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"joysoftware.netdaemon.hassmodel.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ButrNexusuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"butr.nexusuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codebleach(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codebleach {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trperf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trperf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XunitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xunit-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hawaii(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hawaii {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zipsrc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zipsrc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe12netxslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe12netxslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConanyaoSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conanyao.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MermaidGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mermaid-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TaigaMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taiga-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SundewPackagingTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sundew.packaging.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dcmorganize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dcmorganize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Keypressprocesstool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"keypressprocesstool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EirMfsh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eir.mfsh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DolittleElog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dolittle.elog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PengChengSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"peng-cheng.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GroupdocsConversionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"groupdocs.conversion-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NunitRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nunit.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Oraclecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oraclecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Speedgrapher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"speedgrapher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmithyCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smithy-csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mockaco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mockaco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CeleritasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"celeritas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DurabletaskMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"durabletask.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypedsignalrClientTypescriptGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typedsignalr.client.typescript.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codegentools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codegentools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nexusuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nexusuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Samplemcpserver1275706970(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samplemcpserver1275706970 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lgn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lgn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Meissaserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meissaserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nvmfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nvmfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcpproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhotoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"photo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mazweathermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mazweathermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Todo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"todo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilIdlimporterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sil.idlimporter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitFlowVersion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-flow-version {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ExceldnaUnpack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"exceldna-unpack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YardarmCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yardarm.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trinsert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trinsert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vcdg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vcdg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsBiliutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.biliutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IvyConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivy.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cryptofuturesmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cryptofuturesmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsPackager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.packager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MonkeyloaderReferencepackagegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monkeyloader.referencepackagegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Odataexamplegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"odataexamplegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NallHangfiremcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nall.hangfiremcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NerdbankDotnetrepotools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nerdbank.dotnetrepotools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCcvarn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ccvarn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trreplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trreplace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Podcastmetadatagenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"podcastmetadatagenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githublabelsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githublabelsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GetweatherinsightsTalatiMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"getweatherinsights.talati.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Compatibilitychecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"compatibilitychecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StudioleOrbit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"studiole.orbit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codewenmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codewenmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nppe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nppe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetTry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet-try {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MirangoLicensetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mirango.licensetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilNugetcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sil.nugetcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lunet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lunet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SharpupdaterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpupdater.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gamebundle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gamebundle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlnetWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet-win-x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Casidotestmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"casidotestmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trstrip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trstrip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YuniqlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yuniql.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RappajiSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rappaji.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KafkaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kafka-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NethereumGeneratorConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nethereum.generator.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FarkleTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"farkle.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe11netxslt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe11netxslt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BannerlordChangelogparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bannerlord.changelogparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElectronsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"electronsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saxonhe12netxquery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saxonhe12netxquery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlserverlocalmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlserverlocalmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Weathermcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"weathermcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Net2typescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"net2typescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Perla(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"perla {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nupkgversionextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nupkgversionextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CynosuraStudioClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cynosura.studio.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ExperimentalFakeserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"experimental.fakeserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NexusTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nexus-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Terminalguidesigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"terminalguidesigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSlnmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-slnmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElastacloudTwinmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"elastacloud.twinmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugone(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugone {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pgsql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pgsql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}