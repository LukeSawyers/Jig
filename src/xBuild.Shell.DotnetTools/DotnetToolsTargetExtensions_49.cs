using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Runcs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runcs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NovadropDc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"novadrop-dc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trxtoextentreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxtoextentreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonJoinquantpepionswithproteins(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.joinquantpepionswithproteins {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrx2sonar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-trx2sonar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deicrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deicrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Simplemigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simplemigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Federer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"federer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genyman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genyman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMgfxc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mgfxc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NovonordiskSpectrack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"novonordisk.spectrack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FifteenthstandardQuartermaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fifteenthstandard.quartermaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Runfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"runfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NovadropRc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"novadrop-rc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trkleene(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trkleene {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmmDotnetpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"emm.dotnetpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scriptrunnergui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scriptrunnergui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tennis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tennis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GettextNetExtractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gettext.net.extractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mzitudown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mzitudown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeshtopologytoolkitTrimgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meshtopologytoolkit.trimgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UsaToolServicedeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"usa.tool.servicedeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Msixtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msixtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tunnelite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tunnelite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonMsfraggertopsm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.msfraggertopsm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGitignore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gitignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nanofirmwareflasher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nanofirmwareflasher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Verifiable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"verifiable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TankaGenerateDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tanka.generate.docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHttp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-http {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitrelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitrelease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Grep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Panther(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"panther {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSponsor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sponsor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TapperGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tapper.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gcd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gcd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeadowTestnodeHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meadow.testnode.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReothorLabTinyproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reothor.lab.tinyproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trxlog2html(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxlog2html {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonMzmltomzliteionmobility(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.mzmltomzliteionmobility {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fenrir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fenrir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OcTcrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oc.tcrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trrr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trrr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docfx2xml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docfx2xml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetUnnugetize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-unnugetize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsefSqueel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsef-squeel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetX(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-x {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trsem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trsem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Togglheatmap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"togglheatmap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpeckleManagerFeed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"speckle.manager.feed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWaffle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-waffle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZongsoftToolsDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zongsoft.tools.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WoofwareNunittestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"woofware.nunittestrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Siccarcmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"siccarcmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonPsmbasedquantificationtims(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.psmbasedquantificationtims {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Genny(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"genny {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HcDev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hc.dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gcprefreshupmtoken(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gcprefreshupmtoken {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerUtilsQaportaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.utils.qaportaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kcmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kcmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WigLynxManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wig.lynx.manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Synctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"synctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jwtd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jwtd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qxswitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qxswitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Struct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"struct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpServerNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.server.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilMachineTranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sil.machine.translator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetInitTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-init-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Htmltoxmlnugettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"htmltoxmlnugettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetYaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-yaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpcTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opc-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrdevTasks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grdev.tasks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Myproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDecodeJwt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-decode-jwt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Namespace2xml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"namespace2xml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProtocGenDelphiRuntimeTests(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"protoc-gen-delphi.runtime-tests {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Necto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"necto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProtocGenDelphi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"protoc-gen-delphi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FusedigitalQuicksetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fusedigital.quicksetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SrtsnetlayerGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"srtsnetlayer.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDeathStar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-death-star {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOssindex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ossindex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Subsln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"subsln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TestreporterSpecflowTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testreporter.specflow.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fshello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fshello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UtopiaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"utopia.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Windebloat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"windebloat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ndext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ndext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dict(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dict {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ManghMetrologyUnitgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mangh.metrology.unitgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpServerMauidevenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp.server.mauidevenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Eskv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eskv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Poextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"poextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tomate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}