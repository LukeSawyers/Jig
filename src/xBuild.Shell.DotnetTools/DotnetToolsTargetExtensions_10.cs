using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T MobileactGitealabelsetupper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobileact.gitealabelsetupper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OprotoLambdaOpenapiMergeTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oproto.lambda.openapi.merge.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vbamc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vbamc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ilc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ilc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVersionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-version-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetpackagingConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetpackaging.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Generateverticalslicearchitecture(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generateverticalslicearchitecture {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IvarneAltinnTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivarne.altinn.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HbDaedalosContractArtisan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hb.daedalos.contract.artisan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DependencygraphApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependencygraph.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetpackagingDeployertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetpackaging.deployertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAlfrescoexecuteaction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.alfrescoexecuteaction {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sourcelink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sourcelink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ItglobalMarkdocsCommandlinetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"itglobal.markdocs.commandlinetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RopRoslynmacrosTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rop.roslynmacros.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRoundhouse(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-roundhouse {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Copydllsafterbuildlocaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"copydllsafterbuildlocaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonAdddeducedpeptides(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.adddeducedpeptides {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAiCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ai-core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TenogyToolsFluentmigratorAddmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tenogy.tools.fluentmigrator.addmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAssemblyversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.assemblyversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZycAutomationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zyc.automation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EpicchainSmartcontractAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"epicchain.smartcontract.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonAlignmentbasedquantification(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.alignmentbasedquantification {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Syncer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"syncer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CreateAspnetApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"create-aspnet-app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusCommandlineargsviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.commandlineargsviewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsharpFormattingCommandtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsharp.formatting.commandtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BadgieMigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"badgie.migrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFsharplint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-fsharplint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KgenAvaloniaChromedevtoolsdemo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kgen.avalonia.chromedevtoolsdemo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pub2arc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pub2arc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bytehide(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bytehide {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tyrannosaurustrx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tyrannosaurustrx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrx2sonarForkAllemann(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-trx2sonar-fork-allemann {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EirApibuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eir.apibuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Convertwebapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"convertwebapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PingmintOpenaiChat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pingmint.openai.chat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OneloginAws(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"onelogin-aws {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BonlivaConfigurationautobindertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bonliva.configurationautobindertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HotpotatoAspnetcoreHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hotpotato.aspnetcore.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-train {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Is4SfiConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"is4.sfi.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dynamicapiclientgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dynamicapiclientgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TestgenaiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testgenai.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OmniaAutocodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"omnia.autocodegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LuminaryFedCopy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"luminary.fed.copy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDevCerts(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dev-certs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuAllinone(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.allinone {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DoudCliEncryptDecryptAppsettings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doud.cli.encrypt.decrypt.appsettings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetJdtCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-jdt-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CorebddCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corebdd.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LrAiGit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lr-ai-git {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LiquibaseCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"liquibase.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAliyun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-aliyun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Exelauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"exelauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAesconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.aesconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProgrammeralJsonserializerregistrationgeneratorRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"programmeral.jsonserializerregistrationgenerator.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetReleaser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-releaser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikAspnetcorehtmlMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.aspnetcorehtml.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolitonsPostgresPgup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solitons.postgres.pgup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mediamigrate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mediamigrate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikAspnetcoretagMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.aspnetcoretag.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDynamodbLock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dynamodb-lock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bit76FluentmigratorToolAddmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bit76.fluentmigrator.tool.addmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GregXrmMcpAppmaker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greg.xrm.mcp.appmaker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenboxSimples3Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genbox.simples3.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ParticularAzuretableExport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"particular.azuretable.export {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OllieaveGitclisupersetConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ollieave.gitclisuperset.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Versionize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"versionize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UtherapiCommands(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"utherapi.commands {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAbbyypagecounter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.abbyypagecounter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LpainsAzdiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lpains.azdiff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SourceexpanderConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sourceexpander.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetmigrations8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetmigrations8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CompressedstaticfilesTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"compressedstaticfiles.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetariumScs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetarium-scs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReservoirdevsSwashbuckleAspnetcoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reservoirdevs.swashbuckle.aspnetcore.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DataatrRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dataatr.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-az {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BauerappsOpenapiGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bauerapps.openapi.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetazsync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetazsync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDynamicsBusinesscentralDevelopmentToolsLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dynamics.businesscentral.development.tools.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenapiToTerraform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapi-to-terraform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ComIvanmurzakUnityMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"com.ivanmurzak.unity.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TelerikAjaxMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"telerik.ajax.mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetarch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetarch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWadToCsv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-wad-to-csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DuotifyOpenaiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duotify.openai.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cocor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cocor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Config2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"config2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetsparkleupdaterToolsDsahelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netsparkleupdater.tools.dsahelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fakeserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fakeserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAddContent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-add-content {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xydocgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xydocgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomPowershell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.powershell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testconsoleappforclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testconsoleappforclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkAlfrescoaddgroup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.alfrescoaddgroup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetBlobToCsv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-blob-to-csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}