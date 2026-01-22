using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Avalanche(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avalanche {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilkyfowlAvaloniaFuncuiLiveviewAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"silkyfowl.avalonia.funcui.liveview.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AziotedgeModinit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aziotedge-modinit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdrTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adr-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlnetLinuxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet-linux-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AninoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anino.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MlnetWinArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mlnet-win-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Perfavore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"perfavore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SharpfuzzCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharpfuzz.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azdtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azdtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AngrywaspElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"angrywasp.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AkadeSnippetlink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"akade.snippetlink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposePsdCliNlpEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.psd.cli.nlp.editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KuiperzonePupnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kuiperzone.pupnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AllowedSvelteNetTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"allowed.svelte.net.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WebapiclientcoreOpenapiSourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webapiclientcore.openapi.sourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MiccoreNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"miccore.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposePsdCliResize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.psd.cli.resize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolurumStaalai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solurum.staalai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RegulusApplicationProtocolCodewriter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regulus.application.protocol.codewriter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArmarinhoNfeconverterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"armarinho.nfeconverter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TryagiAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tryagi.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposePsdCliConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.psd.cli.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlisalabRconcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alisalab.rconcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YetanotheraiGodotResourcecheckerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yetanotherai.godot.resourcechecker.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetToolsOutdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tools-outdated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MobileinspectorToolsAddview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mobileinspector.tools.addview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AppledevMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appledev.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CratisArcProxygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cratis.arc.proxygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposePsdCliExport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.psd.cli.export {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AhmuCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ahmu.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azuremigrateanalysisweb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuremigrateanalysisweb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Au(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"au {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StefandevoGenymanXamarinassets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stefandevo.genyman.xamarinassets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetUserSecrets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-user-secrets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autopoint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autopoint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsynkronSwarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asynkron.swarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposePsdCliCrop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.psd.cli.crop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SucroseAvroCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sucrose.avro.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftFilelock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.filelock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmartersoftIdentityClientAssertionProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smartersoft.identity.client.assertion.proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LindexiToolAutosyncgitrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lindexi.tool.autosyncgitrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IantabronMakegenericagain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"iantabron.makegenericagain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BepinexAssemblypublicizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bepinex.assemblypublicizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProactiveSharepointBuildConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proactive.sharepoint.build.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command S18AbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"s18.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Abt099Awskeygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"abt099.awskeygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ArkahnatDotnetOutdatedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arkahnat.dotnet-outdated-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BoostTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"boost.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeSlidesConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.slides.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AutoBuildGolangReleases(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"auto-build-golang-releases {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azuredevopspipelinelibrarycompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuredevopspipelinelibrarycompare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FrenetischapplaudierendBenchy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"frenetischapplaudierend.benchy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Synver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"synver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetarchive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetarchive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcparray2any(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcparray2any {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azfwrmgr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azfwrmgr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Asitcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asitcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ath {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Assemblychecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"assemblychecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Internalaccessiblecompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"internalaccessiblecompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autodocx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autodocx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IoGithubChristopherhxGharun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"io.github.christopherhx.gharun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AterEasyblog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ater.easyblog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaluxReleasesTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avalux.releases.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DaxVpaxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dax.vpax.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webapitoopenapireflector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webapitoopenapireflector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AelfDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aelf.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsaskitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asaskit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShuwenAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shuwen.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsposeImagingImageAlbum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspose.imaging.image-album {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MapsterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mapster.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JstAzuredevopscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jst.azuredevopscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlasdaircooperPasswordgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alasdaircooper.passwordgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimpleAcme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simple-acme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Autotyper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"autotyper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SavoniaAssignmentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"savonia.assignment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command BorsuksoftwareConicalToolsAwsdevicefarmresultsuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.awsdevicefarmresultsuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InsightarchitecturesToolsClonedynamodbtable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"insightarchitectures.tools.clonedynamodbtable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftSbomDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.sbom.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AntdesignCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"antdesign.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmwdMakedeb8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amwd.makedeb8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azuredevopstokengenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuredevopstokengenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FlubucoreTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flubucore.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LimeflightOpenapiDiffCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"limeflight.openapi.diff.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gen-api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azureactivedirectoryauthclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azureactivedirectoryauthclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AmwdMakedeb6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amwd.makedeb6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolslickAwsipchanger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toolslick.awsipchanger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonQuantbasedalignmentWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.quantbasedalignment_win_x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WalgelijkAssetpackagebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"walgelijk.assetpackagebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Atarilynxcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atarilynxcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PclmockCodegenerationConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pclmock.codegeneration.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azsqlidxmgr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azsqlidxmgr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NothrowAnnotate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nothrow.annotate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HexarcPactTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hexarc.pact.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AristurtledevToolsMgcbconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aristurtledev.tools.mgcbconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlauBotsayAlaubolatov(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alau.botsay.alaubolatov {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftAppmodernizationMcpserverDotnetMigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.appmodernization.mcpserver.dotnet.migration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Saturnagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saturnagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}