using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Trxml2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxml2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Blops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LinuxDevCerts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"linux-dev-certs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RstolsmarkEncryptiontool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rstolsmark.encryptiontool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EvolveTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"evolve.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctopusOctonotesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octopus.octonotes.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StatesmithCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"statesmith.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DosCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dos.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Identifiergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"identifiergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BlazoniaComponentgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazonia.componentgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-csi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wham(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wham {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-vs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kampose(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kampose {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Geminittscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geminittscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZstackToolsAuthssh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zstack.tools.authssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fifthatuniversity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fifthatuniversity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cloudatuniversityfourhtxdzzcyber1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudatuniversityfourhtxdzzcyber1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTrxMerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-trx-merge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DarkxahtepCompressedstaticfilesTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"darkxahtep.compressedstaticfiles.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetConfig2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-config2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProyectoDeArchivosTutorial(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proyecto_de_archivos.tutorial {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LegerityUnoPageobjectgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"legerity.uno.pageobjectgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JihadkhawajaMcpFilesystem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jihadkhawaja.mcp.filesystem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JtestCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jtest.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZstackToolsAutossh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zstack.tools.autossh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZyjkAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zyjk.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command X(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"x {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HexmasterCodingguidelinesMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hexmaster.codingguidelines.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitgood(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitgood {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bellatrixcloudtestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bellatrixcloudtestrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ComZengConsoleAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"com.zeng.console.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FvneverDotnetauthors(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fvnever.dotnetauthors {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fileandfoldergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fileandfoldergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HackedbrainIkspozCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hackedbrain.ikspoz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PrstatsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"prstats-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-file {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SquigglecopTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"squigglecop.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RouteGeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"route.generator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToptenNvpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topten.nvpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JkulubyaDotnetHashIdentity(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jkulubya.dotnet.hash-identity {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElectronnetCliHotfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"electronnet.cli-hotfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartsqlDataconnector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartsql.dataconnector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IonpathCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ionpath.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetResteaseclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-resteaseclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenapiTests(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapi-tests {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HexmasterDesignguidelinesServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hexmaster.designguidelines.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Detectduplicates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"detectduplicates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ExploreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"explore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dnzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpserverEverything(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpserver.everything {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloudawesomeFolktuneReviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloudawesome.folktune.reviewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitcommands(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitcommands {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swaggermerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swaggermerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MakspllPathfinder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"makspll.pathfinder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qlubuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qlubuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DarkpatternsOpenapicodegenClientTypescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"darkpatterns.openapicodegen.client.typescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sfextract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sfextract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RepoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"repo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fshadeaot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fshadeaot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsFileutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.fileutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GraphqlclientgeneratorToolSimplified(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"graphqlclientgenerator.tool.simplified {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mdrive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mdrive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Typedependencies(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typedependencies {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharpdetect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpdetect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Makingmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"makingmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JihadkhawajaMcpDevops(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jihadkhawaja.mcp.devops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetBundlingtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-bundlingtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tokenkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tokenkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Quickencrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quickencrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomwareTapir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomware.tapir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Eventgridpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eventgridpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Swedishtestssn(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swedishtestssn {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Refdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"refdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpencertserverEstTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opencertserver.est.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RenameFigmaIcons(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rename-figma-icons {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LittlelittlecloudStepwiseGallery(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"littlelittlecloud.stepwise.gallery {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VkproxyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vkproxy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetmove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetmove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wikipagestatsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wikipagestatsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trparse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trparse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DvoituronDevopsProjectstatus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dvoituron.devops.projectstatus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShengJieSamplemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sheng-jie.samplemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trxgrep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxgrep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RopNugetpublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rop.nugetpublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMlgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mlgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcpclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DvoituronToolsSqltracegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dvoituron.tools.sqltracegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mathmohmedazoz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mathmohmedazoz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MdStdoutCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"md.stdout.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FetchbannerlordversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fetchbannerlordversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodebridgeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codebridge.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GroupdocsMetadataCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"groupdocs.metadata-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Escapethelabgame(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"escapethelabgame {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetforunityCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetforunity.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NeuromcpSqlserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"neuromcp.sqlserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cellpilotmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cellpilotmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetupdatebot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetupdatebot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitForest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-forest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}