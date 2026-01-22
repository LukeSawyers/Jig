using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Codagh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codagh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RdbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rdb-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cabgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cabgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNosln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nosln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FhirCandle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fhir-candle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LadeakChttp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ladeak.chttp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DefaultdocumentationConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"defaultdocumentation.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusMatrixrun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.matrixrun {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Configtransformercore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"configtransformercore {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ComputecTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"computec.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ClonetfsvariablegroupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clonetfsvariablegroup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharply(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharply {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMsixCatalog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-msix-catalog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cpmigrate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cpmigrate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Literatecs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"literatecs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StankinsConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stankins.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilMachineMorphologyHermitcrabTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sil.machine.morphology.hermitcrab.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZebbleCss(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zebble-css {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarraiaCheckpercentage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marraia.checkpercentage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusSendemailtask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.sendemailtask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TktkCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tktk-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharpell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharpell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Igloo15ChangeloggeneratorTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"igloo15.changeloggenerator.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markdownlinkchecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdownlinkchecker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ComteleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"comtele.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DtomakerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dtomaker.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Regitlint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regitlint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Giphycli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"giphycli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetcleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetcleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCstOssgadgetFindsquatsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.cst.ossgadget.findsquats.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZebbleCompileZbl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zebble-compile-zbl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetXdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-xdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PomeloExtensionsCachingMysqlconfigTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pomelo.extensions.caching.mysqlconfig.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesJnetcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.jnetcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CapydbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"capydb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Conventionalchangelog(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conventionalchangelog {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CassiniCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cassini.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ColotilineNugetUpdatetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"colotiline.nuget.updatetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusVerifymd5task(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.verifymd5task {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CorecmdCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"corecmd.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusFiledownloaderWpf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.filedownloader.wpf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Diffenginetray(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"diffenginetray {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Myriad(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myriad {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SarifPatternmatcherCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sarif.patternmatcher.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cursive(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cursive {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ComfygCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"comfyg.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LeancodeContractsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"leancode.contractsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Colortest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"colortest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NmodelsgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nmodelsgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GcoreSourceCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gcore.source.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GcoreSourceJsonclassgeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gcore.source.jsonclassgenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KenticoXperienceDbmanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kentico.xperience.dbmanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MdmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mdm-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmitsoNafToolsNafmdaconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smitso.naf.tools.nafmdaconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CscManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csc-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusRunwithconfigvaluetask(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.runwithconfigvaluetask {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeshtasticCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meshtastic.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csdltodiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csdltodiagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CentralpackagemanagementmigratorRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"centralpackagemanagementmigrator.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkikraYocli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skikra.yocli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IbexCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ibex.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCode(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NmfEcore2code(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nmf-ecore2code {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GregXrmCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greg.xrm.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodecraftProfessionExtensionsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codecraft.profession.extensions.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OmniaCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"omnia.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GithubCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"github.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DidotCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"didot-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mvc567Cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mvc567.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csharptojs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharptojs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCiVersionProperties(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ci-version-properties {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KvpsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kvps-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConductorsharpToolkit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conductorsharp.toolkit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cs2mermaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cs2mermaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mergecoberturaxml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mergecoberturaxml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csvmerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csvmerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EcDynamicsclientGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ec.dynamicsclient.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusGitlabmergerequestcreator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.gitlabmergerequestcreator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CoderpatrosDotnetOutdated(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coderpatros-dotnet-outdated {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SetversionCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"setversion-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csv2class(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csv2class {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ue4cli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ue4cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MastermemoryGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mastermemory.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CsharpLsVs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csharp-ls-vs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DockerHealthcheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docker.healthcheck {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Couchbaseverifier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"couchbaseverifier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PingmintCodegenSql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pingmint.codegen.sql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntegrayConnectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"integray.connector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Csys(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"csys {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloneDisk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clone-disk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChangecuratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"changecurator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChcEfReversePoco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chc.ef.reverse.poco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HarmonyCoreClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"harmony.core.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UsyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"usync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Controllerscaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"controllerscaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCliYamlist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cli-yamlist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReimaginateDatahubCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reimaginate.datahub.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cheese(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cheese {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EnovationcloudCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"enovationcloud.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuCamstar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.camstar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}