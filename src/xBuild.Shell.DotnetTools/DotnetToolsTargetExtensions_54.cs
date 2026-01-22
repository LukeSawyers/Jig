using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T I18nDotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"i18n.dotnet.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmpoweredDataverseWebresources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"empowered.dataverse.webresources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MapoluDotnetRename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mapolu.dotnet.rename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WemicroitDependencytrackDotnetPlugin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wemicroit.dependencytrack.dotnet.plugin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqldumperTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqldumper.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkJwtdecoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.jwtdecoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Webdavupload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webdavupload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Spawndto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spawndto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThammettDevopsquickstartTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thammett.devopsquickstart.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Plr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetdownload(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetdownload {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NupkgValidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nupkg-validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetsoftToolsDeps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netsoft.tools.deps {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Faultdetectordotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faultdetectordotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jdpostdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jdpostdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Po2resxDotnetTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"po2resx-dotnet-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FsixDaemon(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsix.daemon {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Omnia(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"omnia {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ivet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ivet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Seqcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"seqcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftLinuxtracepointsDecodeperftojson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.linuxtracepoints.decodeperftojson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HigedarumaLicenseshtmlgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"higedaruma.licenseshtmlgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Graphdoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"graphdoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Marklechtermanntestclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marklechtermanntestclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftOdataDiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.odata.diagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StarrLabsDotnetRocks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"starr-labs-dotnet-rocks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yunda(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yunda {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SylvanToolsSysteminfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sylvan.tools.systeminfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Femto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"femto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RegisDotnetQrcode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regis.dotnet.qrcode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WebionDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"webion.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RkmSampledotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rkm.sampledotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projdepend(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projdepend {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TomwareSmoky(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomware.smoky {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FvneverDotnetlicenses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fvnever.dotnetlicenses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Excellent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"excellent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Runtimedl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runtimedl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QxToolsDtogenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qx.tools.dtogenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MutterToolsSqlserverDiagrammanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mutter.tools.sqlserver.diagrammanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TestDecem1(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"test_decem1 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Loremipsum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"loremipsum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trdelete(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trdelete {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LunaDevtoolsLocalnugets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"luna.devtools.localnugets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pubdroid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pubdroid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShowgroffenameDotnet9(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"showgroffename-dotnet9 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KrosVariablesubstitution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kros.variablesubstitution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uxsshpush(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uxsshpush {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Urlencode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"urlencode {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ValidateSlnf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"validate-slnf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Triconv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"triconv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trtext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trtext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trdot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trdot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T N3oTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"n3o-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Thd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TopmodelGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topmodel.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LuthorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"luthor-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VecerdiLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vecerdi.license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReothorLabSwaggerproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reothor.lab.swaggerproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tsqllint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tsqllint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Goal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"goal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markoftheweb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markoftheweb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Links2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"links2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FurysMddox(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"furys.mddox {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Json2links(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"json2links {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Yazd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yazd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Shokz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shokz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genesysssg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genesysssg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trcaret(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trcaret {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gamemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gamemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trthompson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trthompson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trdeltree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trdeltree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TcpwtfNumbersequenceTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tcpwtf.numbersequence.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Psdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"psdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trrename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trrename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trtree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trtree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trtokens(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trtokens {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trsponge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trsponge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tw2x(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tw2x {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Quickshare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quickshare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HarpToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"harp.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JmeloseguiToolsMssql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jmelosegui.tools.mssql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trjson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trjson {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpecflowPlusLicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"specflow.plus.license {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trfoldlit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trfoldlit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlserver2puml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlserver2puml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VuisisFormulaX64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vuisis.formula.x64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HazeHello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"haze.hello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gittreeversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gittreeversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kronoweavetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kronoweavetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fflat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fflat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Spocr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spocr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HoppToolsEnginegenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hopp.tools.enginegenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mongorunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mongorunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WinNotifySend(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"win-notify-send {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Prerenderer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"prerenderer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SylvanToolsProcessinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sylvan.tools.processinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Timing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tritext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tritext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mslack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mslack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}