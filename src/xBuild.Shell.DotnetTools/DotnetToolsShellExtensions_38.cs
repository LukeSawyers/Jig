using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command GhulCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ghul.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetConfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-config {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevratingConsoleapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devrating.consoleapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCoyoteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.coyote.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EntityframeworkcoreGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"entityframeworkcore.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codecoverageextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecoverageextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CredfetoTsqlFormatterCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"credfeto.tsql.formatter.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsScriptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cs-script.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrapecityLicensemanagertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grapecity.licensemanagertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command H5Compiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"h5-compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WildernesslabsMeadowCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wildernesslabs.meadow.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KubernetescrdmodelgenSync(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kubernetescrdmodelgen.sync {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetacodeTemplatesuite2Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metacode.templatesuite2.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeshmakersOctoConstructionkitCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meshmakers.octo.constructionkit.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RedthNetMauiCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"redth.net.maui.check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodeworxRestToolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codeworx.rest.tool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CwtoolsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cwtools.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqlhydraCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlhydra.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TddxtTrxconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tddxt.trxconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetacodeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metacode.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PkgchkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pkgchk-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Doclinkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"doclinkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Centralisedpackageconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"centralisedpackageconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ckli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ckli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Competitiveverifiercsresolver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"competitiveverifiercsresolver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Configvalidate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"configvalidate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HoustonCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"houston.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Plantumlclassdiagramgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plantumlclassdiagramgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOutdatedTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-outdated-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetContractsGenerate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-contracts-generate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetacodeTs3Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metacode.ts3.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FixieConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fixie.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotvvmCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotvvm.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaplargeincCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maplargeinc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TryConvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"try-convert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clickhousemigrator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clickhousemigrator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDeb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-deb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docfx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docfx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ContentfulModelscreatorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"contentful.modelscreator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsSdkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.sdkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Claimssetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"claimssetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoffeecupMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coffeecup-macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConjureEfxDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conjure.efx.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntentSoftwarefactoryCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intent.softwarefactory.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Clink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clink {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodegeneratorCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codegenerator.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TailwindcssCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tailwindcss.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OrchardcorecontribPoextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"orchardcorecontrib.poextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoravelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coravel-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRpm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-rpm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RocketmakersEnvironmentGenerationCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rocketmakers.environment.generation.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DolittleRuntimeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dolittle.runtime.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ClojureMain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clojure.main {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodificMvc567Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codific.mvc567.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetafacCg4Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metafac.cg4.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCensus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-census {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ElviaEdnaEventsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"elvia.edna.events.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCodecoverageConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.codecoverage.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkbkonturTypescriptContractgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skbkontur.typescript.contractgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftQuantumChemistryTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.quantum.chemistry.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-repl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenocsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"genocs.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetProjectLicenses(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-project-licenses {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntentPackagerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intent.packager.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codegeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codegeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pauldeen79TemplateframeworkConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pauldeen79.templateframework.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZhiletimeHopeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zhiletime.hope.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UlidCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ulid-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xrmdocumentationgeneratorcorecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xrmdocumentationgeneratorcorecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SquidexCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"squidex.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolhigsonFrameworkEfcoretool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solhigson.framework.efcoretool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WaiinRaaghuCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"waiin.raaghu.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csprojcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csprojcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Congelato(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"congelato {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ContentstackModelGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"contentstack.model.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusGitrevisiontask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.gitrevisiontask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusNugettask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.nugettask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetafacCg3Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metafac.cg3.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusDotnettask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.dotnettask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeadowCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meadow.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pauldeen79TexttemplatetransformationframeworkT4PlusCmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pauldeen79.texttemplatetransformationframework.t4.plus.cmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusNugetpublishtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.nugetpublishtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CuidgenTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cuidgen.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusMsbuildtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.msbuildtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CreatedecisionsmoduleGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"createdecisionsmodule-globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RecompiledminifierCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"recompiledminifier.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EzdbcodegenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ezdbcodegen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FcswatchCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fcswatch-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HolionTranslationsyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"holion.translationsync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetafacCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metafac.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GivenspecsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"givenspecs.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetXunitToJunit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-xunit-to-junit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SvrooijWingetIntuneCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svrooij.winget-intune.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusPicktextvaluetask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.picktextvaluetask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGcm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gcm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharpzxscript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpzxscript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CreateGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"create-guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}