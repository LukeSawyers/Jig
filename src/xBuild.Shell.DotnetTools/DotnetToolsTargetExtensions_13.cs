using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Trxml2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxml2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Blops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LinuxDevCerts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"linux-dev-certs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RstolsmarkEncryptiontool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rstolsmark.encryptiontool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EvolveTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"evolve.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctopusOctonotesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octopus.octonotes.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StatesmithCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"statesmith.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DosCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dos.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Identifiergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"identifiergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BlazoniaComponentgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazonia.componentgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-csi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wham(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wham {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-vs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kampose(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kampose {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Geminittscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geminittscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZstackToolsAuthssh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zstack.tools.authssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fifthatuniversity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fifthatuniversity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cloudatuniversityfourhtxdzzcyber1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudatuniversityfourhtxdzzcyber1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrxMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-trx-merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DarkxahtepCompressedstaticfilesTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"darkxahtep.compressedstaticfiles.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetConfig2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-config2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProyectoDeArchivosTutorial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proyecto_de_archivos.tutorial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LegerityUnoPageobjectgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"legerity.uno.pageobjectgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JihadkhawajaMcpFilesystem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jihadkhawaja.mcp.filesystem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JtestCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jtest.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZstackToolsAutossh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zstack.tools.autossh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZyjkAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zyjk.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T X(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"x {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HexmasterCodingguidelinesMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hexmaster.codingguidelines.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitgood(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitgood {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bellatrixcloudtestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bellatrixcloudtestrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ComZengConsoleAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"com.zeng.console.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FvneverDotnetauthors(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fvnever.dotnetauthors {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fileandfoldergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fileandfoldergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HackedbrainIkspozCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hackedbrain.ikspoz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PrstatsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"prstats-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-file {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SquigglecopTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"squigglecop.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RouteGeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"route.generator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToptenNvpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topten.nvpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JkulubyaDotnetHashIdentity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jkulubya.dotnet.hash-identity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ElectronnetCliHotfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"electronnet.cli-hotfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartsqlDataconnector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartsql.dataconnector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IonpathCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ionpath.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetResteaseclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-resteaseclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenapiTests(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapi-tests {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HexmasterDesignguidelinesServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hexmaster.designguidelines.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Detectduplicates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"detectduplicates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ExploreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"explore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dnzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpserverEverything(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpserver.everything {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloudawesomeFolktuneReviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloudawesome.folktune.reviewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitcommands(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitcommands {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swaggermerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swaggermerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MakspllPathfinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"makspll.pathfinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qlubuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qlubuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DarkpatternsOpenapicodegenClientTypescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"darkpatterns.openapicodegen.client.typescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sfextract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sfextract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RepoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"repo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fshadeaot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fshadeaot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsFileutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.fileutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GraphqlclientgeneratorToolSimplified(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"graphqlclientgenerator.tool.simplified {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mdrive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mdrive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Typedependencies(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typedependencies {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharpdetect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpdetect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Makingmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"makingmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JihadkhawajaMcpDevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jihadkhawaja.mcp.devops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBundlingtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-bundlingtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tokenkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tokenkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Quickencrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quickencrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomwareTapir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomware.tapir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Eventgridpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eventgridpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Swedishtestssn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swedishtestssn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Refdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"refdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpencertserverEstTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opencertserver.est.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RenameFigmaIcons(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rename-figma-icons {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LittlelittlecloudStepwiseGallery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"littlelittlecloud.stepwise.gallery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VkproxyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vkproxy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetmove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetmove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wikipagestatsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wikipagestatsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trparse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trparse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DvoituronDevopsProjectstatus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dvoituron.devops.projectstatus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShengJieSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sheng-jie.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trxgrep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxgrep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RopNugetpublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rop.nugetpublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMlgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mlgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcpclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DvoituronToolsSqltracegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dvoituron.tools.sqltracegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mathmohmedazoz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mathmohmedazoz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MdStdoutCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"md.stdout.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FetchbannerlordversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fetchbannerlordversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodebridgeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codebridge.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GroupdocsMetadataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"groupdocs.metadata-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Escapethelabgame(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"escapethelabgame {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetforunityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetforunity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NeuromcpSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"neuromcp.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cellpilotmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cellpilotmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetupdatebot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetupdatebot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitForest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-forest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}