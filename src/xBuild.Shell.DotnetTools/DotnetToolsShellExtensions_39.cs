using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Codagh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codagh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RdbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rdb-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cabgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cabgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNosln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nosln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FhirCandle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fhir-candle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LadeakChttp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ladeak.chttp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DefaultdocumentationConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"defaultdocumentation.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusMatrixrun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.matrixrun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Configtransformercore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"configtransformercore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ComputecTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"computec.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ClonetfsvariablegroupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clonetfsvariablegroup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharply(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharply {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMsixCatalog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-msix-catalog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cpmigrate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cpmigrate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Literatecs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"literatecs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StankinsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stankins.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilMachineMorphologyHermitcrabTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sil.machine.morphology.hermitcrab.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZebbleCss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zebble-css {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarraiaCheckpercentage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marraia.checkpercentage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusSendemailtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.sendemailtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TktkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tktk-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharpell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharpell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Igloo15ChangeloggeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"igloo15.changeloggenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markdownlinkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdownlinkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ComteleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"comtele.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DtomakerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dtomaker.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Regitlint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regitlint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Giphycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"giphycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCstOssgadgetFindsquatsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.cst.ossgadget.findsquats.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZebbleCompileZbl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zebble-compile-zbl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetXdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-xdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PomeloExtensionsCachingMysqlconfigTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pomelo.extensions.caching.mysqlconfig.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesJnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.jnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CapydbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"capydb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Conventionalchangelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conventionalchangelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CassiniCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cassini.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ColotilineNugetUpdatetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"colotiline.nuget.updatetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusVerifymd5task(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.verifymd5task {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CorecmdCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"corecmd.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusFiledownloaderWpf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.filedownloader.wpf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Diffenginetray(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"diffenginetray {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Myriad(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myriad {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SarifPatternmatcherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sarif.patternmatcher.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cursive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cursive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ComfygCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"comfyg.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LeancodeContractsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"leancode.contractsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Colortest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"colortest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NmodelsgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nmodelsgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GcoreSourceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gcore.source.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GcoreSourceJsonclassgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gcore.source.jsonclassgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KenticoXperienceDbmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kentico.xperience.dbmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MdmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mdm-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmitsoNafToolsNafmdaconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smitso.naf.tools.nafmdaconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CscManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csc-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusRunwithconfigvaluetask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.runwithconfigvaluetask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeshtasticCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meshtastic.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csdltodiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csdltodiagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CentralpackagemanagementmigratorRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"centralpackagemanagementmigrator.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkikraYocli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skikra.yocli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IbexCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ibex.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NmfEcore2code(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nmf-ecore2code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GregXrmCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"greg.xrm.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodecraftProfessionExtensionsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codecraft.profession.extensions.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OmniaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"omnia.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GithubCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"github.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DidotCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"didot-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mvc567Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mvc567.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csharptojs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharptojs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCiVersionProperties(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ci-version-properties {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KvpsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kvps-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConductorsharpToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conductorsharp.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cs2mermaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cs2mermaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mergecoberturaxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mergecoberturaxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csvmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csvmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EcDynamicsclientGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ec.dynamicsclient.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusGitlabmergerequestcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.gitlabmergerequestcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CoderpatrosDotnetOutdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coderpatros-dotnet-outdated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SetversionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"setversion-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csv2class(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csv2class {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ue4cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ue4cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MastermemoryGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mastermemory.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CsharpLsVs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csharp-ls-vs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DockerHealthcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docker.healthcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Couchbaseverifier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"couchbaseverifier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PingmintCodegenSql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pingmint.codegen.sql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntegrayConnectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"integray.connector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Csys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"csys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloneDisk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clone-disk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChangecuratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"changecurator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChcEfReversePoco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chc.ef.reverse.poco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HarmonyCoreClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"harmony.core.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UsyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"usync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Controllerscaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"controllerscaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCliYamlist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cli-yamlist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReimaginateDatahubCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reimaginate.datahub.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cheese(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cheese {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EnovationcloudCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"enovationcloud.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuCamstar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.camstar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}