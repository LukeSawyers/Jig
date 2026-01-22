using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command SaturnCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"saturn.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PylonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pylon-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kustomizeconfigmapgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kustomizeconfigmapgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TocsoftKubeconnectTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tocsoft.kubeconnect.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CommunityPowertoysRunPluginLint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"community.powertoys.run.plugin.lint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodecraftDevelopment(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecraft.development {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VellumCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vellum-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CommonUpdateManual(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"common.update.manual {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cursormcpmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cursormcpmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LdtkmonogameCodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ldtkmonogame.codegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xml2docCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xml2doc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HavitDataEntityframeworkcoreCodegeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"havit.data.entityframeworkcore.codegenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QueilGmoxDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"queil.gmox.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WechatCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wechat.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coverageconvertor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coverageconvertor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Corescanner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"corescanner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqldataConsoleTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqldata.console.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MikenakisSvgconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mikenakis.svgconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusFiledownloaderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.filedownloader.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DngluaCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnglua.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CuginitechGzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cuginitech.gzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cilout(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cilout {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkSendcommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.sendcommand {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Czglsysteminfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"czglsysteminfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FirefliesGraphqlClientConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fireflies.graphql.client.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cargenimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cargenimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cargenmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cargenmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cyberdllprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cyberdllprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DccsLocalizedstringProjectresourcecreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dccs.localizedstring.projectresourcecreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Confluencemarkdownpublisher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"confluencemarkdownpublisher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConfigvalidatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"configvalidator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DimeSchedulerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dime.scheduler.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ColeKeyVaultDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cole.key-vault-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeployfCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deployf.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugettier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugettier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConventionalcommitslinterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conventionalcommitslinter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LmondeilCliCosmosdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lmondeil.cli.cosmosdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UpdateLocalNugetCache(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"update-local-nuget-cache {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sslcachenet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sslcachenet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GoogleCloudToolsDocuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"google.cloud.tools.docuploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Castor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"castor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ClickhouseMigrateCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clickhouse.migrate.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DhiPlatformCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dhi.platform.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Code2pdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"code2pdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CeruleanCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cerulean.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRiderCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-rider-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MspackProcessorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mspack.processor.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command D365odatacsdlshortener(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"d365odatacsdlshortener {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CertficateManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"certficate-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QingshanCodegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qingshan.codegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KnapcodeCertificateextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"knapcode.certificateextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyfxToolsDevcmds(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyfx.tools.devcmds {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uwebservercert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uwebservercert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Czglsys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"czglsys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cadence(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cadence {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SensenetIoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sensenet.io.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JwtCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jwt-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QbDotnetcoreinstaller(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qb.dotnetcoreinstaller {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HyperbeeXsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hyperbee.xs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Doctestcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doctestcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Traduoracli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"traduoracli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusSynctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.synctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CownxuSourcecode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cownxu.sourcecode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypealizrCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typealizr.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CegoStack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cego-stack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LpainsDocumorphCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lpains.documorph.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NmbOnlineradioConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nmb.onlineradio.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PingmintCodegenJson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pingmint.codegen.json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnmangoTdlCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unmango.tdl.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Il2careertoolset(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"il2careertoolset {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Json2yaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"json2yaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ClitoolsJumplist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clitools.jumplist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RigiCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rigi.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cs2j(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cs2j {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deadcsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deadcsharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetConfigtransform(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-configtransform {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Configgrabber(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"configgrabber {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EcryptoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ecrypto.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csipfs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csipfs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coaget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coaget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodeworxPackageversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codeworx.packageversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemaconsultingSpdxtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demaconsulting.spdxtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JrevoltYamlsecretsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jrevolt.yamlsecrets.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemaconsultingPandoctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demaconsulting.pandoctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctonautsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octonauts.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genmy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genmy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Huiyuanai709Cqrs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"huiyuanai709.cqrs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tuscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tuscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Customcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"customcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbenumcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbenumcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimcimGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simcim.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Usynctriggercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"usynctriggercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Convertpdf2png(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"convertpdf2png {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesPlconnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.plconnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gtfsxlsxcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gtfsxlsxcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CanpolatLipsum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"canpolat.lipsum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CaligoSqlgenerateupdatescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"caligo.sqlgenerateupdatescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DoinkChangelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doink.changelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command InvoicekitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"invoicekit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}