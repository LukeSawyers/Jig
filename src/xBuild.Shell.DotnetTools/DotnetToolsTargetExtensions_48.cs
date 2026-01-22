using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Nugetunlister(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetunlister {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetJson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetToTypescript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-to-typescript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRpmNet8(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-rpm-net8 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonPeptidedb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.peptidedb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWait(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-wait {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Interfacesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"interfacesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonPsmbasedquantification(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.psmbasedquantification {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Scrap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scrap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeeksevenlabsPowertoysTerminal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geeksevenlabs.powertoys.terminal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xgames105PmfPmftool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xgames105.pmf.pmftool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hypr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hypr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lockchecktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lockchecktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nablats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nablats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScreepsDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"screeps.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jet-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWiremock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-wiremock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRdp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-rdp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xping(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xping {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QiqiMytool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qiqi.mytool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOleanderLicrescompTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-oleander-licrescomp-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VecerdiGitinit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vecerdi.gitinit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMulticommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-multicommand {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRide(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ride {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DigitalengineTemplatetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"digitalengine.templatetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FirelyServerIngest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"firely.server.ingest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotpaste(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotpaste {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dir2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dir2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vlcgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vlcgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetXunitToJunitPreview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-xunit-to-junit-preview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YugabeWakeonlan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yugabe.wakeonlan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RegitlintFork(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regitlint.fork {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWarp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-warp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToonformatTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"toonformat.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tyxel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tyxel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PpechDotnetHostsctl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ppech.dotnet.hostsctl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEncrypto(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-encrypto {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fornax(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fornax {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EzKeyvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ez-keyvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pcad15team3mortgagecalculator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pcad15team3mortgagecalculator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pdf2img(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pdf2img {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnettoolsTpl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnettools.tpl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dateinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dateinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OptipngTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"optipng.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetReqube(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-reqube {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftProgramsynthesisDslc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.programsynthesis.dslc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mindex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mindex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hyprwt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hyprwt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OsiniloFirstPackage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"osinilo-first-package {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VforteliTypescripthubgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vforteli.typescripthubgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSdlexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sdlexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolrevdevYtx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solrevdev.ytx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netsnap(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netsnap {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ts {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ignarly(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ignarly {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThousandLsp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thousand.lsp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JotlangTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jotlang.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Modshardunpacker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modshardunpacker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PactNetXunitoutput(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pact-net.xunitoutput {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zip2(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zip2 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slnup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slnup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pingct(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pingct {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gripdevjsonschemavalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gripdevjsonschemavalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nupkgwrench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nupkgwrench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Faborite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"faborite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Flowline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flowline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonMzmltomzlite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.mzmltomzlite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SubstrateDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"substrate.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Img2pdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"img2pdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolsNetMongo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tools.net.mongo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kqlier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kqlier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitlinq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlinq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Madhyam(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"madhyam {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mmxmldoc2markdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mmxmldoc2markdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNugetTree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nuget-tree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FormatxamlTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"formatxaml.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonProteininference(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.proteininference {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftTemplateengineTemplatelocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.templateengine.templatelocalizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOrm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-orm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnoPackagediff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uno.packagediff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wcred(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wcred {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markdowner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdowner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Typesharpgenlauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typesharpgenlauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Packedprettier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"packedprettier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Universaltemplates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"universaltemplates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TankaGraphqlGeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tanka.graphql.generator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Vanir(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vanir {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HattrickDbexTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hattrick.dbex.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pomodorosharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pomodorosharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TmdsDbusTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tmds.dbus.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hades(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hades {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonLabelfreeproteinquantification(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.labelfreeproteinquantification {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KswareUpdatepackagereferences(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ksware.updatepackagereferences {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilMachineTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sil.machine.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProteomiqonLabeledproteinquantification(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proteomiqon.labeledproteinquantification {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ghvs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ghvs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tntc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tntc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pngtopdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pngtopdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}