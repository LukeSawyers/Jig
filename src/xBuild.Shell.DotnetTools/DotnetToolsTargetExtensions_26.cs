using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T GittaggerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gittagger.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codegentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codegentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnethttpsecuritycheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnethttpsecuritycheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XdevEasyversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xdev.easyversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SamhammerNet9Trxtohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samhammer.net9.trxtohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypedsqlClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typedsql.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xguid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xguid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetIl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-il {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zipcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zipcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Myage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntentSqlschemaextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intent.sqlschemaextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolFindbypkgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tool.findbypkgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Meditatr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meditatr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PierodetomiDotnetmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pierodetomi.dotnetmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Privatepdfconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"privatepdfconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xeod(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xeod {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Reflectionmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reflectionmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SuitcodeGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"suitcode.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ItnSnkutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"itn.snkutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Goli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"goli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T X509tool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"x509tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bgpicturechanger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bgpicturechanger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotty(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotty {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KifaToolsYoutubeutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kifa.tools.youtubeutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bc_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FileDrill(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"file-drill {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GyppoLogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gyppo.logger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XfuncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xfunc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xfun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xfun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubsettingssync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubsettingssync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TestessentialsToolkitMockserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testessentials.toolkit.mockserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NightkToolbox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nightk.toolbox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetLingohub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-lingohub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mustate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mustate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Glider(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"glider {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FileinformationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fileinformation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LifxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lifx.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetShaderc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-shaderc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Utf8clip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"utf8clip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KnapcodeProtorebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"knapcode.protorebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPrune(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-prune {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csxml2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csxml2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetLighting(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-lighting {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projectlauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectlauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dockgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dockgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T R3eWebguiDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"r3e.webgui.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CapIpinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cap.ipinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Evo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"evo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Strykerrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"strykerrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNugetSearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nuget-search {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KizunaNet6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kizuna.net6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Twitterdumpwhole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"twitterdumpwhole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZajdaRoslyncodegencli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zajda.roslyncodegencli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotngetInitadamtki(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnget-initadamtki {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cleangen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cleangen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TimheuerSimplemcptool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timheuer.simplemcptool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FtDatafangstFtturbo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ft.datafangst.ftturbo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Freezeframe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"freezeframe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotbump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotbump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Schemamagic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"schemamagic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Unitysentinel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unitysentinel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsMsteamsworkflowwebhookcard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.msteamsworkflowwebhookcard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Onefunction(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"onefunction {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Explorateurdll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"explorateurdll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetunused(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetunused {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Portlogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"portlogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FerramentasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ferramentas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codediagramcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codediagramcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WestwindBase64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"westwind.base64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubsecretssync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubsecretssync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PgrokClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pgrok-client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Oggy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oggy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Centralpackagemanagementmigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"centralpackagemanagementmigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HimlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"himl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netframeworktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netframeworktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MoedimMapperMigrationTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moedim.mapper.migration.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FelixPackage20230222Test(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"felix.package.20230222.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SbomLicenses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sbom.licenses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OcTcpnscannerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oc.tcpnscanner.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kubernetessecretdecode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kubernetessecretdecode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dll(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dll {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Opgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkynetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skynet-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tooling(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tooling {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DvoituronToolsSwagger2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dvoituron.tools.swagger2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NugetforunityCliNet5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetforunity.cli.net5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcoreOfficeaddinToolbox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcore-officeaddin-toolbox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntentRoslynweaversanitizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intent.roslynweaversanitizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SofiawlLearnerplusplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sofiawl-learnerplusplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharpidious(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpidious {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DamirscornerClockifyexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"damirscorner.clockifyexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SanetToolsWixComponentsupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sanet.tools.wix.componentsupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JdMsbuildFluentCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jd.msbuild.fluent.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEnv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-env {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codecuisine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecuisine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DependabotBot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependabot-bot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}