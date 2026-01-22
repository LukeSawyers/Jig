using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Avalanche(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avalanche {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilkyfowlAvaloniaFuncuiLiveviewAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"silkyfowl.avalonia.funcui.liveview.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AziotedgeModinit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aziotedge-modinit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdrTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adr-tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlnetLinuxArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet-linux-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AninoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anino.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MlnetWinArm64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mlnet-win-arm64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Perfavore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"perfavore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SharpfuzzCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharpfuzz.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azdtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azdtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AngrywaspElectronnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"angrywasp.electronnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AkadeSnippetlink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"akade.snippetlink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposePsdCliNlpEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.psd.cli.nlp.editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KuiperzonePupnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kuiperzone.pupnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AllowedSvelteNetTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"allowed.svelte.net.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WebapiclientcoreOpenapiSourcegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webapiclientcore.openapi.sourcegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MiccoreNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"miccore.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposePsdCliResize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.psd.cli.resize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolurumStaalai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solurum.staalai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RegulusApplicationProtocolCodewriter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regulus.application.protocol.codewriter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArmarinhoNfeconverterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"armarinho.nfeconverter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TryagiAi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tryagi.ai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposePsdCliConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.psd.cli.convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlisalabRconcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alisalab.rconcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YetanotheraiGodotResourcecheckerConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yetanotherai.godot.resourcechecker.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetToolsOutdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tools-outdated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MobileinspectorToolsAddview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobileinspector.tools.addview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AppledevMcpServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appledev.mcp.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CratisArcProxygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cratis.arc.proxygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposePsdCliExport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.psd.cli.export {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AhmuCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ahmu.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azuremigrateanalysisweb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuremigrateanalysisweb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Au(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"au {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StefandevoGenymanXamarinassets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stefandevo.genyman.xamarinassets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetUserSecrets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-user-secrets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autopoint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autopoint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsynkronSwarm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asynkron.swarm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposePsdCliCrop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.psd.cli.crop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SucroseAvroCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sucrose.avro.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftFilelock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.filelock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmartersoftIdentityClientAssertionProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smartersoft.identity.client.assertion.proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LindexiToolAutosyncgitrepo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lindexi.tool.autosyncgitrepo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IantabronMakegenericagain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"iantabron.makegenericagain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BepinexAssemblypublicizerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bepinex.assemblypublicizer.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProactiveSharepointBuildConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proactive.sharepoint.build.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T S18AbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"s18.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Abt099Awskeygenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"abt099.awskeygenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ArkahnatDotnetOutdatedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arkahnat.dotnet-outdated-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BoostTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"boost.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeSlidesConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.slides.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AutoBuildGolangReleases(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"auto-build-golang-releases {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azuredevopspipelinelibrarycompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuredevopspipelinelibrarycompare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FrenetischapplaudierendBenchy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"frenetischapplaudierend.benchy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Synver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"synver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetarchive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetarchive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcparray2any(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcparray2any {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azfwrmgr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azfwrmgr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Asitcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asitcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ath(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ath {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Assemblychecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"assemblychecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Internalaccessiblecompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"internalaccessiblecompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autodocx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autodocx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IoGithubChristopherhxGharun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"io.github.christopherhx.gharun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AterEasyblog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ater.easyblog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaluxReleasesTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avalux.releases.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DaxVpaxCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dax.vpax.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webapitoopenapireflector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webapitoopenapireflector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AelfDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aelf.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsaskitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asaskit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShuwenAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shuwen.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsposeImagingImageAlbum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspose.imaging.image-album {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MapsterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mapster.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JstAzuredevopscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jst.azuredevopscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlasdaircooperPasswordgeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alasdaircooper.passwordgenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimpleAcme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simple-acme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Autotyper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"autotyper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SavoniaAssignmentTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"savonia.assignment.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T BorsuksoftwareConicalToolsAwsdevicefarmresultsuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"borsuksoftware.conical.tools.awsdevicefarmresultsuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InsightarchitecturesToolsClonedynamodbtable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"insightarchitectures.tools.clonedynamodbtable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftSbomDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.sbom.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AntdesignCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"antdesign.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmwdMakedeb8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amwd.makedeb8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azuredevopstokengenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuredevopstokengenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FlubucoreTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flubucore.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LimeflightOpenapiDiffCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"limeflight.openapi.diff.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenApi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gen-api {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azureactivedirectoryauthclitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azureactivedirectoryauthclitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AmwdMakedeb6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amwd.makedeb6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolslickAwsipchanger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toolslick.awsipchanger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonQuantbasedalignmentWinX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.quantbasedalignment_win_x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WalgelijkAssetpackagebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"walgelijk.assetpackagebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Atarilynxcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atarilynxcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PclmockCodegenerationConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pclmock.codegeneration.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azsqlidxmgr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azsqlidxmgr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NothrowAnnotate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nothrow.annotate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HexarcPactTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hexarc.pact.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AristurtledevToolsMgcbconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aristurtledev.tools.mgcbconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlauBotsayAlaubolatov(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alau.botsay.alaubolatov {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftAppmodernizationMcpserverDotnetMigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.appmodernization.mcpserver.dotnet.migration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Saturnagent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saturnagent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}