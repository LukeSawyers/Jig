using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command I18nDotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"i18n.dotnet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmpoweredDataverseWebresources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"empowered.dataverse.webresources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MapoluDotnetRename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mapolu.dotnet.rename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WemicroitDependencytrackDotnetPlugin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wemicroit.dependencytrack.dotnet.plugin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqldumperTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqldumper.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkJwtdecoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.jwtdecoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Webdavupload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webdavupload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Spawndto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spawndto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThammettDevopsquickstartTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thammett.devopsquickstart.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Plr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetdownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetdownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NupkgValidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nupkg-validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetsoftToolsDeps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netsoft.tools.deps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Faultdetectordotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faultdetectordotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jdpostdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jdpostdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Po2resxDotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"po2resx-dotnet-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FsixDaemon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsix.daemon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Omnia(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"omnia {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ivet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ivet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Seqcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"seqcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftLinuxtracepointsDecodeperftojson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.linuxtracepoints.decodeperftojson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HigedarumaLicenseshtmlgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"higedaruma.licenseshtmlgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Graphdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"graphdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Marklechtermanntestclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marklechtermanntestclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftOdataDiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.odata.diagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StarrLabsDotnetRocks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"starr-labs-dotnet-rocks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yunda(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yunda {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SylvanToolsSysteminfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sylvan.tools.systeminfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Femto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"femto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RegisDotnetQrcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regis.dotnet.qrcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WebionDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"webion.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RkmSampledotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rkm.sampledotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projdepend(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projdepend {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TomwareSmoky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomware.smoky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FvneverDotnetlicenses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fvnever.dotnetlicenses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Excellent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"excellent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Runtimedl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runtimedl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QxToolsDtogenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qx.tools.dtogenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MutterToolsSqlserverDiagrammanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mutter.tools.sqlserver.diagrammanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TestDecem1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"test_decem1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Loremipsum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"loremipsum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trdelete(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trdelete {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LunaDevtoolsLocalnugets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"luna.devtools.localnugets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pubdroid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pubdroid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShowgroffenameDotnet9(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"showgroffename-dotnet9 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KrosVariablesubstitution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kros.variablesubstitution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uxsshpush(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uxsshpush {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Urlencode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"urlencode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ValidateSlnf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"validate-slnf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Triconv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"triconv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trtext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trtext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trdot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trdot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command N3oTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"n3o-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Thd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TopmodelGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topmodel.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LuthorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"luthor-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VecerdiLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vecerdi.license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReothorLabSwaggerproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reothor.lab.swaggerproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tsqllint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tsqllint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Goal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"goal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markoftheweb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markoftheweb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Links2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"links2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FurysMddox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"furys.mddox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Json2links(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"json2links {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Yazd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yazd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Shokz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shokz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genesysssg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genesysssg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trcaret(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trcaret {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gamemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gamemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trthompson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trthompson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trdeltree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trdeltree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TcpwtfNumbersequenceTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tcpwtf.numbersequence.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Psdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"psdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trrename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trrename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trtree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trtree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trtokens(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trtokens {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trsponge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trsponge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tw2x(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tw2x {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Quickshare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quickshare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HarpToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"harp.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JmeloseguiToolsMssql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jmelosegui.tools.mssql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trjson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trjson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpecflowPlusLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"specflow.plus.license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trfoldlit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trfoldlit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlserver2puml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlserver2puml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VuisisFormulaX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vuisis.formula.x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HazeHello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"haze.hello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gittreeversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gittreeversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kronoweavetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kronoweavetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fflat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fflat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Spocr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spocr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HoppToolsEnginegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hopp.tools.enginegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mongorunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mongorunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WinNotifySend(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"win-notify-send {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Prerenderer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"prerenderer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SylvanToolsProcessinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sylvan.tools.processinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Timing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tritext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tritext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mslack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mslack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}