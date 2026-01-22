using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T SaturnCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"saturn.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PylonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pylon-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kustomizeconfigmapgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kustomizeconfigmapgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TocsoftKubeconnectTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tocsoft.kubeconnect.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CommunityPowertoysRunPluginLint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"community.powertoys.run.plugin.lint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodecraftDevelopment(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecraft.development {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VellumCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vellum-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CommonUpdateManual(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"common.update.manual {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cursormcpmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cursormcpmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LdtkmonogameCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ldtkmonogame.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xml2docCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xml2doc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HavitDataEntityframeworkcoreCodegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"havit.data.entityframeworkcore.codegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QueilGmoxDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"queil.gmox.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WechatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wechat.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coverageconvertor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coverageconvertor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Corescanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corescanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqldataConsoleTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqldata.console.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MikenakisSvgconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mikenakis.svgconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusFiledownloaderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.filedownloader.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DngluaCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnglua.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CuginitechGzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cuginitech.gzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cilout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cilout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkSendcommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.sendcommand {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Czglsysteminfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"czglsysteminfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FirefliesGraphqlClientConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fireflies.graphql.client.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cargenimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cargenimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cargenmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cargenmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cyberdllprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cyberdllprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DccsLocalizedstringProjectresourcecreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dccs.localizedstring.projectresourcecreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Confluencemarkdownpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"confluencemarkdownpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConfigvalidatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"configvalidator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DimeSchedulerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dime.scheduler.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ColeKeyVaultDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cole.key-vault-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeployfCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deployf.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugettier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugettier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConventionalcommitslinterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conventionalcommitslinter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LmondeilCliCosmosdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lmondeil.cli.cosmosdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UpdateLocalNugetCache(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"update-local-nuget-cache {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sslcachenet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sslcachenet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GoogleCloudToolsDocuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"google.cloud.tools.docuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Castor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"castor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ClickhouseMigrateCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clickhouse.migrate.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DhiPlatformCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dhi.platform.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Code2pdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"code2pdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CeruleanCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cerulean.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRiderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-rider-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MspackProcessorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mspack.processor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T D365odatacsdlshortener(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"d365odatacsdlshortener {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CertficateManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"certficate-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QingshanCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qingshan.codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KnapcodeCertificateextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"knapcode.certificateextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyfxToolsDevcmds(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyfx.tools.devcmds {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uwebservercert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uwebservercert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Czglsys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"czglsys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cadence(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cadence {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SensenetIoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sensenet.io.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JwtCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jwt-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QbDotnetcoreinstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qb.dotnetcoreinstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HyperbeeXsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hyperbee.xs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Doctestcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doctestcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Traduoracli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"traduoracli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusSynctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.synctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CownxuSourcecode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cownxu.sourcecode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypealizrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typealizr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CegoStack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cego-stack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LpainsDocumorphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lpains.documorph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NmbOnlineradioConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nmb.onlineradio.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PingmintCodegenJson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pingmint.codegen.json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnmangoTdlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unmango.tdl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Il2careertoolset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"il2careertoolset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Json2yaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"json2yaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ClitoolsJumplist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clitools.jumplist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RigiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rigi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cs2j(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cs2j {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deadcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deadcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetConfigtransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-configtransform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Configgrabber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"configgrabber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EcryptoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ecrypto.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csipfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csipfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coaget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coaget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodeworxPackageversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codeworx.packageversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemaconsultingSpdxtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demaconsulting.spdxtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JrevoltYamlsecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jrevolt.yamlsecrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemaconsultingPandoctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demaconsulting.pandoctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctonautsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octonauts.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genmy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genmy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Huiyuanai709Cqrs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"huiyuanai709.cqrs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tuscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tuscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Customcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"customcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbenumcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbenumcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimcimGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simcim.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Usynctriggercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"usynctriggercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Convertpdf2png(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"convertpdf2png {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesPlconnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.plconnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gtfsxlsxcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gtfsxlsxcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CanpolatLipsum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"canpolat.lipsum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CaligoSqlgenerateupdatescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"caligo.sqlgenerateupdatescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DoinkChangelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"doink.changelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T InvoicekitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"invoicekit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}