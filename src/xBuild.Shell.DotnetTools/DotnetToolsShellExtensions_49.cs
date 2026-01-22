using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Runcs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runcs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NovadropDc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"novadrop-dc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trxtoextentreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxtoextentreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonJoinquantpepionswithproteins(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.joinquantpepionswithproteins {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTrx2sonar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-trx2sonar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deicrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deicrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Simplemigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simplemigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Federer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"federer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genyman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genyman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMgfxc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mgfxc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NovonordiskSpectrack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"novonordisk.spectrack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FifteenthstandardQuartermaster(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fifteenthstandard.quartermaster {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Runfile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"runfile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NovadropRc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"novadrop-rc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trkleene(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trkleene {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmmDotnetpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"emm.dotnetpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scriptrunnergui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scriptrunnergui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tennis(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tennis {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GettextNetExtractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gettext.net.extractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mzitudown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mzitudown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeshtopologytoolkitTrimgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meshtopologytoolkit.trimgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UsaToolServicedeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"usa.tool.servicedeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Msixtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msixtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tunnelite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tunnelite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonMsfraggertopsm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.msfraggertopsm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGitignore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gitignore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nanofirmwareflasher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nanofirmwareflasher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Verifiable(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"verifiable {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TankaGenerateDocs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tanka.generate.docs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHttp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-http {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitrelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitrelease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Grep(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grep {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Panther(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"panther {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSponsor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sponsor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TapperGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tapper.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gcd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gcd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeadowTestnodeHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meadow.testnode.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReothorLabTinyproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reothor.lab.tinyproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trxlog2html(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxlog2html {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonMzmltomzliteionmobility(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.mzmltomzliteionmobility {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fenrir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fenrir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OcTcrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oc.tcrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trrr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trrr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docfx2xml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docfx2xml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetUnnugetize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-unnugetize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsefSqueel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsef-squeel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetX(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-x {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trsem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trsem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Togglheatmap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"togglheatmap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpeckleManagerFeed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"speckle.manager.feed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWaffle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-waffle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZongsoftToolsDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zongsoft.tools.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WoofwareNunittestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"woofware.nunittestrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Siccarcmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"siccarcmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonPsmbasedquantificationtims(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.psmbasedquantificationtims {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Genny(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genny {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HcDev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hc.dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gcprefreshupmtoken(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gcprefreshupmtoken {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerUtilsQaportaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.utils.qaportaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kcmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kcmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WigLynxManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wig.lynx.manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Synctool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"synctool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jwtd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jwtd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qxswitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qxswitch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Struct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"struct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpServerNuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.server.nuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilMachineTranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sil.machine.translator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetInitTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-init-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Htmltoxmlnugettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"htmltoxmlnugettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetYaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-yaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpcTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opc-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrdevTasks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grdev.tasks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Myproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDecodeJwt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-decode-jwt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Namespace2xml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"namespace2xml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProtocGenDelphiRuntimeTests(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"protoc-gen-delphi.runtime-tests {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Necto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"necto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProtocGenDelphi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"protoc-gen-delphi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FusedigitalQuicksetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fusedigital.quicksetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SrtsnetlayerGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"srtsnetlayer.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDeathStar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-death-star {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOssindex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ossindex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Subsln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"subsln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TestreporterSpecflowTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testreporter.specflow.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fshello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fshello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UtopiaTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"utopia.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Windebloat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"windebloat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ndext(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ndext {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dict(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dict {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ManghMetrologyUnitgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mangh.metrology.unitgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpServerMauidevenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp.server.mauidevenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Eskv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eskv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Poextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"poextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tomate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}