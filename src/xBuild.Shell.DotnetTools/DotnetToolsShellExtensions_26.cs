using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command GittaggerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gittagger.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codegentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codegentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnethttpsecuritycheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnethttpsecuritycheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XdevEasyversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xdev.easyversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SamhammerNet9Trxtohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samhammer.net9.trxtohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypedsqlClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typedsql.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xguid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xguid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetIl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-il {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zipcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zipcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Myage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntentSqlschemaextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intent.sqlschemaextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolFindbypkgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tool.findbypkgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Meditatr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meditatr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PierodetomiDotnetmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pierodetomi.dotnetmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Privatepdfconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"privatepdfconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xeod(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xeod {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Reflectionmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reflectionmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SuitcodeGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"suitcode.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ItnSnkutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"itn.snkutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Goli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"goli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command X509tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"x509tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bgpicturechanger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bgpicturechanger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KifaToolsYoutubeutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kifa.tools.youtubeutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bc_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FileDrill(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"file-drill {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GyppoLogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gyppo.logger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XfuncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xfunc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xfun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xfun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubsettingssync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubsettingssync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TestessentialsToolkitMockserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testessentials.toolkit.mockserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NightkToolbox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nightk.toolbox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetLingohub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-lingohub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mustate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mustate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Glider(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"glider {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FileinformationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fileinformation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LifxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lifx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetShaderc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-shaderc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Utf8clip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"utf8clip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KnapcodeProtorebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"knapcode.protorebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPrune(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-prune {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csxml2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csxml2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetLighting(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-lighting {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projectlauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectlauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dockgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dockgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command R3eWebguiDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"r3e.webgui.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CapIpinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cap.ipinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Evo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"evo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Strykerrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"strykerrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNugetSearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nuget-search {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KizunaNet6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kizuna.net6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Twitterdumpwhole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"twitterdumpwhole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZajdaRoslyncodegencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zajda.roslyncodegencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotngetInitadamtki(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnget-initadamtki {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cleangen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cleangen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TimheuerSimplemcptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timheuer.simplemcptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FtDatafangstFtturbo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ft.datafangst.ftturbo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Freezeframe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"freezeframe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Schemamagic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"schemamagic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Unitysentinel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unitysentinel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsMsteamsworkflowwebhookcard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.msteamsworkflowwebhookcard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Onefunction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"onefunction {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Explorateurdll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"explorateurdll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetunused(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetunused {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Portlogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"portlogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FerramentasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ferramentas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codediagramcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codediagramcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WestwindBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"westwind.base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubsecretssync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubsecretssync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PgrokClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pgrok-client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Oggy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oggy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Centralpackagemanagementmigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"centralpackagemanagementmigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HimlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"himl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netframeworktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netframeworktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MoedimMapperMigrationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moedim.mapper.migration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FelixPackage20230222Test(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"felix.package.20230222.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SbomLicenses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sbom.licenses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OcTcpnscannerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oc.tcpnscanner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kubernetessecretdecode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kubernetessecretdecode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Opgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkynetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skynet-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DvoituronToolsSwagger2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dvoituron.tools.swagger2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NugetforunityCliNet5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetforunity.cli.net5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcoreOfficeaddinToolbox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcore-officeaddin-toolbox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntentRoslynweaversanitizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intent.roslynweaversanitizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SofiawlLearnerplusplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sofiawl-learnerplusplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharpidious(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpidious {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DamirscornerClockifyexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"damirscorner.clockifyexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SanetToolsWixComponentsupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sanet.tools.wix.componentsupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JdMsbuildFluentCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jd.msbuild.fluent.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEnv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codecuisine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecuisine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DependabotBot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependabot-bot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}