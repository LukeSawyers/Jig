using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Nugetunlister(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetunlister {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetJson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetToTypescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-to-typescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRpmNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-rpm-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonPeptidedb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.peptidedb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWait(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-wait {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Interfacesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"interfacesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonPsmbasedquantification(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.psmbasedquantification {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Scrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeeksevenlabsPowertoysTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geeksevenlabs.powertoys.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xgames105PmfPmftool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xgames105.pmf.pmftool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hypr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hypr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lockchecktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lockchecktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nablats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nablats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScreepsDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"screeps.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jet-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWiremock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-wiremock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRdp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-rdp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xping(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QiqiMytool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qiqi.mytool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOleanderLicrescompTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-oleander-licrescomp-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VecerdiGitinit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vecerdi.gitinit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMulticommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-multicommand {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRide(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ride {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DigitalengineTemplatetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"digitalengine.templatetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FirelyServerIngest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"firely.server.ingest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotpaste(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotpaste {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dir2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dir2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vlcgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vlcgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetXunitToJunitPreview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-xunit-to-junit-preview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YugabeWakeonlan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yugabe.wakeonlan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RegitlintFork(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regitlint.fork {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWarp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-warp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToonformatTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"toonformat.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tyxel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tyxel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PpechDotnetHostsctl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ppech.dotnet.hostsctl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEncrypto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-encrypto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fornax(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fornax {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EzKeyvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ez-keyvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pcad15team3mortgagecalculator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pcad15team3mortgagecalculator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pdf2img(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pdf2img {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnettoolsTpl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnettools.tpl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dateinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dateinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OptipngTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"optipng.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetReqube(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-reqube {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftProgramsynthesisDslc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.programsynthesis.dslc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mindex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mindex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hyprwt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hyprwt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OsiniloFirstPackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"osinilo-first-package {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VforteliTypescripthubgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vforteli.typescripthubgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSdlexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sdlexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolrevdevYtx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solrevdev.ytx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netsnap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netsnap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ignarly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ignarly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThousandLsp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thousand.lsp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JotlangTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jotlang.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Modshardunpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modshardunpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PactNetXunitoutput(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pact-net.xunitoutput {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zip2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zip2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slnup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slnup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pingct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pingct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gripdevjsonschemavalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gripdevjsonschemavalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nupkgwrench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nupkgwrench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Faborite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"faborite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Flowline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flowline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonMzmltomzlite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.mzmltomzlite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SubstrateDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"substrate.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Img2pdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"img2pdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolsNetMongo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tools.net.mongo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kqlier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kqlier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitlinq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlinq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Madhyam(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"madhyam {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mmxmldoc2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mmxmldoc2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNugetTree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nuget-tree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FormatxamlTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"formatxaml.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonProteininference(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.proteininference {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftTemplateengineTemplatelocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.templateengine.templatelocalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOrm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-orm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnoPackagediff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uno.packagediff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wcred(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wcred {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markdowner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdowner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Typesharpgenlauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typesharpgenlauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Packedprettier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"packedprettier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Universaltemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"universaltemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TankaGraphqlGeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tanka.graphql.generator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Vanir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vanir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HattrickDbexTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hattrick.dbex.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pomodorosharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pomodorosharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TmdsDbusTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tmds.dbus.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hades(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hades {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonLabelfreeproteinquantification(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.labelfreeproteinquantification {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KswareUpdatepackagereferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ksware.updatepackagereferences {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilMachineTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sil.machine.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProteomiqonLabeledproteinquantification(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proteomiqon.labeledproteinquantification {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ghvs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ghvs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tntc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tntc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pngtopdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pngtopdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}